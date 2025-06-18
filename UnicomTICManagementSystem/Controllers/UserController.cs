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
        //Getting Data from Users table for Login Check ============================================================== 
        public User GettingLoginInfo(User user)
        {
            User user1 = new User();
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Users WHERE Username = @username", getDBconn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user1.Name = reader.GetString(1);
                    user1.Username = reader.GetString(2);
                    user1.Password = reader.GetString(3);
                    user1.Role = reader.GetString(4);

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
                var cmd = new SQLiteCommand(@"SELECT * FROM Users", getDBconn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserList.Add(new User
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Username = reader.GetString(2),
                        Password = reader.GetString(3),
                        Role = reader.GetString(4),

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
                string AddUsertQuery = @"INSERT INTO Users(Name,Username,Role,Password) 
                                        VALUES (@name,@username,@role,@password)";
                SQLiteCommand insertUserCommand = new SQLiteCommand(AddUsertQuery, getDBconn);
                insertUserCommand.Parameters.AddWithValue("@name", user.Name);
                insertUserCommand.Parameters.AddWithValue("@username",user.Username);
                insertUserCommand.Parameters.AddWithValue("@role", user.Role);
                insertUserCommand.Parameters.AddWithValue("@password", user.Password);
                insertUserCommand.ExecuteNonQuery();

            }
            
        }
        //Updating Data On Users Table ===========================================================
        public void UpdateUser(User user)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Users SET Name = @name,Username = @username, Role = @role ,Password = @password WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("username",user.Username);
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
        
        //Getting User by UserID =================================================================
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
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            Role = reader.GetString(3)
                        };
                    }
                }
            }

            return null;
        }
        //To Get UserID From Users Table by Username ============================================================
        public int?  GetUserIDByUsername(string username) 
        {
            using (var getDBconn = DBConnection.GetConnection()) 
            {
                var cmd = new SQLiteCommand("SELECT Id FROM Users WHERE Username = @username",getDBconn);
                cmd.Parameters.AddWithValue("@username", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }

                }
                return null;
            }
        }
        public string GetPswdByUsername(string username) 
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT Password FROM Users WHERE Username = @username", getDBconn);
                cmd.Parameters.AddWithValue("@username", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString(3);
                    }

                }
                return null;
            }

        }
        public void UpdatePswd(User user)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Users SET Password = @password WHERE Usename = @username", getDBconn);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
