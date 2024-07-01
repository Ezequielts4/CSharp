using SistemaGerenciamentoDeSupermercados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Services
{
    public class ProdutoService
    {
        private List<Produto> _produtos;
        private int qtd = 1;

        public ProdutoService()
        {
            _produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            produto.Id = qtd;
            _produtos.Add(produto);
            qtd++;
        }

        public List<Produto> ListarProduto()
        {
            return _produtos;
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return _produtos.FirstOrDefault(i => i.Id == id);
        }

        public void RemoverProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }
    }
}