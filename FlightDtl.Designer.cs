namespace trouism
{
    partial class FlightDtl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightDtl));
            this.A_time = new System.Windows.Forms.DateTimePicker();
            this.D_Time = new System.Windows.Forms.DateTimePicker();
            this.D_ate = new System.Windows.Forms.DateTimePicker();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Flight_ID = new System.Windows.Forms.TextBox();
            this.Seat = new System.Windows.Forms.TextBox();
            this.Plane_Name = new System.Windows.Forms.TextBox();
            this.Plane_ID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // A_time
            // 
            this.A_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.A_time.Location = new System.Drawing.Point(513, 96);
            this.A_time.Name = "A_time";
            this.A_time.Size = new System.Drawing.Size(93, 20);
            this.A_time.TabIndex = 63;
            // 
            // D_Time
            // 
            this.D_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.D_Time.Location = new System.Drawing.Point(513, 64);
            this.D_Time.Name = "D_Time";
            this.D_Time.Size = new System.Drawing.Size(93, 20);
            this.D_Time.TabIndex = 62;
            // 
            // D_ate
            // 
            this.D_ate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.D_ate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.D_ate.Location = new System.Drawing.Point(513, 128);
            this.D_ate.Name = "D_ate";
            this.D_ate.Size = new System.Drawing.Size(93, 23);
            this.D_ate.TabIndex = 61;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.Location = new System.Drawing.Point(73, 203);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(639, 271);
            this.DataGridView1.TabIndex = 60;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(405, 100);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(83, 17);
            this.Label8.TabIndex = 58;
            this.Label8.Text = "Arrival Time";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(419, 131);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(38, 17);
            this.Label7.TabIndex = 57;
            this.Label7.Text = "Date";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(400, 65);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(106, 17);
            this.Label6.TabIndex = 56;
            this.Label6.Text = " Depature Time";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(87, 131);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(81, 17);
            this.Label5.TabIndex = 55;
            this.Label5.Text = "PlaneName";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(70, 162);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(98, 17);
            this.Label4.TabIndex = 54;
            this.Label4.Text = "Seat Available";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(111, 103);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(57, 17);
            this.Label3.TabIndex = 53;
            this.Label3.Text = "PlaneID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(109, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 17);
            this.Label2.TabIndex = 52;
            this.Label2.Text = "Flight ID";
            // 
            // Flight_ID
            // 
            this.Flight_ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Flight_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Flight_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flight_ID.Location = new System.Drawing.Point(174, 65);
            this.Flight_ID.Name = "Flight_ID";
            this.Flight_ID.Size = new System.Drawing.Size(216, 23);
            this.Flight_ID.TabIndex = 49;
            // 
            // Seat
            // 
            this.Seat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seat.Location = new System.Drawing.Point(175, 159);
            this.Seat.Name = "Seat";
            this.Seat.ReadOnly = true;
            this.Seat.Size = new System.Drawing.Size(216, 23);
            this.Seat.TabIndex = 50;
            // 
            // Plane_Name
            // 
            this.Plane_Name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Plane_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plane_Name.Location = new System.Drawing.Point(174, 130);
            this.Plane_Name.Name = "Plane_Name";
            this.Plane_Name.ReadOnly = true;
            this.Plane_Name.Size = new System.Drawing.Size(216, 23);
            this.Plane_Name.TabIndex = 51;
            // 
            // Plane_ID
            // 
            this.Plane_ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Plane_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Plane_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Plane_ID.FormattingEnabled = true;
            this.Plane_ID.Location = new System.Drawing.Point(175, 99);
            this.Plane_ID.Name = "Plane_ID";
            this.Plane_ID.Size = new System.Drawing.Size(215, 24);
            this.Plane_ID.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(801, 33);
            this.label9.TabIndex = 64;
            this.label9.Text = "Available Flight";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FlightDtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 486);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.A_time);
            this.Controls.Add(this.D_Time);
            this.Controls.Add(this.D_ate);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Plane_ID);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Plane_Name);
            this.Controls.Add(this.Seat);
            this.Controls.Add(this.Flight_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FlightDtl";
            this.Text = "Flight Details";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker A_time;
        internal System.Windows.Forms.DateTimePicker D_Time;
        internal System.Windows.Forms.DateTimePicker D_ate;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox Flight_ID;
        internal System.Windows.Forms.TextBox Seat;
        internal System.Windows.Forms.TextBox Plane_Name;
        internal System.Windows.Forms.ComboBox Plane_ID;
        internal System.Windows.Forms.Label label9;
    }
}