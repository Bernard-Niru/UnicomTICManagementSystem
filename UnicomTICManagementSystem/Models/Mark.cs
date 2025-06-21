using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Models
{
    internal class Mark
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Username { get; set; }
        private int Marks;
        public int Score
        {
            get { return Marks; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    Marks = value;
                }
                else
                {
                    MessageBox.Show("Score must be between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
