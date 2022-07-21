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
                SqliteCommand command = SetCommand(connection);
                int index = 1;

                foreach (var item in list)
                {
                    command = SetCommand(connection);
                    command = SetAttributeCommand(command, item, Convert.ToString(index));

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine(item);
                    }
                    catch (Exception exception)
                    {
                        throw new Exception(exception.Message);
                        Console.Write("Oops something gone wrong.");
                    }
                    index++;
                }
            }
        }

        private static SqliteCommand SetCommand(SqliteConnection connection)
        {
            var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO AspNetUsers (id, Discriminator, name, lastname, password, UserName) VALUES(@id, @Discriminator, @name, @lastname, @password, @UserName)";
/*
            command.Parameters.Add(new SqliteParameter("@id", SqliteType.Text));
            command.Parameters.Add(new SqliteParameter("@Discriminator", SqliteType.Text));
            command.Parameters.Add(new SqliteParameter("@name", SqliteType.Text));
            command.Parameters.Add(new SqliteParameter("@lastname", SqliteType.Text));
            command.Parameters.Add(new SqliteParameter("@password", SqliteType.Text));
            command.Parameters.Add(new SqliteParameter("@UserName", SqliteType.Text));*/

            return command;
        }

        private static SqliteCommand SetAttributeCommand(SqliteCommand command, TempClass item, string index)
        {
            command.CommandText = @"INSERT into AspNetUsers VALUES('"+index+"','"+index+"','"+item.name+"','"+item.lastname +"','"+item.password+"','"+item.username+"');";
            return command;
        }

    }
}