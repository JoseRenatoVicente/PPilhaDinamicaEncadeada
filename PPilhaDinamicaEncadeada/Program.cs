using PPilhaDinamicaEncadeada.Entities;
using System;

namespace PPilhaDinamicaEncadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            ///Implemente um Menu para poder manipular os objetos (Livros) na Pilha.
            ///
            /// Cadastrar Livros

            /// Remover Livros

            /// Imprimir toda a relação de Livros(Um livro de cada vez)

            /// Recuperar a quantidade de livros na pilha

            /// Buscar um determinado Livro(por isbn ou por título)
            /// </summary>
            /// 

            Menu();

            Console.ReadKey();

        }

        public static void Menu()
        {
            PilhaService pilhaService = new PilhaService();

            Console.Clear();

            Console.WriteLine(@"
---------------------------------------Pilha------------------------------------------------

                                1 – Cadastrar Livros
                                2 - Remover Livros
                                3 – Imprimir a relação de Livros
                                4 - Quantidade de livros na pilha
                                5 – Buscar um Livro por ISBN ou título
                                ------------------------------
                                0 - Sair

---------------------------------------------------------------------------------------------
");

            string option = Console.ReadLine();

            switch (option)
            {
                case "0": Environment.Exit(0); break;

                case "1":
                    Console.Clear();
                    pilhaService.AddBook();
                    BackMenu(); break;

                case "2":
                    Console.Clear();
                    pilhaService.RemoveBook();
                    BackMenu(); break;

                case "3":
                    Console.Clear();
                    pilhaService.GetAllBooks();
                    BackMenu(); break;

                case "4":
                    Console.Clear();
                    pilhaService.GetCount();
                    BackMenu(); break;

                case "5":
                    Console.Clear();
                    pilhaService.GetBookByNameISBN();
                    BackMenu(); break;

                default:
                    Console.WriteLine("Opção digitada inválida! ");
                    BackMenu();
                    break;
            }

        }
        public static void BackMenu()
        {
            Console.WriteLine("\n Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }

    }
}
