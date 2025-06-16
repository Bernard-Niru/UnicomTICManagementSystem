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
         
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}