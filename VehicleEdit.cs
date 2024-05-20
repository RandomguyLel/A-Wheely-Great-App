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

            DialogResult result = MessageBox.Show($"Tiks veiktas šādas izmaiņas:\n" +
                $"Nosaukums: {vehicle.Type} --> {textBoxVehicleType.Text}\n" +
                $"Reģ. Nr.: {vehicle.PlateNumber} --> {textBoxPlateNumber.Text}\n" +
                $"Reģ. Apl. Nr.: {vehicle.RegAplNr} --> {textBoxRegAplNr.Text}\n" +
                $"OCTA Termiņš: {vehicle.OctaDueDate.ToShortDateString()} --> {dateTimeOcta.Value.ToShortDateString()}\n" +
                $"TA Termiņš: {vehicle.TaDueDate.ToShortDateString()} --> {dateTimeTa.Value.ToShortDateString()}\n" +
                $"Vai vēlaties turpināt?", "Apstiprināt Izmaiņas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                // Update the vehicle object with the new values
                vehicle.Type = textBoxVehicleType.Text;
                vehicle.PlateNumber = textBoxPlateNumber.Text;
                vehicle.RegAplNr = textBoxRegAplNr.Text;
                vehicle.OctaDueDate = dateTimeOcta.Value;
                vehicle.TaDueDate = dateTimeTa.Value;

                MessageBox.Show("Izmaiņas tika veiksmīgi saglabātas!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Izmaiņas netika veiktas", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

