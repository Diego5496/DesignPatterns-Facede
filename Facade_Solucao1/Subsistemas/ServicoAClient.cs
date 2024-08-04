namespace Facade_Solucao1.Subsistemas
{
    public class ServicoAClient
    {
        public Livro PesquisaLivro(string isbn)
        {
            //definir instancia HttpClient
            //definir endereço base
            //definir formato de resposta JSON
            //montar o request GET]
            //tratar a resposta no formato JSON
            return ServicoA.GetLivro(isbn);
        }
    }
}
