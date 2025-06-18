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
        UserController userController = new UserController();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadRoles()
        {
            role_cbx.DataSource = new List<string> { "Admin", "Lecturer", "Staff" };
            role_cbx.SelectedIndex = -1;

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = name_txt.Text.Trim(),
                Username = username_txt.Text.Trim(),
                Password = "12345",
                Role =(string)role_cbx.SelectedValue


            };
            userController.AddUser(user);
            LoadUsers();
            username_txt.Clear();
            MessageBox.Show("User Added Successfully");
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

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
        //    {
        //        if (User_dgv.SelectedRows.Count > 0)
        //        {
        //            int id = Convert.ToInt32(User_dgv.SelectedRows[0].Cells["Id"].Value);
        //            userController.DeleteUser(id);
        //            LoadUsers();
        //        }
        //    }
        }

        private void User_dgv_SelectionChanged(object sender, EventArgs e)
        {    

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
                        username_txt.Text = user.Username;
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
