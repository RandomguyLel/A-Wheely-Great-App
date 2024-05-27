namespace A_Wheely_Great_App
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regAplNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.octaDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaskoDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmrDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atdDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GridButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vehiclesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelActiveReminder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTitleReminder = new System.Windows.Forms.Label();
            this.buttonReminderAcknowledgement = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListBindingSource)).BeginInit();
            this.panelActiveReminder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.plateNumberDataGridViewTextBoxColumn,
            this.regAplNrDataGridViewTextBoxColumn,
            this.octaDueDateDataGridViewTextBoxColumn,
            this.taDueDateDataGridViewTextBoxColumn,
            this.kaskoDueDateDataGridViewTextBoxColumn,
            this.cmrDueDateDataGridViewTextBoxColumn,
            this.atdDueDateDataGridViewTextBoxColumn,
            this.GridButtonEdit,
            this.GridButtonDelete});
            this.dataGridView1.DataSource = this.vehiclesBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(0, 1080);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 416);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting_1);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Transportlīdzeklis";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plateNumberDataGridViewTextBoxColumn
            // 
            this.plateNumberDataGridViewTextBoxColumn.DataPropertyName = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.FillWeight = 80F;
            this.plateNumberDataGridViewTextBoxColumn.HeaderText = "Tr. Reģ. Nr.";
            this.plateNumberDataGridViewTextBoxColumn.Name = "plateNumberDataGridViewTextBoxColumn";
            this.plateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regAplNrDataGridViewTextBoxColumn
            // 
            this.regAplNrDataGridViewTextBoxColumn.DataPropertyName = "RegAplNr";
            this.regAplNrDataGridViewTextBoxColumn.FillWeight = 90F;
            this.regAplNrDataGridViewTextBoxColumn.HeaderText = "Reģ.Apl.Nr.";
            this.regAplNrDataGridViewTextBoxColumn.Name = "regAplNrDataGridViewTextBoxColumn";
            this.regAplNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // octaDueDateDataGridViewTextBoxColumn
            // 
            this.octaDueDateDataGridViewTextBoxColumn.DataPropertyName = "OctaDueDate";
            this.octaDueDateDataGridViewTextBoxColumn.FillWeight = 85F;
            this.octaDueDateDataGridViewTextBoxColumn.HeaderText = "OCTA Polise";
            this.octaDueDateDataGridViewTextBoxColumn.Name = "octaDueDateDataGridViewTextBoxColumn";
            this.octaDueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taDueDateDataGridViewTextBoxColumn
            // 
            this.taDueDateDataGridViewTextBoxColumn.DataPropertyName = "TaDueDate";
            this.taDueDateDataGridViewTextBoxColumn.FillWeight = 85F;
            this.taDueDateDataGridViewTextBoxColumn.HeaderText = "Teh. Apskate";
            this.taDueDateDataGridViewTextBoxColumn.Name = "taDueDateDataGridViewTextBoxColumn";
            this.taDueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kaskoDueDateDataGridViewTextBoxColumn
            // 
            this.kaskoDueDateDataGridViewTextBoxColumn.DataPropertyName = "KaskoDueDate";
            this.kaskoDueDateDataGridViewTextBoxColumn.FillWeight = 85F;
            this.kaskoDueDateDataGridViewTextBoxColumn.HeaderText = "KASKO Polise";
            this.kaskoDueDateDataGridViewTextBoxColumn.Name = "kaskoDueDateDataGridViewTextBoxColumn";
            this.kaskoDueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmrDueDateDataGridViewTextBoxColumn
            // 
            this.cmrDueDateDataGridViewTextBoxColumn.DataPropertyName = "CmrDueDate";
            this.cmrDueDateDataGridViewTextBoxColumn.FillWeight = 85F;
            this.cmrDueDateDataGridViewTextBoxColumn.HeaderText = "CMR Polise";
            this.cmrDueDateDataGridViewTextBoxColumn.Name = "cmrDueDateDataGridViewTextBoxColumn";
            this.cmrDueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atdDueDateDataGridViewTextBoxColumn
            // 
            this.atdDueDateDataGridViewTextBoxColumn.DataPropertyName = "AtdDueDate";
            this.atdDueDateDataGridViewTextBoxColumn.FillWeight = 85F;
            this.atdDueDateDataGridViewTextBoxColumn.HeaderText = "ATD Licence";
            this.atdDueDateDataGridViewTextBoxColumn.Name = "atdDueDateDataGridViewTextBoxColumn";
            this.atdDueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GridButtonEdit
            // 
            this.GridButtonEdit.FillWeight = 25F;
            this.GridButtonEdit.HeaderText = "";
            this.GridButtonEdit.Name = "GridButtonEdit";
            this.GridButtonEdit.ReadOnly = true;
            this.GridButtonEdit.Text = "Edit";
            // 
            // GridButtonDelete
            // 
            this.GridButtonDelete.FillWeight = 25F;
            this.GridButtonDelete.HeaderText = "";
            this.GridButtonDelete.Name = "GridButtonDelete";
            this.GridButtonDelete.ReadOnly = true;
            this.GridButtonDelete.Text = "Delete";
            // 
            // vehiclesBindingSource1
            // 
            this.vehiclesBindingSource1.DataMember = "Vehicles";
            this.vehiclesBindingSource1.DataSource = this.vehiclesBindingSource;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataSource = this.vehicleListBindingSource;
            this.vehiclesBindingSource.CurrentChanged += new System.EventHandler(this.vehiclesBindingSource_CurrentChanged);
            // 
            // vehicleListBindingSource
            // 
            this.vehicleListBindingSource.DataSource = typeof(A_Wheely_Great_App.FormDashboard.VehicleList);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearch.Location = new System.Drawing.Point(5, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1125, 23);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "Meklēt Transportlīdzekļus";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // panelActiveReminder
            // 
            this.panelActiveReminder.AutoSize = true;
            this.panelActiveReminder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelActiveReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(101)))));
            this.panelActiveReminder.Controls.Add(this.label2);
            this.panelActiveReminder.Controls.Add(this.label1);
            this.panelActiveReminder.Controls.Add(this.LabelTitleReminder);
            this.panelActiveReminder.Controls.Add(this.buttonReminderAcknowledgement);
            this.panelActiveReminder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActiveReminder.Location = new System.Drawing.Point(0, 34);
            this.panelActiveReminder.Name = "panelActiveReminder";
            this.panelActiveReminder.Size = new System.Drawing.Size(1168, 106);
            this.panelActiveReminder.TabIndex = 10;
            this.panelActiveReminder.Visible = false;
            this.panelActiveReminder.Click += new System.EventHandler(this.panelActiveReminder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 32);
            this.label2.TabIndex = 7;
            this.label2.Tag = "maintenance";
            this.label2.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 6;
            this.label1.Visible = false;
            // 
            // LabelTitleReminder
            // 
            this.LabelTitleReminder.AutoSize = true;
            this.LabelTitleReminder.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitleReminder.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitleReminder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitleReminder.ForeColor = System.Drawing.Color.Black;
            this.LabelTitleReminder.Location = new System.Drawing.Point(0, 23);
            this.LabelTitleReminder.Name = "LabelTitleReminder";
            this.LabelTitleReminder.Size = new System.Drawing.Size(251, 32);
            this.LabelTitleReminder.TabIndex = 3;
            this.LabelTitleReminder.Text = "Aktīvie atgādinājumi";
            this.LabelTitleReminder.MouseHover += new System.EventHandler(this.LabelTitleReminder_MouseHover);
            // 
            // buttonReminderAcknowledgement
            // 
            this.buttonReminderAcknowledgement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReminderAcknowledgement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReminderAcknowledgement.Location = new System.Drawing.Point(0, 0);
            this.buttonReminderAcknowledgement.Name = "buttonReminderAcknowledgement";
            this.buttonReminderAcknowledgement.Size = new System.Drawing.Size(1168, 23);
            this.buttonReminderAcknowledgement.TabIndex = 2;
            this.buttonReminderAcknowledgement.Text = "Esmu iepazinies ar šo informāciju";
            this.buttonReminderAcknowledgement.UseVisualStyleBackColor = true;
            this.buttonReminderAcknowledgement.Click += new System.EventHandler(this.buttonReminderAcknowledgement_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 556);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1168, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Veikt Transportlīdzekļu Pārbaudi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 34);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::A_Wheely_Great_App.Properties.Resources.magnifying_glass_24px;
            this.pictureBox1.Location = new System.Drawing.Point(1136, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = " - Veikt pārbaudi visiem transportlīdzekļiem";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1168, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panelActiveReminder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Shown += new System.EventHandler(this.FormDashboard_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListBindingSource)).EndInit();
            this.panelActiveReminder.ResumeLayout(false);
            this.panelActiveReminder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vehicleListBindingSource;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label LabelTitleReminder;
        public System.Windows.Forms.Panel panelActiveReminder;
        private System.Windows.Forms.Button buttonReminderAcknowledgement;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource vehiclesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regAplNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn octaDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaskoDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmrDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atdDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn GridButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn GridButtonDelete;
    }
}