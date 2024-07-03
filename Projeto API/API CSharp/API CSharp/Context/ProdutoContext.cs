using API_CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CSharp.Context
{
    public class ProdutoContext :  DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public string DbPath { get; }

        public ProdutoContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "produto.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
