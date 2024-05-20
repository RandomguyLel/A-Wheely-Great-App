using A_Wheely_Great_App.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static A_Wheely_Great_App.Form1;
using static A_Wheely_Great_App.FormDashboard;
using UITimer = System.Windows.Forms.Timer;

namespace A_Wheely_Great_App
{
    public partial class FormDashboard : Form
    {

        //Attempt at actual backend shid

        public class Vehicle : IComparable<Vehicle>
        {
            public string Type { get; set; }
            public string PlateNumber { get; set; }
            public string RegAplNr { get; set; }
            public DateTime OctaDueDate { get; set; }
            public DateTime TaDueDate { get; set; }

            public int CompareTo(Vehicle other)
            {
                // Compare by PlateNumber
                //return String.Compare(this.PlateNumber, other.PlateNumber);
                return String.Compare(this.OctaDueDate.ToString(), other.OctaDueDate.ToString());

            }
        }

        public class SortableBindingList<T> : BindingList<T>
        {
            private bool isSorted;
            private ListSortDirection sortDirection = ListSortDirection.Ascending;
            private PropertyDescriptor sortProperty;

            protected override bool SupportsSortingCore { get { return true; } }
            protected override bool IsSortedCore { get { return isSorted; } }
            protected override ListSortDirection SortDirectionCore { get { return sortDirection; } }
            protected override PropertyDescriptor SortPropertyCore { get { return sortProperty; } }

            protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
            {
                sortProperty = prop;
                sortDirection = direction;

                List<T> items = this.Items as List<T>;
                if (items != null)
                {
                    Comparison<T> comparison = (a, b) =>
                    {
                        var valueA = prop.GetValue(a);
                        var valueB = prop.GetValue(b);
                        return Comparer<object>.Default.Compare(valueA, valueB);
                    };

                    items.Sort(comparison);
                    if (direction == ListSortDirection.Descending)
                    {
                        items.Reverse();
                    }
                }

                isSorted = true;
                this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }

            protected override void RemoveSortCore()
            {
                isSorted = false;
                sortProperty = null;
            }
        }
        public class VehicleList
        {
            public SortableBindingList<Vehicle> Vehicles { get; set; }
        }
        public static VehicleList vehicles;
        private Boolean StartupCheck = false;
        private NotifyIcon notifyIcon;
        private UITimer timer;
        private static BindingSource bindingSource = new BindingSource();

