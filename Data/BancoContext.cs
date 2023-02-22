using CadastroFornecedores.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace CadastroFornecedores.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options) : base(options)
        {
            
        }

        public DbSet<FornecedorModel> Fornecedor { get; set; }
    }
}
