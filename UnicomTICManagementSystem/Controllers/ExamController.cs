using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class ExamController
    {
        //Getting Data From Exams Table ====================================================
        public List<Exam> GetAllExams()
        {
            var ExamList = new List<Exam>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT e.Id, e.Name, e.CourseID, e.SubjectID, e.Date, e.Time, e.RoomID,
                    Courses.Name AS CourseName, Subjects.Name AS SubjectName, Rooms.Name AS RoomName
                    FROM Exams e
                    LEFT JOIN Courses ON e.CourseID = Courses.Id
                    LEFT JOIN Subjects ON e.SubjectID = Subjects.Id
                    LEFT JOIN Rooms ON e.RoomID = Rooms.Id", getDBconn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ExamList.Add(new Exam
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            CourseId = reader.GetInt32(2),
                            SubjectId = reader.GetInt32(3),
                            Date = reader.GetString(4),
                            Time = reader.GetString(5),
                            RoomId = reader.GetInt32(6),
                            CourseName = reader.IsDBNull(7) ? null : reader.GetString(7),
                            SubjectName = reader.IsDBNull(8) ? null : reader.GetString(8),
                            RoomName = reader.IsDBNull(9) ? null : reader.GetString(9),
                        });
                    }
                }
            }
            return ExamList;
        }

        //Adding Data To Exams Table =====================================================================
        public void AddExam(Exam exam)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"INSERT INTO Exams (Name,CourseID, SubjectID, Date, Time, RoomID) 
                                     VALUES (@name, @courseid, @subjectid, @date, @time, @roomid)", getDBconn);
                cmd.Parameters.AddWithValue("@name", exam.Name);
                cmd.Parameters.AddWithValue("@courseid", exam.CourseId);
                cmd.Parameters.AddWithValue("@subjectid", exam.SubjectId);
                cmd.Parameters.AddWithValue("@date", exam.Date);
                cmd.Parameters.AddWithValue("@time", exam.Time);
                cmd.Parameters.AddWithValue("@roomid", exam.RoomId);

                cmd.ExecuteNonQuery();
            }
        }
        //Getting Data by ID ==============================================================================
        public Exam GetExamById(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Exams WHERE Id = @Id", getDBconn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Exam
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            CourseId = reader.GetInt32(2),
                            SubjectId = reader.GetInt32(3),
                            Date = reader.GetString(4),
                            Time = reader.GetString(5),
                            RoomId = reader.GetInt32(6)
                        };
                    }
                }
            }
            return null;
        }
        //Updating Data On Exams Table ===========================================================
        public void UpdateExam(Exam exam)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"UPDATE Exams SET Name = @name ,CourseID = @courseid , SubjectID = @subjectid , 
                                            Date = @date , Time = @time , RoomID = @roomid WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@name", exam.Name);
                cmd.Parameters.AddWithValue("@courseid", exam.CourseId);
                cmd.Parameters.AddWithValue("@subjectid", exam.SubjectId);
                cmd.Parameters.AddWithValue("@date", exam.Date);
                cmd.Parameters.AddWithValue("@time", exam.Time);
                cmd.Parameters.AddWithValue("@roomid", exam.RoomId);
                cmd.Parameters.AddWithValue("@id", exam.Id);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Exams Table =========================================================
        public void DeleteExam(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Exams WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
