using System.Data.SqlClient;

namespace csharp_biblioteca_db;

public class LibraryDB
{
    public string? Name { get; }
    
    public LibraryDB(string name)
    {
        Name = name;
    }

    public List<Document> GetAll()
    {
        List<Document> allDocs = new List<Document>();
        string connectionString = "Data Source=localhost;Initial Catalog=db-library;Integrated Security=True";
        using SqlConnection connection = new SqlConnection(connectionString);
        string query = "SELECT* FROM Books";
        using SqlCommand command = new SqlCommand(query, connection);
        connection.Open();
        using SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Book b = new Book((int)reader["Id"], 
                (string)reader["Title"],
                (int)reader["Year"],
                (string)reader["Genre"],
                (string)reader["Position"],
                (int)reader["Pages"]);
            
            allDocs.Add(b);
        }
        return allDocs;
    }
}