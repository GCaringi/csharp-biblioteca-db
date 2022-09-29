using csharp_biblioteca_db;

LibraryDB library = new LibraryDB("Feltrinelli");

List<Document> docs = library.GetAll();

foreach (Document doc in docs)
{
    Console.WriteLine(doc);
}
