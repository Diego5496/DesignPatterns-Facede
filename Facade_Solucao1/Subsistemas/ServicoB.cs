namespace Facade_Solucao1.Subsistemas
{
    public class ServicoB
    {
        public static Livro GetLivro(string isbn)
        {
            //Realiza a pesquisa usando um mecanismo complexo
            //e retorna o livro encontrado pelo isbn
            var livro = new Livro();
            livro.ISBN = isbn;
            livro.Titulo = "Código Limpo ";
            livro.Preco = 75.70;
            livro.Origem = "Livraria Cultura";
            return livro;
        }
    }
}
