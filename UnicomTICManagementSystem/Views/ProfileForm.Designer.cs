namespace UnicomTICManagementSystem.Views
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Role_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Username1_lbl = new System.Windows.Forms.Label();
            this.Pswd_lbl = new System.Windows.Forms.Label();
            this.Change_UN_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Username2_lbl = new System.Windows.Forms.Label();
            this.Course1_lbl = new System.Windows.Forms.Label();
            this.Course2_lbl = new System.Windows.Forms.Label();
            this.Change_Pw_btn = new System.Windows.Forms.Button();
            this.Uname_txt = new System.Windows.Forms.TextBox();
            this.Pswd_txt = new System.Windows.Forms.TextBox();
            this.Ok_UN_btn = new System.Windows.Forms.Button();
            this.Ok_Pw_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(386, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 204);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Role_lbl
            // 
            this.Role_lbl.AutoSize = true;
            this.Role_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_lbl.Location = new System.Drawing.Point(345, 409);
            this.Role_lbl.Name = "Role_lbl";
            this.Role_lbl.Size = new System.Drawing.Size(67, 16);
            this.Role_lbl.TabIndex = 2;
            this.Role_lbl.Text = "--ROLE--";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(345, 340);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(75, 16);
            this.Name_lbl.TabIndex = 3;
            this.Name_lbl.Text = "---NAME--";
            this.Name_lbl.Click += new System.EventHandler(this.Name_lbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name :-";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Role :-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password :-";
            // 
            // Username1_lbl
            // 
            this.Username1_lbl.AutoSize = true;
            this.Username1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username1_lbl.Location = new System.Drawing.Point(400, 258);
            this.Username1_lbl.Name = "Username1_lbl";
            this.Username1_lbl.Size = new System.Drawing.Size(168, 29);
            this.Username1_lbl.TabIndex = 7;
            this.Username1_lbl.Text = "--Username--";
            this.Username1_lbl.Click += new System.EventHandler(this.Username_lbl_Click);
            // 
            // Pswd_lbl
            // 
            this.Pswd_lbl.AutoSize = true;
            this.Pswd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pswd_lbl.Location = new System.Drawing.Point(345, 444);
            this.Pswd_lbl.Name = "Pswd_lbl";
            this.Pswd_lbl.Size = new System.Drawing.Size(72, 16);
            this.Pswd_lbl.TabIndex = 8;
            this.Pswd_lbl.Text = "--PSWD--";
            // 
            // Change_UN_btn
            // 
            this.Change_UN_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Change_UN_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_UN_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Change_UN_btn.Location = new System.Drawing.Point(468, 367);
            this.Change_UN_btn.Name = "Change_UN_btn";
            this.Change_UN_btn.Size = new System.Drawing.Size(52, 25);
            this.Change_UN_btn.TabIndex = 9;
            this.Change_UN_btn.Text = "Change";
            this.Change_UN_btn.UseVisualStyleBackColor = false;
            this.Change_UN_btn.Click += new System.EventHandler(this.Change_UN_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username :-";
            // 
            // Username2_lbl
            // 
            this.Username2_lbl.AutoSize = true;
            this.Username2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username2_lbl.Location = new System.Drawing.Point(345, 376);
            this.Username2_lbl.Name = "Username2_lbl";
            this.Username2_lbl.Size = new System.Drawing.Size(112, 16);
            this.Username2_lbl.TabIndex = 11;
            this.Username2_lbl.Text = "--USERNAME--";
            // 
            // Course1_lbl
            // 
            this.Course1_lbl.AutoSize = true;
            this.Course1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course1_lbl.Location = new System.Drawing.Point(263, 483);
            this.Course1_lbl.Name = "Course1_lbl";
            this.Course1_lbl.Size = new System.Drawing.Size(69, 16);
            this.Course1_lbl.TabIndex = 12;
            this.Course1_lbl.Text = "Course :-";
            // 
            // Course2_lbl
            // 
            this.Course2_lbl.AutoSize = true;
            this.Course2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course2_lbl.Location = new System.Drawing.Point(345, 483);
            this.Course2_lbl.Name = "Course2_lbl";
            this.Course2_lbl.Size = new System.Drawing.Size(90, 16);
            this.Course2_lbl.TabIndex = 13;
            this.Course2_lbl.Text = "--COURSE--";
            // 
            // Change_Pw_btn
            // 
            this.Change_Pw_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Change_Pw_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Pw_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Change_Pw_btn.Location = new System.Drawing.Point(468, 435);
            this.Change_Pw_btn.Name = "Change_Pw_btn";
            this.Change_Pw_btn.Size = new System.Drawing.Size(52, 25);
            this.Change_Pw_btn.TabIndex = 14;
            this.Change_Pw_btn.Text = "Change";
            this.Change_Pw_btn.UseVisualStyleBackColor = false;
            this.Change_Pw_btn.Click += new System.EventHandler(this.Change_Pw_btn_Click);
            // 
            // Uname_txt
            // 
            this.Uname_txt.Location = new System.Drawing.Point(532, 371);
            this.Uname_txt.Name = "Uname_txt";
            this.Uname_txt.Size = new System.Drawing.Size(167, 20);
            this.Uname_txt.TabIndex = 15;
            this.Uname_txt.TextChanged += new System.EventHandler(this.Uname_txt_TextChanged);
            // 
            // Pswd_txt
            // 
            this.Pswd_txt.Location = new System.Drawing.Point(532, 435);
            this.Pswd_txt.Name = "Pswd_txt";
            this.Pswd_txt.Size = new System.Drawing.Size(172, 20);
            this.Pswd_txt.TabIndex = 16;
            // 
            // Ok_UN_btn
            // 
            this.Ok_UN_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ok_UN_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_UN_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ok_UN_btn.Location = new System.Drawing.Point(716, 366);
            this.Ok_UN_btn.Name = "Ok_UN_btn";
            this.Ok_UN_btn.Size = new System.Drawing.Size(39, 26);
            this.Ok_UN_btn.TabIndex = 17;
            this.Ok_UN_btn.Text = "OK";
            this.Ok_UN_btn.UseVisualStyleBackColor = false;
            this.Ok_UN_btn.Click += new System.EventHandler(this.Ok_UN_btn_Click);
            // 
            // Ok_Pw_btn
            // 
            this.Ok_Pw_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ok_Pw_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_Pw_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ok_Pw_btn.Location = new System.Drawing.Point(716, 435);
            this.Ok_Pw_btn.Name = "Ok_Pw_btn";
            this.Ok_Pw_btn.Size = new System.Drawing.Size(39, 25);
            this.Ok_Pw_btn.TabIndex = 18;
            this.Ok_Pw_btn.Text = "OK";
            this.Ok_Pw_btn.UseVisualStyleBackColor = false;
            this.Ok_Pw_btn.Click += new System.EventHandler(this.Ok_Pw_btn_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1031, 511);
            this.ControlBox = false;
            this.Controls.Add(this.Ok_Pw_btn);
            this.Controls.Add(this.Ok_UN_btn);
            this.Controls.Add(this.Pswd_txt);
            this.Controls.Add(this.Uname_txt);
            this.Controls.Add(this.Change_Pw_btn);
            this.Controls.Add(this.Course2_lbl);
            this.Controls.Add(this.Course1_lbl);
            this.Controls.Add(this.Username2_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Change_UN_btn);
            this.Controls.Add(this.Pswd_lbl);
            this.Controls.Add(this.Username1_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Role_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.ShowIcon = false;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Role_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Username1_lbl;
        private System.Windows.Forms.Label Pswd_lbl;
        private System.Windows.Forms.Button Change_UN_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username2_lbl;
        private System.Windows.Forms.Label Course1_lbl;
        private System.Windows.Forms.Label Course2_lbl;
        private System.Windows.Forms.Button Change_Pw_btn;
        private System.Windows.Forms.TextBox Uname_txt;
        private System.Windows.Forms.TextBox Pswd_txt;
        private System.Windows.Forms.Button Ok_UN_btn;
        private System.Windows.Forms.Button Ok_Pw_btn;
    }
}