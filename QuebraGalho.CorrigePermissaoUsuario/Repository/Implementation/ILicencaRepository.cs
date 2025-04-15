using QuebraGalho.Core.Entities;

namespace QuebraGalho.Infrastructure.Repository.Implementation;

public interface ILicencaRepository : IDisposable
{
    Task<IEnumerable<ErpLicenca>> GetAllLicencas();
}