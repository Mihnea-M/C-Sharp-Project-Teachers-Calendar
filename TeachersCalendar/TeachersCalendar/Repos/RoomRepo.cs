﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachersCalendar.Models;
using System.Xml.Linq;

namespace TeachersCalendar.Repos
{
    internal class RoomRepo
    {
        private static string connectionString = Properties.Settings.Default.connectionString;

        public static List<Room> getRooms()
        {
            List<Room> list = new List<Room>();
            var query = "SELECT Id, Name, Capacity, HasComputers FROM Room;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                var data = command.ExecuteReader(CommandBehavior.CloseConnection);
                int noCols = data.FieldCount;
                while (data.Read())
                {
                    Room room = new Room();
                    room.Id = (int)(long)data["Id"];
                    room.Name = (string)data["Name"];
                    room.Capacity = (int)(long)data["Capacity"];
                    room.HasComputers = (long)data["HasComputers"] == 0 ? true : false;
                    list.Add(room);
                }
                data.Close();
            }

            return list;
        }

        public static Room getRoom(int id)
        {
            var query = "SELECT Id, Name, Capacity, HasComputers FROM Room WHERE Id = @id;";
            Room room = new Room();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                var data = command.ExecuteReader(CommandBehavior.CloseConnection);
                data.Read();
                room.Id = (int)(long)data["Id"];
                room.Name = (string)data["Name"];
                room.Capacity = (int)(long)data["Capacity"];
                room.HasComputers = (long)data["HasComputers"] == 0 ? true : false;
                    
                data.Close();
            }
            return room;

        }

        internal static void addRoom(Room room)
        {
            var query = "INSERT INTO Room (Name, Capacity, HasComputers) values (@name, @capacity, @hascomputers); SELECT last_insert_rowid();";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", room.Name);
                command.Parameters.AddWithValue("@capacity", room.Capacity);
                command.Parameters.AddWithValue("@hascomputers", room.HasComputers ? 1 : 0);
                
                long id = (long)command.ExecuteScalar();
                room.Id = (int)id;
                
            }
        }

        public static void updateRoom(Room room)
        {
            var query = "UPDATE Room SET Name = @name, Capacity = @capacity, HasComputers = @hascomputers WHERE id = (@id);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", room.Id);
                command.Parameters.AddWithValue("@name", room.Name);
                command.Parameters.AddWithValue("@capacity", room.Capacity);
                command.Parameters.AddWithValue("@hascomputers", room.HasComputers ? 1 : 0);

                command.ExecuteScalar();
            }
        }

        public static void deleteRoom(Room room)
        {
            var query = "DELETE FROM Room WHERE id = (@id);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", room.Id);
                command.ExecuteNonQuery();
            }
        }

    }
}
