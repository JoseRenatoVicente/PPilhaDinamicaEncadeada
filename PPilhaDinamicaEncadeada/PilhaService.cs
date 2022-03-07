using PPilhaDinamicaEncadeada.Entities;
using System;

namespace PPilhaDinamicaEncadeada
{
    internal class PilhaService
    {
        StackBook stackBook = new StackBook();
        int count;

        public void GetAllBooks()
        {
            stackBook.PrintPaused();
        }

        public void GetCount() => Console.WriteLine("A pilha possui {0} {1}", count, count == 1 ? "livro" : "livros");

        public void GetBookByNameISBN()
        {
            if (stackBook.IsEmpty())
                Console.WriteLine("Pilha vazia. Adicione um Livro primeiro");

            Console.WriteLine("Digite o nome do livro: ");
            string where = Console.ReadLine().ToLower();

            stackBook.PrintByNameISBN(where);

            if (where.Length < 1)
            {
                Console.WriteLine("O Nome digitado é inválido");
                GetBookByNameISBN();
            }
        }

        public void AddBook()
        {
            Console.WriteLine(stackBook.Push(InputInfo(new Book())).ToString());

            count++;

            Console.WriteLine("Livro adicionado com sucesso");
        }


        private Book InputInfo(Book book)
        {
            Book Book = book;

            if (book.Title == null || book.Title == "")
            {
                Console.Write("Digite o título do livro: ");
                Book.Title = Console.ReadLine();

                if (string.Empty == Book.Title)
                {
                    Console.WriteLine($"O título está vazio");
                    InputInfo(book);
                }
            }
            if (book.ISBN == 0)
            {
                Console.Write("Digite o número ISBN: ");
                if (Int32.TryParse(Console.ReadLine(), out int ISBNValue))
                    Book.ISBN = ISBNValue;
                else
                {
                    Console.WriteLine($"Formato incorreto, digite um número de ISBN válido");
                    InputInfo(book);
                }

            }
            if (book.YearPublication == 0)
            {
                Console.Write("Digite o ano de publicação do livro: ");
                if (Int32.TryParse(Console.ReadLine(), out int YearPublicationValue))
                    Book.YearPublication = YearPublicationValue;
                else
                {
                    Console.WriteLine($"Formato incorreto, digite um ano de publicação válido");
                    InputInfo(book);
                }
            }

            Console.Clear();

            return book;

        }

        public void RemoveBook()
        {
            if (stackBook.Pop())
            {
                Console.WriteLine("O primeiro livro foi removido");
                count--;
            }
            else
                Console.WriteLine("\nAdicione um livro para usar a opção de remover");
        }

    }
}
