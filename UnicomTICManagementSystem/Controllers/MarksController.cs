using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class MarksController
    {
        //Getting Data From Marks Table ====================================================
        public List<Mark> GetAllMarks()
        {
            var MarkList = new List<Mark>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT m.Id, m.CourseID, m.SubjectID, m.StudentID,m.UserID, m.ExamID ,m.Score,
                    Courses.Name AS CourseName, Subjects.Name AS SubjectName ,Exams.Name AS ExamName,
                    Users.Username AS username, Students.Name AS StudentName
                    FROM Marks m
                    LEFT JOIN Courses ON m.CourseID = Courses.Id
                    LEFT JOIN Subjects ON m.SubjectID = Subjects.Id
                    LEFT JOIN Exams ON m.ExamID = Exams.Id
                    LEFT JOIN Students ON m.StudentID = Students.Id
                    LEFT JOIN Users ON m.UserID = Users.Id", getDBconn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MarkList.Add(new Mark
                        {
                            Id = reader.GetInt32(0),
                            CourseId = reader.GetInt32(1),
                            SubjectId = reader.GetInt32(2),
                            StudentId = reader.GetInt32(3),
                            UserId = reader.GetInt32(4),
                            ExamId = reader.GetInt32(5),
                            Score = reader.GetInt32(6),
                            CourseName = reader.GetString(7),
                            SubjectName = reader.GetString(8),
                            ExamName =  reader.GetString(9),
                            Username = reader.GetString(10),
                            StudentName = reader.GetString(11),
                        });

                    }
                }
            }
            return MarkList;
        }
        public List<Mark> GetMarksByUsername(string username)
        {
            var MarkList = new List<Mark>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT m.Id, m.CourseID, m.SubjectID, m.StudentID, m.UserID, m.ExamID, m.Score,
            Courses.Name AS CourseName, Subjects.Name AS SubjectName, Exams.Name AS ExamName,
            Users.Username AS username, Students.Name AS StudentName
            FROM Marks m
            LEFT JOIN Courses ON m.CourseID = Courses.Id
            LEFT JOIN Subjects ON m.SubjectID = Subjects.Id
            LEFT JOIN Exams ON m.ExamID = Exams.Id
            LEFT JOIN Students ON m.StudentID = Students.Id
            LEFT JOIN Users ON m.UserID = Users.Id
            WHERE Users.Username = @username", getDBconn);

                cmd.Parameters.AddWithValue("@username", username);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MarkList.Add(new Mark
                        {
                            Id = reader.GetInt32(0),
                            CourseId = reader.GetInt32(1),
                            SubjectId = reader.GetInt32(2),
                            StudentId = reader.GetInt32(3),
                            UserId = reader.GetInt32(4),
                            ExamId = reader.GetInt32(5),
                            Score = reader.GetInt32(6),
                            CourseName = reader.GetString(7),
                            SubjectName = reader.GetString(8),
                            ExamName = reader.GetString(9),
                            Username = reader.GetString(10),
                            StudentName = reader.GetString(11),
                        });
                    }
                }
            }
            return MarkList;
        }

        //Adding Data To Marks Table =====================================================================
        public void AddMarks(Mark mark)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"INSERT INTO Marks (CourseID, SubjectID, StudentID, UserID, ExamID, Score) 
                                     VALUES (@courseid, @subjectid, @studentid, @userid, @examid, @score)", getDBconn);
                cmd.Parameters.AddWithValue("@courseid", mark.CourseId);
                cmd.Parameters.AddWithValue("@subjectid", mark.SubjectId);
                cmd.Parameters.AddWithValue("@studentid", mark.StudentId);
                cmd.Parameters.AddWithValue("userid",mark.UserId);
                cmd.Parameters.AddWithValue("@examid", mark.ExamId);
                cmd.Parameters.AddWithValue("@score", mark.Score);

                cmd.ExecuteNonQuery();
            }
        }
        //Getting Data by ID ==============================================================================
        public Mark GetMarksById(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@" SELECT m.Id, m.CourseID, m.SubjectID, m.StudentID, m.UserID, m.ExamID, m.Score,
                                            s.Name AS StudentName
                                            FROM Marks m
                                            LEFT JOIN Students s ON m.StudentID = s.Id
                                            WHERE m.Id = @Id", getDBconn);

                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Mark
                        {
                            Id = reader.GetInt32(0),
                            CourseId = reader.GetInt32(1),
                            SubjectId = reader.GetInt32(2),
                            StudentId = reader.GetInt32(3),
                            UserId = reader.GetInt32(4),
                            ExamId = reader.GetInt32(5),
                            Score = reader.GetInt32(6),
                            StudentName = reader.GetString(7)
                        };
                    }
                }
            }

            return null;
        }

        //Updating Data On Marks Table ===========================================================
        public void UpdateMarks(Mark mark)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"UPDATE Marks SET CourseID = @courseid , SubjectID = @subjectid, StudentID = @studentid,
                                           UserID = @userid, ExamID = @examid, Score = @score WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@courseid", mark.CourseId);
                cmd.Parameters.AddWithValue("@subjectid", mark.SubjectId);
                cmd.Parameters.AddWithValue("@studentid", mark.StudentId);
                cmd.Parameters.AddWithValue("@userid",mark.UserId);
                cmd.Parameters.AddWithValue("@examid", mark.ExamId);
                cmd.Parameters.AddWithValue("@score", mark.Score);
                cmd.Parameters.AddWithValue("@id", mark.Id);

                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Marks Table =========================================================
        public void DeleteMarks(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Marks Table By ExamID =========================================================
        public void DeleteMarksByExamId(int examid)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE ExamID = @examid", getDBconn);
                cmd.Parameters.AddWithValue("@examid", examid);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Marks Table By SubjectID =========================================================
        public void DeleteMarksBySubjectId(int subjectid)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE SubjectID = @subjectid", getDBconn);
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Marks Table By StudentID =========================================================
        public void DeleteMarksByStudentId(int studentid)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE StudentID = @studentid", getDBconn);
                cmd.Parameters.AddWithValue("@studentid", studentid);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Marks Table By UserID =========================================================
        public void DeleteMarksByUserId(int userid)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE UserID = @userid", getDBconn);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
