using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class UserController
    {
        public User GettingLoginInfo(User user)
        {
            User user1 = new User();
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Users WHERE Name = @Name" , getDBconn);
                cmd.Parameters.AddWithValue("@Name", user.UserName);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    user1.UserName = reader.GetString(1);
                    user1.Password = reader.GetString(2);
                    user1.Role = reader.GetString(3);

                }
                              
            }
            return user1;
           
        }
        //Getting Data From Users Table =================================================
        public List<User> GetAllUsers()
        {
            var UserList = new List<User>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand(@"SELECT * FROM Users",getDBconn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserList.Add(new User
                    {
                        Id = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        Password = reader.GetString(2),
                        Role = reader.GetString(3),

                    });
                }
            }
            return UserList;
        }
        //Adding Data To Users Table ======================================================
        public void AddUser(User user) 
        {
            using (var getDBconn = DBConnection.GetConnection()) 
            {
                string AddUsertQuery = @"INSERT INTO Users(Name,Role,Password) 
                                        VALUES (@name,@role,@password)";
                SQLiteCommand insertUserCommand = new SQLiteCommand(AddUsertQuery, getDBconn);
                insertUserCommand.Parameters.AddWithValue("@name", user.UserName);
                insertUserCommand.Parameters.AddWithValue("@role", user.Role);
                insertUserCommand.Parameters.AddWithValue("@password",user.Password);
                insertUserCommand.ExecuteNonQuery();

            }
        }
        //Updating Data On Users Table ===========================================================
        public void UpdateUser(User user)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Users SET Name = @name, Role = @role ,Password = @password WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@name", user.UserName);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From User Table ==========================================================
        public void DeleteUser(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Users WHERE Id = @id", getDBconn);
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

        public User GetUserId(User user)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Users WHERE Name = @name", getDBconn);
                cmd.Parameters.AddWithValue("@name", user.UserName);

                using (var reader = cmd.ExecuteReader())
                {
                   while (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            
                        };
                    }
                }
            }

            return null;
        }
        public User GetUserById(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Users WHERE Id = @Id", getDBconn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            UserName = reader.GetString(1),                          
                        };
                    }
                }
            }

            return null;
        }
    }


    
}
