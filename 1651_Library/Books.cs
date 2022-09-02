using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Library
{
    public class Books
    {
        private string name;
        private int id;
        private string author;


        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setauthor(string author)

        {
            this.author = author;
        }

        public string getauthor()
        {
            return this.author;
        }


        public void ShowBookInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Author: " + this.author);
        }
    }
}
