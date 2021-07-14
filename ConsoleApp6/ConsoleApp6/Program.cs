using System;
using Microsoft.Data.Sqlite;

namespace Phone_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new SqliteConnection("Data Source=usersdata3.db;Mode=ReadOnly;"))
            {
                db.Open();
                    .
                SqliteCommand command = new SqliteCommand();
                command.Connection = db;
            }

        }
    }
}