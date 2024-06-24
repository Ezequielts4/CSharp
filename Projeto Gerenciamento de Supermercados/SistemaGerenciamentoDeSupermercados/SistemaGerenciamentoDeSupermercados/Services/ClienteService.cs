using SistemaGerenciamentoDeSupermercados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Services
{
    public class ClienteService
    {
        private List<Cliente> _cliente;
        private int qtd = 0;
        public ClienteService()
        {
            _cliente = new List<Cliente>();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            cliente.Id = qtd;
            _cliente.Add(cliente);
            qtd++;
        }

        public void RemoverCliente(Cliente cliente)
        {
            _cliente.Remove(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _cliente;
        }

        public Cliente BuscarClientePorId(int id)
        {
            return _cliente.FirstOrDefault(i => i.Id == id);
        } 
    }
}
