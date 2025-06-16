using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController
    {
        //Getting Data From Students Table ====================================================
        public List<Student> GetAllStudents()
{
    var StudentList = new List<Student>();

    using (var getDBconn = DBConnection.GetConnection())
    {
        var cmd = new SQLiteCommand(@"
            SELECT s.Id, s.Name, s.Address, s.CourseID, s.UserID, Courses.Name AS CourseName
            FROM Students s
            LEFT JOIN Courses ON s.CourseID = Courses.Id
            LEFT JOIN Users ON s.UserID = Users.Id", getDBconn);

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
                CourseName = reader.IsDBNull(5) ? null : reader.GetString(5),
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
                var cmd = new SQLiteCommand("UPDATE Students SET Name = @name, Address = @address , CourseID = @courseId WHERE Id = @id", getDBconn);
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
                            CourseID = reader.GetInt32(3)
                        };
                    }
                }
            }

            return null;
        }




    }
}
