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
    internal class SubjectController
    {
        //Getting Data From Subjects Table ====================================================
        public List<Subject> GetAllSubjects()
        {
            var SubjectList = new List<Subject>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT s.Id, s.Name,  s.CourseID, Courses.Name AS CourseName
                    FROM Subjects s
                    LEFT JOIN Courses ON s.CourseID = Courses.Id", getDBconn);


                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SubjectList.Add(new Subject
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        CourseID = reader.GetInt32(2),
                        CourseName = reader.IsDBNull(3) ? null : reader.GetString(3),

                    });
                }
            }
            return SubjectList;
        }

        //Adding Data To Subjects Table ============================================================
        public void AddSubject(Subject subject)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"INSERT INTO Subjects (Name,CourseID) 
                                            VALUES (@Name,@CourseID)", getDBconn);
                cmd.Parameters.AddWithValue("@Name", subject.Name);
                cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                cmd.ExecuteNonQuery();
            }
        }
        //Updating Data on subject Table ===============================================================
        public void UpdateSubject(Subject subject)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Subjects SET Name = @name, CourseID = @courseid  WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@name", subject.Name);
                cmd.Parameters.AddWithValue("@courseid", subject.CourseID);
                cmd.Parameters.AddWithValue("@id", subject.Id);
                cmd.ExecuteNonQuery();
            }
        }
        //Getting a subject from Subjects Table by Id ======================================================
        public Subject GetSubjectById(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects WHERE Id = @Id", getDBconn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Subject
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            CourseID = reader.GetInt32(2)
                        };
                    }
                }
            }

            return null;
        }
        //Deleting Data From Subjects Table =========================================================
        public void DeleteSubject(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        // Getting subjects Belonging to a Course ===============================================================
        public List<Subject> GetSubjectByCoID(int courseId)
        {
            var subjectListByCoID = new List<Subject>();
            using (var conn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT Id, Name FROM Subjects WHERE CourseID = @courseId", conn);
                cmd.Parameters.AddWithValue("@courseId", courseId);

                using (var reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        subjectListByCoID.Add(new Subject
                         {
                            Id=reader.GetInt32(0),
                            Name=reader.GetString(1),
                            
                         });
                    }
                }
            }
            return subjectListByCoID;
        }
    }
}
