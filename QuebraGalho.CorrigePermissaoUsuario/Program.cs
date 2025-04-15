using QuebraGalho.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using QuebraGalho.Infrastructure.Repository.Implementation;

var services = new ServiceCollection();
ConfigureServices(services);
var serviceProvider = services.BuildServiceProvider();

var licencaRepository = serviceProvider.GetService<ILicencaRepository>();
var permissaoRepository = serviceProvider.GetService<IPermissaoRepository>();
var usuarioRepository = serviceProvider.GetService<IUsuarioRepository>();

var lstLicencas = await licencaRepository!.GetAllLicencas();

Console.WriteLine("Digite o nome do usuario para adicionar a permissão da tela de computador");
var nomeUsuario = Console.ReadLine()!;

if (nomeUsuario.Contains("SANT@"))
{
    foreach (var licenca in lstLicencas)
    {
        var lstUsuarios = await usuarioRepository!.GetUsuariosByLicenca(licenca.NrLicenca);
        foreach (var usuario in lstUsuarios)
        {
            if (usuario.NmLogin.Equals(nomeUsuario))
            {
                if (await permissaoRepository!.GetPermissao(licenca.NrLicenca, usuario.IdUsuario) is null)
                {
                    var result = await permissaoRepository.AddPermissao(licenca.NrLicenca, usuario.IdUsuario);
                    Console.WriteLine(result.Equals(0) ? "ERRO" : "PERMISSÃO INSERIDA COM SUCESSO");
                }
                break;
            }
        }    
    }
    Console.WriteLine("Finalizado!!!");
}

return;


static void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<ILicencaRepository, LicencaRepository>();
    services.AddScoped<IPermissaoRepository, PermissaoRepository>();
    services.AddScoped<IUsuarioRepository, UsuarioRepository>();
}