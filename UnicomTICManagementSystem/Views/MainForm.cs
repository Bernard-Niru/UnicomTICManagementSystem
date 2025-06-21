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

        public void LoadForm(object formObj)
        {
            if (this.Mainpanel.Controls.Count > 0)
            {
                this.Mainpanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(form);
            this.Mainpanel.Tag = form;
            form.Show();
        }
        private void Students_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentsForm());
           
        }

        private void Courses_btn_Click(object sender, EventArgs e)
        {
           LoadForm(new CoursesForm());
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {               
            LoadForm( new UsersForm());
                          
        }

        private void MainForm_Load(object sender, EventArgs e) // Hiding buttons and others accornding to role 
        {          
            if (Login.CurrentRole == "Student" || Login.CurrentRole == "Staff" || Login.CurrentRole == "Lecturer")
            {
                Users_btn.Visible = false;
                Courses_btn.Visible = false;
                Subjects_btn.Visible = false;
                Students_btn.Visible = false ;
                Rooms_btn.Visible = false ;

            }           
        }

        private void Subjects_btn_Click(object sender, EventArgs e)
        {
            LoadForm( new SubjectsForm());

        }

        private void Rooms_btn_Click(object sender, EventArgs e)
        {
            LoadForm( new RoomsForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_btn_Click(object sender, EventArgs e)
        {
            LoadForm( new TimeTableForm());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void Sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exams_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamsForm());
        }

        private void Marks_btn_Click(object sender, EventArgs e)
        {
            LoadForm( new MarksForm());
        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new ProfileForm());
        }
    }
}
