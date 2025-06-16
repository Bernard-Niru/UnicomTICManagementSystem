using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();          
        }

        private void Students_btn_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
            this.Hide();
        }

        private void Courses_btn_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.Show();
            this.Hide();
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {               
             UsersForm usersForm = new UsersForm();
             usersForm.Show();
             this.Hide();               
        }

        private void MainForm_Load(object sender, EventArgs e)
        {          
            if (Role.CurrentRole == "Student")
            {
                Users_btn.Visible = false;
                Courses_btn.Visible = false;

            }
            else if (Role.CurrentRole == "Staff" || Role.CurrentRole == "Lecturer")
            {
                Users_btn.Visible = false;
            }

        }
    }
}
