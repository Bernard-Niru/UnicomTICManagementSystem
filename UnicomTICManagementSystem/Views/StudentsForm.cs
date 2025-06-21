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
        private void LoadStudents() // Load data from Students table to DataGridView
        {
            Student_dgv.DataSource = null;
            Student_dgv.DataSource = studentController.GetAllStudents();
            
            Student_dgv.Columns["CourseID"].Visible = false;
            Student_dgv.Columns["UserID"].Visible = false ;
            Student_dgv.ClearSelection();
        }
        private void LoadCourses() // Load course to ComboBox
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
            Username_txt.Clear();
            address_txt.Clear();
            course_cbx.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }     
        private void Add_btn_Click(object sender, EventArgs e) // Adding student to both Students & Users Table
        {
            string userName = Username_txt.Text.Trim();
            string name = name_txt.Text.Trim();
            User user = new User
            {
                Name = name,
                Username = userName,
                Password = "12345", 
                Role = "Student"
            };

            bool added = userController.AddUser(user);
            if (added)                                                      // check if username exists
            {
                User userId = userController.GetUserIDByUsername(userName); // Getting the UserID from Users table by Username

                Student student = new Student
                {
                    Name = name,
                    Username = userName,
                    Address = address_txt.Text.Trim(),
                    CourseID = (int)course_cbx.SelectedValue,
                    UserID = userId.Id
                };

                studentController.AddStudent(student);
                LoadStudents();
                ClearForm();
                MessageBox.Show("Student Added Successfully");
            }
        }

        private void course_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void Student_dgv_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e) // Deleting Student from Students & Users Table
        {
            string username = Username_txt.Text.Trim();
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete");
                return;
            }

            var confirmatiion = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmatiion == DialogResult.Yes)
            {
                var userID = studentController.GetUserID(selectedStudentId);     // Getting the UserID of the Deleted Student 

                studentController.DeleteStudent(selectedStudentId);

                userController.DeleteUser(userID.UserID);
              
                LoadStudents();
                MessageBox.Show("Student Deleted Successfully");

                
                ClearForm(); //'Object reference not set to an instance of an object userID was null.


            }
        }

        private void Student_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            
        }
        private void Update_btn_Click(object sender, EventArgs e) // Updating student from both Students & Users table 
        {
            string newName = name_txt.Text.Trim();
            string newAddress = address_txt.Text.Trim();

            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newAddress))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            var student = new Student
            {
                Id = selectedStudentId,
                Name = newName,
                Address = newAddress,
                CourseID = (int)course_cbx.SelectedValue

            };
            studentController.UpdateStudent(student);
            
            
            MessageBox.Show("Student Updated Successfully");
            var userID= studentController.GetUserID(selectedStudentId);
           
            var user = new User
            {
                Id = userID.UserID,
                Name = newName,
            };
            userController.UpdateUser(user);

            usersForm.LoadUsers();
            LoadStudents();
            ClearForm();
        }

        private void address_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_dgv_SelectionChanged_1(object sender, EventArgs e)
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
    }
}
