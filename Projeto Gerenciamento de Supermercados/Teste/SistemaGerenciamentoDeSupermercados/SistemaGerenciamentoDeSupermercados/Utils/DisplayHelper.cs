using SistemaGerenciamentoDeSupermercados;
using SistemaGerenciamentoDeSupermercados.Models;
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
        public static void MostrarDetalhes(ClienteService clienteService)
        {
            var itens = clienteService.ListarClientes();
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

        public static void BarraCarregamento(string texto, int tempo, int quantidade, string cor)
        {
            if (cor == "VERDE")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else if (cor == "VERMELHO")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            Console.Write(texto);
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }

            Console.ResetColor();
        }
    }
}