﻿using System;
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
    public partial class ExamsForm : Form
    {
        private ExamController examController = new ExamController();
        private CourseController courseController = new CourseController();
        private SubjectController subjectController = new SubjectController();
        private RoomController roomController = new RoomController();
        private MarksController MarksController = new MarksController();
        private int selectedExamId = -1;
        public ExamsForm()
        {
            InitializeComponent();
            LoadExams();
            LoadCourses();
            LoadRooms();
        }
        private void LoadExams() // Load data from Students table to DataGridView
        {
            if (Login.CurrentRole == "Student")
            {
                Exams_dgv.DataSource = null;
                Exams_dgv.DataSource = examController.GetExamsByCourseName(Login.CurrentCourse);
                Exams_dgv.Columns["CourseID"].Visible = false;
                Exams_dgv.Columns["SubjectID"].Visible = false;
                Exams_dgv.Columns["RoomID"].Visible = false;
                Exams_dgv.ClearSelection();
            }
            else
            {
                Exams_dgv.DataSource = null;
                Exams_dgv.DataSource = examController.GetAllExams();
                Exams_dgv.Columns["CourseID"].Visible = false;
                Exams_dgv.Columns["SubjectID"].Visible = false;
                Exams_dgv.Columns["RoomID"].Visible = false;
                Exams_dgv.ClearSelection();
            }
        }
        private void LoadCourses() // Load course to ComboBox
        {
            var courses = courseController.GetAllCourses();
            Courses_cbx.DataSource = courses;
            Courses_cbx.DisplayMember = "Name";
            Courses_cbx.ValueMember = "Id";
            Courses_cbx.SelectedIndex = -1;
        }
        private void LoadRooms()
        {
            var rooms = roomController.GetAllRooms();
            Rooms_cbx.DataSource = rooms;
            Rooms_cbx.DisplayMember = "Name";
            Rooms_cbx.ValueMember = "Id";
            Rooms_cbx.SelectedIndex = -1;
        }
        private void ClearForm()
        {
            Name_txt.Clear();
            Courses_cbx.SelectedIndex = -1;
            Subjects_cbx.SelectedIndex =- 1;
            Rooms_cbx.SelectedIndex =- 1;
        }
        private bool ShowMessage() // Return true if all fields are valid
        {
            if (Courses_cbx.SelectedIndex == -1 || Courses_cbx.SelectedValue == null)
            {
                MessageBox.Show("Please select a course.");
                return false;
            }          
            if (Subjects_cbx.SelectedIndex == -1 || Subjects_cbx.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject.");
                return false;
            }
            if (Rooms_cbx.SelectedIndex == -1 || Rooms_cbx.SelectedValue == null)
            {
                MessageBox.Show("Please select a room.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Name_txt.Text.Trim()))
            {
                MessageBox.Show("Please enter Exam Name.");
                return false;
            }

            return true; 
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Courses_cbx.SelectedValue == null) return;

            if (int.TryParse(Courses_cbx.SelectedValue.ToString(), out int selectedCourseId))
            {
                var subjects = subjectController.GetSubjectByCoID(selectedCourseId);
                Subjects_cbx.DataSource = subjects;
                Subjects_cbx.DisplayMember = "Name";
                Subjects_cbx.ValueMember = "Id";
                Subjects_cbx.SelectedIndex = -1;
            }
        }

        private void ExamsForm_Load(object sender, EventArgs e)
        {
            if (Login.CurrentRole == "Student")
            {
                Courses_cbx.Visible = false;
                Subjects_cbx.Visible = false;
                Rooms_cbx.Visible = false;
                Date_dtp.Visible = false;
                Time_dtp.Visible = false;
                Name_txt.Visible = false;
                Add_btn.Visible = false;
                Update_btn.Visible = false;
                Delete_btn.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
              

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete");
                return;
            }

            var confirmatiion = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmatiion == DialogResult.Yes)
            {
                examController.DeleteExam(selectedExamId);
                MarksController.DeleteMarksByExamId(selectedExamId);
                LoadExams();
                MessageBox.Show("Exam Deleted Successfully");
                ClearForm();
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            if (ShowMessage()) 
            {
                var exam = new Exam
                {
                    Name = Name_txt.Text,
                    Id = selectedExamId,
                    CourseId = (int)Courses_cbx.SelectedValue,
                    SubjectId = (int)Subjects_cbx.SelectedValue,
                    Date = Date_dtp.Text,
                    Time = Time_dtp.Text,
                    RoomId = (int)Rooms_cbx.SelectedValue

                };
                examController.UpdateExam(exam);
                LoadExams();
                MessageBox.Show("Exam updated successfully!");
                ClearForm();
            }

            
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
           if (ShowMessage()) 
           {
                Exam exam = new Exam
                {
                    Name = Name_txt.Text.Trim(),
                    CourseId = (int)Courses_cbx.SelectedValue,
                    SubjectId = (int)Subjects_cbx.SelectedValue,
                    Date = Date_dtp.Text,
                    Time = Time_dtp.Text,
                    RoomId = (int)Rooms_cbx.SelectedValue,
                };

                examController.AddExam(exam);
                LoadExams();
                MessageBox.Show("Exam Added Successfully");
                ClearForm();
            }           
        }
        private void Exams_dgv_SelectionChanged(object sender, EventArgs e)
        {

            if (Exams_dgv.SelectedRows.Count > 0)
            {
                var row = Exams_dgv.SelectedRows[0];
                var examView = row.DataBoundItem as Exam;

                if (examView != null)
                {
                    selectedExamId = examView.Id;

                    var exam = examController.GetExamById(selectedExamId);
                    if (exam != null)
                    {
                        Name_txt.Text = exam.Name;
                        Courses_cbx.SelectedValue = exam.CourseId;
                        Subjects_cbx.SelectedValue = exam.SubjectId;
                        Rooms_cbx.SelectedValue = exam.RoomId;
                        Date_dtp.Text = exam.Date;
                        Time_dtp.Text = exam.Time;
                    }
                }
            }
            else
            {

                selectedExamId = -1;
            }
        }
    }
}
