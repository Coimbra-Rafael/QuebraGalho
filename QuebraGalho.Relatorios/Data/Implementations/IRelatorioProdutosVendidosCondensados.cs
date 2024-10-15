using QuebraGalho.Core.Models;

namespace QuebraGalho.Relatorios.Data.Implementations;

public interface IRelatorioProdutosVendidosCondensados : IDisposable
{
    public Task<IEnumerable<RelatorioProdutosVendidosCondensadosPorCliente>> GetRelatorioProdutosVendidosCondensados(string nr_licenca, long id_cliente, DateTime dt_inicio, DateTime dt_final);
}
