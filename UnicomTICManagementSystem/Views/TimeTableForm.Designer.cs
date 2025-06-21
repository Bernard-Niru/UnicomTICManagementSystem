namespace UnicomTICManagementSystem.Views
{
    partial class TimeTableForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Timetable_dgv = new System.Windows.Forms.DataGridView();
            this.Courses_cbx = new System.Windows.Forms.ComboBox();
            this.Subjects_cbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Date_dtp = new System.Windows.Forms.DateTimePicker();
            this.Time_dtp = new System.Windows.Forms.DateTimePicker();
            this.Rooms_cbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Timetable_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Timetable_dgv
            // 
            this.Timetable_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Timetable_dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Timetable_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Timetable_dgv.Location = new System.Drawing.Point(37, 63);
            this.Timetable_dgv.Name = "Timetable_dgv";
            this.Timetable_dgv.Size = new System.Drawing.Size(968, 257);
            this.Timetable_dgv.TabIndex = 1;
            this.Timetable_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Timetable_dgv_CellContentClick);
            this.Timetable_dgv.SelectionChanged += new System.EventHandler(this.Timetable_dgv_SelectionChanged);
            // 
            // Courses_cbx
            // 
            this.Courses_cbx.FormattingEnabled = true;
            this.Courses_cbx.Location = new System.Drawing.Point(177, 343);
            this.Courses_cbx.Name = "Courses_cbx";
            this.Courses_cbx.Size = new System.Drawing.Size(168, 21);
            this.Courses_cbx.TabIndex = 3;
            this.Courses_cbx.SelectedIndexChanged += new System.EventHandler(this.Courses_cbx_SelectedIndexChanged);
            // 
            // Subjects_cbx
            // 
            this.Subjects_cbx.FormattingEnabled = true;
            this.Subjects_cbx.Location = new System.Drawing.Point(177, 390);
            this.Subjects_cbx.Name = "Subjects_cbx";
            this.Subjects_cbx.Size = new System.Drawing.Size(168, 21);
            this.Subjects_cbx.TabIndex = 4;
            this.Subjects_cbx.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject Name";
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Red;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_btn.Location = new System.Drawing.Point(291, 476);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 7;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_btn.Location = new System.Drawing.Point(469, 476);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 8;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_btn.Location = new System.Drawing.Point(652, 476);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 9;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Date_dtp
            // 
            this.Date_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_dtp.Location = new System.Drawing.Point(495, 343);
            this.Date_dtp.Name = "Date_dtp";
            this.Date_dtp.ShowUpDown = true;
            this.Date_dtp.Size = new System.Drawing.Size(115, 20);
            this.Date_dtp.TabIndex = 10;
            this.Date_dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Time_dtp
            // 
            this.Time_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_dtp.Location = new System.Drawing.Point(495, 395);
            this.Time_dtp.Name = "Time_dtp";
            this.Time_dtp.ShowUpDown = true;
            this.Time_dtp.Size = new System.Drawing.Size(115, 20);
            this.Time_dtp.TabIndex = 11;
            // 
            // Rooms_cbx
            // 
            this.Rooms_cbx.FormattingEnabled = true;
            this.Rooms_cbx.Location = new System.Drawing.Point(763, 342);
            this.Rooms_cbx.Name = "Rooms_cbx";
            this.Rooms_cbx.Size = new System.Drawing.Size(181, 21);
            this.Rooms_cbx.TabIndex = 12;
            this.Rooms_cbx.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(694, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 511);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rooms_cbx);
            this.Controls.Add(this.Time_dtp);
            this.Controls.Add(this.Date_dtp);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Subjects_cbx);
            this.Controls.Add(this.Courses_cbx);
            this.Controls.Add(this.Timetable_dgv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeTableForm";
            this.ShowIcon = false;
            this.Text = "TimeTableForm";
            this.Load += new System.EventHandler(this.TimeTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Timetable_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Timetable_dgv;
        private System.Windows.Forms.ComboBox Courses_cbx;
        private System.Windows.Forms.ComboBox Subjects_cbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DateTimePicker Date_dtp;
        private System.Windows.Forms.DateTimePicker Time_dtp;
        private System.Windows.Forms.ComboBox Rooms_cbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}