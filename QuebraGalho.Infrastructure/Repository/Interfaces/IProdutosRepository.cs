using QuebraGalho.Core.Entities;

namespace QuebraGalho.Infrastructure.Repository.Interfaces;

public interface IProdutosRepository: IDisposable
{
    Task<IEnumerable<ErpProdutoServico>> GetAllProductsAsync(string nrLicenca);
}