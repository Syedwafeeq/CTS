using System;
using System.Data.SqlClient;

class UpdateDelete
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Database=CTS_Training;Integrated Security=True;";

        using (SqlConnection connection =
            new SqlConnection(connectionString))
        {
            connection.Open();

            string updateQuery =
                "UPDATE Students SET CGPA = @cgpa WHERE StudentID = @id";

            SqlCommand updateCommand =
                new SqlCommand(updateQuery, connection);

            updateCommand.Parameters.AddWithValue("@cgpa", 9.2);
            updateCommand.Parameters.AddWithValue("@id", 101);

            int updatedRows =
                updateCommand.ExecuteNonQuery();

            Console.WriteLine(
                updatedRows + " row updated."
            );

            string deleteQuery =
                "DELETE FROM Students WHERE StudentID = @id";

            SqlCommand deleteCommand =
                new SqlCommand(deleteQuery, connection);

            deleteCommand.Parameters.AddWithValue("@id", 105);

            int deletedRows =
                deleteCommand.ExecuteNonQuery();

            Console.WriteLine(
                deletedRows + " row deleted."
            );
        }
    }
}
