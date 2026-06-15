using System;
using System.Data.SqlClient;

class ReadData
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Database=CTS_Training;Integrated Security=True;";

        using (SqlConnection connection =
            new SqlConnection(connectionString))
        {
            string query =
                "SELECT StudentID, FullName, Department FROM Students";

            SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["StudentID"] + " " +
                    reader["FullName"] + " " +
                    reader["Department"]
                );
            }

            reader.Close();
        }
    }
}
