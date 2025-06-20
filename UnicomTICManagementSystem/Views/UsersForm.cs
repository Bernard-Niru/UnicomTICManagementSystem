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
    public partial class UsersForm : Form
    {
        private StudentController studentController = new StudentController();
        private UserController userController = new UserController();
        private int selectedUserId = -1;

        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
            LoadRoles();
           

        }
        public void LoadUsers()
        {
            User_dgv.DataSource = null;
            User_dgv.DataSource = userController.GetAllUsers();            
            User_dgv.ClearSelection();
        }
        private void ClearForm() 
        {
            name_txt.Clear();
            username_txt.Clear();
            role_cbx.SelectedIndex = -1;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadRoles()
        {
            role_cbx.DataSource = new List<string> { "Admin", "Lecturer", "Staff"};
            role_cbx.SelectedIndex = -1;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = name_txt.Text.Trim(),
                Username = username_txt.Text.Trim(),
                Password = "12345",
                Role = (string)role_cbx.SelectedValue
            };

            bool added = userController.AddUser(user);

            if (added)
            {
                LoadUsers();
                MessageBox.Show("User Added Successfully");
            }
            ClearForm();
        }


        private void role_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string newName = name_txt.Text.Trim();
            string newRole = (string) role_cbx.SelectedValue;

            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newRole))
            {
                MessageBox.Show("Please enter both Name and Role.");
                return;
            }

            var user = new User
            {
                Id = selectedUserId,
                Name = newName,
                Role = (string)role_cbx.SelectedValue

            };
            userController.UpdateUser(user);
            MessageBox.Show("User updated successfully");

            string role = Convert.ToString(User_dgv.SelectedRows[0].Cells["Role"].Value);
            if (role == "Student")                                                         // If role is "Student" Update user on Students Table also
            {
                Student student = new Student 
                {
                    Id = selectedUserId,
                    Name = newName,
                };
                studentController.UpdateStudentByUserID(student);
            }

            LoadUsers();
            ClearForm();
        }

        private void Delete_btn_Click(object sender, EventArgs e) // Deleting User
        {                                          
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a User to delete");
                return;
            }

            var confirmatiion = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmatiion == DialogResult.Yes)
            {
                string role = Convert.ToString(User_dgv.SelectedRows[0].Cells["Role"].Value);
                int userid = Convert.ToInt32(User_dgv.SelectedRows[0].Cells["id"].Value);
                if (role == "Student")
                {
                    studentController.DeleteStudentByUserID(userid);                   // If Role is "Student" delete the user from Students table also
                }
                userController.DeleteUser(userid);
                ClearForm();
                LoadUsers();
                MessageBox.Show("User Deleted Successfully");
            }
            
        }

        private void User_dgv_SelectionChanged(object sender, EventArgs e)
        {
            ClearForm();
            if (User_dgv.SelectedRows.Count > 0)
            {
                var row = User_dgv.SelectedRows[0];
                var userView = row.DataBoundItem as User;

                if (userView != null)
                {
                    selectedUserId = userView.Id;

                    var user = userController.GetUserById(selectedUserId);
                    if (user != null)
                    {
                        name_txt.Text = user.Name;
                        role_cbx.SelectedItem = user.Role;
                    }
                }
            }
            else
            {

                selectedUserId = -1;
            }
        }
    }
}
