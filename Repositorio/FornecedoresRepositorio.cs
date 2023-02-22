using CadastroFornecedores.Data;
using CadastroFornecedores.Models;

namespace CadastroFornecedores.Repositorio
{
    public class FornecedoresRepositorio : InterfaceFornecedor
    {
        private readonly BancoContext _bancoContext;

        public FornecedoresRepositorio(BancoContext bancoContext) 
        {
            this._bancoContext = bancoContext;
        }

        public FornecedorModel ListarPorId(int id)
        {

            return _bancoContext.Fornecedor.FirstOrDefault(x => x.Id == id);
        }

        public List<FornecedorModel> BuscarTodos()
        {
            return _bancoContext.Fornecedor.ToList();
        }

        public FornecedorModel Adicionar(FornecedorModel fornecedor)
        {
            //gravar no BD
            _bancoContext.Fornecedor.Add(fornecedor);
            _bancoContext.SaveChanges();
            return fornecedor;
        }

        public FornecedorModel Atualizar(FornecedorModel fornecedor)
        {
            FornecedorModel fornecedorDB = ListarPorId(fornecedor.Id);

            if (fornecedorDB == null) throw new Exception("Houve um erro na atualização do contao");

            fornecedorDB.Nome = fornecedor.Nome;
            fornecedorDB.Cnpj= fornecedor.Cnpj;
            fornecedorDB.Especialidade = fornecedor.Especialidade;
            _bancoContext.Fornecedor.Update(fornecedorDB);
            _bancoContext.SaveChanges();
            return fornecedorDB;
        }

        public bool Apagar(int id)
        {
            FornecedorModel fornecedorDB = ListarPorId(id);

            if (fornecedorDB == null) throw new Exception("Houve um erro na exclusão do fornecedor");
            _bancoContext.Fornecedor.Remove(fornecedorDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
