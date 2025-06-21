using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    partial class MainForm
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
            this.Students_btn = new System.Windows.Forms.Button();
            this.Courses_btn = new System.Windows.Forms.Button();
            this.Users_btn = new System.Windows.Forms.Button();
            this.Subjects_btn = new System.Windows.Forms.Button();
            this.Rooms_btn = new System.Windows.Forms.Button();
            this.Timetable_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Marks_btn = new System.Windows.Forms.Button();
            this.Exams_btn = new System.Windows.Forms.Button();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.Sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students_btn
            // 
            this.Students_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Students_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_btn.Location = new System.Drawing.Point(28, 113);
            this.Students_btn.Name = "Students_btn";
            this.Students_btn.Size = new System.Drawing.Size(103, 23);
            this.Students_btn.TabIndex = 0;
            this.Students_btn.Text = "Students";
            this.Students_btn.UseVisualStyleBackColor = false;
            this.Students_btn.Click += new System.EventHandler(this.Students_btn_Click);
            // 
            // Courses_btn
            // 
            this.Courses_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Courses_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_btn.Location = new System.Drawing.Point(28, 315);
            this.Courses_btn.Name = "Courses_btn";
            this.Courses_btn.Size = new System.Drawing.Size(103, 23);
            this.Courses_btn.TabIndex = 1;
            this.Courses_btn.Text = "Courses";
            this.Courses_btn.UseVisualStyleBackColor = false;
            this.Courses_btn.Click += new System.EventHandler(this.Courses_btn_Click);
            // 
            // Users_btn
            // 
            this.Users_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Users_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_btn.Location = new System.Drawing.Point(28, 67);
            this.Users_btn.Name = "Users_btn";
            this.Users_btn.Size = new System.Drawing.Size(103, 23);
            this.Users_btn.TabIndex = 2;
            this.Users_btn.Text = "Users";
            this.Users_btn.UseVisualStyleBackColor = false;
            this.Users_btn.Click += new System.EventHandler(this.Users_btn_Click);
            // 
            // Subjects_btn
            // 
            this.Subjects_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Subjects_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subjects_btn.Location = new System.Drawing.Point(28, 371);
            this.Subjects_btn.Name = "Subjects_btn";
            this.Subjects_btn.Size = new System.Drawing.Size(103, 23);
            this.Subjects_btn.TabIndex = 3;
            this.Subjects_btn.Text = "Subjects";
            this.Subjects_btn.UseVisualStyleBackColor = false;
            this.Subjects_btn.Click += new System.EventHandler(this.Subjects_btn_Click);
            // 
            // Rooms_btn
            // 
            this.Rooms_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Rooms_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms_btn.Location = new System.Drawing.Point(28, 425);
            this.Rooms_btn.Name = "Rooms_btn";
            this.Rooms_btn.Size = new System.Drawing.Size(103, 23);
            this.Rooms_btn.TabIndex = 4;
            this.Rooms_btn.Text = "Rooms";
            this.Rooms_btn.UseVisualStyleBackColor = false;
            this.Rooms_btn.Click += new System.EventHandler(this.Rooms_btn_Click);
            // 
            // Timetable_btn
            // 
            this.Timetable_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Timetable_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timetable_btn.Location = new System.Drawing.Point(28, 166);
            this.Timetable_btn.Name = "Timetable_btn";
            this.Timetable_btn.Size = new System.Drawing.Size(103, 23);
            this.Timetable_btn.TabIndex = 6;
            this.Timetable_btn.Text = "Time Table";
            this.Timetable_btn.UseVisualStyleBackColor = false;
            this.Timetable_btn.Click += new System.EventHandler(this.Timetable_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(112, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Sidepanel.Controls.Add(this.button2);
            this.Sidepanel.Controls.Add(this.button1);
            this.Sidepanel.Controls.Add(this.Marks_btn);
            this.Sidepanel.Controls.Add(this.Rooms_btn);
            this.Sidepanel.Controls.Add(this.Exams_btn);
            this.Sidepanel.Controls.Add(this.Subjects_btn);
            this.Sidepanel.Controls.Add(this.Students_btn);
            this.Sidepanel.Controls.Add(this.Users_btn);
            this.Sidepanel.Controls.Add(this.Courses_btn);
            this.Sidepanel.Controls.Add(this.Timetable_btn);
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidepanel.Location = new System.Drawing.Point(0, 0);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(151, 550);
            this.Sidepanel.TabIndex = 8;
            this.Sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidepanel_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "👤";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Marks_btn
            // 
            this.Marks_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Marks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks_btn.Location = new System.Drawing.Point(28, 264);
            this.Marks_btn.Name = "Marks_btn";
            this.Marks_btn.Size = new System.Drawing.Size(103, 23);
            this.Marks_btn.TabIndex = 8;
            this.Marks_btn.Text = "Marks";
            this.Marks_btn.UseVisualStyleBackColor = false;
            this.Marks_btn.Click += new System.EventHandler(this.Marks_btn_Click);
            // 
            // Exams_btn
            // 
            this.Exams_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Exams_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exams_btn.Location = new System.Drawing.Point(28, 212);
            this.Exams_btn.Name = "Exams_btn";
            this.Exams_btn.Size = new System.Drawing.Size(103, 23);
            this.Exams_btn.TabIndex = 7;
            this.Exams_btn.Text = "Exams";
            this.Exams_btn.UseVisualStyleBackColor = false;
            this.Exams_btn.Click += new System.EventHandler(this.Exams_btn_Click);
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackColor = System.Drawing.SystemColors.Window;
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(151, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(1047, 550);
            this.Mainpanel.TabIndex = 9;
            this.Mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mainpanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 550);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.Sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Sidepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Students_btn;
        private System.Windows.Forms.Button Courses_btn;
        private System.Windows.Forms.Button Users_btn;
        private System.Windows.Forms.Button Subjects_btn;
        private System.Windows.Forms.Button Rooms_btn;
        private System.Windows.Forms.Button Timetable_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button Marks_btn;
        private System.Windows.Forms.Button Exams_btn;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Button button2;
    }
}