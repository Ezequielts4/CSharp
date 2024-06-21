using SistemaGerenciamentoDeSupermercados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Services
{
    public abstract class ProdutoService
    {
        private List<Produto> _produtos;

        public ProdutoService()
        {
            _produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public List<Produto> ListarProduto()
        {
            return _produtos;
        }

        public Produto BuscarPorId(int id)
        {
            return _produtos.FirstOrDefault(i => i.IdP == id);
        }

        public void RemoverProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }
    }
}
