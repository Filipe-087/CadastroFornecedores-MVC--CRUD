using CadastroFornecedores.Models;

namespace CadastroFornecedores.Repositorio
{

    public interface InterfaceFornecedor
    {
        FornecedorModel ListarPorId(int id);
        List<FornecedorModel> BuscarTodos();
        FornecedorModel Adicionar(FornecedorModel fornecedor);
        FornecedorModel Atualizar(FornecedorModel fornecedor);

        bool Apagar(int id);
    }
}
