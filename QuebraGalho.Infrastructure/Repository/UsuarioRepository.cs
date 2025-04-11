using System.Data;
using System.Text;
using Dapper;
using MySqlConnector;
using QuebraGalho.Core.Entities;

namespace QuebraGalho.Infrastructure.Repository;

public class UsuarioRepository : IDisposable
{
    public async Task<IEnumerable<ErpUsuario>> GetUsuariosByLicenca(string nrLicenca)
    {
        await using var connection = new MySqlConnection("server=santsystem.ddns.net;port=3312;uid=santsystem;pwd=Sant**3692;database=erp_web;");

        if(connection.State.Equals(ConnectionState.Closed))
            await connection.OpenAsync();
        
        var selectUsuarios = new StringBuilder(
            """
                SELECT ERP_USUARIO.ID_USUARIO as IdUsuario, ERP_USUARIO.NM_LOGIN AS NmLogin  
                FROM ERP_USUARIO WHERE ERP_USUARIO.NR_LICENCA = @NrLicenca
            """
        );
        var parameters = new DynamicParameters();
        parameters.Add("@NrLicenca", nrLicenca);
    
        return await connection.QueryAsync<ErpUsuario>(selectUsuarios.ToString(), parameters);
    }

    public async Task<ErpUsuario?> GetUsuarioById(string nrLicenca, long idUsuario)
    {
        await using var connection = new MySqlConnection("server=santsystem.ddns.net;port=3312;uid=santsystem;pwd=Sant**3692;database=erp_web;");

        if(connection.State.Equals(ConnectionState.Closed))
            await connection.OpenAsync();
        
        var selectUsuarios = new StringBuilder(
            """
                SELECT ERP_USUARIO.ID_USUARIO as IdUsuario, ERP_USUARIO.NM_LOGIN AS NmLogin  
                FROM ERP_USUARIO 
                WHERE ERP_USUARIO.NR_LICENCA = @NrLicenca
                    AND ERP_USUARIO.ID_USUARIO = @IdUsuario 
            """
        );
        var parameters = new DynamicParameters();
        parameters.Add("@NrLicenca", nrLicenca);
        parameters.Add("IdUsuario", idUsuario);
        
        return await connection.QueryFirstOrDefaultAsync<ErpUsuario>(selectUsuarios.ToString(), parameters);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}