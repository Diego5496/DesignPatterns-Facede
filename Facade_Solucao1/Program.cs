using System;
using System.Collections.Generic;

namespace Facade_Solucao1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComparaPreco comparaPreco = new ComparaPreco();

            Console.WriteLine("### Pesquisar Preços de Livros ###\n");
            Console.WriteLine("Informe o ISBN do livro");
            string isbn = Console.ReadLine();

            List<Livro> livros = comparaPreco.Comparar(isbn);

            Console.WriteLine($"\n ---- Resultado da Pesquisa ----\n");

            foreach(var livro in livros)
            {
                Console.WriteLine($"ISBN : {livro.ISBN} - {livro.Titulo} - {livro.Preco:C} " +
                    $"- {livro.Origem}\n");
            }

            Console.ReadKey();
        }
    }
}
