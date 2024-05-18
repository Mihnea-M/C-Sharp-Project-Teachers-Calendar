using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachersCalendar.Models;

namespace TeachersCalendar.Repos
{
    internal class ClassTimeRepo
    {
        private string connectionString = Properties.Settings.Default.connectionString;

        public ClassTime getClassTime(int dayIndex, int timeIndex)
        {
            var query = "SELECT Id FROM ClassTime WHERE DayIndex = @dayindex AND TimeIndex = @timeindex";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@dayindex", dayIndex);
                command.Parameters.AddWithValue("@timeindex", timeIndex);
                var data = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                data.Read();
                long id = (long)data["Id"];
                data.Close();
                return new ClassTime((int)id, dayIndex, timeIndex);
            }
        }

        public ClassTime getClassTime(int id)
        {
            var query = "SELECT DayIndex, TimeIndex FROM ClassTime WHERE Id = @id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);
                var data = command.ExecuteReader();
                data.Read();
                int dayIndex = (int)(long)data["DayIndex"];
                int timeIndex = (int)(long)data["TimeIndex"];
                connection.Close();
                return new ClassTime(id, dayIndex, timeIndex);
            }
        }

        private void addClassTime(ClassTime classTime)
        {
            var query = "insert into ClassTime (DayIndex, TimeIndex) values (@dayindex, @timeindex); SELECT last_insert_rowid();";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@dayindex", classTime.DayIndex);
                command.Parameters.AddWithValue("@timeindex", classTime.TimeIndex);
                long id = (long)command.ExecuteScalar();
                connection.Close();
            }
        }

    }
}
