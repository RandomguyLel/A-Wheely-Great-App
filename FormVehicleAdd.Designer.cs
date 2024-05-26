namespace A_Wheely_Great_App
{
    partial class FormVehicleAdd
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
            this.textBoxVehicleType = new System.Windows.Forms.TextBox();
            this.textBoxPlateNumber = new System.Windows.Forms.TextBox();
            this.textBoxRegAplNr = new System.Windows.Forms.TextBox();
            this.LabelVehicleType = new System.Windows.Forms.Label();
            this.LabelVehiclePlate = new System.Windows.Forms.Label();
            this.LabelVehicleRegAplNr = new System.Windows.Forms.Label();
            this.LabelVehicleOctaDate = new System.Windows.Forms.Label();
            this.LabelVehicleTaDate = new System.Windows.Forms.Label();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.dateTimeOcta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTa = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAtd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCmr = new System.Windows.Forms.DateTimePicker();
            this.dateTimeKasko = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxVehicleType
            // 
            this.textBoxVehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVehicleType.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVehicleType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxVehicleType.Location = new System.Drawing.Point(586, 29);
            this.textBoxVehicleType.MaxLength = 150;
            this.textBoxVehicleType.Name = "textBoxVehicleType";
            this.textBoxVehicleType.Size = new System.Drawing.Size(171, 33);
            this.textBoxVehicleType.TabIndex = 0;
            // 
            // textBoxPlateNumber
            // 
            this.textBoxPlateNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlateNumber.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPlateNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlateNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPlateNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlateNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPlateNumber.Location = new System.Drawing.Point(586, 92);
            this.textBoxPlateNumber.MaxLength = 12;
            this.textBoxPlateNumber.Name = "textBoxPlateNumber";
            this.textBoxPlateNumber.Size = new System.Drawing.Size(171, 33);
            this.textBoxPlateNumber.TabIndex = 1;
            // 
            // textBoxRegAplNr
            // 
            this.textBoxRegAplNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegAplNr.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRegAplNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegAplNr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRegAplNr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegAplNr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxRegAplNr.Location = new System.Drawing.Point(586, 161);
            this.textBoxRegAplNr.MaxLength = 12;
            this.textBoxRegAplNr.Name = "textBoxRegAplNr";
            this.textBoxRegAplNr.Size = new System.Drawing.Size(171, 33);
            this.textBoxRegAplNr.TabIndex = 2;
            // 
            // LabelVehicleType
            // 
            this.LabelVehicleType.AutoSize = true;
            this.LabelVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehicleType.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicleType.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehicleType.Location = new System.Drawing.Point(22, 18);
            this.LabelVehicleType.Name = "LabelVehicleType";
            this.LabelVehicleType.Size = new System.Drawing.Size(397, 37);
            this.LabelVehicleType.TabIndex = 3;
            this.LabelVehicleType.Text = "Transportlīdzekļa Nosaukums";
            this.LabelVehicleType.Click += new System.EventHandler(this.LabelVehicleType_Click);
            // 
            // LabelVehiclePlate
            // 
            this.LabelVehiclePlate.AutoSize = true;
            this.LabelVehiclePlate.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehiclePlate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehiclePlate.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehiclePlate.Location = new System.Drawing.Point(22, 82);
            this.LabelVehiclePlate.Name = "LabelVehiclePlate";
            this.LabelVehiclePlate.Size = new System.Drawing.Size(287, 37);
            this.LabelVehiclePlate.TabIndex = 3;
            this.LabelVehiclePlate.Text = "Reģistrācijas Numurs";
            this.LabelVehiclePlate.Click += new System.EventHandler(this.LabelVehicleType_Click);
            // 
            // LabelVehicleRegAplNr
            // 
            this.LabelVehicleRegAplNr.AutoSize = true;
            this.LabelVehicleRegAplNr.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehicleRegAplNr.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicleRegAplNr.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehicleRegAplNr.Location = new System.Drawing.Point(22, 150);
            this.LabelVehicleRegAplNr.Name = "LabelVehicleRegAplNr";
            this.LabelVehicleRegAplNr.Size = new System.Drawing.Size(362, 37);
            this.LabelVehicleRegAplNr.TabIndex = 3;
            this.LabelVehicleRegAplNr.Text = "Reģistrācijas Apliecības Nr.";
            this.LabelVehicleRegAplNr.Click += new System.EventHandler(this.LabelVehicleType_Click);
            // 
            // LabelVehicleOctaDate
            // 
            this.LabelVehicleOctaDate.AutoSize = true;
            this.LabelVehicleOctaDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehicleOctaDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicleOctaDate.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehicleOctaDate.Location = new System.Drawing.Point(22, 214);
            this.LabelVehicleOctaDate.Name = "LabelVehicleOctaDate";
            this.LabelVehicleOctaDate.Size = new System.Drawing.Size(273, 37);
            this.LabelVehicleOctaDate.TabIndex = 3;
            this.LabelVehicleOctaDate.Text = "OCTA Beigu Datums";
            this.LabelVehicleOctaDate.Click += new System.EventHandler(this.LabelVehicleType_Click);
            // 
            // LabelVehicleTaDate
            // 
            this.LabelVehicleTaDate.AutoEllipsis = true;
            this.LabelVehicleTaDate.AutoSize = true;
            this.LabelVehicleTaDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelVehicleTaDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicleTaDate.ForeColor = System.Drawing.Color.Silver;
            this.LabelVehicleTaDate.Location = new System.Drawing.Point(22, 277);
            this.LabelVehicleTaDate.Name = "LabelVehicleTaDate";
            this.LabelVehicleTaDate.Size = new System.Drawing.Size(378, 37);
            this.LabelVehicleTaDate.TabIndex = 3;
            this.LabelVehicleTaDate.Text = "Teh. Apskates Beigu Datums";
            this.LabelVehicleTaDate.Click += new System.EventHandler(this.LabelVehicleType_Click);
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddVehicle.AutoSize = true;
            this.buttonAddVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddVehicle.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAddVehicle.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonAddVehicle.FlatAppearance.BorderSize = 2;
            this.buttonAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVehicle.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonAddVehicle.Location = new System.Drawing.Point(274, 559);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(259, 38);
            this.buttonAddVehicle.TabIndex = 5;
            this.buttonAddVehicle.Text = "Pievienot Tranportlīdzekli";
            this.buttonAddVehicle.UseVisualStyleBackColor = false;
            this.buttonAddVehicle.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimeOcta
            // 
            this.dateTimeOcta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeOcta.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeOcta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeOcta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeOcta.Location = new System.Drawing.Point(586, 217);
            this.dateTimeOcta.Name = "dateTimeOcta";
            this.dateTimeOcta.Size = new System.Drawing.Size(171, 34);
            this.dateTimeOcta.TabIndex = 3;
            // 
            // dateTimeTa
            // 
            this.dateTimeTa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTa.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeTa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTa.Location = new System.Drawing.Point(586, 277);
            this.dateTimeTa.Name = "dateTimeTa";
            this.dateTimeTa.Size = new System.Drawing.Size(171, 34);
            this.dateTimeTa.TabIndex = 4;
            // 
            // dateTimeAtd
            // 
            this.dateTimeAtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeAtd.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeAtd.Checked = false;
            this.dateTimeAtd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAtd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAtd.Location = new System.Drawing.Point(586, 456);
            this.dateTimeAtd.Name = "dateTimeAtd";
            this.dateTimeAtd.ShowCheckBox = true;
            this.dateTimeAtd.Size = new System.Drawing.Size(171, 34);
            this.dateTimeAtd.TabIndex = 19;
            // 
            // dateTimeCmr
            // 
            this.dateTimeCmr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeCmr.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeCmr.Checked = false;
            this.dateTimeCmr.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCmr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCmr.Location = new System.Drawing.Point(586, 398);
            this.dateTimeCmr.Name = "dateTimeCmr";
            this.dateTimeCmr.ShowCheckBox = true;
            this.dateTimeCmr.Size = new System.Drawing.Size(171, 34);
            this.dateTimeCmr.TabIndex = 20;
            // 
            // dateTimeKasko
            // 
            this.dateTimeKasko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeKasko.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeKasko.Checked = false;
            this.dateTimeKasko.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeKasko.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeKasko.Location = new System.Drawing.Point(586, 339);
            this.dateTimeKasko.Name = "dateTimeKasko";
            this.dateTimeKasko.ShowCheckBox = true;
            this.dateTimeKasko.Size = new System.Drawing.Size(171, 34);
            this.dateTimeKasko.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(22, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "ATD licences Beigu Datums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(22, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "CMR Polises Beigu Datums";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(22, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "KASKO Polises Beigu Datums";
            // 
            // FormVehicleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.dateTimeAtd);
            this.Controls.Add(this.dateTimeCmr);
            this.Controls.Add(this.dateTimeKasko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeTa);
            this.Controls.Add(this.dateTimeOcta);
            this.Controls.Add(this.textBoxRegAplNr);
            this.Controls.Add(this.textBoxPlateNumber);
            this.Controls.Add(this.textBoxVehicleType);
            this.Controls.Add(this.buttonAddVehicle);
            this.Controls.Add(this.LabelVehicleTaDate);
            this.Controls.Add(this.LabelVehicleOctaDate);
            this.Controls.Add(this.LabelVehicleRegAplNr);
            this.Controls.Add(this.LabelVehiclePlate);
            this.Controls.Add(this.LabelVehicleType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVehicleAdd";
            this.Text = "FormVehicleAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVehicleType;
        private System.Windows.Forms.TextBox textBoxPlateNumber;
        private System.Windows.Forms.TextBox textBoxRegAplNr;
        private System.Windows.Forms.Label LabelVehicleType;
        private System.Windows.Forms.Label LabelVehiclePlate;
        private System.Windows.Forms.Label LabelVehicleRegAplNr;
        private System.Windows.Forms.Label LabelVehicleOctaDate;
        private System.Windows.Forms.Label LabelVehicleTaDate;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.DateTimePicker dateTimeOcta;
        private System.Windows.Forms.DateTimePicker dateTimeTa;
        private System.Windows.Forms.DateTimePicker dateTimeAtd;
        private System.Windows.Forms.DateTimePicker dateTimeCmr;
        private System.Windows.Forms.DateTimePicker dateTimeKasko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}