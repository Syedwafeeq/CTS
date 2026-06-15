using System;
using System.Data.SqlClient;

class ConnectionDemo
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Database=CTS_Training;Integrated Security=True;";

        SqlConnection connection =
            new SqlConnection(connectionString);

        try
        {
            connection.Open();
            Console.WriteLine("Database connection established.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
            Console.WriteLine("Connection closed.");
        }
    }
}

