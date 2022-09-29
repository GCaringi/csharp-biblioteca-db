using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    public class Library
    {
        public string Name { get; }

        private List<Users> _users;

        private List<Document> _documents;

        public Library(string name)
        {
            Name = name;
            _users = new List<Users>();
            _documents = new List<Document>();
        }

        public void allDoc()
        {
            if (_documents.Count() == 0)
            {
                Console.WriteLine("Non c'è nulla nella libreria");
            }
            else
            {
                Console.WriteLine("Lista dei Documenti");
                foreach (Document doc in _documents)
                {
                    Console.WriteLine(doc.Title);
                }
            }
        }

        public void AddDocument(Document doc)
        {
            _documents.Add(doc);
        }

        public void RegisterUser(Users user)
        {
            _users.Add(user);
        }

        public Document searchByCode(int code)
        {
            foreach(Document doc in _documents)
            {
                if (doc.Code == code)
                {
                    return doc;
                }
            }

            return null;
        }

        public List<Document> searchByName(string name)
        {
            List<Document> result = new List<Document>();
            if (!_documents.Any())
            {
                return result;
            }

            foreach (Document document in _documents)
            {
                if (document.Title.Contains(name)){
                    result.Add(document);
                }
            }
            return result; 
        }

    }

    
}
