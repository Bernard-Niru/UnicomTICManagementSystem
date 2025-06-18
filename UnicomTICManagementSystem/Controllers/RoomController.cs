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
    internal class RoomController
    {
        //Getting All Data From Rooms Table ===========================================================
        public List<Room> GetAllRooms()
        {
            var roomList = new List<Room>();

            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Rooms", getDBconn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomList.Add(new Room
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        RoomType = reader.GetString(2)
                    });
                }
            }
            return roomList;
        }
        //Adding Data To Rooms Table ================================================================
        public void AddRoom(Room room)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Rooms (Name,Type) VALUES (@name,@type)", getDBconn);
                cmd.Parameters.AddWithValue("@name", room.Name);
                cmd.Parameters.AddWithValue("@type",room.RoomType);
                cmd.ExecuteNonQuery();
            }
        }
        //Updating Data On Rooms Table ===========================================================
        public void UpdateRoom(Room room)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Rooms SET Name = @name,Type = @type WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@name", room.Name);
                cmd.Parameters.AddWithValue("@type", room.RoomType);
                cmd.Parameters.AddWithValue("@id", room.Id);
                cmd.ExecuteNonQuery();
            }
        }
        //Deleting Data From Rooms Table ==========================================================
        public void DeleteRoom(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Rooms WHERE Id = @id", getDBconn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        //Getting A Room by ID From Rooms Table =======================================================
        public Room GetRoomById(int id)
        {
            using (var getDBconn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Rooms WHERE Id = @Id", getDBconn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Room
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            RoomType = reader.GetString(2)
                        };
                    }
                }
            }

            return null;
        }
    }
}
