using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachersCalendar.Models;

namespace TeachersCalendar.Repos
{
    internal class TeacherRepo
    {
        private string connectionString = Properties.Settings.Default.connectionString;

        public List<Teacher> getTeachers()
        {
            List<Teacher> list = new List<Teacher>();
            var query = "SELECT Id, FirstName, LastName FROM teacher;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                File.WriteAllText("test.txt", "tet");
                var data = command.ExecuteReader(CommandBehavior.Default);
                int noCols = data.FieldCount;
                while (data.Read())
                {
                    Teacher teacher = new Teacher();
                    for (int i = 0; i < noCols; i++)
                    {
                        var colName = data.GetName(i);
                        switch (colName.ToLower())
                        {
                            case "id":
                                teacher.Id = (int)(long)data.GetValue(i);
                                break;
                            case "firstname":
                                teacher.FirstName = data.GetString(i);
                                break;
                            case "lastname":
                                teacher.LastName = data.GetString(i);
                                break;
                        }
                    }
                    list.Add(teacher);
                }
                data.Close();
            }

            return list;
        }

        public void addTeacher(Teacher teacher)
        {
            var query = "insert into teacher (FirstName, LastName) values (@firstName, @lastName); SELECT last_insert_rowid();";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
   
                command.Parameters.AddWithValue("@firstName", teacher.FirstName);
                command.Parameters.AddWithValue("@lastName", teacher.LastName);
                long id = (long)command.ExecuteScalar();
                teacher.Id = (int)id;
            }
        }

        public void updateTeacher(Teacher teacher)
        {
            var query = "UPDATE Teacher SET FirstName = (@firstname), LastName = (@lastname) WHERE id = (@id);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", teacher.Id);
                command.Parameters.AddWithValue("@firstname", teacher.FirstName);
                command.Parameters.AddWithValue("@lastname", teacher.LastName);
                
                command.ExecuteScalar();
            }
        }

        public void deleteTeacher(Teacher teacher)
        {
            var query = "DELETE FROM Teacher WHERE id = (@id);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", teacher.Id);
                command.ExecuteNonQuery();
            }
        }
        
    }
}
