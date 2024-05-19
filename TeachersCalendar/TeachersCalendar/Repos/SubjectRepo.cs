using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachersCalendar.Models;

namespace TeachersCalendar.Repos
{
    internal class SubjectRepo
    {

        private static string connectionString = Properties.Settings.Default.connectionString;

        public static List<Subject> getSubjects()
        {
            List<Subject> list = new List<Subject>();
            var query = "SELECT Id, Name, Description FROM Subject;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                var data = command.ExecuteReader(CommandBehavior.Default);
                int noCols = data.FieldCount;
                while (data.Read())
                {
                    Subject subject = new Subject();
                    subject.Id = (int)(long)data["id"];
                    subject.Name = (string)data["Name"];
                    subject.Description = (string)data["Description"];
                    list.Add(subject);
                }
                data.Close();
            }

            return list;
        }

        public static void addSubject(Subject subject)
        {
            var query = "insert into Subject (Name, Description) values (@name, @description); SELECT last_insert_rowid();";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@name", subject.Name);
                command.Parameters.AddWithValue("@description", subject.Description);
                long id = (long)command.ExecuteScalar();
                subject.Id = (int)id;
            }
        }

        public static void updateSubject(Subject subject)
        {
            var query = "UPDATE Subject SET Name = (@name), Description = @description WHERE id = (@id);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", subject.Id);
                command.Parameters.AddWithValue("@name", subject.Name);
                command.Parameters.AddWithValue("@description", subject.Description);

                command.ExecuteScalar();

            }
        }

        public static void deleteSubject(Subject subject)
        {
            var query = "DELETE FROM Subject WHERE id = (@id);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", subject.Id);
                command.ExecuteNonQuery();
            }
        }

        public static Subject getSubject(int id)
        {
            Subject subject = new Subject();
            var query = "SELECT Id, Name, Description FROM Subject WHERE id = @id;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                var data = command.ExecuteReader(CommandBehavior.Default);
                data.Read();
                subject.Id = (int)(long)data["id"];
                subject.Name = (string)data["Name"];    
                subject.Description = (string)data["Description"];
                
                data.Close();
            }

            return subject;
        }
    }
}
