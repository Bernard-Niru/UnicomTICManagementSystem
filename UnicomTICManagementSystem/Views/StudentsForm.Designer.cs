namespace UnicomTICManagementSystem.Views
{
    partial class StudentsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.course_cbx = new System.Windows.Forms.ComboBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Student_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Student_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(189, 344);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(258, 20);
            this.name_txt.TabIndex = 4;
            this.name_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(652, 340);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(258, 20);
            this.address_txt.TabIndex = 5;
            this.address_txt.TextChanged += new System.EventHandler(this.address_txt_TextChanged);
            // 
            // course_cbx
            // 
            this.course_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_cbx.FormattingEnabled = true;
            this.course_cbx.Location = new System.Drawing.Point(652, 396);
            this.course_cbx.Name = "course_cbx";
            this.course_cbx.Size = new System.Drawing.Size(258, 21);
            this.course_cbx.TabIndex = 6;
            this.course_cbx.SelectedIndexChanged += new System.EventHandler(this.course_cbx_SelectedIndexChanged);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_btn.Location = new System.Drawing.Point(487, 476);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 7;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_btn.Location = new System.Drawing.Point(652, 476);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 8;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Red;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_btn.Location = new System.Drawing.Point(308, 476);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 9;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "UserName";
            // 
            // Username_txt
            // 
            this.Username_txt.Location = new System.Drawing.Point(189, 396);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(258, 20);
            this.Username_txt.TabIndex = 15;
            this.Username_txt.TextChanged += new System.EventHandler(this.Username_txt_TextChanged);
            // 
            // Student_dgv
            // 
            this.Student_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Student_dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Student_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_dgv.Location = new System.Drawing.Point(47, 55);
            this.Student_dgv.Name = "Student_dgv";
            this.Student_dgv.Size = new System.Drawing.Size(933, 269);
            this.Student_dgv.TabIndex = 16;
            this.Student_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student_dgv_CellContentClick_1);
            this.Student_dgv.SelectionChanged += new System.EventHandler(this.Student_dgv_SelectionChanged_1);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 511);
            this.Controls.Add(this.Student_dgv);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.course_cbx);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.AddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.ComboBox course_cbx;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.DataGridView Student_dgv;
    }
}