        public FormDashboard()
        {
            InitializeComponent();
            // Load vehicles from JSON file 
            try
            {
                if (File.Exists("vehicles.json"))
                {
                    Console.WriteLine("JSON File Exists, Loading.");
                    var json = File.ReadAllText("vehicles.json");
                    vehicles = JsonConvert.DeserializeObject<VehicleList>(json);
                    Console.WriteLine(vehicles.Vehicles.Count + " vehicles have been loaded.");
                    // Bind the list of vehicles to the DataGridView
                    bindingSource.DataSource = vehicles.Vehicles; // Search Filter
                    dataGridView1.DataSource = bindingSource;
                    

                }
                else
                {
                    Console.WriteLine("No JSON file not found, prompting user for input");
                    DialogResult result = MessageBox.Show("vehicles.json data file was not found. First Launch?\n" +
                        "A new file will be generated in program's directory. \nApplication will be restarted. ", "No JSON Found",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        using (File.Create("vehicles.json"))
                        {
                            // The using statement automatically closes the FileStream after the file is created
                        }
                        Console.WriteLine("File Created.");
                        Console.WriteLine("Writing JSON Structure to file.");
                        string json_structure = "{\r\n  \"vehicles\": [\r\n\r\n  ]\r\n}";
                        File.WriteAllText("vehicles.json", json_structure);
                        Console.WriteLine("Writing JSON Structure was completed.");
                        Console.WriteLine("Restarting...");
                        Application.Restart();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        //your code here
                        Environment.Exit(0);
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            //Reminder Block Start
            // Initialize NotifyIcon
            notifyIcon = new NotifyIcon
            {
                Visible = true,
                Icon = SystemIcons.Information,  // Set this to your app's icon
                BalloonTipTitle = "Vehicle Maintenance Reminder",
                
            };

            // Initialize Timer

            timer = new UITimer
            {
                Interval = (int)TimeSpan.FromDays(1).TotalMilliseconds  // Set interval to 1 day
            };
            timer.Tick += Timer_Tick;

            LoadVehicles();
            Console.WriteLine("Checkin StartupCheck");
            Console.WriteLine($"{StartupCheck.ToString()}");
            //StartupCheck = true;
            if (StartupCheck==false) //Maintenance checc on startup
            {
                Console.WriteLine("Performing first check...");
                CheckMaintenanceDates();
                timer.Start();
                Console.WriteLine("Maintenance Timer Set for 1 day");
                Console.WriteLine("Check complete, disabling...");
                StartupCheck = true;
            }

        }
        public void LoadVehicles()
        {
            var json = File.ReadAllText("vehicles.json");
            vehicles = JsonConvert.DeserializeObject<VehicleList>(json);
            // Rebind the data source
            bindingSource.DataSource = null;
            bindingSource.DataSource = vehicles.Vehicles;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Refresh();
        }
        public void ClearActiveReminders()
        {
            // Make a list of the maintenance labels to process
            var labelsToRemove = new List<Control>();
            foreach (Control control in panelActiveReminder.Controls)
            {
                if (control.Tag is "maintenance")
                {
                    labelsToRemove.Add(control);
                }
            }
            // Remove the maintenance labels
            foreach (Control control in labelsToRemove)
            {
                panelActiveReminder.Controls.Remove(control);
                Console.WriteLine(control.Name + " Control cleared");
            }

        }
        public void CheckMaintenanceDates()
        {
            //panelActiveReminder.Visible = true;

            ClearActiveReminders();
            //Thread.Sleep(50);
            panelActiveReminder.Refresh();
            Console.WriteLine("Starting Maintenance Checks");
            LoadVehicles();
            Thread.Sleep(500);
            dataGridView1.Refresh();

            var today = DateTime.Today;
            foreach (var vehicle in vehicles.Vehicles) //Flags vehicles with due date less den 1 week
            {
                var daysUntilOCTA = (vehicle.OctaDueDate - today).TotalDays;
                if (daysUntilOCTA <= 7)
                {
                    ShowNotificationOCTA(vehicle);
                }
                var daysUntilTA = (vehicle.TaDueDate - today).TotalDays;
                if (daysUntilTA <= 7)
                {
                    ShowNotificationTA(vehicle);
                }

            }

        }
        //Reminder stuff
        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckMaintenanceDates();
        }


        private void ShowNotificationOCTA(Vehicle vehicle)
        {
            Console.WriteLine($"Pushing OCTA Notification for vehicle {vehicle.Type} ({vehicle.PlateNumber} {vehicle.RegAplNr})");
            notifyIcon.BalloonTipText = $"Vehicle {vehicle.Type} ({vehicle.PlateNumber} {vehicle.RegAplNr}) is due for OCTA on {vehicle.OctaDueDate:yyyy-MM-dd}.";
            notifyIcon.ShowBalloonTip(5000); // Time in ms
            notifyIcon.Visible = true;
            // TODO: Add notifications for TA check - DONE

            var labelOCTA = new Label
            {
                
                Text = $"Vehicle {vehicle.Type} ({vehicle.PlateNumber} {vehicle.RegAplNr}) is due for OCTA on {vehicle.OctaDueDate:yyyy-MM-dd}.",
                AutoSize = true, Dock = DockStyle.Bottom,
                Font = new Font("Sergoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                //ForeColor = Color.FromArgb(64,64,64),
                AutoEllipsis = true,
                Tag = "maintenance"
                // Adjust the size of the label to fit the text
            };
            panelActiveReminder.Visible = true;
            panelActiveReminder.Controls.Add(labelOCTA);
        }
        private void ShowNotificationTA(Vehicle vehicle)
        {
            Console.WriteLine($"Pushing TA Notification for vehicle {vehicle.Type} ({vehicle.PlateNumber} {vehicle.RegAplNr})");
            notifyIcon.BalloonTipText = $"Vehicle {vehicle.Type} ({vehicle.PlateNumber} {vehicle.RegAplNr}) is due for TA on {vehicle.TaDueDate:yyyy-MM-dd}.";
            notifyIcon.ShowBalloonTip(5000); // Time in ms
            notifyIcon.Visible = true;


            var labelTA = new Label
            {
                Text = $"Vehicle {vehicle.Type} ({vehicle.PlateNumber} {vehicle.RegAplNr}) is due for TA on {vehicle.TaDueDate:yyyy-MM-dd}.",
                AutoSize = true,
                Dock = DockStyle.Bottom,
                Font = new Font("Sergoe UI", 12, FontStyle.Bold),
                //ForeColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.Black,
                AutoEllipsis = true,
                Tag = "maintenance"
                // Adjust the size of the label to fit the text
            };
            panelActiveReminder.Visible = true;
            panelActiveReminder.Controls.Add(labelTA);
        }
        // Reminder end
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           
        }

        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Adding Icons to Grid Buttons
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.pencil.Width;
                var h = Properties.Resources.pencil.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.pencil, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //using delete button
        {
            // If a delete button was clicked
            if (dataGridView1.Columns[e.ColumnIndex].Name == "GridButtonDelete")
            {
                // Check if the clicked cell is not the header (row index -1)
                if (e.RowIndex >= 0)
                {
                    // Get the Id of the vehicle to delete
                    var id = (string)dataGridView1.Rows[e.RowIndex].Cells["plateNumberDataGridViewTextBoxColumn"].Value;

                    // Delete the vehicle
                    DeleteVehicle(id);
                }
                    
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "GridButtonEdit")
            {

                if (e.RowIndex >= 0)
                {
                    // Get the Id of the vehicle to edit
                    var id = (string)dataGridView1.Rows[e.RowIndex].Cells["plateNumberDataGridViewTextBoxColumn"].Value;
                    EditVehicle(id);
                }
                    
            }
        }
        private void EditVehicle(string id)
        {


            // Find the vehicle in the list
            var vehicle = vehicles.Vehicles.FirstOrDefault(v => v.PlateNumber == id);
            //TODO Remove initial confirmation window before editing
            //DialogResult result = MessageBox.Show($"Do you really want to edit vehicle {vehicle.Type} {vehicle.PlateNumber}?"
            //    , "Edit Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (vehicle != null)
            {
                //Pop up new small edit form and somehow pass data to it, then save it and refresh whole list;
                VehicleEdit myForm = new VehicleEdit(vehicle);
                //myForm.vehicle = vehicle;                   
                myForm.ShowDialog();
                // Save the updated list of vehicles to the JSON file
                var json = JsonConvert.SerializeObject(vehicles, Formatting.Indented);
                File.WriteAllText("vehicles.json", json);
                //Console.WriteLine($"{vehicle.Type} has been deleted");
                //Update the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = vehicles.Vehicles;
            }
            //if (result == DialogResult.Yes)
            //{
            //    // If the vehicle was found, remove it from the list
               

            //    else
            //    {
            //        Console.WriteLine($"No vehicle found with PlateNumber {id}.");
            //    }
            //}
            //else if (result == DialogResult.No)
            //{
            //    MessageBox.Show("Vehicle was not edited", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void DeleteVehicle(string id)
        {
            

            // Find the vehicle in the list
            var vehicle = vehicles.Vehicles.FirstOrDefault(v => v.PlateNumber == id);
            DialogResult result = MessageBox.Show($"Do you really want to delete vehicle {vehicle.Type} {vehicle.PlateNumber}?", "Delete Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // If the vehicle was found, remove it from the list
                if (vehicle != null)
                {
                    vehicles.Vehicles.Remove(vehicle);

                    // Save the updated list of vehicles to the JSON file
                    var json = JsonConvert.SerializeObject(vehicles, Formatting.Indented);
                    File.WriteAllText("vehicles.json", json);
                    Console.WriteLine($"{vehicle.Type} has been deleted");
                    // Update the DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = vehicles.Vehicles;
                }


                else
                {
                    Console.WriteLine($"No vehicle found with PlateNumber {id}.");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Vehicle was not deleted", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


        }

        private void buttonReminderAcknowledgement_Click(object sender, EventArgs e)
        {
            panelActiveReminder.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckMaintenanceDates();
        }

        private void vehiclesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"DataError occurred in column {e.ColumnIndex}, row {e.RowIndex}: {e.Exception.Message}");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the text from the search box
            string searchText = textBoxSearch.Text.ToLower();
            
            if (searchText != "Search for Vehicles")
            {
                var filteredVehicles = vehicles.Vehicles
                .Where(v => v.Type.ToLower().Contains(searchText)
                    || v.PlateNumber.ToLower().Contains(searchText)
                    || v.RegAplNr.ToLower().Contains(searchText))
                .ToList();
                bindingSource.DataSource = new BindingList<Vehicle>(filteredVehicles);
            }
            // Perform the filtering manually
            
                

            // Update the BindingSource
            
            // Print the filter expression and the number of rows
            Console.WriteLine($"Number of rows: {dataGridView1.Rows.Count}");
            dataGridView1.Refresh();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search for Vehicles")
            {
                textBoxSearch.Text = "";
            }
        }
        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                // Remove the TextChanged event handler
                textBoxSearch.TextChanged -= textBoxSearch_TextChanged;

                // Set the placeholder text
                textBoxSearch.Text = "Search for Vehicles";

                // Add the TextChanged event handler back
                textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            }
            //textBoxSearch.Text = "Search for Vehicles"; //Cannot really sellect anything when exiting search box
        }
        private void FormDashboard_Shown(object sender, EventArgs e)
        {
            LoadVehicles();
            Console.WriteLine("Dashboard Shown");
        }

        private void panelActiveReminder_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
 
}
