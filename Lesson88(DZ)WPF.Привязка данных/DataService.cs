using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson88_DZ_WPF.Привязка_данных
{
    public class DataService
    {
        private string connectionString = "Data Source=people.db;Version=3;";

        public Person GetFirstPerson()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName, LastName, Age FROM People LIMIT 1";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Person
                            {
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Age = Convert.ToInt32(reader["Age"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
