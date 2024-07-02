using SistemaGerenciamentoDeSupermercados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Services
{
    public class TransacaoService
    {
        private int qtd = 1;
        private List<TransacaoDeVendas> _transacao;

        public TransacaoService()
        {
            _transacao = new List<TransacaoDeVendas>();
        }

        public void AdicionarTransacao(TransacaoDeVendas transacao)
        {
            transacao.Id = qtd;
            _transacao.Add(transacao);
            qtd++;
        }

        public void RemoverTransacao(TransacaoDeVendas transacao)
        {
            _transacao.Remove(transacao);
        }

        public List<TransacaoDeVendas> ListarTransacao()
        {
            return _transacao;
        }

        public TransacaoDeVendas BuscarTransacaoPorId(int id)
        {
            return _transacao.FirstOrDefault(i => i.Id == id);
        }
    }
}