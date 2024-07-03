using API_CSharp.Models;

namespace API_CSharp.Repository
{
    public class ProdutoRepository
    {
        List<Produto> ListaProduto = new()
        {
            new Produto()
            {
                Nome = "Produto Tste",
                Categoria = "Categoria Teste"
            }
        };

        public List<Produto> ListarProdutos()
        {
            return ListaProduto;
        }

        public Produto CadastrarProduto(Produto produto)
        {
            ListaProduto.Add(produto);
            return produto;
        }
    }
}
