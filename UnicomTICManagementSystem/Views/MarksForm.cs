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
    public partial class MarksForm : Form
    {
        private MarksController marksController = new MarksController();
        private CourseController courseController = new CourseController();
        private SubjectController subjectController = new SubjectController();
        private ExamController examController = new ExamController();
        private StudentController studentController = new StudentController();
        private UserController userController = new UserController();   
        private int selectedMarksId = -1;
        public MarksForm()
        {
            InitializeComponent();
            LoadMarks();
            LoadCourses();
        }
        private void LoadMarks() // Load data from Marks table to DataGridView
        {
            if (Login.CurrentRole == "Student")                                  // loading the marks of the student who logged in
            {
                Marks_dgv.DataSource = null;
                Marks_dgv.DataSource = marksController.GetMarksByUsername(Login.CurrentUserName);
                Marks_dgv.Columns["CourseID"].Visible = false;
                Marks_dgv.Columns["SubjectID"].Visible = false;
                Marks_dgv.Columns["StudentID"].Visible = false;
                Marks_dgv.Columns["UserID"].Visible = false;
                Marks_dgv.Columns["ExamID"].Visible = false;
                Marks_dgv.ClearSelection();
            }
            else
            {
                Marks_dgv.DataSource = null;
                Marks_dgv.DataSource = marksController.GetAllMarks();
                Marks_dgv.Columns["CourseID"].Visible = false;
                Marks_dgv.Columns["SubjectID"].Visible = false;
                Marks_dgv.Columns["StudentID"].Visible = false;
                Marks_dgv.Columns["UserID"].Visible = false;
                Marks_dgv.Columns["ExamID"].Visible = false;
                Marks_dgv.ClearSelection();
            }
        }
        private void LoadCourses() // Load course to ComboBox
        {
            var courses = courseController.GetAllCourses();
            Courses_cbx.DataSource = courses;
            Courses_cbx.DisplayMember = "Name";
            Courses_cbx.ValueMember = "Id";
            
        }
        private void ClearForm()
        {
            //Courses_cbx.SelectedIndex = -1;
            Subjects_cbx.SelectedIndex = -1;
            Exams_cbx.SelectedIndex = -1;
            Name_txt.Clear();
            Marks_txt.Clear();
            Username_cbx.Visible = false;
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
            if (string.IsNullOrWhiteSpace(Name_txt.Text.Trim()))
            {
                MessageBox.Show("Please enter student's name.");
                return false;
            }
            if (Username_cbx.SelectedIndex == -1 || Username_cbx.SelectedValue == null)
            {
                MessageBox.Show("Please select student's username.");
                return false;
            }
            if (Exams_cbx.SelectedIndex == -1 || Exams_cbx.SelectedValue == null)
            {
                MessageBox.Show("Please select an exam.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Marks_txt.Text.Trim()))
            {
                MessageBox.Show("Please enter Marks.");
                return false;
            }
            return true;
        }

        private void Marks_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Marks_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_txt_TextChanged(object sender, EventArgs e)
        {                     
            string name = Name_txt.Text.Trim();
            int courseid = (int)Courses_cbx.SelectedValue;

            List<Student> studentList = studentController.GetStudentByCourseID(courseid);
            var UserIDs = new List<int>();

            foreach (var student in studentList)
            {
                if (string.Equals(student.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    UserIDs.Add(student.UserID);
                    

                    if (UserIDs.Count == 0)
                    {
                        label8.Visible = true;
                        Add_btn.Visible = false;
                    }
                    else
                    {
                        var usernames = userController.GetUsernamesByIds(UserIDs);
                        Username_cbx.Visible = true;
                        label9.Visible = true;
                        label8.Visible = false;
                        Add_btn.Visible = true;
                        label7.Visible = true;

                        Username_cbx.DataSource = null;
                        Username_cbx.DataSource = usernames;
                        Username_cbx.DisplayMember = "Username";
                        Username_cbx.ValueMember = "Id";
                        Username_cbx.SelectedIndex = -1;
                    }
                }
                else 
                {
                    label8.Visible = true;
                    Add_btn.Visible = false;
                }
            }
                              
        }

        private void MarksForm_Load(object sender, EventArgs e)
        {
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            Username_cbx.Visible = false;

            if (Login.CurrentRole == "Student") // Hiding buttons According to their role
            {
                Courses_cbx.Visible = false;
                Subjects_cbx.Visible = false;
                Exams_cbx.Visible = false;
                Name_txt.Visible = false;
                Marks_txt.Visible = false;
                Add_btn.Visible = false;
                Update_btn.Visible = false;
                Delete_btn.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

            }
        }

        private void Courses_cbx_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Subjects_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Subjects_cbx.SelectedValue == null) return;

            if (int.TryParse(Subjects_cbx.SelectedValue.ToString(), out int selectedSubjectId))
            {
                var exams = examController.GetExamBySID(selectedSubjectId);
                Exams_cbx.DataSource = exams;
                Exams_cbx.DisplayMember = "Name";
                Exams_cbx.ValueMember = "Id";
                Exams_cbx.SelectedIndex = -1;
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

            if (selectedMarksId == -1)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            if (ShowMessage())
            {
                int userid = (int)Username_cbx.SelectedValue;
                var studentid = studentController.GetIdByUserID(userid);

                var mark = new Mark
                {
                    Id = selectedMarksId,
                    CourseId = (int)Courses_cbx.SelectedValue,
                    SubjectId = (int)Subjects_cbx.SelectedValue,
                    ExamId = (int)Exams_cbx.SelectedValue,
                    StudentId = studentid.Id,
                    UserId = userid,
                    Score = int.Parse(Marks_txt.Text.Trim())

                };
                marksController.UpdateMarks(mark);
                LoadMarks();
                MessageBox.Show("Row updated successfully!");
                ClearForm();
                
            }
            
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ShowMessage())
            {
                if (!int.TryParse(Marks_txt.Text.Trim(), out int score) || score < 0 || score > 100)
                {
                    MessageBox.Show("Marks must be between 0 and 100.", "Invalid Marks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int userid = (int)Username_cbx.SelectedValue;
                var studentid = studentController.GetIdByUserID(userid);

                Mark mark = new Mark
                {
                    CourseId = (int)Courses_cbx.SelectedValue,
                    SubjectId = (int)Subjects_cbx.SelectedValue,
                    ExamId = (int)Exams_cbx.SelectedValue,
                    StudentId = studentid.Id,
                    UserId = userid,
                    Score = int.Parse(Marks_txt.Text.Trim())
                };

                marksController.AddMarks(mark);
                LoadMarks();
                MessageBox.Show("Marks Added Successfully");
               // ClearForm();
            }
           
        }

        private void Marks_dgv_SelectionChanged(object sender, EventArgs e)
        {
            label9.Visible = false;

            if (Marks_dgv.SelectedRows.Count > 0)
            {
                var row = Marks_dgv.SelectedRows[0];
                var markView = row.DataBoundItem as Mark;

                if (markView != null)
                {
                    selectedMarksId = markView.Id;

                    var mark = marksController.GetMarksById(selectedMarksId);
                    if (mark != null)
                    {
                        Courses_cbx.SelectedValue = mark.CourseId;
                        Subjects_cbx.SelectedValue = mark.SubjectId;
                        Username_cbx.SelectedValue = mark.UserId;
                        Exams_cbx.SelectedValue = mark.ExamId; 
                        Marks_txt.Text = Convert.ToString(mark.Score);
                        Name_txt.Text = mark.StudentName;
                    }
                }
            }
            else
            {

                selectedMarksId = -1;
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (selectedMarksId == -1)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }

            var confirmatiion = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmatiion == DialogResult.Yes)
            {
                marksController.DeleteMarks(selectedMarksId);
                LoadMarks();
                MessageBox.Show("Row Deleted Successfully");
                ClearForm();
            }
        }

        private void Exams_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
