using QuebraGalho.Relatorios.Data.Implementations;
using QuebraGalho.Relatorios.Data.Persistence;
using QuebraGalho.Relatorios.GeradorPdf;
using QuebraGalho.Core.Models;
using QuebraGalho.Relatorios.Services.Implementations;

namespace QuebraGalho.Relatorios.Services;

public class RelatorioProdutosVendidosCondensadosServices : IRelatorioProdutosVendidosCondensadosServices
{
    private readonly IRelatorioProdutosVendidosCondensados _persistence;

    public RelatorioProdutosVendidosCondensadosServices(IRelatorioProdutosVendidosCondensados persistence)
    {
        _persistence = persistence;
    }

    public async Task<IEnumerable<RelatorioProdutosVendidosCondensadosPorCliente>> GetRelatorioProdutosVendidosCondensados(string nr_licenca, long id_cliente, DateTime dt_inicio, DateTime dt_final)
    {
        var newRelatorioProdutosVendidosCondensados = new List<RelatorioProdutosVendidosCondensadosPorCliente>();
        var relatorioProdutosVendidosCondensados = await _persistence.GetRelatorioProdutosVendidosCondensados(nr_licenca, id_cliente, dt_inicio, dt_final);
        decimal valorTotal = 0;
        decimal valorTotalQuantidade = 0;
        string nr_venda = string.Empty;
        for (int i = 0; i < relatorioProdutosVendidosCondensados.Count(); i++) 
        {
            if (!string.IsNullOrEmpty(nr_venda) && nr_venda.Equals(relatorioProdutosVendidosCondensados.ToArray()[i].NR_VENDA)) continue;

            valorTotal = valorTotal + relatorioProdutosVendidosCondensados.ToArray()[i].VL_SUBTOTAL;
            valorTotalQuantidade = valorTotalQuantidade + relatorioProdutosVendidosCondensados.ToArray()[i].QUANTIDADE;
            nr_venda = relatorioProdutosVendidosCondensados.ToArray()[i].NR_VENDA;
        }

        foreach (var item in relatorioProdutosVendidosCondensados)
        {
            item.VL_TOTAL = valorTotal;
            item.VL_TOTAL_QUANTIDADE = valorTotalQuantidade;

            newRelatorioProdutosVendidosCondensados.Add(item);
        }

        new GerarRelatorioDeProdutosCondensadosPorCliente().GerarPdf(newRelatorioProdutosVendidosCondensados);

        return relatorioProdutosVendidosCondensados;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
