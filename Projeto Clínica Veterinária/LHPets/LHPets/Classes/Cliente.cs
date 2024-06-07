namespace LHPets.Classes
{
    public class Cliente
    {
        public Cliente(string cpf_cpnj, string nome, string endereco, string rg_ie, char tipo, float valor, float valor_imposto, float total)
        {
            this.cpf_cpnj = cpf_cpnj;
            this.nome = nome;
            this.endereco = endereco;
            this.rg_ie = rg_ie;
            this.tipo = tipo;
            this.valor = valor;
            this.valor_imposto = valor_imposto;
            this.total = total;
        }

        public string cpf_cpnj { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string rg_ie { get; set; }
        public char tipo { get; set; }
        public float valor { get; set; }
        public float valor_imposto { get; set; }
        public float total { get; set; }
    }
}
