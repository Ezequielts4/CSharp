namespace API_CSharp.Models
{
    public class Produto
    {
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
    }
}
