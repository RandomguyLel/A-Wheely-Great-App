﻿using A_Wheely_Great_App.Properties;
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
using static A_Wheely_Great_App.Form1;

namespace A_Wheely_Great_App
{
    public partial class FormDashboard : Form
    {

        //Attempt at actual backend shit

        public class Vehicle
        {
            public string Type { get; set; }
            public string PlateNumber { get; set; }
            public string RegAplNr { get; set; }
            public DateTime OctaDueDate { get; set; }
            public DateTime TaDueDate { get; set; }

        }
        public class VehicleList
        {
            public List<Vehicle> Vehicles { get; set; }
        }
        public static VehicleList vehicles;


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
                    dataGridView1.DataSource = vehicles.Vehicles;
                }
                else
                {
                    Console.WriteLine("No JSON file not found, prompting user for input");
                    DialogResult result = MessageBox.Show("vehicles.json data file was not found. First Launch?\nA new file will be generated in program's directory. \nApplication will be restarted. ", "No JSON Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                    
                    //throw new InvalidOperationException("No Json Data File Found! Please place vehicles.json file in the root directory.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }



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
    }
}
