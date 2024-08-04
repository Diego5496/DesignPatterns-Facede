namespace Facade_Solucao1.Subsistemas
{
    public class ServicoA
    {
        //Realizando a pesquisa usando um mecanismo complexo
        // retornar um livro pelo isbn
        public static Livro GetLivro(string isbn)
        {
            var livro = new Livro();
            livro.ISBN = isbn;
            livro.Titulo = "Código Limpo";
            livro.Preco = 76.20;
            livro.Origem = "Amazon.com";
            return livro;
        }
    }
}
