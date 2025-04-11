using System.Data;
using System.Text;
using Dapper;
using MySqlConnector;
using QuebraGalho.Core.Entities;

namespace QuebraGalho.Infrastructure.Repository;

public class PermissaoRepository : IDisposable
{
    public async Task<ErpPermissao?> GetPermissao(string nrLicenca, decimal idUsuario)
    {
        await using var connection = new MySqlConnection("server=santsystem.ddns.net;port=3312;uid=santsystem;pwd=Sant**3692;database=erp_web;");

        if(connection.State.Equals(ConnectionState.Closed))
            await connection.OpenAsync();
        
        var selectParametrosUsuario = new StringBuilder(
            """
            SELECT ERP_PERMISSAO.NR_LICENCA as NrLicenca, ERP_PERMISSAO.NM_OBJETO as NmObjeto FROM ERP_PERMISSAO 
                WHERE ERP_PERMISSAO.NR_LICENCA = @NrLicenca 
                  AND ERP_PERMISSAO.ID_USUARIO = @IdUsuario 
                  AND ERP_PERMISSAO.NM_OBJETO = 'frmERP_Computador.sant' 
            """
        );
        var parameters = new DynamicParameters();
        parameters.Add("@NrLicenca", nrLicenca);
        parameters.Add("IdUsuario", idUsuario);
            
        return await connection.QueryFirstOrDefaultAsync<ErpPermissao>(selectParametrosUsuario.ToString(), parameters);

    }

    public async Task<int> AddPermissao(string nrLicenca, decimal idUsuario)
    {
        await using var connection = new MySqlConnection("server=santsystem.ddns.net;port=3312;uid=santsystem;pwd=Sant**3692;database=erp_web;");

        if(connection.State.Equals(ConnectionState.Closed))
            await connection.OpenAsync();
        
        var insertParameter = new StringBuilder(
            """
            INSERT INTO erp_web.ERP_PERMISSAO (NR_LICENCA, ID_EMPRESA, ID_USUARIO, NM_OBJETO, DM_TIPO_PERMISSAO) 
            VALUES (@NrLicenca, 1, @IdUsuario, 'frmERP_Computador.sant', 'X')
            """
        );
        
        var parameters = new DynamicParameters();
        parameters.Add("@NrLicenca", nrLicenca);
        parameters.Add("IdUsuario", idUsuario);
            
        return await connection.ExecuteAsync(insertParameter.ToString(), parameters);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}