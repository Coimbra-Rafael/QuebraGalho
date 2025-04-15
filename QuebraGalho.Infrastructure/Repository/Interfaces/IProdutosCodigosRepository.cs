using QuebraGalho.Core.Entities;

namespace QuebraGalho.Infrastructure.Repository.Interfaces;

public interface IProdutosCodigosRepository : IDisposable
{
    Task<ErpProdutoServicoCodigo> GetProdutoCodigoByCodigoAsync(string nrLicenca, string codigo);
    Task<bool> DefinirCodigoPrincialAsync(ErpProdutoServicoCodigo produtoCodigo);
}