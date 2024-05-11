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

namespace A_Wheely_Great_App
{
    
    public partial class Form1 : Form
    {
        

        //Draggable Window without border start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
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

        
        public Form1()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            // btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

                  
            

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left= btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Dashboard";
            this.PanelFormLoader.Controls.Clear();
            FormDashboard FormDashboard_Vrb = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } ;
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlNav.Height= button1.Height;
            PnlNav.Top= button1.Top;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Add a Vehicle";
            this.PanelFormLoader.Controls.Clear();
            FormVehicleAdd FormDashboard_Vrb = new FormVehicleAdd() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();

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
            PnlNav.Height = btnSettings.Height;
            PnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
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
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) //Draggable Window
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e) //Draggable Window
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
