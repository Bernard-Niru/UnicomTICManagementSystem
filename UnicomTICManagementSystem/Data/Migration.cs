using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Data
{
    internal static class Migration
    {
        public static void CreateTables()
        {
            using (var getDBconn = DBConnection.GetConnection()) 
            {
                string createTables = @"
                    CREATE TABLE IF NOT EXISTS Users
                    (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL ,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                    );
                    INSERT INTO Users (Name, Password, Role)
                    SELECT 'Admin', '12345', 'Admin'
                    WHERE NOT EXISTS (
                    SELECT * FROM Users 
                    WHERE Name = 'Admin' AND Password = '12345' AND Role = 'Admin'
                    );


                    
                     CREATE TABLE IF NOT EXISTS Courses
                    (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Students
                    (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL ,
                    Address TEXT NOT NULL,
                    CourseID INTEGER,
                    UserID INTEGER,
                    FOREIGN KEY (CourseID) REFERENCES Courses(Id)
                    FOREIGN KEY(UserID) REFERENCES Users(Id)
                    );

                     CREATE TABLE IF NOT EXISTS Subjects
                    (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,                
                    CourseID INTEGER,
                    FOREIGN KEY (CourseID) REFERENCES Courses(Id)
                    );
                                       
                    CREATE TABLE IF NOT EXISTS Exams
                    (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    SubjectID INTEGER,
                    FOREIGN KEY (SubjectID) REFERENCES Subjects(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Marks
                    (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER,
                    ExamID INTEGER,
                    Score INTEGER,
                    FOREIGN KEY (StudentID) REFERENCES Students(Id),
                    FOREIGN KEY (ExamID) REFERENCES Exams(Id)
                    );
                    
                    CREATE TABLE IF NOT EXISTS Rooms
                    (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Type TEXT NOT NULL
                    );

                     CREATE TABLE IF NOT EXISTS Timetables
                    (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER,
                    TimeSlot TEXT,
                    RoomID INTEGER,
                    FOREIGN KEY (StudentID) REFERENCES Students(Id),
                    FOREIGN KEY (RoomID) REFERENCES Rooms(Id)
                    );
                ";
                SQLiteCommand command = new SQLiteCommand(createTables, getDBconn);
                command.ExecuteNonQuery();

            }
        }
    }
}
