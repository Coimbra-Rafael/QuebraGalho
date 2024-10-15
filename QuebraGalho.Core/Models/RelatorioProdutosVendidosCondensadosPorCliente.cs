using System.ComponentModel.DataAnnotations;

namespace QuebraGalho.Core.Models;

public  class RelatorioProdutosVendidosCondensadosPorCliente : IDisposable
{
    [Key]
    public string NR_LICENCA { get; set; }
    [Key]
    public long NR_ITEM { get; set; } 
    [Key]
    public long ID_MOVIMENTO { get; set; } 

    public string DS_MUNICIPIO { get; set; }
    public string DS_BAIRRO_EMPRESA { get; set; }
    public string DS_EMAIL_EMPRESA { get; set; }
    public string DS_CPF_CNPJ { get; set; }
    public string NM_RAZAO_SOCIAL { get; set; }
    public string DS_MUNICIPIO_EMPRESA { get; set; }
    public string DS_EMAIL { get; set; }
    public string NR_TELEFONE { get; set; }
    public string NR_TELEFONE_EMPRESA { get; set; }
    public string DS_BAIRRO { get; set; }
    public string DS_ENDERECO_EMPRESA { get; set; }
    public string DS_ENDERECO { get; set; }
    public string NR_VENDA { get; set; }
    public string DS_CPF_CNPJ_EMPRESA { get; set; }
    public string NM_FANTASIA_EMPRESA { get; set; }
    public string ID_PRODUTOS_CODIGOS { get; set; }
    public string DS_PRODUTO_SERVICO { get; set; }
    public decimal QUANTIDADE { get; set; }
    public decimal VL_UNITARIO { get; set; }
    public decimal VL_SUBTOTAL { get; set; }
    public decimal VL_TOTAL { get; set; }
    public string NM_RAZAO_SOCIAL_EMPRESA { get; set; }
    public decimal VL_TOTAL_QUANTIDADE { get; set; }

    public  void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
