using System;
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
    internal class ClassRepo
    {
        private static string connectionString = Properties.Settings.Default.connectionString;
        public static List<UniClass> getClassesOfTeacher(Teacher teacher)
        {
            List<UniClass> list = new List<UniClass>();
            var query = "SELECT Id, RoomId, SubjectId, ClassTimeId FROM Class WHERE TeacherId = @teacherId;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@teacherId", teacher.Id);
                var data = command.ExecuteReader(CommandBehavior.Default);
                int noCols = data.FieldCount;
                while (data.Read())
                {
                    UniClass uniClass = new UniClass();
                    uniClass.Id = (int)(long)data["id"];
                    uniClass.Room = RoomRepo.getRoom((int)(long)data["RoomId"]);
                    uniClass.ClassTime = ClassTimeRepo.getClassTime((int)(long)data["ClassTimeId"]);
                    uniClass.Subject = SubjectRepo.getSubject((int)(long)data["SubjectId"]);
                    list.Add(uniClass);
                }
                data.Close();
            }

            return list;
        }

        public static void addClass(UniClass uniClass, Teacher teacher)
        {
            var query = "insert into Class (RoomId, SubjectId, ClassTimeId, TeacherId) values (@RoomId, @SubjectId, @ClassTimeId, @TeacherId); SELECT last_insert_rowid();";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@RoomId", uniClass.Room.Id);
                command.Parameters.AddWithValue("@SubjectId", uniClass.Subject.Id);
                command.Parameters.AddWithValue("@ClassTimeId", uniClass.ClassTime.Id);
                command.Parameters.AddWithValue("@TeacherId", teacher.Id);
                long id = (long)command.ExecuteScalar();
                teacher.Id = (int)id;
            }
        }

        internal static void updateClass(UniClass uniClass, Teacher teacher)
        {
            var query = "Update Class SET RoomId = @RoomId, SubjectId = @SubjectId, ClassTimeId = @ClassTimeId, TeacherId = @TeacherId WHERE id = @id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@id", uniClass.Id);
                command.Parameters.AddWithValue("@RoomId", uniClass.Room.Id);
                command.Parameters.AddWithValue("@SubjectId", uniClass.Subject.Id);
                command.Parameters.AddWithValue("@ClassTimeId", uniClass.ClassTime.Id);
                command.Parameters.AddWithValue("@TeacherId", teacher.Id);

                command.ExecuteNonQuery();
            }
        }
    }
}
