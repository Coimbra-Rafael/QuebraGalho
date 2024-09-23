using Microsoft.EntityFrameworkCore;
using QuebraGalho.Relatorios.Data.Implementations;
using QuebraGalho.Relatorios.Models;
using MySqlConnector;
using Dapper;

namespace QuebraGalho.Relatorios.Data.Persistence;

public class RelatorioProdutosVendidosCondensados : IRelatorioProdutosVendidosCondensados
{
    private readonly ErpDbContext _erpDbContext;

    public RelatorioProdutosVendidosCondensados(ErpDbContext erpDbContext)
    {
        _erpDbContext = erpDbContext;
    }

    public async Task<IEnumerable<RelatorioProdutosVendidosCondensadosPorCliente>> GetRelatorioProdutosVendidosCondensados(string nr_licenca, long id_cliente, DateTime dt_inicio, DateTime dt_final)
    {
        using (var connection = new MySqlConnection(_erpDbContext.Database.GetConnectionString()))
        {
			var parametros = new { NR_LICENCA = nr_licenca, ID_PESSOA = id_cliente, DT_INICIO = dt_inicio, DT_FINAL = dt_final };


            var result = await connection.QueryAsync<RelatorioProdutosVendidosCondensadosPorCliente>(@"
					select
						ERP_EMPRESA.NR_LICENCA, 
						ERP_EMPRESA.NM_FANTASIA as NM_FANTASIA_EMPRESA, 
						ERP_EMPRESA.NM_RAZAO_SOCIAL as NM_RAZAO_SOCIAL_EMPRESA,
						ERP_EMPRESA.NR_CNPJ as DS_CPF_CNPJ_EMPRESA, 
						ERP_EMPRESA.DS_ENDERECO as DS_ENDERECO_EMPRESA, 
						ERP_EMPRESA.DS_BAIRRO as DS_BAIRRO_EMPRESA,
						ERP_EMPRESA.NR_TELEFONE as NR_TELEFONE_EMPRESA,
						ERP_EMPRESA.DS_EMAIL as DS_EMAIL_EMPRESA,
						MUN_EMP.DS_MUNICIPIO as DS_MUNICIPIO_EMPRESA,
						ERP_PESSOA.NM_RAZAO_SOCIAL, 
						ERP_PESSOA.NR_CNPJ_CPF as DS_CPF_CNPJ, 
						ERP_PESSOA.DS_ENDERECO, 
						ERP_PESSOA.DS_BAIRRO,
						ERP_PESSOA.NR_TELEFONE, 
						ERP_PESSOA.DS_EMAIL,
						ERP_MUNICIPIO.DS_MUNICIPIO,
					 	ERP_MOVIMENTO.ID_MOVIMENTO, 
						ERP_MOVIMENTO.NR_VENDA, 
						ERP_MOVIMENTO.DT_EMISSAO, 
					 	ERP_MOVIMENTO_ITEM.NR_ITEM, 
						ERP_MOVIMENTO_ITEM.ID_PRODUTOS_CODIGOS, 
						ERP_MOVIMENTO_ITEM.DS_PRODUTO_SERVICO,
						SUM(ERP_MOVIMENTO_ITEM.QUANTIDADE) as QUANTIDADE, 
						ERP_MOVIMENTO_ITEM.VL_UNITARIO,
						ERP_MOVIMENTO_ITEM.VL_UNITARIO * SUM(ERP_MOVIMENTO_ITEM.QUANTIDADE) as VL_SUBTOTAL, 
						0 as VL_TOTAL,
						0 as VL_TOTAL_QUANTIDADE
					from
						ERP_MOVIMENTO_ITEM,
					     ERP_MOVIMENTO,
					     ERP_EMPRESA,
					     ERP_PESSOA,
					     ERP_MUNICIPIO MUN_EMP,
					     ERP_MUNICIPIO
					where
						ERP_MOVIMENTO_ITEM.NR_LICENCA = ERP_MOVIMENTO.NR_LICENCA
						and ERP_MOVIMENTO_ITEM.ID_MOVIMENTO = ERP_MOVIMENTO.ID_MOVIMENTO
						and ERP_MOVIMENTO.NR_LICENCA = ERP_EMPRESA.NR_LICENCA
						and ERP_MOVIMENTO.ID_EMPRESA = ERP_EMPRESA.ID_EMPRESA
						and ERP_MOVIMENTO.NR_LICENCA = ERP_PESSOA.NR_LICENCA
						and ERP_MOVIMENTO.ID_PESSOA = ERP_PESSOA.ID_PESSOA
						and ERP_EMPRESA.ID_MUNICIPIO = MUN_EMP.ID_MUNICIPIO
						and ERP_PESSOA.ID_MUNICIPIO = ERP_MUNICIPIO.ID_MUNICIPIO
						and ERP_MOVIMENTO.NR_LICENCA = @NR_LICENCA
						and ERP_MOVIMENTO.ID_PESSOA = @ID_PESSOA
						and ERP_MOVIMENTO.DT_EMISSAO between @DT_INICIO and @DT_FINAL
						and ERP_MOVIMENTO.DM_CANCELAMENTO <> 'S'
				group by
					ERP_MOVIMENTO_ITEM.ID_PRODUTO_SERVICO,
					ERP_MOVIMENTO_ITEM.ID_PRODUTOS_CODIGOS
				order by
					VL_SUBTOTAL desc ", parametros).ConfigureAwait(true);


			return result;
        }
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
