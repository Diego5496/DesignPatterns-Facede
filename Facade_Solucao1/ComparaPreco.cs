using Facade_Solucao1.Subsistemas;
using System.Collections.Generic;

namespace Facade_Solucao1
{
    public class ComparaPreco
    {
        public List<Livro> Comparar(string isbn)
        {
            ServicoAClient clientA = new ServicoAClient();
            Livro livroA = clientA.PesquisaLivro(isbn);

            ServicoBClient clientB = new ServicoBClient();
            Livro livroB = clientB.PesquisaLivro(isbn);

            List<Livro> livros = new List<Livro>();
            livros.Add(livroA);
            livros.Add(livroB);

            livros.Sort(delegate (Livro b1, Livro b2)
            {
                return b1.Preco.CompareTo(b2.Preco);
            });

            return livros;
        }
    }
}
