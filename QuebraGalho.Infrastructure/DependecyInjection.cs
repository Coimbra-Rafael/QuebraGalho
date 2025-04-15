using Microsoft.Extensions.DependencyInjection;
using QuebraGalho.Infrastructure.Repository;
using QuebraGalho.Infrastructure.Repository.Interfaces;

namespace QuebraGalho.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddDependecyInjection(this IServiceCollection services)
    {
        services.AddScoped<ILicencaRepository, LicencaRepository>();
        services.AddScoped<IProdutosRepository, ProdutosRepository>();
        services.AddScoped<IProdutosCodigosRepository, ProdutosCodigosRepository>();
        return services;
    }
}