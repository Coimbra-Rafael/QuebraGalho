using System.Data;
using System.Text;
using Dapper;
using MySqlConnector;
using QuebraGalho.Core.Entities;
using QuebraGalho.Infrastructure.Repository.Interfaces;

namespace QuebraGalho.Infrastructure.Repository;

public class ProdutosRepository: IProdutosRepository
{
    public async Task<IEnumerable<ErpProdutoServico>> GetAllProductsAsync(string nrLicenca)
    {
        await using var connection = new MySqlConnection("server=santsystem.ddns.net;port=3312;uid=santsystem;pwd=Sant**3692;database=erp_web;");

        if(connection.State.Equals(ConnectionState.Closed))
            await connection.OpenAsync();

        var selectProdutosByLicneca = new StringBuilder(
            """
            SELECT 
                ERP_PRODUTO_SERVICO.NR_LICENCA AS NrLicenca, 
                ERP_PRODUTO_SERVICO.ID_PRODUTO_SERVICO AS IdProdutoServico, 
                ERP_PRODUTO_SERVICO.CD_PRODUTO_SERVICO AS CdProdutoServico 
            FROM ERP_PRODUTO_SERVICO  
            WHERE ERP_PRODUTO_SERVICO.NR_LICENCA = @NrLicenca 
            """
        );

        var parameter = new DynamicParameters();
        parameter.Add("NrLicenca", nrLicenca);
        
        return await connection.QueryAsync<ErpProdutoServico>(selectProdutosByLicneca.ToString(), parameter);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}