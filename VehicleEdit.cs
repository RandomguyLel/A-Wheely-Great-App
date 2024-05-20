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

namespace A_Wheely_Great_App
{
    public partial class VehicleEdit : Form
    {
        internal FormDashboard.Vehicle vehicle;
        //private FormDashboard formDashboard;

        public VehicleEdit(FormDashboard.Vehicle vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;

            textBoxVehicleType.Text = vehicle.Type;
            textBoxPlateNumber.Text = vehicle.PlateNumber;
            textBoxRegAplNr.Text = vehicle.RegAplNr;
            dateTimeOcta.Value = vehicle.OctaDueDate;
            dateTimeTa.Value = vehicle.TaDueDate;

        }

        private void buttonEditVehicle_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"The following changes will be made:\n" +
                $"Type: {vehicle.Type} --> {textBoxVehicleType.Text}\n" +
                $"Plate Nr.: {vehicle.PlateNumber} --> {textBoxPlateNumber.Text}\n" +
                $"Reg Apl Nr.: {vehicle.RegAplNr} --> {textBoxRegAplNr.Text}\n" +
                $"OCTA Due Date: {vehicle.OctaDueDate.ToShortDateString()} --> {dateTimeOcta.Value.ToShortDateString()}\n" +
                $"TA Due Date: {vehicle.TaDueDate.ToShortDateString()} --> {dateTimeTa.Value.ToShortDateString()}\n" +
                $"Do You Wish to Proceed?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                // Update the vehicle object with the new values
                vehicle.Type = textBoxVehicleType.Text;
                vehicle.PlateNumber = textBoxPlateNumber.Text;
                vehicle.RegAplNr = textBoxRegAplNr.Text;
                vehicle.OctaDueDate = dateTimeOcta.Value;
                vehicle.TaDueDate = dateTimeTa.Value;

                MessageBox.Show("Changes were saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Save the updated list of vehicles to the JSON file
                //Maybe save the single vehicle here and save to json on dashboard form?

                //var json = JsonConvert.SerializeObject(vehicle, Formatting.Indented);
                //File.WriteAllText("vehicles.json", json);
                //Console.WriteLine($"{vehicle.Type} has been updated");
                // Close the form
                this.Close();

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("No changes were made", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

