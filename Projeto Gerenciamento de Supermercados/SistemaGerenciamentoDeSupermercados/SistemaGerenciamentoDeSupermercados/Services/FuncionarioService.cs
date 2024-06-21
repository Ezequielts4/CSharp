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
        private List<Funcionario> _funcionarios;

        public FuncionarioService()
        {
            _funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _funcionarios.Add(funcionario);
        }

        public List<Funcionario> ListarFuncionario()
        {
            return _funcionarios;
        }

        public Funcionario BuscarPorId(int id)
        {
            return _funcionarios.FirstOrDefault(i => i.Id == id);
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            _funcionarios.Remove(funcionario);
        }
    }
}
