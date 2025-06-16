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
    public partial class CoursesForm : Form
    {
        private CourseController courseController = new CourseController();
        public CoursesForm()
        {
            InitializeComponent();
            LoadCourses();
        }
        private void LoadCourses() 
        {
            Courses_dgv.DataSource = null;
            Courses_dgv.DataSource = courseController.GetAllCourses();           
            Courses_dgv.ClearSelection();
           
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Course course = new Course 
            {
                Name = name_txt.Text.Trim(),
            };
            courseController.AddCourses(course);
            LoadCourses();
            name_txt.Clear();
        }

        private void Courses_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
           MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
