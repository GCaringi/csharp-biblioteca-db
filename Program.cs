using System.Data.SqlClient;

string stringConnection = "Data Source=localhost;Initial Catalog=db-library;Integrated Security=True";

SqlConnection connection = new SqlConnection(stringConnection);

try
{
    connection.Open();
    Console.WriteLine("Connection is open");
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
finally
{
    connection.Close();
    Console.WriteLine("Connection is closed");    
}
