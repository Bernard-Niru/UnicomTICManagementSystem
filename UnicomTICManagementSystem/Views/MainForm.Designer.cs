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
            this.Pwsd_btn = new System.Windows.Forms.Button();
            this.Timetable_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Students_btn
            // 
            this.Students_btn.Location = new System.Drawing.Point(317, 40);
            this.Students_btn.Name = "Students_btn";
            this.Students_btn.Size = new System.Drawing.Size(75, 23);
            this.Students_btn.TabIndex = 0;
            this.Students_btn.Text = "Students";
            this.Students_btn.UseVisualStyleBackColor = true;
            this.Students_btn.Click += new System.EventHandler(this.Students_btn_Click);
            // 
            // Courses_btn
            // 
            this.Courses_btn.Location = new System.Drawing.Point(317, 104);
            this.Courses_btn.Name = "Courses_btn";
            this.Courses_btn.Size = new System.Drawing.Size(75, 23);
            this.Courses_btn.TabIndex = 1;
            this.Courses_btn.Text = "Courses";
            this.Courses_btn.UseVisualStyleBackColor = true;
            this.Courses_btn.Click += new System.EventHandler(this.Courses_btn_Click);
            // 
            // Users_btn
            // 
            this.Users_btn.Location = new System.Drawing.Point(317, 165);
            this.Users_btn.Name = "Users_btn";
            this.Users_btn.Size = new System.Drawing.Size(75, 23);
            this.Users_btn.TabIndex = 2;
            this.Users_btn.Text = "Users";
            this.Users_btn.UseVisualStyleBackColor = true;
            this.Users_btn.Click += new System.EventHandler(this.Users_btn_Click);
            // 
            // Subjects_btn
            // 
            this.Subjects_btn.Location = new System.Drawing.Point(317, 220);
            this.Subjects_btn.Name = "Subjects_btn";
            this.Subjects_btn.Size = new System.Drawing.Size(75, 23);
            this.Subjects_btn.TabIndex = 3;
            this.Subjects_btn.Text = "Subjects";
            this.Subjects_btn.UseVisualStyleBackColor = true;
            this.Subjects_btn.Click += new System.EventHandler(this.Subjects_btn_Click);
            // 
            // Rooms_btn
            // 
            this.Rooms_btn.Location = new System.Drawing.Point(317, 279);
            this.Rooms_btn.Name = "Rooms_btn";
            this.Rooms_btn.Size = new System.Drawing.Size(75, 23);
            this.Rooms_btn.TabIndex = 4;
            this.Rooms_btn.Text = "Rooms";
            this.Rooms_btn.UseVisualStyleBackColor = true;
            this.Rooms_btn.Click += new System.EventHandler(this.Rooms_btn_Click);
            // 
            // Pwsd_btn
            // 
            this.Pwsd_btn.Location = new System.Drawing.Point(643, 389);
            this.Pwsd_btn.Name = "Pwsd_btn";
            this.Pwsd_btn.Size = new System.Drawing.Size(103, 23);
            this.Pwsd_btn.TabIndex = 5;
            this.Pwsd_btn.Text = "Change Password";
            this.Pwsd_btn.UseVisualStyleBackColor = true;
            this.Pwsd_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timetable_btn
            // 
            this.Timetable_btn.Location = new System.Drawing.Point(317, 341);
            this.Timetable_btn.Name = "Timetable_btn";
            this.Timetable_btn.Size = new System.Drawing.Size(87, 23);
            this.Timetable_btn.TabIndex = 6;
            this.Timetable_btn.Text = "Time Table";
            this.Timetable_btn.UseVisualStyleBackColor = true;
            this.Timetable_btn.Click += new System.EventHandler(this.Timetable_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "<----";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Timetable_btn);
            this.Controls.Add(this.Pwsd_btn);
            this.Controls.Add(this.Rooms_btn);
            this.Controls.Add(this.Subjects_btn);
            this.Controls.Add(this.Users_btn);
            this.Controls.Add(this.Courses_btn);
            this.Controls.Add(this.Students_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Students_btn;
        private System.Windows.Forms.Button Courses_btn;
        private System.Windows.Forms.Button Users_btn;
        private System.Windows.Forms.Button Subjects_btn;
        private System.Windows.Forms.Button Rooms_btn;
        private System.Windows.Forms.Button Pwsd_btn;
        private System.Windows.Forms.Button Timetable_btn;
        private System.Windows.Forms.Button button1;
    }
}