using SistemaGerenciamentoDeSupermercados.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Utils
{
    public static class DisplayHelper
    {
        public static void MostrarDetalhes(ClienteService detalhesCliente)
        {
            var itens = detalhesCliente.ListarClientes();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }

        public static void MostrarDetalhes(FuncionarioService detalhesFuncionario)
        {
            var itens = detalhesFuncionario.ListarFuncionario();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }

        public static void MostrarDetalhes(ProdutoService detalhesProduto)
        {
            var itens = detalhesProduto.ListarProduto();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }

        public static void MostrarDetalhes(TransacaoService detalhesTransacao)
        {
            var itens = detalhesTransacao.ListarTransacao();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }
    }
}
