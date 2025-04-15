using System.Data;
using System.Text;
using Dapper;
using MySqlConnector;
using QuebraGalho.Core.Entities;
using QuebraGalho.Infrastructure.Repository.Interfaces;

namespace QuebraGalho.Infrastructure.Repository;

public class ProdutosCodigosRepository : IProdutosCodigosRepository
{
    public async Task<ErpProdutoServicoCodigo> GetProdutoCodigoByCodigoAsync(string nrLicenca, string codigo)
    {
        await using var connection = new MySqlConnection("server=santsystem.ddns.net;port=3312;uid=santsystem;pwd=Sant**3692;database=erp_web;");

        if(connection.State.Equals(ConnectionState.Closed))
            await connection.OpenAsync();

        var selectProdutosCodigos = new StringBuilder(
            """
            SELECT
                ERP_PRODUTO_SERVICO_CODIGOS.NR_LICENCA AS NrLicenca,
                ERP_PRODUTO_SERVICO_CODIGOS.ID_PRODUTO_SERVICO AS IdProdutoServico,
                ERP_PRODUTO_SERVICO_CODIGOS.ID_PRODUTOS_CODIGOS AS IdProdutosCodigos,
                ERP_PRODUTO_SERVICO_CODIGOS.DM_CODIGO_PRINCIPAL AS DmCodigoPrincipal,
                ERP_PRODUTO_SERVICO_CODIGOS.ID_TABELA_PRECO AS IdTabelaPreco
            FROM ERP_PRODUTO_SERVICO_CODIGOS
            WHERE ERP_PRODUTO_SERVICO_CODIGOS.NR_LICENCA = @NrLicenca
            AND ERP_PRODUTO_SERVICO_CODIGOS.ID_PRODUTOS_CODIGOS = @IdProdutosCodigos
            """
        );

        var parameter = new DynamicParameters();
        parameter.Add("@NrLicenca", nrLicenca);
        parameter.Add("@IdProdutosCodigos", codigo);
        
        return (await connection.QueryFirstOrDefaultAsync<ErpProdutoServicoCodigo>(selectProdutosCodigos.ToString(), parameter))!;
    }

    public async Task<bool> DefinirCodigoPrincialAsync(ErpProdutoServicoCodigo produtoCodigo)
    {
        await using var connection = new MySqlConnection("server=santsystem.ddns.net;port=3312;uid=santsystem;pwd=Sant**3692;database=erp_web;");

        if(connection.State.Equals(ConnectionState.Closed))
            await connection.OpenAsync();

        var updateCodigoPrincipal = new StringBuilder(
            """
            UPDATE ERP_PRODUTO_SERVICO_CODIGOS 
            SET ERP_PRODUTO_SERVICO_CODIGOS.DM_CODIGO_PRINCIPAL = 'S'
            WHERE ERP_PRODUTO_SERVICO_CODIGOS.NR_LICENCA = @NrLicenca 
              AND ERP_PRODUTO_SERVICO_CODIGOS.ID_PRODUTOS_CODIGOS = @IdProdutoCodigo 
            """
        );
        var parameter = new DynamicParameters();
        parameter.Add("NrLicenca", produtoCodigo.NrLicenca);
        parameter.Add("@IdProdutoCodigo", produtoCodigo.IdProdutosCodigos);

        var result = await connection.ExecuteAsync(updateCodigoPrincipal.ToString(), parameter);
        return result > 0;
    }
    
    public void Dispose()
    {
        GC.SuppressFinalize(this);   
    }
}