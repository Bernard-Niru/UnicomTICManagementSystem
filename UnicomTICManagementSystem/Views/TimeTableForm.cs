using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTICManagementSystem.Views
{
    public partial class TimeTableForm : Form
    {
        private TimeTableController timeTableController = new TimeTableController();
        private CourseController courseController = new CourseController();
        private SubjectController subjectController = new SubjectController();
        private RoomController roomController = new RoomController();
        private int selectedTimetableId = -1;

        public TimeTableForm()
        {
            InitializeComponent();
            LoadTimetable();
            LoadCourses();
            LoadRooms();
        }
        private void LoadTimetable() // Load data from Students table to DataGridView
        {
            Timetable_dgv.DataSource = null;
            Timetable_dgv.DataSource = timeTableController.GetTimetable();
            Timetable_dgv.Columns["CourseID"].Visible = false;
            Timetable_dgv.Columns["SubjectID"].Visible = false;
            Timetable_dgv.Columns["RoomID"].Visible = false;
            Timetable_dgv.ClearSelection();
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void TimeTableForm_Load(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e) //Updating 
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var timetable = new Timetable
            {
                Id = selectedTimetableId,
                CourseId = (int)Courses_cbx.SelectedValue,
                SubjectId = (int)Subjects_cbx.SelectedValue,
                Date = Date_dtp.Text,
                Time = Time_dtp.Text,
                RoomId = (int)Rooms_cbx.SelectedValue

            };
            timeTableController.UpdateTimetable(timetable);
            LoadTimetable();
            MessageBox.Show("Timetable updated successfully!");

        }
        private void button4_Click(object sender, EventArgs e) // Add
        {
            Timetable timetable = new Timetable
            {
                CourseId = (int)Courses_cbx.SelectedValue,
                SubjectId = (int)Subjects_cbx.SelectedValue,
                Date = Date_dtp.Text,
                Time = Time_dtp.Text,
                RoomId = (int)Rooms_cbx.SelectedValue,
            };

            timeTableController.AddtoTimetable(timetable);
            LoadTimetable();
            MessageBox.Show(" Added Successfully");
        }

        private void Timetable_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Courses_cbx_SelectedIndexChanged(object sender, EventArgs e) // To Show Subjects belonging to selected course only
        {
            if (Courses_cbx.SelectedValue == null) return;

            if (int.TryParse(Courses_cbx.SelectedValue.ToString(), out int selectedCourseId))
            {
                var subjects = subjectController.GetSubjectByCoID(selectedCourseId);
                Subjects_cbx.DataSource = subjects;
                Subjects_cbx.DisplayMember = "Name";
                Subjects_cbx.ValueMember = "Id";
            }
        }

        private void Timetable_dgv_SelectionChanged(object sender, EventArgs e)
        {

            if (Timetable_dgv.SelectedRows.Count > 0)
            {
                var row = Timetable_dgv.SelectedRows[0];
                var TimetableView = row.DataBoundItem as Timetable;

                if (TimetableView != null)
                {
                    selectedTimetableId = TimetableView.Id;

                    var Timetable = timeTableController.GetTimetableById(selectedTimetableId);
                    if (Timetable != null)
                    {
                        Courses_cbx.SelectedValue = Timetable.CourseId;
                        Subjects_cbx.SelectedValue = Timetable.SubjectId;
                        Rooms_cbx.SelectedValue = Timetable.RoomId;
                        Date_dtp.Text = Timetable.Date;
                        Time_dtp.Text = Timetable.Time;
                    }
                }
            }
            else
            {

                selectedTimetableId = -1;
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Delete_btn_Click(object sender, EventArgs e) // Delete
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }

            var confirmatiion = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmatiion == DialogResult.Yes)
            {
                timeTableController.DeleteTimetable(selectedTimetableId);
                LoadTimetable();
                MessageBox.Show("Row Deleted Successfully");
            }
        }
    }
}
