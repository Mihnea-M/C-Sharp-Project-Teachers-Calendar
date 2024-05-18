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
            var query = "SELECT Id, Name FROM Subject;";
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
                    list.Add(subject);
                }
                data.Close();
                connection.Close();
            }

            return list;
        }

        public void addSubject(Subject subject)
        {
            var query = "insert into Subject (Name) values (@name); SELECT last_insert_rowid();";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@name", subject.Name);
                long id = (long)command.ExecuteScalar();
                subject.Id = (int)id;
                connection.Close();
            }
        }

        public void updateSubject(Subject subject)
        {
            var query = "UPDATE Subject SET Name = (@name) WHERE id = (@id);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", subject.Id);
                command.Parameters.AddWithValue("@firstname", subject.Name);

                command.ExecuteScalar();

                connection.Close();
            }
        }

    }
}
