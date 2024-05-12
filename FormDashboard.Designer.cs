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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelActiveReminder = new System.Windows.Forms.Panel();
            this.buttonReminderAcknowledgement = new System.Windows.Forms.Button();
            this.labelSubMaintenance1 = new System.Windows.Forms.Label();
            this.LabelTitleReminder = new System.Windows.Forms.Label();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regAplNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.octaDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GridButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListBindingSource)).BeginInit();
            this.panelActiveReminder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.plateNumberDataGridViewTextBoxColumn,
            this.regAplNrDataGridViewTextBoxColumn,
            this.octaDueDateDataGridViewTextBoxColumn,
            this.taDueDateDataGridViewTextBoxColumn,
            this.GridButtonEdit,
            this.GridButtonDelete});
            this.dataGridView1.DataSource = this.vehiclesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(0, 1080);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 463);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting_1);
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.vehicleListBindingSource;
            // 
            // vehicleListBindingSource
            // 
            this.vehicleListBindingSource.DataSource = typeof(A_Wheely_Great_App.FormDashboard.VehicleList);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1183, 20);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.Text = "Meklēt Transportlīdzekli";
            // 
            // panelActiveReminder
            // 
            this.panelActiveReminder.AutoSize = true;
            this.panelActiveReminder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelActiveReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(50)))));
            this.panelActiveReminder.Controls.Add(this.buttonReminderAcknowledgement);
            this.panelActiveReminder.Controls.Add(this.labelSubMaintenance1);
            this.panelActiveReminder.Controls.Add(this.LabelTitleReminder);
            this.panelActiveReminder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActiveReminder.Location = new System.Drawing.Point(0, 20);
            this.panelActiveReminder.Name = "panelActiveReminder";
            this.panelActiveReminder.Size = new System.Drawing.Size(1183, 97);
            this.panelActiveReminder.TabIndex = 10;
            // 
            // buttonReminderAcknowledgement
            // 
            this.buttonReminderAcknowledgement.Location = new System.Drawing.Point(403, 71);
            this.buttonReminderAcknowledgement.Name = "buttonReminderAcknowledgement";
            this.buttonReminderAcknowledgement.Size = new System.Drawing.Size(75, 23);
            this.buttonReminderAcknowledgement.TabIndex = 5;
            this.buttonReminderAcknowledgement.Text = "Noted";
            this.buttonReminderAcknowledgement.UseVisualStyleBackColor = true;
            this.buttonReminderAcknowledgement.Click += new System.EventHandler(this.buttonReminderAcknowledgement_Click);
            // 
            // labelSubMaintenance1
            // 
            this.labelSubMaintenance1.AllowDrop = true;
            this.labelSubMaintenance1.AutoSize = true;
            this.labelSubMaintenance1.BackColor = System.Drawing.Color.Transparent;
            this.labelSubMaintenance1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSubMaintenance1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubMaintenance1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSubMaintenance1.Location = new System.Drawing.Point(0, 32);
            this.labelSubMaintenance1.Name = "labelSubMaintenance1";
            this.labelSubMaintenance1.Size = new System.Drawing.Size(318, 25);
            this.labelSubMaintenance1.TabIndex = 4;
            this.labelSubMaintenance1.Text = "Active Maintenance Reminder info";
            // 
            // LabelTitleReminder
            // 
            this.LabelTitleReminder.AutoSize = true;
            this.LabelTitleReminder.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitleReminder.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitleReminder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitleReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelTitleReminder.Location = new System.Drawing.Point(0, 0);
            this.LabelTitleReminder.Name = "LabelTitleReminder";
            this.LabelTitleReminder.Size = new System.Drawing.Size(368, 32);
            this.LabelTitleReminder.TabIndex = 3;
            this.LabelTitleReminder.Text = "Active Maintenance Reminders";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plateNumberDataGridViewTextBoxColumn
            // 
            this.plateNumberDataGridViewTextBoxColumn.DataPropertyName = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.HeaderText = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.Name = "plateNumberDataGridViewTextBoxColumn";
            this.plateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regAplNrDataGridViewTextBoxColumn
            // 
            this.regAplNrDataGridViewTextBoxColumn.DataPropertyName = "RegAplNr";
            this.regAplNrDataGridViewTextBoxColumn.HeaderText = "RegAplNr";
            this.regAplNrDataGridViewTextBoxColumn.Name = "regAplNrDataGridViewTextBoxColumn";
            this.regAplNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // octaDueDateDataGridViewTextBoxColumn
            // 
            this.octaDueDateDataGridViewTextBoxColumn.DataPropertyName = "OctaDueDate";
            this.octaDueDateDataGridViewTextBoxColumn.HeaderText = "OctaDueDate";
            this.octaDueDateDataGridViewTextBoxColumn.Name = "octaDueDateDataGridViewTextBoxColumn";
            this.octaDueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taDueDateDataGridViewTextBoxColumn
            // 
            this.taDueDateDataGridViewTextBoxColumn.DataPropertyName = "TaDueDate";
            this.taDueDateDataGridViewTextBoxColumn.HeaderText = "TaDueDate";
            this.taDueDateDataGridViewTextBoxColumn.Name = "taDueDateDataGridViewTextBoxColumn";
            this.taDueDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1183, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelActiveReminder);
            this.Controls.Add(this.textBoxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListBindingSource)).EndInit();
            this.panelActiveReminder.ResumeLayout(false);
            this.panelActiveReminder.PerformLayout();
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
        public System.Windows.Forms.Label labelSubMaintenance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regAplNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn octaDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn GridButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn GridButtonDelete;
    }
}