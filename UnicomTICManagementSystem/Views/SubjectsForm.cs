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
    public partial class SubjectsForm : Form
    {
        private SubjectController subjectController = new SubjectController();
        private CourseController courseController = new CourseController();
        private int selectedSubjectId = -1;
        public SubjectsForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadCourses();
        }
        private void LoadSubjects() // Load data from Subjects table to DataGridView
        {
            Subjects_dgv.DataSource = null;
            Subjects_dgv.DataSource = subjectController.GetAllSubjects();

            Subjects_dgv.Columns["CourseID"].Visible = false;
            Subjects_dgv.ClearSelection();
        }
        private void LoadCourses() // Load courses on ComboBox
        {
            var courses = courseController.GetAllCourses();

            course_cbx.DataSource = courses;
            course_cbx.DisplayMember = "Name";
            course_cbx.ValueMember = "Id";
            course_cbx.SelectedIndex = -1;
        }
        private void ClearForm() 
        {
            name_txt.Clear();
            course_cbx.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e) // Deleting subject
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete");
                return;
            }

            var confirmatiion = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmatiion == DialogResult.Yes)
            {
                subjectController.DeleteSubject(selectedSubjectId);                            
                ClearForm();
                LoadSubjects();
                MessageBox.Show("Subject Deleted Successfully");
            }
        }
                
        private void course_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e) // Adding subject
        {          
            Subject subject = new Subject
            {
                Name = name_txt.Text.Trim(),
                CourseID = (int)course_cbx.SelectedValue
            };
            subjectController.AddSubject(subject);
            LoadSubjects();
            ClearForm();
            MessageBox.Show("Subject Added Successfully");
            
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subjects_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Subjects_dgv_SelectionChanged(object sender, EventArgs e)
        {

            if (Subjects_dgv.SelectedRows.Count > 0)
            {
                var row = Subjects_dgv.SelectedRows[0];
                var subjectView = row.DataBoundItem as Subject;


                if (subjectView != null)
                {
                    selectedSubjectId = subjectView.Id;

                    var subject = subjectController.GetSubjectById(selectedSubjectId);
                    if (subject != null)
                    {
                        name_txt.Text = subject.Name;
                        course_cbx.SelectedValue = subject.CourseID;
                    }
                }
            }
            else
            {

                selectedSubjectId = -1;
            }

        }

        private void Edit_btn_Click(object sender, EventArgs e) // Updating Subject
        {
            {
                if (selectedSubjectId == -1)
                {
                    MessageBox.Show("Please select a subject to update.");
                    return;
                }

                var subject = new Subject
                {
                    Id = selectedSubjectId,
                    Name = name_txt.Text,
                    CourseID = (int)course_cbx.SelectedValue

                };
                subjectController.UpdateSubject(subject);
                ClearForm();
                LoadSubjects();               
                MessageBox.Show("Subject Upadted Successfully!");

            }
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
