namespace UnicomTICManagementSystem.Views
{
    partial class MarksForm
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
            this.Marks_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Courses_cbx = new System.Windows.Forms.ComboBox();
            this.Subjects_cbx = new System.Windows.Forms.ComboBox();
            this.Exams_cbx = new System.Windows.Forms.ComboBox();
            this.Students_cbx = new System.Windows.Forms.ComboBox();
            this.Marks_txt = new System.Windows.Forms.TextBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Username_cbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Marks_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marks";
            // 
            // Marks_dgv
            // 
            this.Marks_dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Marks_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Marks_dgv.Location = new System.Drawing.Point(27, 57);
            this.Marks_dgv.Name = "Marks_dgv";
            this.Marks_dgv.Size = new System.Drawing.Size(963, 250);
            this.Marks_dgv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(730, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(727, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Marks";
            // 
            // Courses_cbx
            // 
            this.Courses_cbx.FormattingEnabled = true;
            this.Courses_cbx.Location = new System.Drawing.Point(89, 359);
            this.Courses_cbx.Name = "Courses_cbx";
            this.Courses_cbx.Size = new System.Drawing.Size(121, 21);
            this.Courses_cbx.TabIndex = 7;
            // 
            // Subjects_cbx
            // 
            this.Subjects_cbx.FormattingEnabled = true;
            this.Subjects_cbx.Location = new System.Drawing.Point(89, 410);
            this.Subjects_cbx.Name = "Subjects_cbx";
            this.Subjects_cbx.Size = new System.Drawing.Size(121, 21);
            this.Subjects_cbx.TabIndex = 8;
            // 
            // Exams_cbx
            // 
            this.Exams_cbx.FormattingEnabled = true;
            this.Exams_cbx.Location = new System.Drawing.Point(777, 359);
            this.Exams_cbx.Name = "Exams_cbx";
            this.Exams_cbx.Size = new System.Drawing.Size(121, 21);
            this.Exams_cbx.TabIndex = 9;
            // 
            // Students_cbx
            // 
            this.Students_cbx.FormattingEnabled = true;
            this.Students_cbx.Location = new System.Drawing.Point(453, 359);
            this.Students_cbx.Name = "Students_cbx";
            this.Students_cbx.Size = new System.Drawing.Size(121, 21);
            this.Students_cbx.TabIndex = 10;
            // 
            // Marks_txt
            // 
            this.Marks_txt.Location = new System.Drawing.Point(777, 406);
            this.Marks_txt.Name = "Marks_txt";
            this.Marks_txt.Size = new System.Drawing.Size(121, 20);
            this.Marks_txt.TabIndex = 11;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Red;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_btn.Location = new System.Drawing.Point(322, 476);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 12;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_btn.Location = new System.Drawing.Point(481, 476);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 13;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_btn.Location = new System.Drawing.Point(646, 476);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 14;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username";
            // 
            // Username_cbx
            // 
            this.Username_cbx.FormattingEnabled = true;
            this.Username_cbx.Location = new System.Drawing.Point(453, 406);
            this.Username_cbx.Name = "Username_cbx";
            this.Username_cbx.Size = new System.Drawing.Size(121, 21);
            this.Username_cbx.TabIndex = 16;
            // 
            // MarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 511);
            this.ControlBox = false;
            this.Controls.Add(this.Username_cbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Marks_txt);
            this.Controls.Add(this.Students_cbx);
            this.Controls.Add(this.Exams_cbx);
            this.Controls.Add(this.Subjects_cbx);
            this.Controls.Add(this.Courses_cbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Marks_dgv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarksForm";
            this.ShowIcon = false;
            this.Text = "MarksForm";
            ((System.ComponentModel.ISupportInitialize)(this.Marks_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Marks_dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Courses_cbx;
        private System.Windows.Forms.ComboBox Subjects_cbx;
        private System.Windows.Forms.ComboBox Exams_cbx;
        private System.Windows.Forms.ComboBox Students_cbx;
        private System.Windows.Forms.TextBox Marks_txt;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Username_cbx;
    }
}