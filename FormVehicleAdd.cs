using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static A_Wheely_Great_App.FormDashboard;

namespace A_Wheely_Great_App
{
    public partial class FormVehicleAdd : Form
    {
        private Form1 mainForm;
        public FormVehicleAdd(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void LabelVehicleType_Click(object sender, EventArgs e)
        {

        }
        private FormDashboard formDashboard;
        private Form1 form1;
        private void button4_Click(object sender, EventArgs e)
        {

            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Lūdzu aizpildiet visus laukus!", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);//Your textbox is empty
            }
            else
            {
                var vehicle = new Vehicle
                {
                    Type = textBoxVehicleType.Text,
                    PlateNumber = textBoxPlateNumber.Text,
                    RegAplNr = textBoxRegAplNr.Text,
                    OctaDueDate = dateTimeOcta.Value.Date,
                    TaDueDate = dateTimeTa.Value.Date,

                };
                Console.WriteLine("Adding new vehicle: " + vehicle.Type + " " + vehicle.RegAplNr);
                // Add the new vehicle to the list
                vehicles.Vehicles.Add(vehicle);

                // Save the updated list of vehicles to the JSON file
                Console.WriteLine("Writing data to JSON...");
                var json = JsonConvert.SerializeObject(vehicles, Formatting.Indented);
                File.WriteAllText("vehicles.json", json);

                MessageBox.Show("Transportlīdzeklis " + vehicle.Type + " pievienots veiksmīgi!", "Transportlīdzeklis pievienots", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Call the method on Form1
                mainForm.ClickDashboardButton();
                //formDashboard.LoadVehicles();
            }
            // Create a new vehicle from the input data
           
        }
    }
}
