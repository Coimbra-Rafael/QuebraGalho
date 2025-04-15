using Microsoft.Extensions.DependencyInjection;
using QuebraGalho.Infrastructure;
using QuebraGalho.Infrastructure.Repository.Interfaces;

var services = new ServiceCollection();
services.AddDependecyInjection();
var serviceProvider = services.BuildServiceProvider();

var licencaRepository = serviceProvider.GetService<ILicencaRepository>();
var produtoRepository = serviceProvider.GetService<IProdutosRepository>();
var produtoCodigosRepository = serviceProvider.GetService<IProdutosCodigosRepository>();

long count = 0;
foreach (var licenca in await licencaRepository!.GetAllLicencas())
{
    if (licenca.NrLicenca.Equals("41498"))
    {
        foreach (var produto in await produtoRepository!.GetAllProductsAsync(licenca.NrLicenca))
        {
            try
            {
                var produtoCodigos = await produtoCodigosRepository!.GetProdutoCodigoByCodigoAsync(produto.NrLicenca,
                    produto.CdProdutoServico);

                var result = await produtoCodigosRepository.DefinirCodigoPrincialAsync(produtoCodigos);
                Console.WriteLine(result
                    ? $"{produtoCodigos.NrLicenca} Codigo atualizado {produtoCodigos.IdProdutosCodigos}"
                    : $"{produtoCodigos.NrLicenca} Codigo com ERRO {produtoCodigos.IdProdutosCodigos}");
                count++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                count++;
            }
        }
    }
}
Console.WriteLine(count);

