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
    internal class LoginController
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
                    user1.Id = reader.GetInt32(0);
                    user1.Name = reader.GetString(1);
                    user1.Username = reader.GetString(2);
                    user1.Password = reader.GetString(3);
                    user1.Role = reader.GetString(4);

                }

            }
            return user1;

        }
    }
}
