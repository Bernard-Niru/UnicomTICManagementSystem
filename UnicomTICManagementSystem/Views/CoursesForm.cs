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
        private int selectedCourseId = -1;

        public CoursesForm()
        {
            InitializeComponent();
            LoadCourses();
        }
        private void LoadCourses() // Load data from Course table to DataGridView
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

        private void Add_btn_Click(object sender, EventArgs e) // Adding course
        {
            if (string.IsNullOrWhiteSpace(name_txt.Text.Trim()))
            {
                MessageBox.Show("Please enter course Name.");
                return;
            }
            Course course = new Course 
            {
                Name = name_txt.Text.Trim(),
            };
            courseController.AddCourses(course);
            LoadCourses();
            name_txt.Clear();
            MessageBox.Show("Course Added Successfully");
        }

        private void Courses_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void Courses_dgv_SelectionChanged(object sender, EventArgs e)
        {

            if (Courses_dgv.SelectedRows.Count > 0)
            {
                var row = Courses_dgv.SelectedRows[0];
                var CourseView = row.DataBoundItem as Course;


                if (CourseView != null)
                {
                    selectedCourseId = CourseView.Id;

                    var course = courseController.GetCourseById(selectedCourseId);
                    if (course != null)
                    {
                        name_txt.Text = course.Name;

                    }
                }
                else
                {
                    selectedCourseId = -1;
                }

            }
        }

        private void Delete_btn_Click(object sender, EventArgs e) // Deleting course
        {
            //if (selectedCourseId == -1)
            //{
            //    MessageBox.Show("Please select a course to delete");
            //    return;
            //}

            //var confirmatiion = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
            //if (confirmatiion == DialogResult.Yes)
            //{
            //    courseController.DeleteCourse(selectedCourseId);
            //    name_txt.Clear();   
            //    LoadCourses();
            //    MessageBox.Show("Course Deleted Successfully");
            //}
        }

        private void Update_btn_Click(object sender, EventArgs e) // updating Course
        {

            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name_txt.Text.Trim()))
            {
                MessageBox.Show("Please enter course name.");
                return;
            }
            var course = new Course
            {
                Id = selectedCourseId,
                Name = name_txt.Text,

            };
            courseController.UpdateCourse(course);
            name_txt.Clear() ;
            LoadCourses();
            MessageBox.Show("Course Updated Successfully!");

            

        }
    }
}
