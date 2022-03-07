using System;

namespace PPilhaDinamicaEncadeada.Entities
{
    internal class StackBook
    {

        public Book Top { get; set; }

        public Book Push(Book aux)
        {
            aux.Previous = Top;
            Top = aux;

            return aux;
        }

        public void Print()
        {
            if (IsEmpty()) Console.WriteLine("A Pilha está vazia, adicione um livro");
            else
            {
                Console.WriteLine("========== Os elementos da pilha são =========\n");
                Book aux = Top;
                do
                {
                    Console.WriteLine(aux.ToString() + "\n");
                    aux = aux.Previous;
                } while (aux != null);

                Console.WriteLine("========== Fim da impressão =========\n");
            }
        }

        public void PrintPaused()
        {
            if (IsEmpty()) Console.WriteLine("A Pilha está vazia, adicione um livro");
            else
            {
                Console.WriteLine("========== Os elementos da pilha são =========\n");
                Book aux = Top;
                do
                {
                    Console.WriteLine(aux.ToString() + "\n");
                    aux = aux.Previous;

                    Console.WriteLine("Pressione qualquer tecla para motrar o próximo livro");
                    Console.ReadKey();
                } while (aux != null);

                Console.WriteLine("========== Fim da impressão =========\n");
            }
        }

        public void PrintByNameISBN(string where)
        {
            if (IsEmpty()) Console.WriteLine("A Pilha está vazia, adicione um livro");
            else
            {
                Console.WriteLine("========== Os elementos da pilha são =========\n");
                Book aux = Top;
                do
                {
                    Console.WriteLine(aux.PrintByNameISBN(where) + "\n");
                    aux = aux.Previous;
                } while (aux != null);

                Console.WriteLine("========== Fim da impressão =========\n");
            }
        }

        public bool Pop()
        {
            if (IsEmpty()) Console.WriteLine("A Pilha está vazia.");
            else
            {
                Top = Top.Previous;
                return true;
            }

            return false;
        }

        public bool IsEmpty()
        {
            return Top == null ? true : false;
        }

    }
}
