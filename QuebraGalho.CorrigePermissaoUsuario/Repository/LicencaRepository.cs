using System.Data;
using System.Text;
using Dapper;
using MySqlConnector;
using QuebraGalho.Core.Entities;
using QuebraGalho.Infrastructure.Repository.Implementation;

namespace QuebraGalho.Infrastructure.Repository;

public class LicencaRepository : ILicencaRepository
{
    public async Task<IEnumerable<ErpLicenca>> GetAllLicencas()
    {
        await using var connection = new MySqlConnection("server=santsystem.ddns.net;port=3312;uid=santsystem;pwd=Sant**3692;database=erp_web;");

        if(connection.State.Equals(ConnectionState.Closed))
            await connection.OpenAsync();

        var selectLicencas = new StringBuilder("SELECT ERP_LICENCA.NR_LICENCA AS NrLicenca FROM ERP_LICENCA");
        return await  connection.QueryAsync<ErpLicenca>(selectLicencas.ToString());
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}