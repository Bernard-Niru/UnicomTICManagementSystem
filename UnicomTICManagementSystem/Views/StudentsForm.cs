using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class StudentsForm : Form
    {
        private StudentController studentController = new StudentController();
        private CourseController courseController = new CourseController();
        private UserController userController = new UserController();
        private UsersForm usersForm = new UsersForm();
        private int selectedStudentId = -1;
        public StudentsForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadCourses();
        }
        private void LoadStudents()
        {
            Student_dgv.DataSource = null;
            Student_dgv.DataSource = studentController.GetAllStudents();
            
            Student_dgv.Columns["CourseID"].Visible = false;
            Student_dgv.Columns["UserID"].Visible = false ;
            Student_dgv.ClearSelection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Student_dgv.SelectedRows.Count > 0) 
            {
                int id = Convert.ToInt32(Student_dgv.SelectedRows[0].Cells["Id"].Value);
                studentController.DeleteStudent(id);
                LoadStudents();
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadCourses() 
        {
            var courses = courseController.GetAllCourses();
            course_cbx.DataSource = courses;
            course_cbx.DisplayMember = "Name";
            course_cbx.ValueMember = "Id";
        }
      
        private void Add_btn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserName = name_txt.Text.Trim(),
                Password = "12345",
                Role = "Student"
            };
            userController.AddUser(user);
            usersForm.LoadUsers();

            //Getting User ID of the respective Student
            User getuserid =userController.GetUserId(user);
            Student student = new Student
            {
                Name = name_txt.Text.Trim(),
                Address = address_txt.Text.Trim(),
                CourseID = (int)course_cbx.SelectedValue,
                UserID = getuserid?.Id ?? 0
            };
            studentController.AddStudent(student);
            LoadStudents();
            
            name_txt.Clear();
            address_txt.Clear();
            MessageBox.Show("Student Added Successfully");
        }

        private void course_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Student_dgv_SelectionChanged(object sender, EventArgs e)
        {

            if (Student_dgv.SelectedRows.Count > 0)
            {
                var row = Student_dgv.SelectedRows[0];
                var studentView = row.DataBoundItem as Student;

                if (studentView != null)
                {
                    selectedStudentId = studentView.Id;

                    var student = studentController.GetStudentById(selectedStudentId);
                    if (student != null)
                    {
                        name_txt.Text = student.Name;
                        address_txt.Text = student.Address;
                        course_cbx.SelectedValue = student.CourseID;
                    }
                }
            }
            else
            {

                selectedStudentId = -1;
            }



        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (Student_dgv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Student_dgv.SelectedRows[0].Cells["Id"].Value);
                studentController.DeleteStudent(id);
                LoadStudents();
            }
        }

        private void Student_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            
        }


        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name_txt.Text) || string.IsNullOrWhiteSpace(address_txt.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            var student = new Student
            {
                Id = selectedStudentId,
                Name = name_txt.Text,
                Address = address_txt.Text,
                CourseID = (int)course_cbx.SelectedValue
                
            };
            studentController.UpdateStudent(student);
            LoadStudents();
            

            User username = new User
            {
                UserName = name_txt.Text,                          
            };
            User getuserid = userController.GetUserId(username);
            User user = new User
            {
                Id = getuserid.Id,
                UserName = name_txt.Text,
                Password = "12345",
                Role = "Student"

            };

            userController.UpdateUser(user);
            usersForm.LoadUsers();
            MessageBox.Show("Student Updated Successfully");

        }
    }
}
