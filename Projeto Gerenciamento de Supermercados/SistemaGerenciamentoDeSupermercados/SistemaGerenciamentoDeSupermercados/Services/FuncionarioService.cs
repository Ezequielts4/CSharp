using SistemaGerenciamentoDeSupermercados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Services
{
    public class FuncionarioService
    {
        private int qtd = 0;
        private List<Funcionario> _funcionarios;

        public FuncionarioService()
        {
            _funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = qtd;
            _funcionarios.Add(funcionario);
            qtd++;
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            _funcionarios.Remove(funcionario);
        }

        public List<Funcionario> ListarFuncionario()
        {
            return _funcionarios;
        }

        public Funcionario BuscarFuncionarioPorId(int id)
        {
            return _funcionarios.FirstOrDefault(i => i.Id == id);
        }
    }
}
