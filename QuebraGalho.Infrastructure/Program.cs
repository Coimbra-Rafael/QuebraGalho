using QuebraGalho.Infrastructure.Repository;

foreach (var licenca in await new LicencaRepository().GetAllLicencas())
{
    foreach (var usuario in await new UsuarioRepository().GetUsuariosByLicenca(licenca.NrLicenca))
    {
        if (usuario.NmLogin.Equals("SANT@FELIPE"))
        {
            using var permissaoRepository = new PermissaoRepository();
            if (await permissaoRepository.GetPermissao(licenca.NrLicenca, usuario.IdUsuario) is null)
            {
                var result = await permissaoRepository.AddPermissao(licenca.NrLicenca, usuario.IdUsuario);
                Console.WriteLine(result.Equals(0) ? "ERRO" : "PERMISSÃO INSERIDA COM SUCESSO");
            }
            break;
        }
    }    
}
Console.WriteLine("Finalizado!!!");