using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;
using static System.Collections.Specialized.BitVector32;

namespace UnicomTICManagementSystem.Controllers
{
    internal class CourseController
    {
        //Getting Data From Courses Table ===========================================================
        public List<Course> GetAllCourses()
        {
            var courseList = new List<Course>();         

            using (var getDBconn = DBConnection.GetConnection()) 
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses",getDBconn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    courseList.Add(new Course
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    }); 
                }
            }
            return courseList;
        }
        //Adding Data To Courses Table ================================================================
        public void AddCourses(Course course)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Courses (Name) VALUES (@Name)", getDBconn);
                cmd.Parameters.AddWithValue("@Name", course.Name);
                cmd.ExecuteNonQuery();
            }
        }
    }
       
}
