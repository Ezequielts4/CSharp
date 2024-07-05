using API_CSharp.Context;
using API_CSharp.Models;

namespace API_CSharp.Repository
{
    public class ProdutoRepository
    {

        ProdutoContext contexto = new ProdutoContext();


        // essa lista pode ser apagada, já está sendo criada com o banco de dados

        //List<Produto> ListaProduto = new()
        //{
        //    new Produto()
        //    {
        //        Nome = "Produto Tste",
        //        Categoria = "Categoria Teste"
        //    }
        //};

        //public List<Produto> ListarProdutos()
        //{
        //    return ListaProduto;
        //}


        //public Produto CadastrarProduto(Produto produto)
        //{
        //    ListaProduto.Add(produto);
        //    return produto;
        //}

        public List<Produto> ListarProdutos()
        {
            return contexto.Produtos.ToList();
        }

        public void CadastrarProduto(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }
    }
}
