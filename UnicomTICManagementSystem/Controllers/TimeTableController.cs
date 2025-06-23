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
    internal class TimeTableController
    {
        //Getting Data From Timetables Table ====================================================
        public List<Timetable> GetTimetable()
        {
            var TimetableList = new List<Timetable>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT t.Id, t.CourseID, t.SubjectID, t.Date, t.Time, t.RoomID,
                    Courses.Name AS CourseName, Subjects.Name AS SubjectName, Rooms.Name AS RoomName
                    FROM Timetables t
                    LEFT JOIN Courses ON t.CourseID = Courses.Id
                    LEFT JOIN Subjects ON t.SubjectID = Subjects.Id
                    LEFT JOIN Rooms ON t.RoomID = Rooms.Id", getDBconn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TimetableList.Add(new Timetable
                        {
                            Id = reader.GetInt32(0),
                            CourseId = reader.GetInt32(1),
                            SubjectId = reader.GetInt32(2),
                            Date = reader.GetString(3),
                            Time = reader.GetString(4),
                            RoomId = reader.GetInt32(5),
                            CourseName = reader.IsDBNull(6) ? null : reader.GetString(6),
                            SubjectName = reader.IsDBNull(7) ? null : reader.GetString(7),
                            RoomName = reader.IsDBNull(8) ? null : reader.GetString(8),
                        });
                    }
                }
            }
            return TimetableList;
        }
        //Getting Data of the Student's Course who logged in =========================================
        public List<Timetable> GetTimetableByCourseName(string courseName)
        {
            var TimetableList = new List<Timetable>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT t.Id, t.CourseID, t.SubjectID, t.Date, t.Time, t.RoomID,
            Courses.Name AS CourseName, Subjects.Name AS SubjectName, Rooms.Name AS RoomName
            FROM Timetables t
            LEFT JOIN Courses ON t.CourseID = Courses.Id
            LEFT JOIN Subjects ON t.SubjectID = Subjects.Id
            LEFT JOIN Rooms ON t.RoomID = Rooms.Id
            WHERE Courses.Name = @courseName", getDBconn);

                cmd.Parameters.AddWithValue("@courseName", courseName);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TimetableList.Add(new Timetable
                        {
                            Id = reader.GetInt32(0),
                            CourseId = reader.GetInt32(1),
                            SubjectId = reader.GetInt32(2),
                            Date = reader.GetString(3),
                            Time = reader.GetString(4),
                            RoomId = reader.GetInt32(5),
                            CourseName = reader.IsDBNull(6) ? null : reader.GetString(6),
                            SubjectName = reader.IsDBNull(7) ? null : reader.GetString(7),
                            RoomName = reader.IsDBNull(8) ? null : reader.GetString(8),
                        });
                    }
                }
            }
            return TimetableList;
        }




        //Adding Data To Timetables Table ============================================================
        public void AddtoTimetable(Timetable timetable)
        {
                using (var getDBconn = DBConnection.GetConnection())
                {
                    var cmd = new SQLiteCommand(@"INSERT INTO Timetables (CourseID, SubjectID, Date, Time, RoomID) 
                                         VALUES (@courseid, @subjectid, @date, @time, @roomid)", getDBconn);
                    cmd.Parameters.AddWithValue("@courseid", timetable.CourseId);
                    cmd.Parameters.AddWithValue("@subjectid", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@date", timetable.Date);
                    cmd.Parameters.AddWithValue("@time", timetable.Time);
                    cmd.Parameters.AddWithValue("@roomid", timetable.RoomId);

                    cmd.ExecuteNonQuery();
                }
        }
        //Getting Data by ID ==============================================================================
        public Timetable GetTimetableById(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Timetables WHERE Id = @Id", getDBconn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Timetable
                        {
                            Id = reader.GetInt32(0),
                            CourseId = reader.GetInt32(1),
                            SubjectId = reader.GetInt32(2),
                            Date = reader.GetString(3),
                            Time = reader.GetString(4),
                            RoomId = reader.GetInt32(5)
                        };
                    }
                }
            }
            return null;
        }
        //Updating Data On Timetables Table ===========================================================
        public void UpdateTimetable(Timetable timetable)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"UPDATE Timetables SET CourseID = @courseid , SubjectID = @subjectid , 
                                            Date = @date , Time = @time , RoomID = @roomid WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@courseid", timetable.CourseId);
                cmd.Parameters.AddWithValue("@subjectid", timetable.SubjectId);
                cmd.Parameters.AddWithValue("@date", timetable.Date);
                cmd.Parameters.AddWithValue("@time", timetable.Time);
                cmd.Parameters.AddWithValue("@roomid", timetable.RoomId);
                cmd.Parameters.AddWithValue("@id", timetable.Id);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Timetables Table =========================================================
        public void DeleteTimetable(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Timetables WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Timetables Table By SubjectID =========================================================
        public void DeleteTimetableBySubjectID(int subjectid)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Timetables WHERE SubjectID = @subjectid", getDBconn);
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
