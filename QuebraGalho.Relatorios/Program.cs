using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuebraGalho.Relatorios.Data;
using QuebraGalho.Relatorios.Data.Implementations;
using QuebraGalho.Relatorios.Data.Persistence;
using QuebraGalho.Relatorios.Services;
using QuebraGalho.Relatorios.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ErpDbContext>(
    optionsBuilder => optionsBuilder.UseMySql("server=santsystemsrv07.ddns.net;port=4406;database=erp_web;uid=santsystem;pwd=Sant**3692", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.37-mysql"))    
);
builder.Services.AddScoped<IRelatorioProdutosVendidosCondensados, RelatorioProdutosVendidosCondensados>();
builder.Services.AddScoped<IRelatorioProdutosVendidosCondensadosServices, RelatorioProdutosVendidosCondensadosServices>();

var app = builder.Build();

app.MapGet("/Relatorio", async ([FromServices] IRelatorioProdutosVendidosCondensadosServices services, [FromHeader] string nr_licenca, [FromHeader] string id_cliente,
                    [FromHeader] DateTime dt_inicio, [FromHeader] DateTime dt_final) =>
{
    var result = await services.GetRelatorioProdutosVendidosCondensados(nr_licenca, long.Parse(id_cliente), dt_inicio, dt_final);

    if(result != null)
        return Results.Ok("Relatorio Gerado com sucesso!");

    return Results.Content("Não foi possível gerar o relátorio");
});

await app.RunAsync();