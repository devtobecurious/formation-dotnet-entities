using System;
using System.Data.SqlClient;

namespace CallingAdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Server=(local);Database=JeuDontOnEstLeHeros.database.dev;Trusted_Connection=True;";
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Paragraphe";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["Titre"]);
                            var paragraph = new Paragraphe()
                            {
                                Title = reader["Titre"].ToString()
                            };
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
