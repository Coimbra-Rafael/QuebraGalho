using QuebraGalho.Relatorios.Models;

namespace QuebraGalho.Relatorios.Services.Implementations;

public interface IRelatorioProdutosVendidosCondensadosServices : IDisposable
{
    public Task<IEnumerable<RelatorioProdutosVendidosCondensadosPorCliente>> GetRelatorioProdutosVendidosCondensados(string nr_licenca, long id_cliente, DateTime dt_inicio, DateTime dt_final);
}
