using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using A_Wheely_Great_App.Properties;
using Newtonsoft.Json;
using System.IO;
using static A_Wheely_Great_App.FormDashboard;
using System.Security.Cryptography.X509Certificates;
using System.Threading;


namespace A_Wheely_Great_App
{

    public partial class Form1 : Form
    {
        private FormDashboard formDashboard;  // Reference to the FormDashboard

        //Draggable Window without border start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public void DraggableWindow()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        //Draggable Window without border end

        //Rounded edge stuff start
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        //Rounded edge stuff end

        //public void LoadVehicles()
        //{
            //var json = File.ReadAllText("vehicles.json");
            //vehicles = JsonConvert.DeserializeObject<VehicleList>(json);
        //}


        public void LoadVehicles()
        {
            try
            {
                if (File.Exists("vehicles.json"))
                {
                    var json = File.ReadAllText("vehicles.json");
                    vehicles = JsonConvert.DeserializeObject<VehicleList>(json);
                }
                else
                {
                    Console.WriteLine("No JSON file not found, prompting user for input");                  
                }
                //throw new InvalidOperationException("No Json Data File Found! Please place vehicles.json file in the root directory.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    
        public Form1()
        {

            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            // btnDashboard.BackColor = Color.FromArgb(46, 51, 73);




            // Load vehicles from JSON file
            //LoadVehicles();

            




        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //formDashboard = new FormDashboard();
            btnDashboard.PerformClick();
            //formDashboard.CheckMaintenanceDates();


        }
        //private Boolean FormLoaded = false;
        public static FormDashboard FormDashboard_Vrb;
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Dashboard";
            this.PanelFormLoader.Controls.Clear();

            if (FormDashboard_Vrb == null)
            {
                FormDashboard_Vrb = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            }

            this.PanelFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();

            //formDashboard = new FormDashboard(); //keeping initialized to change stuff in it
        }
        public void ClickDashboardButton()
        {
            btnDashboard.PerformClick();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            PnlNav.Height = button1.Height;
            PnlNav.Top = button1.Top;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Add a Vehicle";
            this.PanelFormLoader.Controls.Clear();
            FormVehicleAdd FormDashboard_Vrb = new FormVehicleAdd(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
            FormDashboard_Vrb.Refresh();
            //button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlNav.Height = button2.Height;
            PnlNav.Top = button2.Top;
            button2.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PnlNav.Height = button3.Height;
            PnlNav.Top = button3.Top;
            
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LabelTitle.Text = "About";
            PnlNav.Height = btnAbout.Height;
            PnlNav.Top = btnAbout.Top;
            btnAbout.BackColor = Color.FromArgb(46, 51, 73);
            this.PanelFormLoader.Controls.Clear();
            var about = new Label
            {
                Text = "A Wheeeeely Great app\nCreated as part of my internship thingy c:\n© Rik Solutions 2024",
                AutoSize = true,
                Dock = DockStyle.Left,
                Font = new Font("Sergoe UI", 15, FontStyle.Bold),
                //Margin = (0, 0, 0);
                ForeColor = Color.FromArgb(255, 255, 255),
                AutoEllipsis = true,
                //Tag = "maintenance"
                // Adjust the size of the label to fit the text
            };
            
            PanelFormLoader.Controls.Add(about);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(24, 30, 54);
        }

        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //private void buttonMaximize_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //}
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void Form1_MouseDown(object sender, MouseEventArgs e) //Draggable Window
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggableWindow();
            }
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e) //Draggable Window
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggableWindow();
            }
        }



        //private void button4_Click(object sender, EventArgs e)
        //{

        //}

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggableWindow();
            }
        }


        

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            formDashboard.CheckMaintenanceDates();
        }

        private void HeaderPanel_Click(object sender, EventArgs e)
        {
            formDashboard.ActiveControl = null;
        }
        //private void buttonTestLabel_Click(object sender, EventArgs e)
        //{
        //    formDashboard.labelSubMaintenance1.Text = "Added from foreign form";
        //    formDashboard.labelSubMaintenance1.Refresh();
        //    Application.DoEvents();

        //    //Move all reminder logic to Dashboard form/////
        //}
    }
}
