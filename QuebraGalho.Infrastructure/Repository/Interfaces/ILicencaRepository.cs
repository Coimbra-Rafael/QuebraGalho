using QuebraGalho.Core.Entities;

namespace QuebraGalho.Infrastructure.Repository.Interfaces;

public interface ILicencaRepository : IDisposable
{
    Task<IEnumerable<ErpLicenca>> GetAllLicencas();
}