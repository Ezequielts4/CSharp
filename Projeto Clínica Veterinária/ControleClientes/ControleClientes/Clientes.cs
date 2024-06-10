using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class Clientes
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; protected set; }
        public float ValorImposto { get; protected set; }
        public float Total { get; protected set; }

        // virtual -> o método permite ser sobrescrito
        public virtual void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 10 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }   
    }
}

// sobrecarga -> o mesmo método pode ser escrito com atributos diferentes várias vezes
