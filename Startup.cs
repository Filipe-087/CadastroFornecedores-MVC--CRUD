using CadastroFornecedores.Data;
using CadastroFornecedores.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace CadastroFornecedores
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get;}

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddDbContext<BancoContext>(o =>o.UseSqlServer(Configuration.GetConnectionString("DataBase")));
            services.AddScoped<InterfaceFornecedor, FornecedoresRepositorio>();
        }

       
    }
}
