﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTICManagementSystem.Controllers
{
    internal class UserController
    {

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
        public bool AddUser(User user)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                string AddUsertQuery = @"INSERT INTO Users(Name,Username,Role,Password) 
                                VALUES (@name,@username,@role,@password)";
                SQLiteCommand insertUserCommand = new SQLiteCommand(AddUsertQuery, getDBconn);
                insertUserCommand.Parameters.AddWithValue("@name", user.Name);
                insertUserCommand.Parameters.AddWithValue("@username", user.Username);
                insertUserCommand.Parameters.AddWithValue("@role", user.Role);
                insertUserCommand.Parameters.AddWithValue("@password", user.Password);

                try
                {
                    insertUserCommand.ExecuteNonQuery();
                    return true;
                }
                catch (SQLiteException ex) // check if username exists
                {
                    if (ex.ResultCode == SQLiteErrorCode.Constraint && ex.Message.Contains("UNIQUE"))
                    {
                        MessageBox.Show("Username already exists.Try a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else // for any other errors
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }

        //Updating Data On Users Table ===========================================================
        public void UpdateUser(User user)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Users SET Name = @name  WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@name", user.Name);
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
                            Name = reader.GetString(1),
                            Username = reader.GetString(2),
                            Password = reader.GetString(3),
                            Role = reader.GetString(4)
                        };
                    }
                }
            }

            return null;
        }
        //To Get UserID From Users Table by Username ============================================================
        public User GetUserIDByUsername(string username)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT Id FROM Users WHERE Username = @username", getDBconn);
                cmd.Parameters.AddWithValue("@username", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
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
        public List<User> GetUsernameByName(string name)
        {
            var UsernameList = new List<User>();

            using (var getDBconn = DBConnection.GetConnection())
            {

                var cmd = new SQLiteCommand("SELECT Id, Username FROM Users WHERE Name = @name COLLATE NOCASE", getDBconn);
                cmd.Parameters.AddWithValue("@name", name);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UsernameList.Add(new User
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Username = reader.IsDBNull(1) ? null : reader.GetString(1)
                    });
                }
            }

            return UsernameList;
        }
        // Updating username by users ===================================================================================== 
        public bool UpdateUsername(int id, string username)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Users SET Username = @username WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SQLiteException ex) // check if username exists
                {
                    if (ex.ResultCode == SQLiteErrorCode.Constraint && ex.Message.Contains("UNIQUE"))
                    {
                        MessageBox.Show("Username already exists.Try a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else // for any other errors
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public void UpdatePassword(int id, string password)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Users SET Password = @password WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

            }

        }
        public List<User> GetUsernamesByIds(List<int> userids)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var query = "SELECT Id,Username FROM Users WHERE Id IN (" + string.Join(",", userids.Select((id, index) => "@Id" + index)) + ")";
                var cmd = new SQLiteCommand(query, getDBconn);

                for (int i = 0; i < userids.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@Id" + i, userids[i]);
                }

                using (var reader = cmd.ExecuteReader())
                {
                    var usernameList = new List<User>();
                    while (reader.Read())
                    {
                        usernameList.Add(new User
                        {   Id = reader.GetInt32(0),                        
                            Username = reader.GetString(1),
                            
                        });
                    }
                    return usernameList;
                }
            }
        }

    }
}
