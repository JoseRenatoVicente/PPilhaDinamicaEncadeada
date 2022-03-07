using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilhaDinamicaEncadeada.Entities
{
    internal class Book
    {
        public Book()
        {

        }
        public Book(int iSBN, string title, int anoYearPublication)
        {
            ISBN = iSBN;
            Title = title;
            YearPublication = anoYearPublication;
            Previous = null;
        }

        public int ISBN { get; set; }
        public string Title { get; set; }
        public int YearPublication { get; set; }
        public Book Previous { get; set; }

        public string PrintByNameISBN(string where)
        {
            if (Title.ToLower().Contains(where) || ISBN.ToString().Contains(where)) 
                return ToString();
            
            return null;
        }

        public override string ToString()
        {
            return $"========== Dados do Livro ===========\n ISBN:\t{ISBN} \n Titulo: {Title}\n Publicação: {YearPublication}\n";
        }
    }
}
