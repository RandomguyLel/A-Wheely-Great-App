namespace A_Wheely_Great_App
{
    partial class VehicleEdit
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
            this.dateTimeTa = new System.Windows.Forms.DateTimePicker();
            this.dateTimeOcta = new System.Windows.Forms.DateTimePicker();
            this.buttonEditVehicle = new System.Windows.Forms.Button();
            this.LabelVehicleTaDate = new System.Windows.Forms.Label();
            this.LabelVehicleOctaDate = new System.Windows.Forms.Label();
            this.LabelVehicleRegAplNr = new System.Windows.Forms.Label();
            this.LabelVehiclePlate = new System.Windows.Forms.Label();
            this.LabelVehicleType = new System.Windows.Forms.Label();
            this.textBoxRegAplNr = new System.Windows.Forms.TextBox();
            this.textBoxPlateNumber = new System.Windows.Forms.TextBox();
            this.textBoxVehicleType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimeTa
            // 
            this.dateTimeTa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTa.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeTa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTa.Location = new System.Drawing.Point(501, 310);
            this.dateTimeTa.Name = "dateTimeTa";
            this.dateTimeTa.Size = new System.Drawing.Size(200, 34);
            this.dateTimeTa.TabIndex = 5;
            // 
            // dateTimeOcta
            // 
            this.dateTimeOcta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeOcta.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeOcta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeOcta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeOcta.Location = new System.Drawing.Point(501, 250);
            this.dateTimeOcta.Name = "dateTimeOcta";
            this.dateTimeOcta.Size = new System.Drawing.Size(200, 34);
            this.dateTimeOcta.TabIndex = 4;
            // 
            // buttonEditVehicle
            // 
            this.buttonEditVehicle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEditVehicle.AutoSize = true;
            this.buttonEditVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditVehicle.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonEditVehicle.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonEditVehicle.FlatAppearance.BorderSize = 2;
            this.buttonEditVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditVehicle.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonEditVehicle.Location = new System.Drawing.Point(321, 374);
            this.buttonEditVehicle.Name = "buttonEditVehicle";
            this.buttonEditVehicle.Size = new System.Drawing.Size(191, 38);
            this.buttonEditVehicle.TabIndex = 6;
            this.buttonEditVehicle.Text = "Saglabāt Izmaiņas";
            this.buttonEditVehicle.UseVisualStyleBackColor = false;
            this.buttonEditVehicle.Click += new System.EventHandler(this.buttonEditVehicle_Click);
            // 
            // LabelVehicleTaDate
            // 
            this.LabelVehicleTaDate.AutoSize = true;
            this.LabelVehicleTaDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehicleTaDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicleTaDate.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehicleTaDate.Location = new System.Drawing.Point(99, 310);
            this.LabelVehicleTaDate.Name = "LabelVehicleTaDate";
            this.LabelVehicleTaDate.Size = new System.Drawing.Size(274, 37);
            this.LabelVehicleTaDate.TabIndex = 13;
            this.LabelVehicleTaDate.Text = "Vehicle TA Due Date";
            // 
            // LabelVehicleOctaDate
            // 
            this.LabelVehicleOctaDate.AutoSize = true;
            this.LabelVehicleOctaDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehicleOctaDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicleOctaDate.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehicleOctaDate.Location = new System.Drawing.Point(99, 247);
            this.LabelVehicleOctaDate.Name = "LabelVehicleOctaDate";
            this.LabelVehicleOctaDate.Size = new System.Drawing.Size(311, 37);
            this.LabelVehicleOctaDate.TabIndex = 14;
            this.LabelVehicleOctaDate.Text = "Vehicle OCTA Due Date";
            // 
            // LabelVehicleRegAplNr
            // 
            this.LabelVehicleRegAplNr.AutoSize = true;
            this.LabelVehicleRegAplNr.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehicleRegAplNr.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicleRegAplNr.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehicleRegAplNr.Location = new System.Drawing.Point(99, 183);
            this.LabelVehicleRegAplNr.Name = "LabelVehicleRegAplNr";
            this.LabelVehicleRegAplNr.Size = new System.Drawing.Size(254, 37);
            this.LabelVehicleRegAplNr.TabIndex = 15;
            this.LabelVehicleRegAplNr.Text = "Vehicle Reg Apl Nr";
            // 
            // LabelVehiclePlate
            // 
            this.LabelVehiclePlate.AutoSize = true;
            this.LabelVehiclePlate.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehiclePlate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehiclePlate.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehiclePlate.Location = new System.Drawing.Point(99, 115);
            this.LabelVehiclePlate.Name = "LabelVehiclePlate";
            this.LabelVehiclePlate.Size = new System.Drawing.Size(293, 37);
            this.LabelVehiclePlate.TabIndex = 16;
            this.LabelVehiclePlate.Text = "Vehicle Plate Number";
            // 
            // LabelVehicleType
            // 
            this.LabelVehicleType.AutoSize = true;
            this.LabelVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehicleType.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicleType.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehicleType.Location = new System.Drawing.Point(99, 51);
            this.LabelVehicleType.Name = "LabelVehicleType";
            this.LabelVehicleType.Size = new System.Drawing.Size(177, 37);
            this.LabelVehicleType.TabIndex = 17;
            this.LabelVehicleType.Text = "Vehicle Type";
            // 
            // textBoxRegAplNr
            // 
            this.textBoxRegAplNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegAplNr.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRegAplNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegAplNr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRegAplNr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegAplNr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxRegAplNr.Location = new System.Drawing.Point(501, 194);
            this.textBoxRegAplNr.Name = "textBoxRegAplNr";
            this.textBoxRegAplNr.Size = new System.Drawing.Size(171, 26);
            this.textBoxRegAplNr.TabIndex = 3;
            // 
            // textBoxPlateNumber
            // 
            this.textBoxPlateNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlateNumber.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPlateNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlateNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPlateNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlateNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPlateNumber.Location = new System.Drawing.Point(501, 125);
            this.textBoxPlateNumber.MaxLength = 12;
            this.textBoxPlateNumber.Name = "textBoxPlateNumber";
            this.textBoxPlateNumber.Size = new System.Drawing.Size(171, 26);
            this.textBoxPlateNumber.TabIndex = 1;
            // 
            // textBoxVehicleType
            // 
            this.textBoxVehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVehicleType.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVehicleType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxVehicleType.Location = new System.Drawing.Point(501, 62);
            this.textBoxVehicleType.MaxLength = 150;
            this.textBoxVehicleType.Name = "textBoxVehicleType";
            this.textBoxVehicleType.Size = new System.Drawing.Size(171, 26);
            this.textBoxVehicleType.TabIndex = 0;
            // 
            // VehicleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeTa);
            this.Controls.Add(this.dateTimeOcta);
            this.Controls.Add(this.textBoxRegAplNr);
            this.Controls.Add(this.textBoxPlateNumber);
            this.Controls.Add(this.textBoxVehicleType);
            this.Controls.Add(this.buttonEditVehicle);
            this.Controls.Add(this.LabelVehicleTaDate);
            this.Controls.Add(this.LabelVehicleOctaDate);
            this.Controls.Add(this.LabelVehicleRegAplNr);
            this.Controls.Add(this.LabelVehiclePlate);
            this.Controls.Add(this.LabelVehicleType);
            this.Name = "VehicleEdit";
            this.Text = "VehicleEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeTa;
        private System.Windows.Forms.DateTimePicker dateTimeOcta;
        private System.Windows.Forms.Button buttonEditVehicle;
        private System.Windows.Forms.Label LabelVehicleTaDate;
        private System.Windows.Forms.Label LabelVehicleOctaDate;
        private System.Windows.Forms.Label LabelVehicleRegAplNr;
        private System.Windows.Forms.Label LabelVehiclePlate;
        private System.Windows.Forms.Label LabelVehicleType;
        private System.Windows.Forms.TextBox textBoxRegAplNr;
        private System.Windows.Forms.TextBox textBoxPlateNumber;
        internal System.Windows.Forms.TextBox textBoxVehicleType;
    }
}