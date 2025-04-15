using QuebraGalho.Core.Entities;

namespace QuebraGalho.Infrastructure.Repository.Implementation;

public interface IUsuarioRepository : IDisposable
{
    Task<IEnumerable<ErpUsuario>> GetUsuariosByLicenca(string nrLicenca);
}