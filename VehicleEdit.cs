using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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


            //dateTimeOcta.Value = vehicle.OctaDueDate;
            //dateTimeTa.Value = vehicle.TaDueDate;
            if (vehicle.OctaDueDate.HasValue)
            {
                dateTimeOcta.Value = vehicle.OctaDueDate.Value;
                dateTimeOcta.Checked = true;
            }
            if (vehicle.TaDueDate.HasValue)
            {
                dateTimeTa.Value = vehicle.TaDueDate.Value;
                dateTimeTa.Checked = true;
            }
            if (vehicle.KaskoDueDate.HasValue)
            {
                dateTimeKasko.Value = vehicle.KaskoDueDate.Value;
                dateTimeKasko.Checked = true;
            }
            if (vehicle.CmrDueDate.HasValue)
            {
                dateTimeCmr.Value = vehicle.CmrDueDate.Value;
                dateTimeCmr.Checked = true;
            }
            if (vehicle.AtdDueDate.HasValue)
            {
                dateTimeAtd.Value = vehicle.AtdDueDate.Value;
                dateTimeAtd.Checked = true;
            }

        }

        private void buttonEditVehicle_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"Tiks veiktas šādas izmaiņas:\n" +
                $"Nosaukums: {vehicle.Type} --> {textBoxVehicleType.Text}\n" +
                $"Reģ. Nr.: {vehicle.PlateNumber} --> {textBoxPlateNumber.Text}\n" +
                $"Reģ. Apl. Nr.: {vehicle.RegAplNr} --> {textBoxRegAplNr.Text}\n" +
                $"OCTA Termiņš: {vehicle.OctaDueDate.ToString()} --> {(dateTimeOcta.Checked ? dateTimeOcta.Value.Date : (DateTime?)null)}\n" +
                $"TA Termiņš: {vehicle.TaDueDate.ToString()} --> {(dateTimeTa.Checked ? dateTimeTa.Value.Date : (DateTime?)null)}\n" +
                $"Kasko Termiņš: {vehicle.KaskoDueDate.ToString()} --> {(dateTimeKasko.Checked ? dateTimeKasko.Value.Date : (DateTime?)null)}\n" +
                $"CMR Termiņš: {vehicle.CmrDueDate.ToString()} --> {(dateTimeCmr.Checked ? dateTimeCmr.Value.Date : (DateTime?)null)}\n" +
                $"ATD Termiņš: {vehicle.AtdDueDate.ToString()} --> {(dateTimeAtd.Checked ? dateTimeAtd.Value.Date : (DateTime?)null)}\n" +

                $"Vai vēlaties turpināt?", "Apstiprināt Izmaiņas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                // Update the vehicle object with the new values
                vehicle.Type = textBoxVehicleType.Text;
                vehicle.PlateNumber = textBoxPlateNumber.Text;
                vehicle.RegAplNr = textBoxRegAplNr.Text;
                vehicle.OctaDueDate = dateTimeOcta.Checked ? dateTimeOcta.Value.Date : (DateTime?)null;
                vehicle.TaDueDate = dateTimeTa.Checked ? dateTimeTa.Value.Date : (DateTime?)null;
                //Non-Mandatory Values
                vehicle.KaskoDueDate = dateTimeKasko.Checked ? dateTimeKasko.Value.Date : (DateTime?)null;
                vehicle.CmrDueDate = dateTimeCmr.Checked ? dateTimeCmr.Value.Date : (DateTime?)null;
                vehicle.AtdDueDate = dateTimeAtd.Checked ? dateTimeAtd.Value.Date : (DateTime?)null;
                MessageBox.Show("Izmaiņas tika veiksmīgi saglabātas!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Save the updated list of vehicles to the JSON file
                // Stuff gets saved in FormDashboard after this form is closed
                Console.WriteLine($"{vehicle.Type} has been updated");
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

