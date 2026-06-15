using System;
using System.Data.SqlClient;

class InsertData
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Database=CTS_Training;Integrated Security=True;";

        using (SqlConnection connection =
            new SqlConnection(connectionString))
        {
            string query =
                "INSERT INTO Students (StudentID, FullName, Email, Department, CGPA) " +
                "VALUES (@id, @name, @email, @department, @cgpa)";

            SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", 105);
            command.Parameters.AddWithValue("@name", "Jaswanth");
            command.Parameters.AddWithValue("@email", "jaswanth@example.com");
            command.Parameters.AddWithValue("@department", "Cyber Security");
            command.Parameters.AddWithValue("@cgpa", 8.9);

            connection.Open();

            int rows = command.ExecuteNonQuery();

            Console.WriteLine(rows + " row inserted.");
        }
    }
}
