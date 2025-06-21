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
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem
{
    public partial class LoginForm : Form
    {
        private LoginController loginController = new LoginController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
              
        private void Register_btn_Click(object sender, EventArgs e) // Login
        {         
            User user = new User();
            user.Username = name_txt.Text.Trim();
            user.Password = pswd_txt.Text.Trim(); 
           
            User user1 = loginController.GettingLoginInfo(user);
            if (user1.Username == user.Username && user1.Password == user.Password)
            {
                Login.CurrentPassword = user1.Password;
                Login.CurrentUserName = user1.Username;
                Login.CurrentName = user1.Name; 

                if (user1.Role == "Admin")
                {
                    Login.CurrentRole = "Admin";
                }
                else if (user1.Role == "Student")       //Assigning the role to a static class

                {
                    Login.CurrentRole = "Student";
                }
                else if (user1.Role == "Lecturer")
                {
                    Login.CurrentRole = "Lecturer";
                }
                else
                {
                    Login.CurrentRole = "Staff";
                }
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Invalid Username or Password","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswd_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
