using QuebraGalho.Core.Entities;

namespace QuebraGalho.Infrastructure.Repository.Implementation;

public interface IPermissaoRepository : IDisposable
{
    Task<ErpPermissao?> GetPermissao(string nrLicenca, decimal idUsuario);
    Task<int> AddPermissao(string nrLicenca, decimal idUsuario);
}