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
        public FormVehicleAdd()
        {
            InitializeComponent();
        }

        private void LabelVehicleType_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create a new vehicle from the input data
            var vehicle = new Vehicle
            {
                Type = textBoxVehicleType.Text,
                PlateNumber = textBoxPlateNumber.Text,
                RegAplNr = textBoxRegAplNr.Text,
                OctaDueDate = dateTimeOcta.Value.Date,
                TaDueDate = dateTimeTa.Value.Date,

            };
            Console.WriteLine("Adding new vehicle: "+vehicle.Type+" "+ vehicle.RegAplNr);
            // Add the new vehicle to the list
            vehicles.Vehicles.Add(vehicle);

            // Save the updated list of vehicles to the JSON file
            Console.WriteLine("Writing data to JSON...");
            var json = JsonConvert.SerializeObject(vehicles, Formatting.Indented);
            File.WriteAllText("vehicles.json", json);

            MessageBox.Show("Vehicle "+vehicle.Type+" added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
