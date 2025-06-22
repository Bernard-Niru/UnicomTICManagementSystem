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
                    SELECT m.Id, m.CourseID, m.SubjectID, m.StudentID, m.ExamID ,m.Score,
                    Courses.Name AS CourseName, Subjects.Name AS SubjectName ,Exams.Name AS ExamName,
                    Students.Username AS username, Students.Name AS StudentName
                    FROM Marks m
                    LEFT JOIN Courses ON m.CourseID = Courses.Id
                    LEFT JOIN Subjects ON m.SubjectID = Subjects.Id
                    LEFT JOIN Exams ON m.ExamID = Exams.Id
                    LEFT JOIN Students ON m.StudentID = Students.Id", getDBconn);

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
                            ExamId = reader.GetInt32(4),
                            Score = reader.GetInt32(5),
                            CourseName = reader.IsDBNull(6) ? null : reader.GetString(6),
                            SubjectName = reader.IsDBNull(7) ? null : reader.GetString(7),
                            ExamName = reader.IsDBNull(8) ? null : reader.GetString(8),
                            Username = reader.IsDBNull(9) ? null : reader.GetString(9),
                            StudentName = reader.IsDBNull(10) ? null : reader.GetString(10),
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
                var cmd = new SQLiteCommand(@"INSERT INTO Marks (CourseID, SubjectID, StudentID, ExamID, Score) 
                                     VALUES (@courseid, @subjectid, @studentid, @examid, @score)", getDBconn);
                cmd.Parameters.AddWithValue("@courseid", mark.CourseId);
                cmd.Parameters.AddWithValue("@subjectid", mark.SubjectId);
                cmd.Parameters.AddWithValue("@studentid", mark.StudentId);
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
                var cmd = new SQLiteCommand(@" SELECT m.Id, m.CourseID, m.SubjectID, m.StudentID, m.ExamID, m.Score,
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
                            ExamId = reader.GetInt32(4),
                            Score = reader.GetInt32(5),
                            StudentName = reader.IsDBNull(6) ? null : reader.GetString(6)
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
                                            ExamID = @examid, Score = @score WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@courseid", mark.CourseId);
                cmd.Parameters.AddWithValue("@subjectid", mark.SubjectId);
                cmd.Parameters.AddWithValue("@studentid", mark.StudentId);
                cmd.Parameters.AddWithValue("@examid", mark.ExamId);
                cmd.Parameters.AddWithValue("@score", mark.Score);
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
    }
}
