using Newtonsoft.Json;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace SqliteInsert
{
    public class Program
    {
        private const string SQLiteDir = "/db.sqlite";
        public static void Main()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source = db.sqlite"))
            {
                connection.Open();
                List<TempClass> list = ListTempClass.getlist();
                int index = 1;

                foreach (var item in list)
                {
                    SqliteCommand command = SetAttributeCommand(item, Convert.ToString(index));
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine(item);
                    }
                    catch (Exception exception)
                    {
                        throw new Exception(exception.Message);
                    }
                    index++;
                }
            }
        }

        private static SqliteCommand SetAttributeCommand(TempClass item, string index)
        {
            SqliteCommand command = new SqliteCommand();
            command.CommandText = @"INSERT into *INSERT THE TABLE NAME* VALUES(*INSERT VALUES*);";
            // Example -> command.CommandText = @"INSERT into AspNetUsers VALUES('" + index + "','" + index + "','" + item.name + "','" + item.lastname + "','" + item.password + "','" + item.username + "');";
            return command;
        }

    }
}