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
        try
        {
            string query = "SELECT* FROM Books";
            string connectionString = "Data Source=localhost;Initial Catalog=db-library;Integrated Security=True";
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand bookCommand = new SqlCommand(query,
                connection);
            connection.Open();
            using SqlDataReader bookReader = bookCommand.ExecuteReader();
            while (bookReader.Read())
            {
                Book tmpBook = new Book((int)bookReader["Id"],
                    (string)bookReader["Title"],
                    (int)bookReader["Year"],
                    (string)bookReader["Genre"],
                    (string)bookReader["Position"],
                    (int)bookReader["Pages"]);
                allDocs.Add(tmpBook);
            }

            bookReader.Close();
            
            query = "SELECT* FROM Dvds";
            using SqlCommand DvdCommand = new SqlCommand(query,
                connection);
            using SqlDataReader DvdReader = DvdCommand.ExecuteReader();
            while (DvdReader.Read())
            {
                Dvd tmpDvd = new Dvd((int)DvdReader["Id"],
                    (string)DvdReader["Title"],
                    (int)DvdReader["Year"],
                    (string)DvdReader["Genre"],
                    (string)DvdReader["Position"],
                    (int)DvdReader["Duration"]);
                allDocs.Add(tmpDvd);
            }
            connection.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return allDocs;
    }
}