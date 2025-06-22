using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class ProfileForm : Form
    {
        private UserController userController = new UserController();
        private StudentController studentController = new StudentController();

        public ProfileForm()
        {
            InitializeComponent();
            LoadForm();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           

        }
        private void LoadForm() 
        {
            Uname_txt.Visible = false;
            Pswd_txt.Visible = false;
            Ok_Pw_btn.Visible = false;
            Ok_UN_btn.Visible = false;
            Course1_lbl.Visible = false;
            Course2_lbl.Visible = false;

            Username1_lbl.Text = Login.CurrentUserName;
            Name_lbl.Text = Login.CurrentName;
            Role_lbl.Text = Login.CurrentRole;
            Pswd_lbl.Text = Login.CurrentPassword;
            Username2_lbl.Text = Login.CurrentUserName;

            if (Login.CurrentRole == "Student")
            {
                Course1_lbl.Visible = true;
                Course2_lbl.Visible = true;
                Course2_lbl.Text = Login.CurrentCourse;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void Username_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Change_UN_btn_Click(object sender, EventArgs e)
        {
            Uname_txt.Visible=true;
            Ok_UN_btn.Visible=true;
        }

        private void Change_Pw_btn_Click(object sender, EventArgs e)
        {
            Pswd_txt.Visible=true;
            Ok_Pw_btn.Visible=true;
        }

        private void Ok_UN_btn_Click(object sender, EventArgs e)
        {
            string username = Uname_txt.Text.Trim();
            var userid = userController.GetUserIDByUsername(Login.CurrentUserName);
            bool updated = userController.UpdateUsername(userid.Id,username);

            if (updated)
            {
                Login.CurrentUserName = username;
                MessageBox.Show("Username updated Successfully");
                LoadForm();
                
                
            }
        }

        private void Ok_Pw_btn_Click(object sender, EventArgs e)
        {
            string password = Pswd_txt.Text.Trim();
            var userid = userController.GetUserIDByUsername(Login.CurrentUserName);
            userController.UpdatePassword(userid.Id,password);
            Login.CurrentPassword = password;
            MessageBox.Show("Password updated Successfully");
            LoadForm();

        }

        private void Name_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
