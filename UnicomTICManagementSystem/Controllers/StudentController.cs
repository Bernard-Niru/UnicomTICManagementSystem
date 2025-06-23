using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController
    {
        //Getting Data From Students Table =================================================================================================
        public List<Student> GetAllStudents()
        {
            var StudentList = new List<Student>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT s.Id, s.Name, s.Address, s.CourseID, s.UserID, Courses.Name AS CourseName,Users.Username AS Username
                    FROM Students s
                    LEFT JOIN Users ON s.UserID = Users.Id
                    LEFT JOIN Courses ON s.CourseID = Courses.Id", getDBconn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    StudentList.Add(new Student
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),                     
                        Address = reader.GetString(2),
                        CourseID = reader.GetInt32(3),
                        UserID = reader.GetInt32(4),                      
                        CourseName = reader.GetString(5),
                        Username = reader.GetString(6),
                    });
                }
            }
            return StudentList;
        }

        //Adding Data To Students Table ============================================================
        public void AddStudent(Student student)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"INSERT INTO Students (Name,Address,CourseID,UserID) 
                                            VALUES (@Name,@Address,@CourseID,@UserID)", getDBconn);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
                cmd.Parameters.AddWithValue("@UserID", student.UserID);
                cmd.ExecuteNonQuery();

            }
        }
        //Updating Data On Students Table ===========================================================
        public void UpdateStudent(Student student)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Students SET Name = @name , Address = @address , CourseID = @courseId WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@courseId", student.CourseID);
                cmd.Parameters.AddWithValue("@id",student.Id);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Students Table =========================================================
        public void DeleteStudent(int id) 
        {
            using (var getDBconn = DBConnection.GetConnection()) 
            {
                var cmd = new SQLiteCommand("DELETE FROM Students WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public Student GetStudentById(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Students WHERE Id = @Id", getDBconn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            CourseID = reader.GetInt32(3),
                            UserID = reader.GetInt32(4)
                        };
                    }
                }
            }

            return null;
        }
        public Student GetUserID(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT UserID FROM Students WHERE Id = @Id", getDBconn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            UserID = reader.GetInt32(0)
                        };                      
                    }                   
                }
            }
            return null;
        }
        public Student GetIdByUserID(int userid)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT Id FROM Students WHERE UserID = @userid", getDBconn);
                cmd.Parameters.AddWithValue("@userid", userid);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            Id = reader.GetInt32(0)
                        };
                    }
                }
            }
            return null;
        }

        public void DeleteStudentByUserID(int userid)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Students WHERE UserID = @userid", getDBconn);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateStudentByUserID(Student student) 
        {
            using (var getDBconn = DBConnection.GetConnection()) 
            {
                var cmd = new SQLiteCommand("UPDATE Students SET Name = @name  WHERE UserID = @userid", getDBconn);
                cmd.Parameters.AddWithValue("@name",student.Name);
                cmd.Parameters.AddWithValue("@userid",student.UserID);
                cmd.ExecuteNonQuery();
            }

        }
        
        public Student GetCIDByUserID(int userid) 
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT CourseID FROM Students WHERE UserID = @userid", getDBconn);
                cmd.Parameters.AddWithValue("@userid", userid);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            CourseID = reader.GetInt32(0)
                        };
                    }
                }
            }
            return null;
        }
        public List<Student> GetStudentByCourseID(int courseid)
        {
            var studentList = new List<Student>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT Name, UserID FROM Students WHERE CourseID = @courseid", getDBconn);
                cmd.Parameters.AddWithValue("@courseid", courseid);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studentList.Add(new Student
                    {
                        Name = reader.IsDBNull(0) ? null : reader.GetString(0), // Name is at index 0
                        UserID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1)  // UserID is at index 1
                    });
                }
            }

            return studentList;
        }



    }
}
