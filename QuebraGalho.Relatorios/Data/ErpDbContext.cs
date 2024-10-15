using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using QuebraGalho.Core.Entities;

namespace QuebraGalho.Relatorios.Data;

public partial class ErpDbContext : DbContext
{
    public ErpDbContext()
    {
    }

    public ErpDbContext(DbContextOptions<ErpDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CartoesBandeira> CartoesBandeiras { get; set; }

    public virtual DbSet<ErpAlmoxarifado> ErpAlmoxarifados { get; set; }

    public virtual DbSet<ErpArquivo> ErpArquivos { get; set; }

    public virtual DbSet<ErpArquivoBalanca> ErpArquivoBalancas { get; set; }

    public virtual DbSet<ErpAtividadePessoa> ErpAtividadePessoas { get; set; }

    public virtual DbSet<ErpBancoCarteira> ErpBancoCarteiras { get; set; }

    public virtual DbSet<ErpBancoContaSaldo> ErpBancoContaSaldos { get; set; }

    public virtual DbSet<ErpBancoContum> ErpBancoConta { get; set; }

    public virtual DbSet<ErpBancoFebraban> ErpBancoFebrabans { get; set; }

    public virtual DbSet<ErpBoleto> ErpBoletos { get; set; }

    public virtual DbSet<ErpCaixaMovimento> ErpCaixaMovimentos { get; set; }

    public virtual DbSet<ErpCaixaMovimentoSangriaAporte> ErpCaixaMovimentoSangriaAportes { get; set; }

    public virtual DbSet<ErpCaixaMovimentoVenda> ErpCaixaMovimentoVendas { get; set; }

    public virtual DbSet<ErpCaracteristica> ErpCaracteristicas { get; set; }

    public virtual DbSet<ErpCategoriaProduto> ErpCategoriaProdutos { get; set; }

    public virtual DbSet<ErpCest> ErpCests { get; set; }

    public virtual DbSet<ErpClassificacaoFiscal> ErpClassificacaoFiscals { get; set; }

    public virtual DbSet<ErpCmd> ErpCmds { get; set; }

    public virtual DbSet<ErpComputador> ErpComputadors { get; set; }

    public virtual DbSet<ErpCondicaoPagamento> ErpCondicaoPagamentos { get; set; }

    public virtual DbSet<ErpCondicaoPagamentoDetalhe> ErpCondicaoPagamentoDetalhes { get; set; }

    public virtual DbSet<ErpConfigEmpresa> ErpConfigEmpresas { get; set; }

    public virtual DbSet<ErpConfigEmpresaMail> ErpConfigEmpresaMails { get; set; }

    public virtual DbSet<ErpConfigEmpresaModulo> ErpConfigEmpresaModulos { get; set; }

    public virtual DbSet<ErpConfigEmpresaScantech> ErpConfigEmpresaScanteches { get; set; }

    public virtual DbSet<ErpConfigEmpresaYandeh> ErpConfigEmpresaYandehs { get; set; }

    public virtual DbSet<ErpCor> ErpCors { get; set; }

    public virtual DbSet<ErpDispositivosMovei> ErpDispositivosMoveis { get; set; }

    public virtual DbSet<ErpEmpresa> ErpEmpresas { get; set; }

    public virtual DbSet<ErpEmpresaLogotipo> ErpEmpresaLogotipos { get; set; }

    public virtual DbSet<ErpEntradaArquivoXml> ErpEntradaArquivoXmls { get; set; }

    public virtual DbSet<ErpEntradaGem> ErpEntradaGems { get; set; }

    public virtual DbSet<ErpEntradaGemFinanceiro> ErpEntradaGemFinanceiros { get; set; }

    public virtual DbSet<ErpEntradaGemItem> ErpEntradaGemItems { get; set; }

    public virtual DbSet<ErpEntradaGemItemKardex> ErpEntradaGemItemKardices { get; set; }

    public virtual DbSet<ErpEntradaGemItemLote> ErpEntradaGemItemLotes { get; set; }

    public virtual DbSet<ErpEntradaGemItemRateio> ErpEntradaGemItemRateios { get; set; }

    public virtual DbSet<ErpEntradaGemRateio> ErpEntradaGemRateios { get; set; }

    public virtual DbSet<ErpEntradaTipoRateio> ErpEntradaTipoRateios { get; set; }

    public virtual DbSet<ErpEtiquetaDado> ErpEtiquetaDados { get; set; }

    public virtual DbSet<ErpEtiquetaImpressao> ErpEtiquetaImpressaos { get; set; }

    public virtual DbSet<ErpEtiquetum> ErpEtiqueta { get; set; }

    public virtual DbSet<ErpFechamentoDiarioScantech> ErpFechamentoDiarioScanteches { get; set; }

    public virtual DbSet<ErpFrameworkCampo> ErpFrameworkCampos { get; set; }

    public virtual DbSet<ErpFrameworkPesq> ErpFrameworkPesqs { get; set; }

    public virtual DbSet<ErpFrameworkPesqCampo> ErpFrameworkPesqCampos { get; set; }

    public virtual DbSet<ErpFrameworkTabela> ErpFrameworkTabelas { get; set; }

    public virtual DbSet<ErpGestaoPreco> ErpGestaoPrecos { get; set; }

    public virtual DbSet<ErpGrupoDespesa> ErpGrupoDespesas { get; set; }

    public virtual DbSet<ErpGrupoPessoa> ErpGrupoPessoas { get; set; }

    public virtual DbSet<ErpGrupoPrecoProduto> ErpGrupoPrecoProdutos { get; set; }

    public virtual DbSet<ErpGrupoProduto> ErpGrupoProdutos { get; set; }

    public virtual DbSet<ErpGrupoReceitum> ErpGrupoReceita { get; set; }

    public virtual DbSet<ErpImagem> ErpImagems { get; set; }

    public virtual DbSet<ErpInventario> ErpInventarios { get; set; }

    public virtual DbSet<ErpInventarioContagemRapidum> ErpInventarioContagemRapida { get; set; }

    public virtual DbSet<ErpInventarioProduto> ErpInventarioProdutos { get; set; }

    public virtual DbSet<ErpInventarioProdutosKardex> ErpInventarioProdutosKardices { get; set; }

    public virtual DbSet<ErpIpsBloqueadosW> ErpIpsBloqueadosWs { get; set; }

    public virtual DbSet<ErpKardex> ErpKardices { get; set; }

    public virtual DbSet<ErpKardexMovimentoEstoqueProduto> ErpKardexMovimentoEstoqueProdutos { get; set; }

    public virtual DbSet<ErpLicenca> ErpLicencas { get; set; }

    public virtual DbSet<ErpLicencaLiberacaoFinanceiro> ErpLicencaLiberacaoFinanceiros { get; set; }

    public virtual DbSet<ErpLicencaSession> ErpLicencaSessions { get; set; }

    public virtual DbSet<ErpLicencasHomologacao> ErpLicencasHomologacaos { get; set; }

    public virtual DbSet<ErpLog> ErpLogs { get; set; }

    public virtual DbSet<ErpLogErroPdv> ErpLogErroPdvs { get; set; }

    public virtual DbSet<ErpLogObjeto> ErpLogObjetos { get; set; }

    public virtual DbSet<ErpMensagemSistema> ErpMensagemSistemas { get; set; }

    public virtual DbSet<ErpMenu> ErpMenus { get; set; }

    public virtual DbSet<ErpModulo> ErpModulos { get; set; }

    public virtual DbSet<ErpMovimento> ErpMovimentos { get; set; }

    public virtual DbSet<ErpMovimentoBanco> ErpMovimentoBancos { get; set; }

    public virtual DbSet<ErpMovimentoCancelamento> ErpMovimentoCancelamentos { get; set; }

    public virtual DbSet<ErpMovimentoConciliacao> ErpMovimentoConciliacaos { get; set; }

    public virtual DbSet<ErpMovimentoCupomReferenciado> ErpMovimentoCupomReferenciados { get; set; }

    public virtual DbSet<ErpMovimentoEstoque> ErpMovimentoEstoques { get; set; }

    public virtual DbSet<ErpMovimentoEstoqueProduto> ErpMovimentoEstoqueProdutos { get; set; }

    public virtual DbSet<ErpMovimentoItem> ErpMovimentoItems { get; set; }

    public virtual DbSet<ErpMovimentoItemKardex> ErpMovimentoItemKardices { get; set; }

    public virtual DbSet<ErpMovimentoItemKardexCancelamento> ErpMovimentoItemKardexCancelamentos { get; set; }

    public virtual DbSet<ErpMovimentoItemLote> ErpMovimentoItemLotes { get; set; }

    public virtual DbSet<ErpMovimentoLogScantech> ErpMovimentoLogScanteches { get; set; }

    public virtual DbSet<ErpMovimentoNotaFiscal> ErpMovimentoNotaFiscals { get; set; }

    public virtual DbSet<ErpMovimentoRecebimento> ErpMovimentoRecebimentos { get; set; }

    public virtual DbSet<ErpMovimentoXmlImportado> ErpMovimentoXmlImportados { get; set; }

    public virtual DbSet<ErpMunicipio> ErpMunicipios { get; set; }

    public virtual DbSet<ErpNaturezaOperacao> ErpNaturezaOperacaos { get; set; }

    public virtual DbSet<ErpNcm> ErpNcms { get; set; }

    public virtual DbSet<ErpObjetoPermissao> ErpObjetoPermissaos { get; set; }

    public virtual DbSet<ErpPai> ErpPais { get; set; }

    public virtual DbSet<ErpParametrosCategorium> ErpParametrosCategoria { get; set; }

    public virtual DbSet<ErpParametrosComputador> ErpParametrosComputadors { get; set; }

    public virtual DbSet<ErpParametrosDefault> ErpParametrosDefaults { get; set; }

    public virtual DbSet<ErpParametrosGrupo> ErpParametrosGrupos { get; set; }

    public virtual DbSet<ErpParametrosLicenca> ErpParametrosLicencas { get; set; }

    public virtual DbSet<ErpParametrosSubgrupo> ErpParametrosSubgrupos { get; set; }

    public virtual DbSet<ErpPedidoCompra> ErpPedidoCompras { get; set; }

    public virtual DbSet<ErpPedidoCompraItem> ErpPedidoCompraItems { get; set; }

    public virtual DbSet<ErpPedidoCotacao> ErpPedidoCotacaos { get; set; }

    public virtual DbSet<ErpPedidoCotacaoItem> ErpPedidoCotacaoItems { get; set; }

    public virtual DbSet<ErpPedidoCotacaoPendente> ErpPedidoCotacaoPendentes { get; set; }

    public virtual DbSet<ErpPedidoCotacaoPendenteFornecedore> ErpPedidoCotacaoPendenteFornecedores { get; set; }

    public virtual DbSet<ErpPedidoCotacaoPendenteItem> ErpPedidoCotacaoPendenteItems { get; set; }

    public virtual DbSet<ErpPedidoVendaCupomReferenciado> ErpPedidoVendaCupomReferenciados { get; set; }

    public virtual DbSet<ErpPedidoVendaGeradoErpMovimento> ErpPedidoVendaGeradoErpMovimentos { get; set; }

    public virtual DbSet<ErpPedidoVendaItem> ErpPedidoVendaItems { get; set; }

    public virtual DbSet<ErpPedidoVendaItemPendente> ErpPedidoVendaItemPendentes { get; set; }

    public virtual DbSet<ErpPedidoVendaParcela> ErpPedidoVendaParcelas { get; set; }

    public virtual DbSet<ErpPedidoVendaPendente> ErpPedidoVendaPendentes { get; set; }

    public virtual DbSet<ErpPedidoVendum> ErpPedidoVenda { get; set; }

    public virtual DbSet<ErpPerfilTributario> ErpPerfilTributarios { get; set; }

    public virtual DbSet<ErpPerfilTributarioCofin> ErpPerfilTributarioCofins { get; set; }

    public virtual DbSet<ErpPerfilTributarioIcm> ErpPerfilTributarioIcms { get; set; }

    public virtual DbSet<ErpPerfilTributarioIcmsSimple> ErpPerfilTributarioIcmsSimples { get; set; }

    public virtual DbSet<ErpPerfilTributarioIpi> ErpPerfilTributarioIpis { get; set; }

    public virtual DbSet<ErpPerfilTributarioPi> ErpPerfilTributarioPis { get; set; }

    public virtual DbSet<ErpPermissao> ErpPermissaos { get; set; }

    public virtual DbSet<ErpPessoa> ErpPessoas { get; set; }

    public virtual DbSet<ErpPessoaCliente> ErpPessoaClientes { get; set; }

    public virtual DbSet<ErpPessoaClienteLiberacaoBloqueio> ErpPessoaClienteLiberacaoBloqueios { get; set; }

    public virtual DbSet<ErpPessoaMigracao> ErpPessoaMigracaos { get; set; }

    public virtual DbSet<ErpPessoaTipo> ErpPessoaTipos { get; set; }

    public virtual DbSet<ErpPessoaUsuario> ErpPessoaUsuarios { get; set; }

    public virtual DbSet<ErpPessoaVendedor> ErpPessoaVendedors { get; set; }

    public virtual DbSet<ErpPolo> ErpPolos { get; set; }

    public virtual DbSet<ErpProducaoFicha> ErpProducaoFichas { get; set; }

    public virtual DbSet<ErpProducaoFichaKardex> ErpProducaoFichaKardices { get; set; }

    public virtual DbSet<ErpProducaoFichaLote> ErpProducaoFichaLotes { get; set; }

    public virtual DbSet<ErpProducaoFichaMateriaPrima> ErpProducaoFichaMateriaPrimas { get; set; }

    public virtual DbSet<ErpProducaoFichaMateriaPrimaKardex> ErpProducaoFichaMateriaPrimaKardices { get; set; }

    public virtual DbSet<ErpProducaoFichaMateriaPrimaLote> ErpProducaoFichaMateriaPrimaLotes { get; set; }

    public virtual DbSet<ErpProdutoLote> ErpProdutoLotes { get; set; }

    public virtual DbSet<ErpProdutoLoteMovimento> ErpProdutoLoteMovimentos { get; set; }

    public virtual DbSet<ErpProdutoSaldo> ErpProdutoSaldos { get; set; }

    public virtual DbSet<ErpProdutoServico> ErpProdutoServicos { get; set; }

    public virtual DbSet<ErpProdutoServicoCaracteristica> ErpProdutoServicoCaracteristicas { get; set; }

    public virtual DbSet<ErpProdutoServicoCodigo> ErpProdutoServicoCodigos { get; set; }

    public virtual DbSet<ErpProdutoServicoCodigoFornecedor> ErpProdutoServicoCodigoFornecedors { get; set; }

    public virtual DbSet<ErpProdutoServicoComponente> ErpProdutoServicoComponentes { get; set; }

    public virtual DbSet<ErpProdutoServicoCorImagem> ErpProdutoServicoCorImagems { get; set; }

    public virtual DbSet<ErpProdutoServicoDesossa> ErpProdutoServicoDesossas { get; set; }

    public virtual DbSet<ErpProdutoServicoDesossaPerdum> ErpProdutoServicoDesossaPerda { get; set; }

    public virtual DbSet<ErpProdutoServicoEcommerce> ErpProdutoServicoEcommerces { get; set; }

    public virtual DbSet<ErpProdutoServicoEmpresaPreco> ErpProdutoServicoEmpresaPrecos { get; set; }

    public virtual DbSet<ErpProdutoServicoFornecedoresCotacao> ErpProdutoServicoFornecedoresCotacaos { get; set; }

    public virtual DbSet<ErpProdutoServicoLock> ErpProdutoServicoLocks { get; set; }

    public virtual DbSet<ErpProdutoServicoMigracao> ErpProdutoServicoMigracaos { get; set; }

    public virtual DbSet<ErpProdutoServicoOutro> ErpProdutoServicoOutros { get; set; }

    public virtual DbSet<ErpProdutoValorMedio> ErpProdutoValorMedios { get; set; }

    public virtual DbSet<ErpPromocao> ErpPromocaos { get; set; }

    public virtual DbSet<ErpPromocaoPack> ErpPromocaoPacks { get; set; }

    public virtual DbSet<ErpPromocaoPacksDescontoVariado> ErpPromocaoPacksDescontoVariados { get; set; }

    public virtual DbSet<ErpPromocaoPacksLevaPaga> ErpPromocaoPacksLevaPagas { get; set; }

    public virtual DbSet<ErpPromocaoPacksPrecoFixo> ErpPromocaoPacksPrecoFixos { get; set; }

    public virtual DbSet<ErpPromocaoProdutosCodigo> ErpPromocaoProdutosCodigos { get; set; }

    public virtual DbSet<ErpPromocaoTipo> ErpPromocaoTipos { get; set; }

    public virtual DbSet<ErpProxCodigo> ErpProxCodigos { get; set; }

    public virtual DbSet<ErpRegraFiscalSat> ErpRegraFiscalSats { get; set; }

    public virtual DbSet<ErpSetor> ErpSetors { get; set; }

    public virtual DbSet<ErpSinc> ErpSincs { get; set; }

    public virtual DbSet<ErpSincCodigo> ErpSincCodigos { get; set; }

    public virtual DbSet<ErpSincEcommerce> ErpSincEcommerces { get; set; }

    public virtual DbSet<ErpSubgrupoDespesa> ErpSubgrupoDespesas { get; set; }

    public virtual DbSet<ErpSubgrupoProduto> ErpSubgrupoProdutos { get; set; }

    public virtual DbSet<ErpSubgrupoReceitum> ErpSubgrupoReceita { get; set; }

    public virtual DbSet<ErpSugestaoCompra> ErpSugestaoCompras { get; set; }

    public virtual DbSet<ErpTabelaPreco> ErpTabelaPrecos { get; set; }

    public virtual DbSet<ErpTabelaPrecoProduto> ErpTabelaPrecoProdutos { get; set; }

    public virtual DbSet<ErpTeste> ErpTestes { get; set; }

    public virtual DbSet<ErpTipoDespesa> ErpTipoDespesas { get; set; }

    public virtual DbSet<ErpTipoMovimentoBanco> ErpTipoMovimentoBancos { get; set; }

    public virtual DbSet<ErpTipoMovimentoEstoque> ErpTipoMovimentoEstoques { get; set; }

    public virtual DbSet<ErpTipoPagamento> ErpTipoPagamentos { get; set; }

    public virtual DbSet<ErpTipoRecebimento> ErpTipoRecebimentos { get; set; }

    public virtual DbSet<ErpTipoReceitum> ErpTipoReceita { get; set; }

    public virtual DbSet<ErpTipoSangriaAporte> ErpTipoSangriaAportes { get; set; }

    public virtual DbSet<ErpTituloGuidsProcessado> ErpTituloGuidsProcessados { get; set; }

    public virtual DbSet<ErpTituloPagar> ErpTituloPagars { get; set; }

    public virtual DbSet<ErpTituloPagarBaixa> ErpTituloPagarBaixas { get; set; }

    public virtual DbSet<ErpTituloPagarBaixaMovimentoBanco> ErpTituloPagarBaixaMovimentoBancos { get; set; }

    public virtual DbSet<ErpTituloReceber> ErpTituloRecebers { get; set; }

    public virtual DbSet<ErpTituloReceberBaixa> ErpTituloReceberBaixas { get; set; }

    public virtual DbSet<ErpTituloReceberBaixaMovimentoBanco> ErpTituloReceberBaixaMovimentoBancos { get; set; }

    public virtual DbSet<ErpTituloReceberBaixaUsuarioConvenio> ErpTituloReceberBaixaUsuarioConvenios { get; set; }

    public virtual DbSet<ErpUf> ErpUfs { get; set; }

    public virtual DbSet<ErpUnidadeMedidum> ErpUnidadeMedida { get; set; }

    public virtual DbSet<ErpUsuario> ErpUsuarios { get; set; }

    public virtual DbSet<ErpUsuario1> ErpUsuarios1 { get; set; }

    public virtual DbSet<ErpUsuarioIp> ErpUsuarioIps { get; set; }

    public virtual DbSet<ErpUsuarioSession> ErpUsuarioSessions { get; set; }

    public virtual DbSet<ErpVendaProduto> ErpVendaProdutos { get; set; }

    public virtual DbSet<ErpVendum> ErpVenda { get; set; }

    public virtual DbSet<ErpWebLog> ErpWebLogs { get; set; }

    public virtual DbSet<PdvCartoesBandeira> PdvCartoesBandeiras { get; set; }

    public virtual DbSet<PdvGrupoTipoRecebimento> PdvGrupoTipoRecebimentos { get; set; }

    public virtual DbSet<PdvTipoRecebimento> PdvTipoRecebimentos { get; set; }

    public virtual DbSet<PdvTipoRecebimentoComputador> PdvTipoRecebimentoComputadors { get; set; }

    public virtual DbSet<ScantechUrl> ScantechUrls { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VersaoArquivo> VersaoArquivos { get; set; }

    public virtual DbSet<VersaoListaArquivo> VersaoListaArquivos { get; set; }

    public virtual DbSet<VersaoSistema> VersaoSistemas { get; set; }

    public virtual DbSet<ViewErpCategoriaProduto> ViewErpCategoriaProdutos { get; set; }

    public virtual DbSet<ViewErpComputador> ViewErpComputadors { get; set; }

    public virtual DbSet<ViewErpEmpresaScantech> ViewErpEmpresaScanteches { get; set; }

    public virtual DbSet<ViewErpProdutoServicoCodigo> ViewErpProdutoServicoCodigos { get; set; }

    public virtual DbSet<ViewErpProdutoServicoPesquisa> ViewErpProdutoServicoPesquisas { get; set; }

    public virtual DbSet<ViewErpSubgrupoProduto> ViewErpSubgrupoProdutos { get; set; }

    public virtual DbSet<YandehProcessamento> YandehProcessamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<CartoesBandeira>(entity =>
        {
            entity.HasKey(e => e.IdBandeira).HasName("PRIMARY");

            entity.ToTable("cartoes_bandeira");

            entity.Property(e => e.IdBandeira)
                .HasMaxLength(60)
                .HasColumnName("ID_BANDEIRA");
            entity.Property(e => e.DsBandeira)
                .HasMaxLength(255)
                .HasColumnName("DS_BANDEIRA");
        });

        modelBuilder.Entity<ErpAlmoxarifado>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdAlmoxarifado })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_almoxarifado");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdAlmoxarifado)
                .HasPrecision(4)
                .HasColumnName("ID_ALMOXARIFADO");
            entity.Property(e => e.DsAlmoxarifado)
                .HasMaxLength(60)
                .HasColumnName("DS_ALMOXARIFADO");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpAlmoxarifados)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_ERP_ALMOXARIFADO");
        });

        modelBuilder.Entity<ErpArquivo>(entity =>
        {
            entity.HasKey(e => e.IdArquivo).HasName("PRIMARY");

            entity.ToTable("erp_arquivo");

            entity.Property(e => e.IdArquivo)
                .HasMaxLength(60)
                .HasColumnName("ID_ARQUIVO");
            entity.Property(e => e.DsArquivo)
                .HasColumnType("mediumtext")
                .HasColumnName("DS_ARQUIVO");
        });

        modelBuilder.Entity<ErpArquivoBalanca>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdArquivo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_arquivo_balanca");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdArquivo)
                .HasMaxLength(60)
                .HasColumnName("ID_ARQUIVO");
            entity.Property(e => e.ConteudoArquivo).HasColumnName("CONTEUDO_ARQUIVO");
            entity.Property(e => e.DmSinc)
                .HasMaxLength(1)
                .HasColumnName("DM_SINC");
            entity.Property(e => e.DthrGeracao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_GERACAO");
        });

        modelBuilder.Entity<ErpAtividadePessoa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdAtividade })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_atividade_pessoa");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdAtividade)
                .HasPrecision(4)
                .HasColumnName("ID_ATIVIDADE");
            entity.Property(e => e.DsAtividade)
                .HasMaxLength(100)
                .HasColumnName("DS_ATIVIDADE");
        });

        modelBuilder.Entity<ErpBancoCarteira>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdCarteira })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_banco_carteira");

            entity.HasIndex(e => new { e.NrLicenca, e.IdBancoConta }, "FK_ERP_BANCO_CONTA_ERP_BANCO_CARTEIRA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdCarteira)
                .HasPrecision(4)
                .HasColumnName("ID_CARTEIRA");
            entity.Property(e => e.DmFluxoCaixa)
                .HasMaxLength(1)
                .HasColumnName("DM_FLUXO_CAIXA");
            entity.Property(e => e.DmImpressaoBoleto)
                .HasMaxLength(1)
                .HasColumnName("DM_IMPRESSAO_BOLETO");
            entity.Property(e => e.DsCarteira)
                .HasMaxLength(100)
                .HasColumnName("DS_CARTEIRA");
            entity.Property(e => e.IdBancoConta)
                .HasPrecision(4)
                .HasColumnName("ID_BANCO_CONTA");
            entity.Property(e => e.NrCarteira)
                .HasMaxLength(10)
                .HasColumnName("NR_CARTEIRA");
            entity.Property(e => e.NrDiasBloqueio)
                .HasPrecision(4)
                .HasColumnName("NR_DIAS_BLOQUEIO");
            entity.Property(e => e.NrNossoNumero)
                .HasPrecision(20)
                .HasColumnName("NR_NOSSO_NUMERO");
            entity.Property(e => e.NrPrazoProtesto)
                .HasPrecision(4)
                .HasColumnName("NR_PRAZO_PROTESTO");
            entity.Property(e => e.NrPrefixo)
                .HasMaxLength(15)
                .HasColumnName("NR_PREFIXO");
            entity.Property(e => e.NrVariacaoCarteira)
                .HasPrecision(4)
                .HasColumnName("NR_VARIACAO_CARTEIRA");
            entity.Property(e => e.VlJurosMensal)
                .HasPrecision(15, 2)
                .HasColumnName("VL_JUROS_MENSAL");

            entity.HasOne(d => d.ErpBancoContum).WithMany(p => p.ErpBancoCarteiras)
                .HasForeignKey(d => new { d.NrLicenca, d.IdBancoConta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_BANCO_CONTA_ERP_BANCO_CARTEIRA");
        });

        modelBuilder.Entity<ErpBancoContaSaldo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdBancoConta, e.DtSaldo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_banco_conta_saldo");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdBancoConta)
                .HasPrecision(4)
                .HasColumnName("ID_BANCO_CONTA");
            entity.Property(e => e.DtSaldo).HasColumnName("DT_SALDO");
            entity.Property(e => e.VlSaldo)
                .HasPrecision(15, 2)
                .HasColumnName("VL_SALDO");

            entity.HasOne(d => d.ErpBancoContum).WithMany(p => p.ErpBancoContaSaldos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdBancoConta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_BANCO_CONTA_SALDO");
        });

        modelBuilder.Entity<ErpBancoContum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdBancoConta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_banco_conta");

            entity.HasIndex(e => e.CodigoBanco, "FK_ERP_BANCO_FEBRABAN_BANCO_CONTA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdBancoConta)
                .HasPrecision(4)
                .HasColumnName("ID_BANCO_CONTA");
            entity.Property(e => e.CodigoBanco)
                .HasMaxLength(5)
                .HasColumnName("CODIGO_BANCO");
            entity.Property(e => e.DsBancoConta)
                .HasMaxLength(100)
                .HasColumnName("DS_BANCO_CONTA");
            entity.Property(e => e.NrAgencia)
                .HasMaxLength(10)
                .HasColumnName("NR_AGENCIA");
            entity.Property(e => e.NrConta)
                .HasMaxLength(10)
                .HasColumnName("NR_CONTA");

            entity.HasOne(d => d.CodigoBancoNavigation).WithMany(p => p.ErpBancoConta)
                .HasForeignKey(d => d.CodigoBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_BANCO_FEBRABAN_BANCO_CONTA");
        });

        modelBuilder.Entity<ErpBancoFebraban>(entity =>
        {
            entity.HasKey(e => e.CodigoBanco).HasName("PRIMARY");

            entity.ToTable("erp_banco_febraban");

            entity.Property(e => e.CodigoBanco)
                .HasMaxLength(5)
                .HasColumnName("CODIGO_BANCO");
            entity.Property(e => e.NomeBanco)
                .HasMaxLength(100)
                .HasColumnName("NOME_BANCO");
        });

        modelBuilder.Entity<ErpBoleto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.GuidBoleto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_boleto");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.GuidBoleto)
                .HasMaxLength(60)
                .HasColumnName("GUID_BOLETO");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(30)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DtVencimento).HasColumnName("DT_VENCIMENTO");
            entity.Property(e => e.NmBoleto)
                .HasMaxLength(255)
                .HasColumnName("NM_BOLETO");
            entity.Property(e => e.NmCliente)
                .HasMaxLength(255)
                .HasColumnName("NM_CLIENTE");
            entity.Property(e => e.VlBoleto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BOLETO");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpBoletos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_BOLETO_ERP_EMPRESA");
        });

        modelBuilder.Entity<ErpCaixaMovimento>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimento, e.NrLicenca, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_caixa_movimento");

            entity.Property(e => e.IdMovimento)
                .HasMaxLength(60)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtAbertura)
                .HasColumnType("datetime")
                .HasColumnName("DT_ABERTURA");
            entity.Property(e => e.DtEncerramento)
                .HasColumnType("datetime")
                .HasColumnName("DT_ENCERRAMENTO");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.VlAbertura)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ABERTURA");
            entity.Property(e => e.VlFechamento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FECHAMENTO");
        });

        modelBuilder.Entity<ErpCaixaMovimentoSangriaAporte>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_caixa_movimento_sangria_aporte");

            entity.HasIndex(e => new { e.IdMovimentoCaixa, e.NrLicenca, e.IdEmpresa }, "FK_ERP_CAIXA_MOVIMENTO_SANGRIA_APORTE");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasMaxLength(60)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DmSangriaAporte)
                .HasMaxLength(1)
                .HasColumnName("DM_SANGRIA_APORTE");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtMovimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_MOVIMENTO");
            entity.Property(e => e.IdMovimentoCaixa)
                .HasMaxLength(60)
                .HasColumnName("ID_MOVIMENTO_CAIXA");
            entity.Property(e => e.IdUsuarioFiscal)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO_FISCAL");
            entity.Property(e => e.VlMovimento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_MOVIMENTO");

            entity.HasOne(d => d.ErpCaixaMovimento).WithMany(p => p.ErpCaixaMovimentoSangriaAportes)
                .HasForeignKey(d => new { d.IdMovimentoCaixa, d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_CAIXA_MOVIMENTO_SANGRIA_APORTE");
        });

        modelBuilder.Entity<ErpCaixaMovimentoVenda>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdVenda })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_caixa_movimento_vendas");

            entity.HasIndex(e => new { e.IdMovimento, e.NrLicenca, e.IdEmpresa }, "FK_ERP_CAIXA_MOVIMENTO_VENDAS");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasMaxLength(60)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdVenda)
                .HasMaxLength(60)
                .HasColumnName("ID_VENDA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");

            entity.HasOne(d => d.ErpCaixaMovimento).WithMany(p => p.ErpCaixaMovimentoVenda)
                .HasForeignKey(d => new { d.IdMovimento, d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_CAIXA_MOVIMENTO_VENDAS");
        });

        modelBuilder.Entity<ErpCaracteristica>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdCaracteristica })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_caracteristica");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdCaracteristica)
                .HasPrecision(4)
                .HasColumnName("ID_CARACTERISTICA");
            entity.Property(e => e.CdCaracteristicaExterno)
                .HasMaxLength(60)
                .HasColumnName("CD_CARACTERISTICA_EXTERNO");
            entity.Property(e => e.DmEnviaEcommerce)
                .HasMaxLength(1)
                .HasColumnName("DM_ENVIA_ECOMMERCE");
            entity.Property(e => e.DsCaracteristica)
                .HasMaxLength(300)
                .HasColumnName("DS_CARACTERISTICA");
        });

        modelBuilder.Entity<ErpCategoriaProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdCategoria })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_categoria_produto");

            entity.HasIndex(e => new { e.NrLicenca, e.IdSubgrupo }, "FK_ERP_SUBGRUPO_CATEGORIA_PRODUTO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdCategoria)
                .HasPrecision(4)
                .HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.DsCategoria)
                .HasMaxLength(60)
                .HasColumnName("DS_CATEGORIA");
            entity.Property(e => e.IdSubgrupo)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO");

            entity.HasOne(d => d.ErpSubgrupoProduto).WithMany(p => p.ErpCategoriaProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdSubgrupo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_SUBGRUPO_CATEGORIA");
        });

        modelBuilder.Entity<ErpCest>(entity =>
        {
            entity.HasKey(e => new { e.CdCest, e.CdNcm })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_cest");

            entity.Property(e => e.CdCest)
                .HasMaxLength(7)
                .HasColumnName("CD_CEST");
            entity.Property(e => e.CdNcm)
                .HasMaxLength(8)
                .HasColumnName("CD_NCM");
        });

        modelBuilder.Entity<ErpClassificacaoFiscal>(entity =>
        {
            entity.HasKey(e => e.CdClassificacao).HasName("PRIMARY");

            entity.ToTable("erp_classificacao_fiscal");

            entity.Property(e => e.CdClassificacao)
                .HasMaxLength(4)
                .HasColumnName("CD_CLASSIFICACAO");
            entity.Property(e => e.DsClassificacao)
                .HasMaxLength(255)
                .HasColumnName("DS_CLASSIFICACAO");
        });

        modelBuilder.Entity<ErpCmd>(entity =>
        {
            entity.HasKey(e => e.IdCmd).HasName("PRIMARY");

            entity.ToTable("erp_cmd");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa }, "FK_ERP_EMPRESA_ERP_CMD");

            entity.Property(e => e.IdCmd)
                .HasPrecision(19)
                .HasColumnName("ID_CMD");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DsCmd)
                .HasMaxLength(100)
                .HasColumnName("DS_CMD");
            entity.Property(e => e.DthrAtual)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_ATUAL");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NmDatacenter)
                .HasMaxLength(60)
                .HasColumnName("NM_DATACENTER");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.Prioridade)
                .HasPrecision(4)
                .HasColumnName("PRIORIDADE");
            entity.Property(e => e.VlCmd)
                .HasMaxLength(2000)
                .HasColumnName("VL_CMD");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpCmds)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_ERP_CMD");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpCmds)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_ERP_CMD");
        });

        modelBuilder.Entity<ErpComputador>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdComputador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_computador");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.DadosVersao)
                .HasMaxLength(60)
                .HasColumnName("DADOS_VERSAO");
            entity.Property(e => e.DmAtivo)
                .HasMaxLength(1)
                .HasColumnName("DM_ATIVO");
            entity.Property(e => e.DmCaixaPrincipal)
                .HasMaxLength(1)
                .HasColumnName("DM_CAIXA_PRINCIPAL");
            entity.Property(e => e.DmTipoComputador)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_COMPUTADOR");
            entity.Property(e => e.DthrUltimoSinc)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_ULTIMO_SINC");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(255)
                .HasColumnName("MAC_ADDRESS");
            entity.Property(e => e.NmComputador)
                .HasMaxLength(255)
                .HasColumnName("NM_COMPUTADOR");
            entity.Property(e => e.NrDocumentoNfce)
                .HasPrecision(9)
                .HasColumnName("NR_DOCUMENTO_NFCE");
            entity.Property(e => e.NrPdv)
                .HasPrecision(10)
                .HasColumnName("NR_PDV");
            entity.Property(e => e.NrSerieNfce)
                .HasPrecision(3)
                .HasColumnName("NR_SERIE_NFCE");
        });

        modelBuilder.Entity<ErpCondicaoPagamento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdCondicaoPagamento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_condicao_pagamento");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTabelaPreco }, "FK_ERP_TABELA_PRECO_CONDICAO_PAGAMENTO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdCondicaoPagamento)
                .HasPrecision(4)
                .HasColumnName("ID_CONDICAO_PAGAMENTO");
            entity.Property(e => e.DsCondicaoPagamento)
                .HasMaxLength(100)
                .HasColumnName("DS_CONDICAO_PAGAMENTO");
            entity.Property(e => e.IdTabelaPreco)
                .HasPrecision(8)
                .HasColumnName("ID_TABELA_PRECO");
            entity.Property(e => e.PercAcrescimo)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_ACRESCIMO");
            entity.Property(e => e.PercComissao)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_COMISSAO");
            entity.Property(e => e.PercDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_DESCONTO");

            entity.HasOne(d => d.ErpTabelaPreco).WithMany(p => p.ErpCondicaoPagamentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTabelaPreco })
                .HasConstraintName("FK_ERP_TABELA_PRECO_CONDICAO_PAGAMENTO");
        });

        modelBuilder.Entity<ErpCondicaoPagamentoDetalhe>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdCondicaoPagamento, e.NrDia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_condicao_pagamento_detalhe");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdCondicaoPagamento)
                .HasPrecision(4)
                .HasColumnName("ID_CONDICAO_PAGAMENTO");
            entity.Property(e => e.NrDia)
                .HasPrecision(4)
                .HasColumnName("NR_DIA");

            entity.HasOne(d => d.ErpCondicaoPagamento).WithMany(p => p.ErpCondicaoPagamentoDetalhes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdCondicaoPagamento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_CONDICAO_PAGAMENTO_PEDIDO_VENDA_DETALHE");
        });

        modelBuilder.Entity<ErpConfigEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_config_empresa");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DmTributacaoAutomatica)
                .HasMaxLength(1)
                .HasColumnName("DM_TRIBUTACAO_AUTOMATICA");
            entity.Property(e => e.DsArquivoLogo)
                .HasMaxLength(100)
                .HasColumnName("DS_ARQUIVO_LOGO");
            entity.Property(e => e.DsCaminhoJasper)
                .HasMaxLength(255)
                .HasColumnName("DS_CAMINHO_JASPER");
            entity.Property(e => e.DsCaminhoLog)
                .HasMaxLength(100)
                .HasColumnName("DS_CAMINHO_LOG");
            entity.Property(e => e.DsCaminhoRsc)
                .HasMaxLength(100)
                .HasColumnName("DS_CAMINHO_RSC");
            entity.Property(e => e.DsCaminhoTmp)
                .HasMaxLength(100)
                .HasColumnName("DS_CAMINHO_TMP");
            entity.Property(e => e.DsUrlCotacao)
                .HasMaxLength(255)
                .HasColumnName("DS_URL_COTACAO");
            entity.Property(e => e.DsUrlNfe)
                .HasMaxLength(255)
                .HasColumnName("DS_URL_NFE");
            entity.Property(e => e.DsUrlTributacao)
                .HasMaxLength(255)
                .HasColumnName("DS_URL_TRIBUTACAO");
            entity.Property(e => e.NrVersaoAplicativo)
                .HasMaxLength(60)
                .HasColumnName("NR_VERSAO_APLICATIVO");

            entity.HasOne(d => d.ErpEmpresa).WithOne(p => p.ErpConfigEmpresa)
                .HasForeignKey<ErpConfigEmpresa>(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_CONFIG_EMPRESA");
        });

        modelBuilder.Entity<ErpConfigEmpresaMail>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.NrLicenca })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_config_empresa_mail");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa }, "FK_ERP_EMPRESA_CONFIG_EMPRESA_MAIL");

            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.DmPopSsl)
                .HasMaxLength(1)
                .HasColumnName("DM_POP_SSL");
            entity.Property(e => e.DmSmtpSsl)
                .HasMaxLength(1)
                .HasColumnName("DM_SMTP_SSL");
            entity.Property(e => e.PopEmail)
                .HasMaxLength(100)
                .HasColumnName("POP_EMAIL");
            entity.Property(e => e.PopPorta)
                .HasMaxLength(5)
                .HasColumnName("POP_PORTA");
            entity.Property(e => e.PopSenha)
                .HasMaxLength(60)
                .HasColumnName("POP_SENHA");
            entity.Property(e => e.PopUsuario)
                .HasMaxLength(60)
                .HasColumnName("POP_USUARIO");
            entity.Property(e => e.SmtpEmail)
                .HasMaxLength(100)
                .HasColumnName("SMTP_EMAIL");
            entity.Property(e => e.SmtpPorta)
                .HasMaxLength(5)
                .HasColumnName("SMTP_PORTA");
            entity.Property(e => e.SmtpRemetente)
                .HasMaxLength(100)
                .HasColumnName("SMTP_REMETENTE");
            entity.Property(e => e.SmtpRemetenteFinanceiro)
                .HasMaxLength(100)
                .HasColumnName("SMTP_REMETENTE_FINANCEIRO");
            entity.Property(e => e.SmtpSenha)
                .HasMaxLength(100)
                .HasColumnName("SMTP_SENHA");
            entity.Property(e => e.SmtpUsuario)
                .HasMaxLength(60)
                .HasColumnName("SMTP_USUARIO");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpConfigEmpresaMails)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_CONFIG_EMPRESA_MAIL");
        });

        modelBuilder.Entity<ErpConfigEmpresaModulo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_config_empresa_modulos");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DmUsaCotacao)
                .HasMaxLength(1)
                .HasColumnName("DM_USA_COTACAO");
            entity.Property(e => e.DmUsaDesossa)
                .HasMaxLength(1)
                .HasColumnName("DM_USA_DESOSSA");
            entity.Property(e => e.DmUsaParametrosAntigo)
                .HasMaxLength(1)
                .HasColumnName("DM_USA_PARAMETROS_ANTIGO");
            entity.Property(e => e.DmUsaProducao)
                .HasMaxLength(1)
                .HasColumnName("DM_USA_PRODUCAO");

            entity.HasOne(d => d.ErpEmpresa).WithOne(p => p.ErpConfigEmpresaModulo)
                .HasForeignKey<ErpConfigEmpresaModulo>(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_CONFIG_MODULOS");
        });

        modelBuilder.Entity<ErpConfigEmpresaScantech>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_config_empresa_scantech");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DmAtivo)
                .HasMaxLength(1)
                .HasColumnName("DM_ATIVO");
            entity.Property(e => e.DtUltimaExecucao)
                .HasColumnType("datetime")
                .HasColumnName("DT_ULTIMA_EXECUCAO");
            entity.Property(e => e.NmPasswordWs)
                .HasMaxLength(60)
                .HasColumnName("NM_PASSWORD_WS");
            entity.Property(e => e.NmUsuarioWs)
                .HasMaxLength(60)
                .HasColumnName("NM_USUARIO_WS");
            entity.Property(e => e.NrEmpresaScantech)
                .HasMaxLength(20)
                .HasColumnName("NR_EMPRESA_SCANTECH");
            entity.Property(e => e.NrLocalScantech)
                .HasMaxLength(20)
                .HasColumnName("NR_LOCAL_SCANTECH");
            entity.Property(e => e.TempoBuscaScantech)
                .HasPrecision(8)
                .HasColumnName("TEMPO_BUSCA_SCANTECH");

            entity.HasOne(d => d.ErpEmpresa).WithOne(p => p.ErpConfigEmpresaScantech)
                .HasForeignKey<ErpConfigEmpresaScantech>(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_CONFIG_SCANTECH");
        });

        modelBuilder.Entity<ErpConfigEmpresaYandeh>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_config_empresa_yandeh");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DsChaveApi)
                .HasMaxLength(60)
                .HasColumnName("DS_CHAVE_API");

            entity.HasOne(d => d.ErpEmpresa).WithOne(p => p.ErpConfigEmpresaYandeh)
                .HasForeignKey<ErpConfigEmpresaYandeh>(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_CONFIG_EMPRESA_YANDEH");
        });

        modelBuilder.Entity<ErpCor>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdCor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_cor");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdCor)
                .HasPrecision(4)
                .HasColumnName("ID_COR");
            entity.Property(e => e.CdCorExterno)
                .HasMaxLength(60)
                .HasColumnName("CD_COR_EXTERNO");
            entity.Property(e => e.DmEnviaEcommerce)
                .HasMaxLength(1)
                .HasColumnName("DM_ENVIA_ECOMMERCE");
            entity.Property(e => e.DsCor)
                .HasMaxLength(20)
                .HasColumnName("DS_COR");
        });

        modelBuilder.Entity<ErpDispositivosMovei>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdImei })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_dispositivos_moveis");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdImei)
                .HasMaxLength(60)
                .HasColumnName("ID_IMEI");
            entity.Property(e => e.DmAtivo)
                .HasMaxLength(1)
                .HasColumnName("DM_ATIVO");
            entity.Property(e => e.DsDispositivo)
                .HasMaxLength(60)
                .HasColumnName("DS_DISPOSITIVO");
            entity.Property(e => e.DthrCadastro)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_CADASTRO");
        });

        modelBuilder.Entity<ErpEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_empresa");

            entity.HasIndex(e => e.IdMunicipio, "FK_ERP_MUNICIPIO_ERP_EMPRESA");

            entity.HasIndex(e => e.IdPais, "FK_ERP_PAIS_ERP_EMPRESA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.CdEmpresa)
                .HasPrecision(8)
                .HasColumnName("CD_EMPRESA");
            entity.Property(e => e.CdUnidade)
                .HasPrecision(8)
                .HasColumnName("CD_UNIDADE");
            entity.Property(e => e.Crt)
                .HasMaxLength(1)
                .HasColumnName("CRT");
            entity.Property(e => e.DsBairro)
                .HasMaxLength(100)
                .HasColumnName("DS_BAIRRO");
            entity.Property(e => e.DsEmail)
                .HasMaxLength(100)
                .HasColumnName("DS_EMAIL");
            entity.Property(e => e.DsEndereco)
                .HasMaxLength(100)
                .HasColumnName("DS_ENDERECO");
            entity.Property(e => e.DsEnderecoCompl)
                .HasMaxLength(20)
                .HasColumnName("DS_ENDERECO_COMPL");
            entity.Property(e => e.IdMunicipio)
                .HasPrecision(8)
                .HasColumnName("ID_MUNICIPIO");
            entity.Property(e => e.IdPais)
                .HasPrecision(4)
                .HasColumnName("ID_PAIS");
            entity.Property(e => e.NmFantasia)
                .HasMaxLength(100)
                .HasColumnName("NM_FANTASIA");
            entity.Property(e => e.NmRazaoSocial)
                .HasMaxLength(100)
                .HasColumnName("NM_RAZAO_SOCIAL");
            entity.Property(e => e.NrCep)
                .HasMaxLength(8)
                .HasColumnName("NR_CEP");
            entity.Property(e => e.NrCnpj)
                .HasMaxLength(20)
                .HasColumnName("NR_CNPJ");
            entity.Property(e => e.NrDdd)
                .HasMaxLength(5)
                .HasColumnName("NR_DDD");
            entity.Property(e => e.NrEndereco)
                .HasMaxLength(10)
                .HasColumnName("NR_ENDERECO");
            entity.Property(e => e.NrInscricaoEstadual)
                .HasMaxLength(20)
                .HasColumnName("NR_INSCRICAO_ESTADUAL");
            entity.Property(e => e.NrTelefone)
                .HasMaxLength(15)
                .HasColumnName("NR_TELEFONE");

            entity.HasOne(d => d.IdMunicipioNavigation).WithMany(p => p.ErpEmpresas)
                .HasForeignKey(d => d.IdMunicipio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MUNICIPIO_ERP_EMPRESA");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.ErpEmpresas)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PAIS_ERP_EMPRESA");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpEmpresas)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_ERP_EMPRESA");
        });

        modelBuilder.Entity<ErpEmpresaLogotipo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_empresa_logotipo");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.ConteudoArquivo).HasColumnName("CONTEUDO_ARQUIVO");
            entity.Property(e => e.NmArquivo)
                .HasMaxLength(255)
                .HasColumnName("NM_ARQUIVO");

            entity.HasOne(d => d.ErpEmpresa).WithOne(p => p.ErpEmpresaLogotipo)
                .HasForeignKey<ErpEmpresaLogotipo>(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_LOGOTIPO");
        });

        modelBuilder.Entity<ErpEntradaArquivoXml>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdArquivo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_entrada_arquivo_xml");

            entity.HasIndex(e => new { e.NrLicenca, e.NrChaveAcesso }, "IDX_001_ERP_ENTRADA_ARQUIVO_XML");

            entity.HasIndex(e => new { e.NrLicenca, e.IdSinc }, "IDX_002_ERP_ENTRADA_ARQUIVO_XML");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdArquivo)
                .HasMaxLength(60)
                .HasColumnName("ID_ARQUIVO");
            entity.Property(e => e.DmProcessado)
                .HasMaxLength(1)
                .HasColumnName("DM_PROCESSADO");
            entity.Property(e => e.DtEmissaoDocumento).HasColumnName("DT_EMISSAO_DOCUMENTO");
            entity.Property(e => e.IdSinc)
                .HasPrecision(20)
                .HasColumnName("ID_SINC");
            entity.Property(e => e.NmPessoaEmitente)
                .HasMaxLength(120)
                .HasColumnName("NM_PESSOA_EMITENTE");
            entity.Property(e => e.NrChaveAcesso)
                .HasMaxLength(44)
                .HasColumnName("NR_CHAVE_ACESSO");
            entity.Property(e => e.NrCnpjEmitente)
                .HasMaxLength(14)
                .HasColumnName("NR_CNPJ_EMITENTE");
            entity.Property(e => e.NrDocumento)
                .HasMaxLength(20)
                .HasColumnName("NR_DOCUMENTO");
            entity.Property(e => e.VlNotaFiscal)
                .HasPrecision(15, 2)
                .HasColumnName("VL_NOTA_FISCAL");
        });

        modelBuilder.Entity<ErpEntradaGem>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGem, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_entrada_gem");

            entity.HasIndex(e => new { e.NrLicenca, e.IdNaturezaOperacao }, "FK_ERP_NATUREZA_OPERACAO_ENTRADA_GEM");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoa }, "FK_ERP_PESSOA_ENTRADA_GEM");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.CdModeloDocumento)
                .HasMaxLength(2)
                .HasColumnName("CD_MODELO_DOCUMENTO");
            entity.Property(e => e.DmImportadoXml)
                .HasMaxLength(1)
                .HasColumnName("DM_IMPORTADO_XML");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DtAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("DT_ATUALIZACAO");
            entity.Property(e => e.DtDocumento)
                .HasColumnType("datetime")
                .HasColumnName("DT_DOCUMENTO");
            entity.Property(e => e.DtRecebimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_RECEBIMENTO");
            entity.Property(e => e.IdAlmoxarifado)
                .HasPrecision(4)
                .HasColumnName("ID_ALMOXARIFADO");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.NrChaveAcesso)
                .HasMaxLength(44)
                .HasColumnName("NR_CHAVE_ACESSO");
            entity.Property(e => e.NrDocumento)
                .HasMaxLength(9)
                .HasColumnName("NR_DOCUMENTO");
            entity.Property(e => e.NrDocumentoExterno)
                .HasMaxLength(60)
                .HasColumnName("NR_DOCUMENTO_EXTERNO");
            entity.Property(e => e.NrSerie)
                .HasMaxLength(6)
                .HasColumnName("NR_SERIE");
            entity.Property(e => e.VlAcrescimoFinanceiro)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ACRESCIMO_FINANCEIRO");
            entity.Property(e => e.VlDescontoFinanceiro)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESCONTO_FINANCEIRO");
            entity.Property(e => e.VlNotaFiscal)
                .HasPrecision(15, 2)
                .HasColumnName("VL_NOTA_FISCAL");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpEntradaGems)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_ERP_GEM");

            entity.HasOne(d => d.ErpNaturezaOperacao).WithMany(p => p.ErpEntradaGems)
                .HasForeignKey(d => new { d.NrLicenca, d.IdNaturezaOperacao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_NATUREZA_OPERACAO_ENTRADA_GEM");

            entity.HasOne(d => d.ErpPessoa).WithMany(p => p.ErpEntradaGems)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PESSOA_ENTRADA_GEM");
        });

        modelBuilder.Entity<ErpEntradaGemFinanceiro>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdGem, e.DtVencimento, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_entrada_gem_financeiro");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGem, e.IdEmpresa }, "FK_ERP_GEM_FINANCEIRO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoDespesa }, "FK_ERP_TIPO_DESPESA_GEM_FINANCEIRO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.DtVencimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_VENCIMENTO");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdTipoDespesa)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_DESPESA");
            entity.Property(e => e.NrDocumento)
                .HasMaxLength(20)
                .HasColumnName("NR_DOCUMENTO");
            entity.Property(e => e.VlDuplicata)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DUPLICATA");

            entity.HasOne(d => d.ErpTipoDespesa).WithMany(p => p.ErpEntradaGemFinanceiros)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoDespesa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_DESPESA_GEM_FINANCEIRO");

            entity.HasOne(d => d.ErpEntradaGem).WithMany(p => p.ErpEntradaGemFinanceiros)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGem, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_GEM_FINANCEIRO");
        });

        modelBuilder.Entity<ErpEntradaGemItem>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGem, e.IdEmpresa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_entrada_gem_item");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_GEM_ITEM");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.AliqCofins)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_COFINS");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS");
            entity.Property(e => e.AliqIcmsSt)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS_ST");
            entity.Property(e => e.AliqIpi)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_IPI");
            entity.Property(e => e.AliqIss)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ISS");
            entity.Property(e => e.AliqPis)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_PIS");
            entity.Property(e => e.CdClassificacaoFiscal)
                .HasMaxLength(4)
                .HasColumnName("CD_CLASSIFICACAO_FISCAL");
            entity.Property(e => e.CdServico)
                .HasMaxLength(20)
                .HasColumnName("CD_SERVICO");
            entity.Property(e => e.CstCofins)
                .HasMaxLength(2)
                .HasColumnName("CST_COFINS");
            entity.Property(e => e.CstCsosnIcms)
                .HasMaxLength(3)
                .HasColumnName("CST_CSOSN_ICMS");
            entity.Property(e => e.CstIpi)
                .HasMaxLength(2)
                .HasColumnName("CST_IPI");
            entity.Property(e => e.CstPis)
                .HasMaxLength(2)
                .HasColumnName("CST_PIS");
            entity.Property(e => e.DescricaoItemXml)
                .HasMaxLength(120)
                .HasColumnName("DESCRICAO_ITEM_XML");
            entity.Property(e => e.DmOrigem)
                .HasMaxLength(1)
                .HasColumnName("DM_ORIGEM");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.PercDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_DESCONTO");
            entity.Property(e => e.PercMva)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_MVA");
            entity.Property(e => e.PesoUnitario)
                .HasPrecision(15, 4)
                .HasColumnName("PESO_UNITARIO");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");
            entity.Property(e => e.QuantidadeFator)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE_FATOR");
            entity.Property(e => e.VlBaseCofins)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_COFINS");
            entity.Property(e => e.VlBaseIcms)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS");
            entity.Property(e => e.VlBaseIcmsSt)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS_ST");
            entity.Property(e => e.VlBaseIpi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_IPI");
            entity.Property(e => e.VlBasePis)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_PIS");
            entity.Property(e => e.VlCofins)
                .HasPrecision(15, 2)
                .HasColumnName("VL_COFINS");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESCONTO");
            entity.Property(e => e.VlDespesasAcessorias)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESPESAS_ACESSORIAS");
            entity.Property(e => e.VlFcp)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FCP");
            entity.Property(e => e.VlFrete)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FRETE");
            entity.Property(e => e.VlIcms)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS");
            entity.Property(e => e.VlIcmsSt)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_ST");
            entity.Property(e => e.VlIpi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_IPI");
            entity.Property(e => e.VlIss)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ISS");
            entity.Property(e => e.VlPis)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PIS");
            entity.Property(e => e.VlProdutos)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRODUTOS");
            entity.Property(e => e.VlTotalItem)
                .HasPrecision(15, 2)
                .HasColumnName("VL_TOTAL_ITEM");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(15, 4)
                .HasColumnName("VL_UNITARIO");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpEntradaGemItems)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_GEM_ITEM");

            entity.HasOne(d => d.ErpEntradaGem).WithMany(p => p.ErpEntradaGemItems)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGem, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_GEM_GEM_ITEM");
        });

        modelBuilder.Entity<ErpEntradaGemItemKardex>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGem, e.IdEmpresa, e.NrItem, e.IdKardex })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_entrada_gem_item_kardex");

            entity.HasIndex(e => new { e.NrLicenca, e.IdKardex }, "FK_ERP_KARDEX_ENTRADA_ITEM");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");

            entity.HasOne(d => d.ErpKardex).WithMany(p => p.ErpEntradaGemItemKardices)
                .HasForeignKey(d => new { d.NrLicenca, d.IdKardex })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_KARDEX_ENTRADA_ITEM");

            entity.HasOne(d => d.ErpEntradaGemItem).WithMany(p => p.ErpEntradaGemItemKardices)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGem, d.IdEmpresa, d.NrItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ENTRADA_GEM_ITEM_KARDEX");
        });

        modelBuilder.Entity<ErpEntradaGemItemLote>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGem, e.IdEmpresa, e.NrItem, e.IdSerialLote })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_entrada_gem_item_lote");

            entity.HasIndex(e => new { e.NrLicenca, e.IdSerialLote }, "FK_ERP_PRODUTO_LOTE_ITEM_LOTE");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdSerialLote)
                .HasMaxLength(60)
                .HasColumnName("ID_SERIAL_LOTE");

            entity.HasOne(d => d.ErpProdutoLote).WithMany(p => p.ErpEntradaGemItemLotes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdSerialLote })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_LOTE_ITEM_LOTE");

            entity.HasOne(d => d.ErpEntradaGemItem).WithMany(p => p.ErpEntradaGemItemLotes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGem, d.IdEmpresa, d.NrItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ENTRADA_GEM_ITEM_LOTE");
        });

        modelBuilder.Entity<ErpEntradaGemItemRateio>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdGem, e.NrItem, e.IdTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_entrada_gem_item_rateio");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGem, e.IdEmpresa, e.NrItem }, "FK_ERP_ENTRADA_GEM_ITEM_RATEIO");

            entity.HasIndex(e => e.IdGem, "ID_GEM");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdTipo)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO");
            entity.Property(e => e.VlRateio)
                .HasPrecision(15, 2)
                .HasColumnName("VL_RATEIO");

            entity.HasOne(d => d.ErpEntradaGemItem).WithMany(p => p.ErpEntradaGemItemRateios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGem, d.IdEmpresa, d.NrItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ENTRADA_GEM_ITEM_RATEIO");
        });

        modelBuilder.Entity<ErpEntradaGemRateio>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdGem, e.IdTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_entrada_gem_rateio");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGem, e.IdEmpresa }, "FK_ERP_ENTRADA_GEM_RATEIO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipo }, "FK_ERP_ENTRADA_TIPO_RATEIO_ENTRADA_GEM_RATEIO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.IdTipo)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.VlRateio)
                .HasPrecision(15, 2)
                .HasColumnName("VL_RATEIO");

            entity.HasOne(d => d.ErpEntradaTipoRateio).WithMany(p => p.ErpEntradaGemRateios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ENTRADA_TIPO_RATEIO_ENTRADA_GEM_RATEIO");

            entity.HasOne(d => d.ErpEntradaGem).WithMany(p => p.ErpEntradaGemRateios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGem, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ENTRADA_GEM_RATEIO");
        });

        modelBuilder.Entity<ErpEntradaTipoRateio>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_entrada_tipo_rateio");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipo)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO");
            entity.Property(e => e.DsTipo)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO");
        });

        modelBuilder.Entity<ErpEtiquetaDado>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEtiqueta, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_etiqueta_dados");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(60)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEtiqueta)
                .HasPrecision(8)
                .HasColumnName("ID_ETIQUETA");
            entity.Property(e => e.NrItem)
                .HasPrecision(8)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.Altcbar)
                .HasMaxLength(10)
                .HasColumnName("ALTCBAR");
            entity.Property(e => e.Eixox)
                .HasMaxLength(10)
                .HasColumnName("EIXOX");
            entity.Property(e => e.Eixoy)
                .HasMaxLength(10)
                .HasColumnName("EIXOY");
            entity.Property(e => e.Lbarf)
                .HasMaxLength(10)
                .HasColumnName("LBARF");
            entity.Property(e => e.Lbarlar)
                .HasMaxLength(10)
                .HasColumnName("LBARLAR");
            entity.Property(e => e.Origem)
                .HasMaxLength(10)
                .HasColumnName("ORIGEM");
            entity.Property(e => e.Tipcb)
                .HasMaxLength(10)
                .HasColumnName("TIPCB");
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .HasColumnName("TITULO");

            entity.HasOne(d => d.ErpEtiquetum).WithMany(p => p.ErpEtiquetaDados)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEtiqueta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ETIQUETA_DADOS");
        });

        modelBuilder.Entity<ErpEtiquetaImpressao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdImpressao })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_etiqueta_impressao");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(60)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdImpressao)
                .HasMaxLength(60)
                .HasColumnName("ID_IMPRESSAO");
            entity.Property(e => e.DmSinc)
                .HasMaxLength(1)
                .HasColumnName("DM_SINC");
            entity.Property(e => e.DsProdutoServico)
                .HasMaxLength(255)
                .HasColumnName("DS_PRODUTO_SERVICO");
            entity.Property(e => e.IdEtiqueta)
                .HasPrecision(8)
                .HasColumnName("ID_ETIQUETA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.IdUnidade)
                .HasMaxLength(6)
                .HasColumnName("ID_UNIDADE");
            entity.Property(e => e.QtdeImpressao)
                .HasPrecision(8)
                .HasColumnName("QTDE_IMPRESSAO");
            entity.Property(e => e.VlProduto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRODUTO");
        });

        modelBuilder.Entity<ErpEtiquetum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEtiqueta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_etiqueta");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(60)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEtiqueta)
                .HasPrecision(8)
                .HasColumnName("ID_ETIQUETA");
            entity.Property(e => e.Colunas)
                .HasPrecision(8)
                .HasColumnName("COLUNAS");
            entity.Property(e => e.Distancia)
                .HasMaxLength(10)
                .HasColumnName("DISTANCIA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NmEtiqueta)
                .HasMaxLength(60)
                .HasColumnName("NM_ETIQUETA");
            entity.Property(e => e.QtdeCaracterLinha2)
                .HasPrecision(8)
                .HasColumnName("QTDE_CARACTER_LINHA2");
            entity.Property(e => e.QtdeCaracterLinha6)
                .HasPrecision(8)
                .HasColumnName("QTDE_CARACTER_LINHA6");
            entity.Property(e => e.Resolucao)
                .HasPrecision(8)
                .HasColumnName("RESOLUCAO");
            entity.Property(e => e.Velocidade)
                .HasPrecision(8)
                .HasColumnName("VELOCIDADE");
        });

        modelBuilder.Entity<ErpFechamentoDiarioScantech>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdCaixa, e.DtFechamento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_fechamento_diario_scantech");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdCaixa)
                .HasPrecision(8)
                .HasColumnName("ID_CAIXA");
            entity.Property(e => e.DtFechamento)
                .HasColumnType("datetime")
                .HasColumnName("DT_FECHAMENTO");
            entity.Property(e => e.QtdeCancelamentos)
                .HasPrecision(8)
                .HasColumnName("QTDE_CANCELAMENTOS");
            entity.Property(e => e.QtdeVendas)
                .HasPrecision(8)
                .HasColumnName("QTDE_VENDAS");
            entity.Property(e => e.VlCancelamentos)
                .HasPrecision(15, 2)
                .HasColumnName("VL_CANCELAMENTOS");
            entity.Property(e => e.VlFechamento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FECHAMENTO");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpFechamentoDiarioScanteches)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_FECHAMENTO_DIARIO_SCANTECH");
        });

        modelBuilder.Entity<ErpFrameworkCampo>(entity =>
        {
            entity.HasKey(e => new { e.NmClasse, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_framework_campo");

            entity.Property(e => e.NmClasse)
                .HasMaxLength(60)
                .HasColumnName("NM_CLASSE");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.DmNull)
                .HasMaxLength(1)
                .HasColumnName("DM_NULL");
            entity.Property(e => e.DmPk)
                .HasMaxLength(1)
                .HasColumnName("DM_PK");
            entity.Property(e => e.DmPkGerada)
                .HasMaxLength(1)
                .HasColumnName("DM_PK_GERADA");
            entity.Property(e => e.DmVisivel)
                .HasMaxLength(1)
                .HasColumnName("DM_VISIVEL");
            entity.Property(e => e.DsAtributo)
                .HasMaxLength(60)
                .HasColumnName("DS_ATRIBUTO");
            entity.Property(e => e.DsMascara)
                .HasMaxLength(60)
                .HasColumnName("DS_MASCARA");
            entity.Property(e => e.NmAtributo)
                .HasMaxLength(1000)
                .HasColumnName("NM_ATRIBUTO");
            entity.Property(e => e.NmClasseValidacao)
                .HasMaxLength(100)
                .HasColumnName("NM_CLASSE_VALIDACAO");
            entity.Property(e => e.NmTabela)
                .HasMaxLength(60)
                .HasColumnName("NM_TABELA");
            entity.Property(e => e.NmTipoClasse)
                .HasMaxLength(60)
                .HasColumnName("NM_TIPO_CLASSE");
            entity.Property(e => e.TamGrid)
                .HasPrecision(4)
                .HasColumnName("TAM_GRID");
            entity.Property(e => e.TamPermitido)
                .HasMaxLength(10)
                .HasColumnName("TAM_PERMITIDO");

            entity.HasOne(d => d.NmClasseNavigation).WithMany(p => p.ErpFrameworkCampos)
                .HasForeignKey(d => d.NmClasse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PK_ERP_FRAMEWORK_TABELA_CAMPO");
        });

        modelBuilder.Entity<ErpFrameworkPesq>(entity =>
        {
            entity.HasKey(e => e.IdPesquisa).HasName("PRIMARY");

            entity.ToTable("erp_framework_pesq");

            entity.Property(e => e.IdPesquisa)
                .HasMaxLength(60)
                .HasColumnName("ID_PESQUISA");
            entity.Property(e => e.ComandoSql)
                .HasMaxLength(5000)
                .HasColumnName("ComandoSQL");
            entity.Property(e => e.DmLike)
                .HasMaxLength(1)
                .HasColumnName("DM_LIKE");
            entity.Property(e => e.DsCampoPesq01)
                .HasMaxLength(60)
                .HasColumnName("DS_CAMPO_PESQ_01");
            entity.Property(e => e.DsCampoPesq02)
                .HasMaxLength(60)
                .HasColumnName("DS_CAMPO_PESQ_02");
            entity.Property(e => e.DsCampoPesq03)
                .HasMaxLength(60)
                .HasColumnName("DS_CAMPO_PESQ_03");
            entity.Property(e => e.DsTitulo)
                .HasMaxLength(60)
                .HasColumnName("DS_TITULO");
        });

        modelBuilder.Entity<ErpFrameworkPesqCampo>(entity =>
        {
            entity.HasKey(e => new { e.IdPesquisa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_framework_pesq_campo");

            entity.Property(e => e.IdPesquisa)
                .HasMaxLength(60)
                .HasColumnName("ID_PESQUISA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.DmPk)
                .HasMaxLength(1)
                .HasColumnName("DM_PK");
            entity.Property(e => e.DmTipoClasse)
                .HasMaxLength(60)
                .HasColumnName("DM_TIPO_CLASSE");
            entity.Property(e => e.DmVisivel)
                .HasMaxLength(1)
                .HasColumnName("DM_VISIVEL");
            entity.Property(e => e.DsAtributo)
                .HasMaxLength(60)
                .HasColumnName("DS_ATRIBUTO");
            entity.Property(e => e.DsMascara)
                .HasMaxLength(60)
                .HasColumnName("DS_MASCARA");
            entity.Property(e => e.NmAtributo)
                .HasMaxLength(60)
                .HasColumnName("NM_ATRIBUTO");
            entity.Property(e => e.NmEntidade)
                .HasMaxLength(60)
                .HasColumnName("NM_ENTIDADE");
            entity.Property(e => e.TamGrid)
                .HasPrecision(4)
                .HasColumnName("TAM_GRID");

            entity.HasOne(d => d.IdPesquisaNavigation).WithMany(p => p.ErpFrameworkPesqCampos)
                .HasForeignKey(d => d.IdPesquisa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_FRAMEWORK_PESQUISA_CAMPO");
        });

        modelBuilder.Entity<ErpFrameworkTabela>(entity =>
        {
            entity.HasKey(e => e.NmClasse).HasName("PRIMARY");

            entity.ToTable("erp_framework_tabela");

            entity.Property(e => e.NmClasse)
                .HasMaxLength(60)
                .HasColumnName("NM_CLASSE");
            entity.Property(e => e.ComandoSql)
                .HasMaxLength(5000)
                .HasColumnName("ComandoSQL");
            entity.Property(e => e.DmMestreDetalhe)
                .HasMaxLength(1)
                .HasColumnName("DM_MESTRE_DETALHE");
            entity.Property(e => e.DsTitulo)
                .HasMaxLength(255)
                .HasColumnName("DS_TITULO");
            entity.Property(e => e.NmAutofocoInsert)
                .HasMaxLength(60)
                .HasColumnName("NM_AUTOFOCO_INSERT");
            entity.Property(e => e.NmAutofocoUpdate)
                .HasMaxLength(60)
                .HasColumnName("NM_AUTOFOCO_UPDATE");
            entity.Property(e => e.NmClasseFilha)
                .HasMaxLength(100)
                .HasColumnName("NM_CLASSE_FILHA");
            entity.Property(e => e.NmEntidade)
                .HasMaxLength(60)
                .HasColumnName("NM_ENTIDADE");
            entity.Property(e => e.NmPersistence)
                .HasMaxLength(100)
                .HasColumnName("NM_PERSISTENCE");
            entity.Property(e => e.NmPersistenceObject)
                .HasMaxLength(100)
                .HasColumnName("NM_PERSISTENCE_OBJECT");
        });

        modelBuilder.Entity<ErpGestaoPreco>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGestaoPreco })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_gestao_preco");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_GESTAO_PRECO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTabelaPreco }, "FK_ERP_TABELA_PRECO_GESTAO_PRECO");

            entity.HasIndex(e => new { e.NrLicenca, e.DmStatus, e.IdTabelaPreco, e.IdProdutoServico }, "IDX_0001_ERP_GESTAO_PRECO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGestaoPreco)
                .HasMaxLength(60)
                .HasColumnName("ID_GESTAO_PRECO");
            entity.Property(e => e.DmGerouEtiqueta)
                .HasMaxLength(1)
                .HasColumnName("DM_GEROU_ETIQUETA");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DtAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("DT_ATUALIZACAO");
            entity.Property(e => e.DtRecebimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_RECEBIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdTabelaPreco)
                .HasPrecision(8)
                .HasColumnName("ID_TABELA_PRECO");
            entity.Property(e => e.PercMargem)
                .HasPrecision(15, 4)
                .HasColumnName("PERC_MARGEM");
            entity.Property(e => e.VlCusto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_CUSTO");
            entity.Property(e => e.VlPreco)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRECO");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpGestaoPrecos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_GESTAO_PRECO");

            entity.HasOne(d => d.ErpTabelaPreco).WithMany(p => p.ErpGestaoPrecos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTabelaPreco })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TABELA_PRECO_GESTAO_PRECO");
        });

        modelBuilder.Entity<ErpGrupoDespesa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGrupoDespesa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_grupo_despesa");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGrupoDespesa)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO_DESPESA");
            entity.Property(e => e.DsGrupoDespesa)
                .HasMaxLength(60)
                .HasColumnName("DS_GRUPO_DESPESA");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpGrupoDespesas)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ERP_LICENCA_GRUPO_DESPESA");
        });

        modelBuilder.Entity<ErpGrupoPessoa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGrupo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_grupo_pessoa");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.DsGrupo)
                .HasMaxLength(100)
                .HasColumnName("DS_GRUPO");
        });

        modelBuilder.Entity<ErpGrupoPrecoProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGrupoPrecoProduto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_grupo_preco_produto");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGrupoPrecoProduto)
                .HasPrecision(8)
                .HasColumnName("ID_GRUPO_PRECO_PRODUTO");
            entity.Property(e => e.DsGrupoPrecoProduto)
                .HasMaxLength(60)
                .HasColumnName("DS_GRUPO_PRECO_PRODUTO");
        });

        modelBuilder.Entity<ErpGrupoProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGrupo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_grupo_produto");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.DsGrupo)
                .HasMaxLength(60)
                .HasColumnName("DS_GRUPO");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpGrupoProdutos)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_ERP_GRUPO_PRODUTO");
        });

        modelBuilder.Entity<ErpGrupoReceitum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGrupoReceita })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_grupo_receita");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGrupoReceita)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO_RECEITA");
            entity.Property(e => e.DsGrupoReceita)
                .HasMaxLength(60)
                .HasColumnName("DS_GRUPO_RECEITA");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpGrupoReceita)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_GRUPO_RECEITA");
        });

        modelBuilder.Entity<ErpImagem>(entity =>
        {
            entity.HasKey(e => e.IdImagem).HasName("PRIMARY");

            entity.ToTable("erp_imagem");

            entity.Property(e => e.IdImagem)
                .HasMaxLength(60)
                .HasColumnName("ID_IMAGEM");
            entity.Property(e => e.Imagem).HasColumnName("IMAGEM");
        });

        modelBuilder.Entity<ErpInventario>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdInventario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_inventario");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa }, "FK_ERP_EMPRESA_INVENTARIO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoMovimentoEntrada }, "FK_ERP_TIPO_MOVIMENTO_INVENTARIO_ENTRADA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoMovimentoSaida }, "FK_ERP_TIPO_MOVIMENTO_INVENTARIO_SAIDA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdUsuarioAtualizacao }, "FK_ERP_USUARIO_INVENTARIO_ATUALIZACAO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdInventario)
                .HasMaxLength(60)
                .HasColumnName("ID_INVENTARIO");
            entity.Property(e => e.DmAtualizado)
                .HasMaxLength(1)
                .HasColumnName("DM_ATUALIZADO");
            entity.Property(e => e.DmSaldo)
                .HasMaxLength(1)
                .HasColumnName("DM_SALDO");
            entity.Property(e => e.DsInventario)
                .HasMaxLength(60)
                .HasColumnName("DS_INVENTARIO");
            entity.Property(e => e.DtInventario).HasColumnName("DT_INVENTARIO");
            entity.Property(e => e.DthrAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_ATUALIZACAO");
            entity.Property(e => e.IdAlmoxarifado)
                .HasPrecision(4)
                .HasColumnName("ID_ALMOXARIFADO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdTipoMovimentoEntrada)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO_ENTRADA");
            entity.Property(e => e.IdTipoMovimentoSaida)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO_SAIDA");
            entity.Property(e => e.IdUsuarioAtualizacao)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO_ATUALIZACAO");
            entity.Property(e => e.NrDocumento)
                .HasPrecision(20)
                .HasColumnName("NR_DOCUMENTO");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpInventarios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_INVENTARIO");

            entity.HasOne(d => d.ErpTipoMovimentoEstoque).WithMany(p => p.ErpInventarioErpTipoMovimentoEstoques)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoMovimentoEntrada })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_MOVIMENTO_INVENTARIO_ENTRADA");

            entity.HasOne(d => d.ErpTipoMovimentoEstoqueNavigation).WithMany(p => p.ErpInventarioErpTipoMovimentoEstoqueNavigations)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoMovimentoSaida })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_MOVIMENTO_INVENTARIO_SAIDA");

            entity.HasOne(d => d.ErpUsuario).WithMany(p => p.ErpInventarios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdUsuarioAtualizacao })
                .HasConstraintName("FK_ERP_USUARIO_INVENTARIO_ATUALIZACAO");
        });

        modelBuilder.Entity<ErpInventarioContagemRapidum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdContagem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_inventario_contagem_rapida");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdContagem)
                .HasMaxLength(60)
                .HasColumnName("ID_CONTAGEM");
            entity.Property(e => e.DthrContagem)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_CONTAGEM");
            entity.Property(e => e.IdAlmoxarifado)
                .HasPrecision(4)
                .HasColumnName("ID_ALMOXARIFADO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdTipoMovimentoEntrada)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO_ENTRADA");
            entity.Property(e => e.IdTipoMovimentoSaida)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO_SAIDA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.QtdeContagem)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_CONTAGEM");
            entity.Property(e => e.VlCustoProduto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_CUSTO_PRODUTO");
        });

        modelBuilder.Entity<ErpInventarioProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdInventario, e.IdProdutoServico })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_inventario_produtos");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_INVENTARIO_PRODUTOS");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdInventario)
                .HasMaxLength(60)
                .HasColumnName("ID_INVENTARIO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.DmAtualizado)
                .HasMaxLength(1)
                .HasColumnName("DM_ATUALIZADO");
            entity.Property(e => e.IdUsuarioContagem)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO_CONTAGEM");
            entity.Property(e => e.QtdeContagem)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_CONTAGEM");
            entity.Property(e => e.VlCustoProduto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_CUSTO_PRODUTO");

            entity.HasOne(d => d.ErpInventario).WithMany(p => p.ErpInventarioProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdInventario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_INVENTARIO_PRODUTOS");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpInventarioProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_INVENTARIO_PRODUTOS");
        });

        modelBuilder.Entity<ErpInventarioProdutosKardex>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdInventario, e.IdKardex })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_inventario_produtos_kardex");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdInventario)
                .HasMaxLength(60)
                .HasColumnName("ID_INVENTARIO");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");
        });

        modelBuilder.Entity<ErpIpsBloqueadosW>(entity =>
        {
            entity.HasKey(e => e.NrIp).HasName("PRIMARY");

            entity.ToTable("erp_ips_bloqueados_ws");

            entity.Property(e => e.NrIp).HasColumnName("NR_IP");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .HasColumnName("DESCRICAO");
        });

        modelBuilder.Entity<ErpKardex>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdKardex })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_kardex");

            entity.HasIndex(e => new { e.NrLicenca, e.IdAlmoxarifado }, "FK_ERP_ALMOXARIFADO_ERP_KARDEX");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa }, "FK_ERP_EMPRESA_ERP_KARDEX");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_KARDEX");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoMovimento }, "FK_ERP_TIPO_MOVIMENTO_KARDEX");

            entity.HasIndex(e => new { e.NrLicenca, e.IdUsuario }, "FK_ERP_USUARIO_ERP_KARDEX");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");
            entity.Property(e => e.DtAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("DT_ATUALIZACAO");
            entity.Property(e => e.DtMovimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_MOVIMENTO");
            entity.Property(e => e.IdAlmoxarifado)
                .HasPrecision(4)
                .HasColumnName("ID_ALMOXARIFADO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.NrDocumento)
                .HasMaxLength(9)
                .HasColumnName("NR_DOCUMENTO");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");
            entity.Property(e => e.VlMedio)
                .HasPrecision(15, 2)
                .HasColumnName("VL_MEDIO");
            entity.Property(e => e.VlMovimento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_MOVIMENTO");

            entity.HasOne(d => d.ErpAlmoxarifado).WithMany(p => p.ErpKardices)
                .HasForeignKey(d => new { d.NrLicenca, d.IdAlmoxarifado })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ALMOXARIFADO_ERP_KARDEX");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpKardices)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_ERP_KARDEX");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpKardices)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_KARDEX");

            entity.HasOne(d => d.ErpTipoMovimentoEstoque).WithMany(p => p.ErpKardices)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoMovimento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_MOVIMENTO_KARDEX");

            entity.HasOne(d => d.ErpUsuario).WithMany(p => p.ErpKardices)
                .HasForeignKey(d => new { d.NrLicenca, d.IdUsuario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_USUARIO_ERP_KARDEX");
        });

        modelBuilder.Entity<ErpKardexMovimentoEstoqueProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdKardex, e.IdMovimento, e.IdEmpresa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_kardex_movimento_estoque_produto");

            entity.HasIndex(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa, e.NrItem }, "FK_ERP_MOVIMENTO_ESTOQUE_PRODUTO_KARDEX");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(8)
                .HasColumnName("NR_ITEM");

            entity.HasOne(d => d.ErpKardex).WithMany(p => p.ErpKardexMovimentoEstoqueProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdKardex })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_KARDEX_MOVIMENTO_ESTOQUE_PRODUTO");

            entity.HasOne(d => d.ErpMovimentoEstoqueProduto).WithMany(p => p.ErpKardexMovimentoEstoqueProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa, d.NrItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_ESTOQUE_PRODUTO_KARDEX");
        });

        modelBuilder.Entity<ErpLicenca>(entity =>
        {
            entity.HasKey(e => e.NrLicenca).HasName("PRIMARY");

            entity.ToTable("erp_licenca");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DmTipoSistema)
                .HasMaxLength(10)
                .HasColumnName("DM_TIPO_SISTEMA");
            entity.Property(e => e.NmFantasia)
                .HasMaxLength(60)
                .HasColumnName("NM_FANTASIA");
            entity.Property(e => e.NrVersao)
                .HasMaxLength(60)
                .HasColumnName("NR_VERSAO");
            entity.Property(e => e.TipoArmazenamento)
                .HasMaxLength(15)
                .HasColumnName("TIPO_ARMAZENAMENTO");
        });

        modelBuilder.Entity<ErpLicencaLiberacaoFinanceiro>(entity =>
        {
            entity.HasKey(e => e.NrLicenca).HasName("PRIMARY");

            entity.ToTable("erp_licenca_liberacao_financeiro");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.DtValidade).HasColumnName("DT_VALIDADE");
            entity.Property(e => e.DthrLiberacao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_LIBERACAO");
        });

        modelBuilder.Entity<ErpLicencaSession>(entity =>
        {
            entity.HasKey(e => new { e.IdSession, e.NrLicenca })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_licenca_session");

            entity.HasIndex(e => e.NrLicenca, "FK_ERP_LICENCA_SESSION");

            entity.Property(e => e.IdSession)
                .HasMaxLength(100)
                .HasColumnName("ID_SESSION");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpLicencaSessions)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_SESSION");
        });

        modelBuilder.Entity<ErpLicencasHomologacao>(entity =>
        {
            entity.HasKey(e => e.NrLicenca).HasName("PRIMARY");

            entity.ToTable("erp_licencas_homologacao");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<ErpLog>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PRIMARY");

            entity.ToTable("erp_log");

            entity.HasIndex(e => new { e.IdSession, e.NrLicenca }, "FK_ERP_LICENCA_SESSION_ERP_LOG");

            entity.Property(e => e.IdLog)
                .HasPrecision(8)
                .HasColumnName("ID_LOG");
            entity.Property(e => e.DtAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("DT_ATUALIZACAO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdSession)
                .HasMaxLength(100)
                .HasColumnName("ID_SESSION");
            entity.Property(e => e.NmClasse)
                .HasMaxLength(255)
                .HasColumnName("NM_CLASSE");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<ErpLogErroPdv>(entity =>
        {
            entity.HasKey(e => e.Identificador).HasName("PRIMARY");

            entity.ToTable("erp_log_erro_pdv");

            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.DthrLog)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_LOG");
            entity.Property(e => e.MsgLog)
                .HasColumnType("text")
                .HasColumnName("MSG_LOG");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<ErpLogObjeto>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PRIMARY");

            entity.ToTable("erp_log_objeto");

            entity.Property(e => e.IdLog)
                .HasPrecision(8)
                .HasColumnName("ID_LOG");
            entity.Property(e => e.XmlObjeto)
                .HasColumnType("blob")
                .HasColumnName("XML_OBJETO");
        });

        modelBuilder.Entity<ErpMensagemSistema>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMensagem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_mensagem_sistema");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMensagem)
                .HasMaxLength(60)
                .HasColumnName("ID_MENSAGEM");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DsMensagem)
                .HasMaxLength(255)
                .HasColumnName("DS_MENSAGEM");
            entity.Property(e => e.DthrMensagem)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_MENSAGEM");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
        });

        modelBuilder.Entity<ErpMenu>(entity =>
        {
            entity.HasKey(e => new { e.IdModulo, e.IdNivel, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_menu");

            entity.Property(e => e.IdModulo)
                .HasPrecision(4)
                .HasColumnName("ID_MODULO");
            entity.Property(e => e.IdNivel)
                .HasPrecision(8)
                .HasColumnName("ID_NIVEL");
            entity.Property(e => e.NrItem)
                .HasPrecision(8)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.DsMenu)
                .HasMaxLength(100)
                .HasColumnName("DS_MENU");
            entity.Property(e => e.DsMenuAnterior)
                .HasMaxLength(255)
                .HasColumnName("DS_MENU_ANTERIOR");
            entity.Property(e => e.IdNivelChamar)
                .HasPrecision(8)
                .HasColumnName("ID_NIVEL_CHAMAR");
            entity.Property(e => e.NmIcone)
                .HasMaxLength(100)
                .HasColumnName("NM_ICONE");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasColumnName("URL");

            entity.HasOne(d => d.IdModuloNavigation).WithMany(p => p.ErpMenus)
                .HasForeignKey(d => d.IdModulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MODULO_ERP_MENU");
        });

        modelBuilder.Entity<ErpModulo>(entity =>
        {
            entity.HasKey(e => e.IdModulo).HasName("PRIMARY");

            entity.ToTable("erp_modulo");

            entity.Property(e => e.IdModulo)
                .HasPrecision(4)
                .HasColumnName("ID_MODULO");
            entity.Property(e => e.DsModulo)
                .HasMaxLength(100)
                .HasColumnName("DS_MODULO");
        });

        modelBuilder.Entity<ErpMovimento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_movimento");

            entity.HasIndex(e => new { e.NrLicenca, e.IdComputador }, "FK_ERP_COMPUTADOR_ERP_MOVIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdCondicaoPagamento }, "FK_ERP_CONDICAO_PAGAMENTO_MOVIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdNaturezaOperacao }, "FK_ERP_NATUREZA_MOVIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoa }, "FK_ERP_PESSOA_MOVIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoaTransportador }, "FK_ERP_PESSOA_MOVIMENTO_TRANSPORTADOR");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoaVendedor }, "FK_ERP_PESSOA_MOVIMENTO_VENDEDOR");

            entity.HasIndex(e => new { e.NrLicenca, e.IdVendaPdv, e.IdEmpresa }, "IDX_0001_ERP_MOVIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa, e.IdPedidoVenda }, "IDX_0002_ERP_MOVIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa, e.DtEmissao }, "IDX_0003_ERP_MOVIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa, e.IdComputador }, "IDX_0004_ERP_MOVIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdVendaPdv }, "IDX_0005_ERP_MOVIMENTO").IsUnique();

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.CdModeloDocumento)
                .HasMaxLength(2)
                .HasColumnName("CD_MODELO_DOCUMENTO");
            entity.Property(e => e.DmCancelamento)
                .HasMaxLength(1)
                .HasColumnName("DM_CANCELAMENTO");
            entity.Property(e => e.DmConsumidorFinal)
                .HasMaxLength(1)
                .HasColumnName("DM_CONSUMIDOR_FINAL");
            entity.Property(e => e.DmEntradaSaida)
                .HasMaxLength(1)
                .HasColumnName("DM_ENTRADA_SAIDA");
            entity.Property(e => e.DmEnviadoScantech)
                .HasMaxLength(1)
                .HasColumnName("DM_ENVIADO_SCANTECH");
            entity.Property(e => e.DmFinalidadeEmissao)
                .HasMaxLength(1)
                .HasColumnName("DM_FINALIDADE_EMISSAO");
            entity.Property(e => e.DmFormaImportacao)
                .HasMaxLength(1)
                .HasColumnName("DM_FORMA_IMPORTACAO");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DmTipoFrete)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_FRETE");
            entity.Property(e => e.DmTipoTransporte)
                .HasMaxLength(2)
                .HasColumnName("DM_TIPO_TRANSPORTE");
            entity.Property(e => e.DsDadosAdicionais)
                .HasMaxLength(3000)
                .HasColumnName("DS_DADOS_ADICIONAIS");
            entity.Property(e => e.DsNaturezaOperacao)
                .HasMaxLength(60)
                .HasColumnName("DS_NATUREZA_OPERACAO");
            entity.Property(e => e.DtDocumentoImportacao).HasColumnName("DT_DOCUMENTO_IMPORTACAO");
            entity.Property(e => e.DtEmissao)
                .HasColumnType("datetime")
                .HasColumnName("DT_EMISSAO");
            entity.Property(e => e.DtEntradaSaida)
                .HasColumnType("datetime")
                .HasColumnName("DT_ENTRADA_SAIDA");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.IdCondicaoPagamento)
                .HasPrecision(4)
                .HasColumnName("ID_CONDICAO_PAGAMENTO");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.IdPedidoVenda)
                .HasPrecision(20)
                .HasColumnName("ID_PEDIDO_VENDA");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.IdPessoaTransportador)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA_TRANSPORTADOR");
            entity.Property(e => e.IdPessoaVendedor)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA_VENDEDOR");
            entity.Property(e => e.IdUfExportacao)
                .HasMaxLength(2)
                .HasColumnName("ID_UF_EXPORTACAO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.IdUsuarioCancelamento)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO_CANCELAMENTO");
            entity.Property(e => e.IdVendaPdv)
                .HasMaxLength(60)
                .HasColumnName("ID_VENDA_PDV");
            entity.Property(e => e.Ippc)
                .HasMaxLength(60)
                .HasColumnName("IPPC");
            entity.Property(e => e.NrChaveAcesso)
                .HasMaxLength(44)
                .HasColumnName("NR_CHAVE_ACESSO");
            entity.Property(e => e.NrChaveAcessoRef)
                .HasMaxLength(44)
                .HasColumnName("NR_CHAVE_ACESSO_REF");
            entity.Property(e => e.NrCnpjTerceiros)
                .HasMaxLength(14)
                .HasColumnName("NR_CNPJ_TERCEIROS");
            entity.Property(e => e.NrColeta)
                .HasMaxLength(20)
                .HasColumnName("NR_COLETA");
            entity.Property(e => e.NrCpfCnpjConsumidor)
                .HasMaxLength(14)
                .HasColumnName("NR_CPF_CNPJ_CONSUMIDOR");
            entity.Property(e => e.NrDocumento)
                .HasMaxLength(10)
                .HasColumnName("NR_DOCUMENTO");
            entity.Property(e => e.NrDocumentoImportacao)
                .HasMaxLength(20)
                .HasColumnName("NR_DOCUMENTO_IMPORTACAO");
            entity.Property(e => e.NrExtratoSat)
                .HasMaxLength(20)
                .HasColumnName("NR_EXTRATO_SAT");
            entity.Property(e => e.NrPedidoCliente)
                .HasMaxLength(30)
                .HasColumnName("NR_PEDIDO_CLIENTE");
            entity.Property(e => e.NrPesoBruto)
                .HasPrecision(15, 4)
                .HasColumnName("NR_PESO_BRUTO");
            entity.Property(e => e.NrPesoLiquido)
                .HasPrecision(15, 4)
                .HasColumnName("NR_PESO_LIQUIDO");
            entity.Property(e => e.NrSerie)
                .HasMaxLength(9)
                .HasColumnName("NR_SERIE");
            entity.Property(e => e.NrVenda)
                .HasPrecision(20)
                .HasColumnName("NR_VENDA");
            entity.Property(e => e.Usupc)
                .HasMaxLength(60)
                .HasColumnName("USUPC");
            entity.Property(e => e.VlAfrmm)
                .HasPrecision(15, 2)
                .HasColumnName("VL_AFRMM");
            entity.Property(e => e.VlBaseCofins)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_COFINS");
            entity.Property(e => e.VlBaseIcms)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS");
            entity.Property(e => e.VlBaseIcmsSubst)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS_SUBST");
            entity.Property(e => e.VlBaseIpi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_IPI");
            entity.Property(e => e.VlBasePis)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_PIS");
            entity.Property(e => e.VlCofins)
                .HasPrecision(15, 2)
                .HasColumnName("VL_COFINS");
            entity.Property(e => e.VlDescIcmsSuframa)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESC_ICMS_SUFRAMA");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESCONTO");
            entity.Property(e => e.VlDespesaAduaneira)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESPESA_ADUANEIRA");
            entity.Property(e => e.VlDespesasAcessorias)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESPESAS_ACESSORIAS");
            entity.Property(e => e.VlFrete)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FRETE");
            entity.Property(e => e.VlIcms)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS");
            entity.Property(e => e.VlIcmsSubst)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_SUBST");
            entity.Property(e => e.VlIpi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_IPI");
            entity.Property(e => e.VlPis)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PIS");
            entity.Property(e => e.VlProdutos)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRODUTOS");
            entity.Property(e => e.VlSeguro)
                .HasPrecision(15, 2)
                .HasColumnName("VL_SEGURO");
            entity.Property(e => e.VlSiscomex)
                .HasPrecision(15, 2)
                .HasColumnName("VL_SISCOMEX");
            entity.Property(e => e.VlTotal)
                .HasPrecision(15, 2)
                .HasColumnName("VL_TOTAL");
            entity.Property(e => e.VlTroco)
                .HasPrecision(15, 2)
                .HasColumnName("VL_TROCO");
            entity.Property(e => e.VolumesEspecie)
                .HasMaxLength(20)
                .HasColumnName("VOLUMES_ESPECIE");
            entity.Property(e => e.VolumesMarca)
                .HasMaxLength(20)
                .HasColumnName("VOLUMES_MARCA");
            entity.Property(e => e.VolumesNumero)
                .HasPrecision(8)
                .HasColumnName("VOLUMES_NUMERO");
            entity.Property(e => e.VolumesQtde)
                .HasPrecision(8)
                .HasColumnName("VOLUMES_QTDE");

            entity.HasOne(d => d.ErpComputador).WithMany(p => p.ErpMovimentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdComputador })
                .HasConstraintName("FK_ERP_COMPUTADOR_ERP_MOVIMENTO");

            entity.HasOne(d => d.ErpCondicaoPagamento).WithMany(p => p.ErpMovimentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdCondicaoPagamento })
                .HasConstraintName("FK_ERP_CONDICAO_PAGAMENTO_MOVIMENTO");

            entity.HasOne(d => d.ErpNaturezaOperacao).WithMany(p => p.ErpMovimentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdNaturezaOperacao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_NATUREZA_MOVIMENTO");

            entity.HasOne(d => d.ErpPessoa).WithMany(p => p.ErpMovimentoErpPessoas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoa })
                .HasConstraintName("FK_ERP_PESSOA_MOVIMENTO");

            entity.HasOne(d => d.ErpPessoaNavigation).WithMany(p => p.ErpMovimentoErpPessoaNavigations)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoaTransportador })
                .HasConstraintName("FK_ERP_PESSOA_MOVIMENTO_TRANSPORTADOR");

            entity.HasOne(d => d.ErpPessoa1).WithMany(p => p.ErpMovimentoErpPessoa1s)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoaVendedor })
                .HasConstraintName("FK_ERP_PESSOA_MOVIMENTO_VENDEDOR");

            entity.HasOne(d => d.ErpPedidoVendum).WithMany(p => p.ErpMovimentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdPedidoVenda })
                .HasConstraintName("FK_ERP_PEDIDO_VENDA_ERP_MOVIMENTO");
        });

        modelBuilder.Entity<ErpMovimentoBanco>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_movimento_banco");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasMaxLength(60)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtMovimento).HasColumnName("DT_MOVIMENTO");
            entity.Property(e => e.IdBancoConta)
                .HasPrecision(4)
                .HasColumnName("ID_BANCO_CONTA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");
            entity.Property(e => e.VlMovimento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_MOVIMENTO");
        });

        modelBuilder.Entity<ErpMovimentoCancelamento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_movimento_cancelamento");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DsJustificativa)
                .HasMaxLength(255)
                .HasColumnName("DS_JUSTIFICATIVA");
            entity.Property(e => e.DthrCancelamento)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_CANCELAMENTO");
            entity.Property(e => e.IdUsuarioCancelamento)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO_CANCELAMENTO");

            entity.HasOne(d => d.ErpMovimento).WithOne(p => p.ErpMovimentoCancelamento)
                .HasForeignKey<ErpMovimentoCancelamento>(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_CANCELAMENTO");
        });

        modelBuilder.Entity<ErpMovimentoConciliacao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.DtConciliacao, e.IdComputador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_movimento_conciliacao");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.DtConciliacao).HasColumnName("DT_CONCILIACAO");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.DthrUltimaSincronizacao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_ULTIMA_SINCRONIZACAO");
            entity.Property(e => e.QuantidadeVendas)
                .HasPrecision(19)
                .HasColumnName("QUANTIDADE_VENDAS");
            entity.Property(e => e.QuantidadeVendasCanceladas)
                .HasPrecision(19)
                .HasColumnName("QUANTIDADE_VENDAS_CANCELADAS");
            entity.Property(e => e.TotalVendas)
                .HasPrecision(15, 2)
                .HasColumnName("TOTAL_VENDAS");
            entity.Property(e => e.TotalVendasCanceladas)
                .HasPrecision(15, 2)
                .HasColumnName("TOTAL_VENDAS_CANCELADAS");
        });

        modelBuilder.Entity<ErpMovimentoCupomReferenciado>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa, e.NrChaveAcesso })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_movimento_cupom_referenciado");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrChaveAcesso)
                .HasMaxLength(44)
                .HasColumnName("NR_CHAVE_ACESSO");

            entity.HasOne(d => d.ErpMovimento).WithMany(p => p.ErpMovimentoCupomReferenciados)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_CUPOM_REFERENCIADO");
        });

        modelBuilder.Entity<ErpMovimentoEstoque>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_movimento_estoque");

            entity.HasIndex(e => new { e.NrLicenca, e.IdAlmoxarifado }, "FK_ERP_ALMOXARIFADO_MOVIMENTO_ESTOQUE");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa }, "FK_ERP_EMPRESA_MOVIMENTO_ESTOQUE");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoMovimento }, "FK_ERP_TIPO_MOVIMENTO_MOVIMENTO_ESTOQUE");

            entity.HasIndex(e => new { e.NrLicenca, e.IdUsuario }, "FK_ERP_USUARIO_ERP_MOVIMENTO_ESTOQUE");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DtAtualizacao).HasColumnName("DT_ATUALIZACAO");
            entity.Property(e => e.DtMovimento).HasColumnName("DT_MOVIMENTO");
            entity.Property(e => e.IdAlmoxarifado)
                .HasPrecision(4)
                .HasColumnName("ID_ALMOXARIFADO");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.NrDocumento)
                .HasMaxLength(9)
                .HasColumnName("NR_DOCUMENTO");

            entity.HasOne(d => d.ErpAlmoxarifado).WithMany(p => p.ErpMovimentoEstoques)
                .HasForeignKey(d => new { d.NrLicenca, d.IdAlmoxarifado })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ALMOXARIFADO_MOVIMENTO_ESTOQUE");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpMovimentoEstoques)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_MOVIMENTO_ESTOQUE");

            entity.HasOne(d => d.ErpTipoMovimentoEstoque).WithMany(p => p.ErpMovimentoEstoques)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoMovimento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_MOVIMENTO_MOVIMENTO_ESTOQUE");

            entity.HasOne(d => d.ErpUsuario).WithMany(p => p.ErpMovimentoEstoques)
                .HasForeignKey(d => new { d.NrLicenca, d.IdUsuario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_USUARIO_ERP_MOVIMENTO_ESTOQUE");
        });

        modelBuilder.Entity<ErpMovimentoEstoqueProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_movimento_estoque_produto");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_MOVIMENTO_ESTOQUE");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(8)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");
            entity.Property(e => e.VlMovimento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_MOVIMENTO");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpMovimentoEstoqueProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_MOVIMENTO_ESTOQUE");

            entity.HasOne(d => d.ErpMovimentoEstoque).WithMany(p => p.ErpMovimentoEstoqueProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_ESTOQUE_PRODUTO");
        });

        modelBuilder.Entity<ErpMovimentoItem>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_movimento_item");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_MOVIMENTO_ITEM");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.AliqCofins)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_COFINS");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS");
            entity.Property(e => e.AliqIcmsCredito)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS_CREDITO");
            entity.Property(e => e.AliqIcmsSubst)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS_SUBST");
            entity.Property(e => e.AliqIpi)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_IPI");
            entity.Property(e => e.AliqPis)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_PIS");
            entity.Property(e => e.CdClassificacao)
                .HasMaxLength(4)
                .HasColumnName("CD_CLASSIFICACAO");
            entity.Property(e => e.CdEnquadramento)
                .HasMaxLength(3)
                .HasColumnName("CD_ENQUADRAMENTO");
            entity.Property(e => e.CdServico)
                .HasMaxLength(20)
                .HasColumnName("CD_SERVICO");
            entity.Property(e => e.CstCofins)
                .HasMaxLength(2)
                .HasColumnName("CST_COFINS");
            entity.Property(e => e.CstCsosn)
                .HasMaxLength(4)
                .HasColumnName("CST_CSOSN");
            entity.Property(e => e.CstIpi)
                .HasMaxLength(2)
                .HasColumnName("CST_IPI");
            entity.Property(e => e.CstPis)
                .HasMaxLength(2)
                .HasColumnName("CST_PIS");
            entity.Property(e => e.DmDetBaseIcms)
                .HasMaxLength(1)
                .HasColumnName("DM_DET_BASE_ICMS");
            entity.Property(e => e.DmDetBaseIcmsSt)
                .HasMaxLength(1)
                .HasColumnName("DM_DET_BASE_ICMS_ST");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DsComplementar)
                .HasMaxLength(255)
                .HasColumnName("DS_COMPLEMENTAR");
            entity.Property(e => e.DsProdutoServico)
                .HasMaxLength(120)
                .HasColumnName("DS_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.IdPromocao)
                .HasPrecision(8)
                .HasColumnName("ID_PROMOCAO");
            entity.Property(e => e.IdUnidade)
                .HasMaxLength(6)
                .HasColumnName("ID_UNIDADE");
            entity.Property(e => e.IdUnidadeTrib)
                .HasMaxLength(6)
                .HasColumnName("ID_UNIDADE_TRIB");
            entity.Property(e => e.NrDrawback)
                .HasMaxLength(15)
                .HasColumnName("NR_DRAWBACK");
            entity.Property(e => e.PercComissao)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_COMISSAO");
            entity.Property(e => e.PercDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_DESCONTO");
            entity.Property(e => e.PercFcp)
                .HasPrecision(15, 4)
                .HasColumnName("PERC_FCP");
            entity.Property(e => e.PercMva)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_MVA");
            entity.Property(e => e.PercPartilha)
                .HasPrecision(15, 4)
                .HasColumnName("PERC_PARTILHA");
            entity.Property(e => e.PercRedIcms)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_RED_ICMS");
            entity.Property(e => e.PercRedIcmsSubst)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_RED_ICMS_SUBST");
            entity.Property(e => e.PercUfDestInter)
                .HasPrecision(15, 4)
                .HasColumnName("PERC_UF_DEST_INTER");
            entity.Property(e => e.PercUfDestIntest)
                .HasPrecision(15, 4)
                .HasColumnName("PERC_UF_DEST_INTEST");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");
            entity.Property(e => e.QuantidadeTrib)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE_TRIB");
            entity.Property(e => e.VlBaseCofins)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_COFINS");
            entity.Property(e => e.VlBaseIcms)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS");
            entity.Property(e => e.VlBaseIcmsSubst)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS_SUBST");
            entity.Property(e => e.VlBaseIcmsSubstRet)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS_SUBST_RET");
            entity.Property(e => e.VlBaseIpi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_IPI");
            entity.Property(e => e.VlBasePis)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_PIS");
            entity.Property(e => e.VlCofins)
                .HasPrecision(15, 2)
                .HasColumnName("VL_COFINS");
            entity.Property(e => e.VlComissao)
                .HasPrecision(15, 2)
                .HasColumnName("VL_COMISSAO");
            entity.Property(e => e.VlDescDi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESC_DI");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESCONTO");
            entity.Property(e => e.VlDespesasAcessorias)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESPESAS_ACESSORIAS");
            entity.Property(e => e.VlFrete)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FRETE");
            entity.Property(e => e.VlIcms)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS");
            entity.Property(e => e.VlIcmsCredito)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_CREDITO");
            entity.Property(e => e.VlIcmsFcp)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_FCP");
            entity.Property(e => e.VlIcmsSubst)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_SUBST");
            entity.Property(e => e.VlIcmsSubstRet)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_SUBST_RET");
            entity.Property(e => e.VlIcmsUfDest)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_UF_DEST");
            entity.Property(e => e.VlIcmsUfRem)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_UF_REM");
            entity.Property(e => e.VlIpi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_IPI");
            entity.Property(e => e.VlPis)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PIS");
            entity.Property(e => e.VlProdutos)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRODUTOS");
            entity.Property(e => e.VlProdutosTrib)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRODUTOS_TRIB");
            entity.Property(e => e.VlSeguro)
                .HasPrecision(15, 2)
                .HasColumnName("VL_SEGURO");
            entity.Property(e => e.VlTotal)
                .HasPrecision(15, 2)
                .HasColumnName("VL_TOTAL");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(15, 4)
                .HasColumnName("VL_UNITARIO");
            entity.Property(e => e.VlUnitarioTrib)
                .HasPrecision(15, 4)
                .HasColumnName("VL_UNITARIO_TRIB");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpMovimentoItems)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_MOVIMENTO_ITEM");

            entity.HasOne(d => d.ErpMovimento).WithMany(p => p.ErpMovimentoItems)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_MOVIMENTO_ITEM");
        });

        modelBuilder.Entity<ErpMovimentoItemKardex>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_movimento_item_kardex");

            entity.HasIndex(e => new { e.NrLicenca, e.IdKardex }, "FK_ERP_KARDEX_MOVIMENTO_ITEM");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");

            entity.HasOne(d => d.ErpKardex).WithMany(p => p.ErpMovimentoItemKardices)
                .HasForeignKey(d => new { d.NrLicenca, d.IdKardex })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_KARDEX_MOVIMENTO_ITEM");

            entity.HasOne(d => d.ErpMovimentoItem).WithOne(p => p.ErpMovimentoItemKardex)
                .HasForeignKey<ErpMovimentoItemKardex>(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa, d.NrItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_ITEM_KARDEX");
        });

        modelBuilder.Entity<ErpMovimentoItemKardexCancelamento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_movimento_item_kardex_cancelamento");

            entity.HasIndex(e => new { e.NrLicenca, e.IdKardex }, "FK_ERP_KARDEX_MOVIMENTO_ITEM-CANCELAMENTO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");

            entity.HasOne(d => d.ErpKardex).WithMany(p => p.ErpMovimentoItemKardexCancelamentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdKardex })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_KARDEX_MOVIMENTO_ITEM-CANCELAMENTO");
        });

        modelBuilder.Entity<ErpMovimentoItemLote>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdMovimento, e.NrItem, e.IdSerialLote })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_movimento_item_lote");

            entity.HasIndex(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa, e.NrItem }, "FK_ERP_MOVIMENTO_ITEM_LOTE");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdSerialLote)
                .HasMaxLength(60)
                .HasColumnName("ID_SERIAL_LOTE");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");

            entity.HasOne(d => d.ErpMovimentoItem).WithMany(p => p.ErpMovimentoItemLotes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa, d.NrItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_ITEM_LOTE");
        });

        modelBuilder.Entity<ErpMovimentoLogScantech>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_movimento_log_scantech");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DsLog)
                .HasMaxLength(10000)
                .HasColumnName("DS_LOG");
            entity.Property(e => e.DthrEnvio)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_ENVIO");
        });

        modelBuilder.Entity<ErpMovimentoNotaFiscal>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_movimento_nota_fiscal");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DanfeEmissao).HasColumnName("DANFE_EMISSAO");
            entity.Property(e => e.DmPreview)
                .HasMaxLength(1)
                .HasColumnName("DM_PREVIEW");
            entity.Property(e => e.DsStatus)
                .HasMaxLength(5000)
                .HasColumnName("DS_STATUS");
            entity.Property(e => e.XmlEmissao)
                .HasColumnType("text")
                .HasColumnName("XML_EMISSAO");

            entity.HasOne(d => d.ErpMovimento).WithOne(p => p.ErpMovimentoNotaFiscal)
                .HasForeignKey<ErpMovimentoNotaFiscal>(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_NOTA_FISCAL");
        });

        modelBuilder.Entity<ErpMovimentoRecebimento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_movimento_recebimento");

            entity.HasIndex(e => new { e.NrLicenca, e.IdRecebimento }, "FK_PDV_TIPO_RECEBIMENTO_MOVIMENTO_RECEBIMENTO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdMovimento, e.DmSituacao }, "IDX_0001_ERP_MOVIMENTO_RECEBIMENTO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.Bandeira)
                .HasMaxLength(50)
                .HasColumnName("BANDEIRA");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.IdRecebimento)
                .HasPrecision(4)
                .HasColumnName("ID_RECEBIMENTO");
            entity.Property(e => e.Impressao)
                .HasColumnType("text")
                .HasColumnName("IMPRESSAO");
            entity.Property(e => e.ImpressaoEstorno)
                .HasColumnType("text")
                .HasColumnName("IMPRESSAO_ESTORNO");
            entity.Property(e => e.Numeroautorizacao)
                .HasMaxLength(50)
                .HasColumnName("NUMEROAUTORIZACAO");
            entity.Property(e => e.Numerocontrole)
                .HasMaxLength(50)
                .HasColumnName("NUMEROCONTROLE");
            entity.Property(e => e.Numerodoc)
                .HasMaxLength(50)
                .HasColumnName("NUMERODOC");
            entity.Property(e => e.VlRecebimento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_RECEBIMENTO");
            entity.Property(e => e.VlTroco)
                .HasPrecision(15, 2)
                .HasColumnName("VL_TROCO");

            entity.HasOne(d => d.ErpMovimento).WithMany(p => p.ErpMovimentoRecebimentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_ERP_MOVIMENTO_RECEBIMENTO");
        });

        modelBuilder.Entity<ErpMovimentoXmlImportado>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_movimento_xml_importado");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.XmlEnviado)
                .HasColumnType("text")
                .HasColumnName("XML_ENVIADO");
            entity.Property(e => e.XmlEnviado2).HasColumnName("XML_ENVIADO2");

            entity.HasOne(d => d.ErpMovimento).WithOne(p => p.ErpMovimentoXmlImportado)
                .HasForeignKey<ErpMovimentoXmlImportado>(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_XML_IMPORTADO");
        });

        modelBuilder.Entity<ErpMunicipio>(entity =>
        {
            entity.HasKey(e => e.IdMunicipio).HasName("PRIMARY");

            entity.ToTable("erp_municipio");

            entity.HasIndex(e => e.IdUf, "FK_ERP_UF_ERP_MUNICIPIO");

            entity.Property(e => e.IdMunicipio)
                .HasPrecision(8)
                .HasColumnName("ID_MUNICIPIO");
            entity.Property(e => e.DsMunicipio)
                .HasMaxLength(100)
                .HasColumnName("DS_MUNICIPIO");
            entity.Property(e => e.IdUf)
                .HasMaxLength(2)
                .HasColumnName("ID_UF");

            entity.HasOne(d => d.IdUfNavigation).WithMany(p => p.ErpMunicipios)
                .HasForeignKey(d => d.IdUf)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_UF_ERP_MUNICIPIO");
        });

        modelBuilder.Entity<ErpNaturezaOperacao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdNaturezaOperacao })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_natureza_operacao");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoMovimento }, "FK_ERP_TIPO_MOVIMENTO_NATUREZA_OPERACAO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.DmEntradaSaida)
                .HasMaxLength(1)
                .HasColumnName("DM_ENTRADA_SAIDA");
            entity.Property(e => e.DmEstoque)
                .HasMaxLength(1)
                .HasColumnName("DM_ESTOQUE");
            entity.Property(e => e.DmFinalidadeEmissao)
                .HasMaxLength(1)
                .HasColumnName("DM_FINALIDADE_EMISSAO");
            entity.Property(e => e.DmFinanceiro)
                .HasMaxLength(1)
                .HasColumnName("DM_FINANCEIRO");
            entity.Property(e => e.DsNaturezaOperacao)
                .HasMaxLength(120)
                .HasColumnName("DS_NATUREZA_OPERACAO");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpNaturezaOperacaos)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_NATUREZA_OPERACAO");

            entity.HasOne(d => d.ErpTipoMovimentoEstoque).WithMany(p => p.ErpNaturezaOperacaos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoMovimento })
                .HasConstraintName("FK_ERP_TIPO_MOVIMENTO_NATUREZA_OPERACAO");
        });

        modelBuilder.Entity<ErpNcm>(entity =>
        {
            entity.HasKey(e => new { e.IdNcm, e.CdNcm })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_ncm");

            entity.Property(e => e.IdNcm)
                .HasPrecision(8)
                .HasColumnName("ID_NCM");
            entity.Property(e => e.CdNcm)
                .HasMaxLength(8)
                .HasColumnName("CD_NCM");
            entity.Property(e => e.DsFonte)
                .HasMaxLength(255)
                .HasColumnName("DS_FONTE");
            entity.Property(e => e.DsNcm)
                .HasMaxLength(255)
                .HasColumnName("DS_NCM");
            entity.Property(e => e.DsVersao)
                .HasMaxLength(20)
                .HasColumnName("DS_VERSAO");
            entity.Property(e => e.PercTributoEstadual)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_TRIBUTO_ESTADUAL");
            entity.Property(e => e.PercTributoFederal)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_TRIBUTO_FEDERAL");
            entity.Property(e => e.PercTributoImportado)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_TRIBUTO_IMPORTADO");
            entity.Property(e => e.PercTributoMuncipal)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_TRIBUTO_MUNCIPAL");
        });

        modelBuilder.Entity<ErpObjetoPermissao>(entity =>
        {
            entity.HasKey(e => e.NmObjeto).HasName("PRIMARY");

            entity.ToTable("erp_objeto_permissao");

            entity.Property(e => e.NmObjeto)
                .HasMaxLength(100)
                .HasColumnName("NM_OBJETO");
            entity.Property(e => e.DsObjeto)
                .HasMaxLength(100)
                .HasColumnName("DS_OBJETO");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<ErpPai>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("PRIMARY");

            entity.ToTable("erp_pais");

            entity.Property(e => e.IdPais)
                .HasPrecision(4)
                .HasColumnName("ID_PAIS");
            entity.Property(e => e.DsPais)
                .HasMaxLength(100)
                .HasColumnName("DS_PAIS");
        });

        modelBuilder.Entity<ErpParametrosCategorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PRIMARY");

            entity.ToTable("erp_parametros_categoria");

            entity.Property(e => e.IdCategoria)
                .HasPrecision(4)
                .HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.DsCategoria)
                .HasMaxLength(255)
                .HasColumnName("DS_CATEGORIA");
            entity.Property(e => e.IdSubgrupo)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO");
        });

        modelBuilder.Entity<ErpParametrosComputador>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdComputador, e.NmParametro })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_parametros_computador");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.NmParametro)
                .HasMaxLength(60)
                .HasColumnName("NM_PARAMETRO");
            entity.Property(e => e.DsParametro)
                .HasMaxLength(255)
                .HasColumnName("DS_PARAMETRO");
            entity.Property(e => e.GrupoParametro)
                .HasMaxLength(60)
                .HasColumnName("GRUPO_PARAMETRO");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.ParametroNovo)
                .HasMaxLength(1)
                .HasColumnName("PARAMETRO_NOVO");
            entity.Property(e => e.VlParametro)
                .HasMaxLength(512)
                .HasColumnName("VL_PARAMETRO");

            entity.HasOne(d => d.ErpComputador).WithMany(p => p.ErpParametrosComputadors)
                .HasForeignKey(d => new { d.NrLicenca, d.IdComputador })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_COMPUTADOR_PARAMETROS");
        });

        modelBuilder.Entity<ErpParametrosDefault>(entity =>
        {
            entity.HasKey(e => e.NmParametro).HasName("PRIMARY");

            entity.ToTable("erp_parametros_default");

            entity.HasIndex(e => e.IdGrupo, "FK_ERP_PARAMETROS_GRUPO_DEFAULT");

            entity.HasIndex(e => e.IdSubgrupo, "FK_ERP_PARAMETROS_SUBGRUPO_DEFAULT");

            entity.HasIndex(e => e.IdCategoria, "FK_ERP_PARAMETRO_CATEGORIA_DEFAULT");

            entity.HasIndex(e => new { e.NmParametro, e.IdGrupo }, "IDX_0001_ERP_PARAMETROS_DEFAULT");

            entity.HasIndex(e => new { e.NmParametro, e.IdSubgrupo }, "IDX_0002_ERP_PARAMETROS_DEFAULT");

            entity.HasIndex(e => new { e.NmParametro, e.IdCategoria }, "IDX_0003_ERP_PARAMETROS_DEFAULT");

            entity.Property(e => e.NmParametro)
                .HasMaxLength(60)
                .HasColumnName("NM_PARAMETRO");
            entity.Property(e => e.DmTipoParametro)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_PARAMETRO");
            entity.Property(e => e.DsParametro)
                .HasMaxLength(255)
                .HasColumnName("DS_PARAMETRO");
            entity.Property(e => e.GrupoParametro)
                .HasMaxLength(60)
                .HasColumnName("GRUPO_PARAMETRO");
            entity.Property(e => e.IdCategoria)
                .HasPrecision(4)
                .HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.IdSubgrupo)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO");
            entity.Property(e => e.ParametroNovo)
                .HasMaxLength(1)
                .HasColumnName("PARAMETRO_NOVO");
            entity.Property(e => e.VlParametro)
                .HasMaxLength(512)
                .HasColumnName("VL_PARAMETRO");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.ErpParametrosDefaults)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK_ERP_PARAMETRO_CATEGORIA_DEFAULT");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.ErpParametrosDefaults)
                .HasForeignKey(d => d.IdGrupo)
                .HasConstraintName("FK_ERP_PARAMETROS_GRUPO_DEFAULT");

            entity.HasOne(d => d.IdSubgrupoNavigation).WithMany(p => p.ErpParametrosDefaults)
                .HasForeignKey(d => d.IdSubgrupo)
                .HasConstraintName("FK_ERP_PARAMETROS_SUBGRUPO_DEFAULT");
        });

        modelBuilder.Entity<ErpParametrosGrupo>(entity =>
        {
            entity.HasKey(e => e.IdGrupo).HasName("PRIMARY");

            entity.ToTable("erp_parametros_grupo");

            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.DsGrupo)
                .HasMaxLength(255)
                .HasColumnName("DS_GRUPO");
        });

        modelBuilder.Entity<ErpParametrosLicenca>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NmParametro })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_parametros_licenca");

            entity.HasIndex(e => e.NmParametro, "FK_ERP_PARAMETROS_DEFAULT_LICENCA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NmParametro)
                .HasMaxLength(60)
                .HasColumnName("NM_PARAMETRO");
            entity.Property(e => e.DsParametro)
                .HasMaxLength(255)
                .HasColumnName("DS_PARAMETRO");
            entity.Property(e => e.GrupoParametro)
                .HasMaxLength(60)
                .HasColumnName("GRUPO_PARAMETRO");
            entity.Property(e => e.ParametroNovo)
                .HasMaxLength(1)
                .HasColumnName("PARAMETRO_NOVO");
            entity.Property(e => e.VlParametro)
                .HasMaxLength(512)
                .HasColumnName("VL_PARAMETRO");

            entity.HasOne(d => d.NmParametroNavigation).WithMany(p => p.ErpParametrosLicencas)
                .HasForeignKey(d => d.NmParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PARAMETROS_DEFAULT_LICENCA");
        });

        modelBuilder.Entity<ErpParametrosSubgrupo>(entity =>
        {
            entity.HasKey(e => e.IdSubgrupo).HasName("PRIMARY");

            entity.ToTable("erp_parametros_subgrupo");

            entity.Property(e => e.IdSubgrupo)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO");
            entity.Property(e => e.DsSubgrupo)
                .HasMaxLength(255)
                .HasColumnName("DS_SUBGRUPO");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");
        });

        modelBuilder.Entity<ErpPedidoCompra>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NrPedido })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_pedido_compra");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NrPedido)
                .HasPrecision(20)
                .HasColumnName("NR_PEDIDO");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DtPrevisaoEntrega)
                .HasColumnType("datetime")
                .HasColumnName("DT_PREVISAO_ENTREGA");
            entity.Property(e => e.DthrEmissao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_EMISSAO");
            entity.Property(e => e.DthrPedido)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_PEDIDO");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.IdentificadorCotacao)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR_COTACAO");
        });

        modelBuilder.Entity<ErpPedidoCompraItem>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NrPedido, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_pedido_compra_item");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NrPedido)
                .HasPrecision(20)
                .HasColumnName("NR_PEDIDO");
            entity.Property(e => e.NrItem)
                .HasPrecision(8)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");
            entity.Property(e => e.QuantidadeEntregue)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE_ENTREGUE");
            entity.Property(e => e.ValorUnitario)
                .HasPrecision(15, 2)
                .HasColumnName("VALOR_UNITARIO");
            entity.Property(e => e.ValorUnitarioEntregue)
                .HasPrecision(15, 2)
                .HasColumnName("VALOR_UNITARIO_ENTREGUE");

            entity.HasOne(d => d.ErpPedidoCompra).WithMany(p => p.ErpPedidoCompraItems)
                .HasForeignKey(d => new { d.NrLicenca, d.NrPedido })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PEDIDO_COMPRA_ITEM");
        });

        modelBuilder.Entity<ErpPedidoCotacao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NrCotacao, e.IdPessoa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_pedido_cotacao");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NrCotacao)
                .HasPrecision(20)
                .HasColumnName("NR_COTACAO");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DsEmail)
                .HasMaxLength(255)
                .HasColumnName("DS_EMAIL");
            entity.Property(e => e.DthrCotacao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_COTACAO");
            entity.Property(e => e.DthrRetorno)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_RETORNO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
        });

        modelBuilder.Entity<ErpPedidoCotacaoItem>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NrCotacao, e.IdPessoa, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_pedido_cotacao_item");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NrCotacao)
                .HasPrecision(20)
                .HasColumnName("NR_COTACAO");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.NrItem)
                .HasPrecision(8)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.DmVencedor)
                .HasMaxLength(1)
                .HasColumnName("DM_VENCEDOR");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.QtdeAtendida)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_ATENDIDA");
            entity.Property(e => e.QtdePedida)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_PEDIDA");
            entity.Property(e => e.ValorUnitario)
                .HasPrecision(15, 2)
                .HasColumnName("VALOR_UNITARIO");

            entity.HasOne(d => d.ErpPedidoCotacao).WithMany(p => p.ErpPedidoCotacaoItems)
                .HasForeignKey(d => new { d.NrLicenca, d.NrCotacao, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PEDIDO_COTACAO_COTACAO_ITEM");
        });

        modelBuilder.Entity<ErpPedidoCotacaoPendente>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.Identificador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_pedido_cotacao_pendente");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.DthrCotacao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_COTACAO");
            entity.Property(e => e.DthrRetorno)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_RETORNO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
        });

        modelBuilder.Entity<ErpPedidoCotacaoPendenteFornecedore>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.Identificador, e.IdPessoa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_pedido_cotacao_pendente_fornecedores");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.DsEmail)
                .HasMaxLength(100)
                .HasColumnName("DS_EMAIL");
        });

        modelBuilder.Entity<ErpPedidoCotacaoPendenteItem>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.Identificador, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_pedido_cotacao_pendente_item");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.NrItem)
                .HasPrecision(8)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.QtdePedida)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_PEDIDA");

            entity.HasOne(d => d.ErpPedidoCotacaoPendente).WithMany(p => p.ErpPedidoCotacaoPendenteItems)
                .HasForeignKey(d => new { d.NrLicenca, d.Identificador })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PEDIDO_COTACAO_PENDENTE_ITEM");
        });

        modelBuilder.Entity<ErpPedidoVendaCupomReferenciado>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPedidoVenda, e.NrChaveAcesso })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_pedido_venda_cupom_referenciado");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPedidoVenda)
                .HasPrecision(20)
                .HasColumnName("ID_PEDIDO_VENDA");
            entity.Property(e => e.NrChaveAcesso)
                .HasMaxLength(44)
                .HasColumnName("NR_CHAVE_ACESSO");

            entity.HasOne(d => d.ErpPedidoVendum).WithMany(p => p.ErpPedidoVendaCupomReferenciados)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdPedidoVenda })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PEDIDO_VENDA_CUPOM_REFERENCIADO");
        });

        modelBuilder.Entity<ErpPedidoVendaGeradoErpMovimento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPedidoVenda, e.IdMovimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_pedido_venda_gerado_erp_movimento");

            entity.HasIndex(e => new { e.NrLicenca, e.IdMovimento, e.IdEmpresa }, "FK_ERP_MOVIMENTO_PEDIDO_VENDA_GERADO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPedidoVenda)
                .HasPrecision(20)
                .HasColumnName("ID_PEDIDO_VENDA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");

            entity.HasOne(d => d.ErpPedidoVendum).WithMany(p => p.ErpPedidoVendaGeradoErpMovimentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdPedidoVenda })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PEDIDO_VENDA_PEDIDO_VENDA_GERADO");

            entity.HasOne(d => d.ErpMovimento).WithMany(p => p.ErpPedidoVendaGeradoErpMovimentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_PEDIDO_VENDA_GERADO");
        });

        modelBuilder.Entity<ErpPedidoVendaItem>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPedidoVenda, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_pedido_venda_item");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPedidoVenda)
                .HasPrecision(20)
                .HasColumnName("ID_PEDIDO_VENDA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.AliqCofins)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_COFINS");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS");
            entity.Property(e => e.AliqIcmsCredito)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS_CREDITO");
            entity.Property(e => e.AliqIcmsSt)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS_ST");
            entity.Property(e => e.AliqIpi)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_IPI");
            entity.Property(e => e.AliqPis)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_PIS");
            entity.Property(e => e.CdClassificacaoFiscal)
                .HasMaxLength(4)
                .HasColumnName("CD_CLASSIFICACAO_FISCAL");
            entity.Property(e => e.CstCofins)
                .HasMaxLength(2)
                .HasColumnName("CST_COFINS");
            entity.Property(e => e.CstCsosn)
                .HasMaxLength(4)
                .HasColumnName("CST_CSOSN");
            entity.Property(e => e.CstIpi)
                .HasMaxLength(2)
                .HasColumnName("CST_IPI");
            entity.Property(e => e.CstPis)
                .HasMaxLength(2)
                .HasColumnName("CST_PIS");
            entity.Property(e => e.DsMensagemRegra)
                .HasMaxLength(255)
                .HasColumnName("DS_MENSAGEM_REGRA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.PercDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_DESCONTO");
            entity.Property(e => e.PercFcp)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_FCP");
            entity.Property(e => e.PercIcmsInterFcp)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_ICMS_INTER_FCP");
            entity.Property(e => e.PercIcmsInterPartilha)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_ICMS_INTER_PARTILHA");
            entity.Property(e => e.PercMva)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_MVA");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");
            entity.Property(e => e.VlBaseCofins)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_COFINS");
            entity.Property(e => e.VlBaseFcp)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_FCP");
            entity.Property(e => e.VlBaseIcms)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS");
            entity.Property(e => e.VlBaseIcmsSt)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_ICMS_ST");
            entity.Property(e => e.VlBaseIpi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_IPI");
            entity.Property(e => e.VlBasePis)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BASE_PIS");
            entity.Property(e => e.VlCofins)
                .HasPrecision(15, 2)
                .HasColumnName("VL_COFINS");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESCONTO");
            entity.Property(e => e.VlDespAcessorias)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESP_ACESSORIAS");
            entity.Property(e => e.VlFcp)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FCP");
            entity.Property(e => e.VlFcpUfDest)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FCP_UF_DEST");
            entity.Property(e => e.VlFrete)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FRETE");
            entity.Property(e => e.VlIcms)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS");
            entity.Property(e => e.VlIcmsCredito)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_CREDITO");
            entity.Property(e => e.VlIcmsSt)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_ST");
            entity.Property(e => e.VlIcmsUfDest)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_UF_DEST");
            entity.Property(e => e.VlIcmsUfRem)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ICMS_UF_REM");
            entity.Property(e => e.VlIpi)
                .HasPrecision(15, 2)
                .HasColumnName("VL_IPI");
            entity.Property(e => e.VlPis)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PIS");
            entity.Property(e => e.VlProdutos)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRODUTOS");
            entity.Property(e => e.VlTotalPedido)
                .HasPrecision(15, 2)
                .HasColumnName("VL_TOTAL_PEDIDO");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(15, 4)
                .HasColumnName("VL_UNITARIO");
        });

        modelBuilder.Entity<ErpPedidoVendaItemPendente>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPedidoVenda, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_pedido_venda_item_pendente");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPedidoVenda)
                .HasPrecision(20)
                .HasColumnName("ID_PEDIDO_VENDA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESCONTO");
            entity.Property(e => e.VlFlex)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FLEX");
            entity.Property(e => e.VlProdutos)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRODUTOS");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(15, 2)
                .HasColumnName("VL_UNITARIO");

            entity.HasOne(d => d.ErpPedidoVendaPendente).WithMany(p => p.ErpPedidoVendaItemPendentes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdPedidoVenda })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PEDIDO_VENDA_PENDENTE_ITEM");
        });

        modelBuilder.Entity<ErpPedidoVendaParcela>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPedidoVenda, e.NrParcela })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_pedido_venda_parcelas");

            entity.HasIndex(e => new { e.NrLicenca, e.IdCarteira }, "FK_ERP_PEDIDO_VENDA_CARTEIRA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(4)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPedidoVenda)
                .HasPrecision(20)
                .HasColumnName("ID_PEDIDO_VENDA");
            entity.Property(e => e.NrParcela)
                .HasPrecision(4)
                .HasColumnName("NR_PARCELA");
            entity.Property(e => e.DtVencimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_VENCIMENTO");
            entity.Property(e => e.IdCarteira)
                .HasPrecision(4)
                .HasColumnName("ID_CARTEIRA");
            entity.Property(e => e.VlParcela)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PARCELA");

            entity.HasOne(d => d.ErpBancoCarteira).WithMany(p => p.ErpPedidoVendaParcelas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdCarteira })
                .HasConstraintName("FK_ERP_PEDIDO_VENDA_CARTEIRA");
        });

        modelBuilder.Entity<ErpPedidoVendaPendente>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPedidoVenda })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_pedido_venda_pendente");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPedidoVenda)
                .HasPrecision(20)
                .HasColumnName("ID_PEDIDO_VENDA");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DthrPedido)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_PEDIDO");
            entity.Property(e => e.IdImei)
                .HasMaxLength(60)
                .HasColumnName("ID_IMEI");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.IdPessoaVendedor)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA_VENDEDOR");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
        });

        modelBuilder.Entity<ErpPedidoVendum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPedidoVenda })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_pedido_venda");

            entity.HasIndex(e => new { e.NrLicenca, e.IdCondicaoPagamento }, "FK_ERP_CONDICAO_PAGAMENTO_PEDIDO_VENDA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdNaturezaOperacao }, "FK_ERP_NATUREZA_PEDIDO_VENDA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoa }, "FK_ERP_PESSOA_PEDIDO_VENDA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoaVendedor }, "FK_ERP_PESSOA_PEDIDO_VENDA_VENDEDOR");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPedidoVenda)
                .HasPrecision(20)
                .HasColumnName("ID_PEDIDO_VENDA");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DmTipoFrete)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_FRETE");
            entity.Property(e => e.DsDadosAdicionais)
                .HasMaxLength(1000)
                .HasColumnName("DS_DADOS_ADICIONAIS");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(1000)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtPedido)
                .HasColumnType("datetime")
                .HasColumnName("DT_PEDIDO");
            entity.Property(e => e.DtPrevisao)
                .HasColumnType("datetime")
                .HasColumnName("DT_PREVISAO");
            entity.Property(e => e.IdCondicaoPagamento)
                .HasPrecision(4)
                .HasColumnName("ID_CONDICAO_PAGAMENTO");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.IdPessoaTransportador)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA_TRANSPORTADOR");
            entity.Property(e => e.IdPessoaVendedor)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA_VENDEDOR");
            entity.Property(e => e.NrChaveAcessoReferencia)
                .HasMaxLength(44)
                .HasColumnName("NR_CHAVE_ACESSO_REFERENCIA");
            entity.Property(e => e.NrColeta)
                .HasMaxLength(20)
                .HasColumnName("NR_COLETA");
            entity.Property(e => e.NrPedidoCliente)
                .HasMaxLength(20)
                .HasColumnName("NR_PEDIDO_CLIENTE");
            entity.Property(e => e.NrPesoBruto)
                .HasPrecision(15, 4)
                .HasColumnName("NR_PESO_BRUTO");
            entity.Property(e => e.NrPesoLiquido)
                .HasPrecision(15, 4)
                .HasColumnName("NR_PESO_LIQUIDO");
            entity.Property(e => e.PercDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_DESCONTO");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESCONTO");
            entity.Property(e => e.VlDespAcessorias)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESP_ACESSORIAS");
            entity.Property(e => e.VlFrete)
                .HasPrecision(15, 2)
                .HasColumnName("VL_FRETE");
            entity.Property(e => e.VolumesEspecie)
                .HasMaxLength(60)
                .HasColumnName("VOLUMES_ESPECIE");
            entity.Property(e => e.VolumesMarca)
                .HasMaxLength(60)
                .HasColumnName("VOLUMES_MARCA");
            entity.Property(e => e.VolumesNumero)
                .HasPrecision(8)
                .HasColumnName("VOLUMES_NUMERO");
            entity.Property(e => e.VolumesQtde)
                .HasPrecision(8)
                .HasColumnName("VOLUMES_QTDE");

            entity.HasOne(d => d.ErpCondicaoPagamento).WithMany(p => p.ErpPedidoVenda)
                .HasForeignKey(d => new { d.NrLicenca, d.IdCondicaoPagamento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_CONDICAO_PAGAMENTO_PEDIDO_VENDA");

            entity.HasOne(d => d.ErpNaturezaOperacao).WithMany(p => p.ErpPedidoVenda)
                .HasForeignKey(d => new { d.NrLicenca, d.IdNaturezaOperacao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_NATUREZA_PEDIDO_VENDA");

            entity.HasOne(d => d.ErpPessoa).WithMany(p => p.ErpPedidoVendumErpPessoas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PESSOA_PEDIDO_VENDA");

            entity.HasOne(d => d.ErpPessoaNavigation).WithMany(p => p.ErpPedidoVendumErpPessoaNavigations)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoaVendedor })
                .HasConstraintName("FK_ERP_PESSOA_PEDIDO_VENDA_VENDEDOR");
        });

        modelBuilder.Entity<ErpPerfilTributario>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPerfilTributario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_perfil_tributario");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPerfilTributario)
                .HasPrecision(4)
                .HasColumnName("ID_PERFIL_TRIBUTARIO");
            entity.Property(e => e.DsPerfilTributario)
                .HasMaxLength(100)
                .HasColumnName("DS_PERFIL_TRIBUTARIO");
        });

        modelBuilder.Entity<ErpPerfilTributarioCofin>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPerfilTributario, e.IdNaturezaOperacao })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_perfil_tributario_cofins");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPerfilTributario)
                .HasPrecision(4)
                .HasColumnName("ID_PERFIL_TRIBUTARIO");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.AliqCofins)
                .HasPrecision(15, 2)
                .HasColumnName("ALIQ_COFINS");
            entity.Property(e => e.Cst)
                .HasMaxLength(2)
                .HasColumnName("CST");

            entity.HasOne(d => d.ErpPerfilTributario).WithMany(p => p.ErpPerfilTributarioCofins)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPerfilTributario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PERFIL_TRIBUTARIO_COFINS");
        });

        modelBuilder.Entity<ErpPerfilTributarioIcm>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPerfilTributario, e.IdNaturezaOperacao, e.UfOrigem, e.UfDestino })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_perfil_tributario_icms");

            entity.HasIndex(e => e.CdClassificacao, "FK_ERP_CLASSIFICACAO_PERFIL_ICMS");

            entity.HasIndex(e => new { e.NrLicenca, e.IdNaturezaOperacao }, "FK_ERP_NATUREZA_PERFIL_ICMS");

            entity.HasIndex(e => e.UfDestino, "FK_ERP_UF_DESTINO_ICMS");

            entity.HasIndex(e => e.UfOrigem, "FK_ERP_UF_ORIGEM_ICMS");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPerfilTributario)
                .HasPrecision(4)
                .HasColumnName("ID_PERFIL_TRIBUTARIO");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.UfOrigem)
                .HasMaxLength(2)
                .HasColumnName("UF_ORIGEM");
            entity.Property(e => e.UfDestino)
                .HasMaxLength(2)
                .HasColumnName("UF_DESTINO");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS");
            entity.Property(e => e.AliqIcmsSt)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS_ST");
            entity.Property(e => e.CdClassificacao)
                .HasMaxLength(4)
                .HasColumnName("CD_CLASSIFICACAO");
            entity.Property(e => e.Cst)
                .HasMaxLength(2)
                .HasColumnName("CST");
            entity.Property(e => e.DmDetBaseCalcIcms)
                .HasMaxLength(1)
                .HasColumnName("DM_DET_BASE_CALC_ICMS");
            entity.Property(e => e.DmDetBaseCalcIcmsSt)
                .HasMaxLength(1)
                .HasColumnName("DM_DET_BASE_CALC_ICMS_ST");
            entity.Property(e => e.PercDescSuframa)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_DESC_SUFRAMA");
            entity.Property(e => e.PercFcp)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_FCP");
            entity.Property(e => e.PercMva)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_MVA");
            entity.Property(e => e.PercRedBcIcms)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_RED_BC_ICMS");
            entity.Property(e => e.PercRedBcIcmsSt)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_RED_BC_ICMS_ST");

            entity.HasOne(d => d.CdClassificacaoNavigation).WithMany(p => p.ErpPerfilTributarioIcms)
                .HasForeignKey(d => d.CdClassificacao)
                .HasConstraintName("FK_ERP_CLASSIFICACAO_PERFIL_ICMS");

            entity.HasOne(d => d.UfDestinoNavigation).WithMany(p => p.ErpPerfilTributarioIcmUfDestinoNavigations)
                .HasForeignKey(d => d.UfDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_UF_DESTINO_ICMS");

            entity.HasOne(d => d.UfOrigemNavigation).WithMany(p => p.ErpPerfilTributarioIcmUfOrigemNavigations)
                .HasForeignKey(d => d.UfOrigem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_UF_ORIGEM_ICMS");

            entity.HasOne(d => d.ErpNaturezaOperacao).WithMany(p => p.ErpPerfilTributarioIcms)
                .HasForeignKey(d => new { d.NrLicenca, d.IdNaturezaOperacao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_NATUREZA_PERFIL_ICMS");

            entity.HasOne(d => d.ErpPerfilTributario).WithMany(p => p.ErpPerfilTributarioIcms)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPerfilTributario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PERFIL_PERFIL_ICMS");
        });

        modelBuilder.Entity<ErpPerfilTributarioIcmsSimple>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPerfilTributario, e.IdNaturezaOperacao, e.UfOrigem, e.UfDestino })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_perfil_tributario_icms_simples");

            entity.HasIndex(e => new { e.NrLicenca, e.IdNaturezaOperacao }, "FK_ERP_NATUREZA_OPERACAO_ICMS_SIMPLES");

            entity.HasIndex(e => e.UfDestino, "FK_ERP_UF_DESTINO_SIMPLES");

            entity.HasIndex(e => e.UfOrigem, "FK_ERP_UF_ORIGEM_SIMPLES");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPerfilTributario)
                .HasPrecision(4)
                .HasColumnName("ID_PERFIL_TRIBUTARIO");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.UfOrigem)
                .HasMaxLength(2)
                .HasColumnName("UF_ORIGEM");
            entity.Property(e => e.UfDestino)
                .HasMaxLength(2)
                .HasColumnName("UF_DESTINO");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS");
            entity.Property(e => e.AliqIcmsCred)
                .HasPrecision(15, 2)
                .HasColumnName("ALIQ_ICMS_CRED");
            entity.Property(e => e.AliqIcmsSt)
                .HasPrecision(15, 4)
                .HasColumnName("ALIQ_ICMS_ST");
            entity.Property(e => e.CdClassificacao)
                .HasMaxLength(4)
                .HasColumnName("CD_CLASSIFICACAO");
            entity.Property(e => e.Csosn)
                .HasMaxLength(3)
                .HasColumnName("CSOSN");
            entity.Property(e => e.DmDetBaseCalcIcms)
                .HasMaxLength(1)
                .HasColumnName("DM_DET_BASE_CALC_ICMS");
            entity.Property(e => e.DmDetBaseCalcIcmsSt)
                .HasMaxLength(1)
                .HasColumnName("DM_DET_BASE_CALC_ICMS_ST");
            entity.Property(e => e.PercDescSuframa)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_DESC_SUFRAMA");
            entity.Property(e => e.PercFcp)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_FCP");
            entity.Property(e => e.PercMva)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_MVA");
            entity.Property(e => e.PercRedBcIcms)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_RED_BC_ICMS");
            entity.Property(e => e.PercRedBcIcmsSt)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_RED_BC_ICMS_ST");

            entity.HasOne(d => d.UfDestinoNavigation).WithMany(p => p.ErpPerfilTributarioIcmsSimpleUfDestinoNavigations)
                .HasForeignKey(d => d.UfDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_UF_DESTINO_SIMPLES");

            entity.HasOne(d => d.UfOrigemNavigation).WithMany(p => p.ErpPerfilTributarioIcmsSimpleUfOrigemNavigations)
                .HasForeignKey(d => d.UfOrigem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_UF_ORIGEM_SIMPLES");

            entity.HasOne(d => d.ErpNaturezaOperacao).WithMany(p => p.ErpPerfilTributarioIcmsSimples)
                .HasForeignKey(d => new { d.NrLicenca, d.IdNaturezaOperacao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_NATUREZA_OPERACAO_ICMS_SIMPLES");

            entity.HasOne(d => d.ErpPerfilTributario).WithMany(p => p.ErpPerfilTributarioIcmsSimples)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPerfilTributario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PERFIL_TRIBUTARIO_ICMS_SIMPLES");
        });

        modelBuilder.Entity<ErpPerfilTributarioIpi>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPerfilTributario, e.IdNaturezaOperacao })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_perfil_tributario_ipi");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPerfilTributario)
                .HasPrecision(4)
                .HasColumnName("ID_PERFIL_TRIBUTARIO");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.AliqIpi)
                .HasPrecision(15, 2)
                .HasColumnName("ALIQ_IPI");
            entity.Property(e => e.ClasseEnquadramento)
                .HasMaxLength(5)
                .HasColumnName("CLASSE_ENQUADRAMENTO");
            entity.Property(e => e.CnpjProdutor)
                .HasMaxLength(14)
                .HasColumnName("CNPJ_PRODUTOR");
            entity.Property(e => e.CodigoEnquadramento)
                .HasMaxLength(5)
                .HasColumnName("CODIGO_ENQUADRAMENTO");
            entity.Property(e => e.CodigoSelo)
                .HasMaxLength(5)
                .HasColumnName("CODIGO_SELO");
            entity.Property(e => e.Cst)
                .HasMaxLength(2)
                .HasColumnName("CST");

            entity.HasOne(d => d.ErpPerfilTributario).WithMany(p => p.ErpPerfilTributarioIpis)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPerfilTributario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PERFIL_TRIBUTARIO_TRIB_IPI");
        });

        modelBuilder.Entity<ErpPerfilTributarioPi>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPerfilTributario, e.IdNaturezaOperacao })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_perfil_tributario_pis");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPerfilTributario)
                .HasPrecision(4)
                .HasColumnName("ID_PERFIL_TRIBUTARIO");
            entity.Property(e => e.IdNaturezaOperacao)
                .HasPrecision(8)
                .HasColumnName("ID_NATUREZA_OPERACAO");
            entity.Property(e => e.AliqPis)
                .HasPrecision(15, 2)
                .HasColumnName("ALIQ_PIS");
            entity.Property(e => e.Cst)
                .HasMaxLength(2)
                .HasColumnName("CST");

            entity.HasOne(d => d.ErpPerfilTributario).WithMany(p => p.ErpPerfilTributarioPis)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPerfilTributario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PERFIL_TRIBUTARIO_PIS");
        });

        modelBuilder.Entity<ErpPermissao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdUsuario, e.NmObjeto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_permissao");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.NmObjeto)
                .HasMaxLength(100)
                .HasColumnName("NM_OBJETO");
            entity.Property(e => e.DmTipoPermissao)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_PERMISSAO");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpPermissaos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_ERP_PERMISSAO");
        });

        modelBuilder.Entity<ErpPessoa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPessoa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_pessoa");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoaTipo }, "FK_ERP_PESSOA_TIPO");

            entity.HasIndex(e => new { e.NrLicenca, e.NrCnpjCpf }, "IDX_ERP_PESSOA_001");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.CdPessoa)
                .HasMaxLength(30)
                .HasColumnName("CD_PESSOA");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DmTipoInscricao)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_INSCRICAO");
            entity.Property(e => e.DsBairro)
                .HasMaxLength(60)
                .HasColumnName("DS_BAIRRO");
            entity.Property(e => e.DsComplemento)
                .HasMaxLength(60)
                .HasColumnName("DS_COMPLEMENTO");
            entity.Property(e => e.DsEmail)
                .HasMaxLength(255)
                .HasColumnName("DS_EMAIL");
            entity.Property(e => e.DsEndereco)
                .HasMaxLength(120)
                .HasColumnName("DS_ENDERECO");
            entity.Property(e => e.DthrAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_ATUALIZACAO");
            entity.Property(e => e.DthrInclusao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_INCLUSAO");
            entity.Property(e => e.IdMunicipio)
                .HasPrecision(8)
                .HasColumnName("ID_MUNICIPIO");
            entity.Property(e => e.IdPessoaTipo)
                .HasPrecision(4)
                .HasColumnName("ID_PESSOA_TIPO");
            entity.Property(e => e.NmFantasia)
                .HasMaxLength(120)
                .HasColumnName("NM_FANTASIA");
            entity.Property(e => e.NmRazaoSocial)
                .HasMaxLength(120)
                .HasColumnName("NM_RAZAO_SOCIAL");
            entity.Property(e => e.NrCep)
                .HasMaxLength(8)
                .HasColumnName("NR_CEP");
            entity.Property(e => e.NrCnpjCpf)
                .HasMaxLength(14)
                .HasColumnName("NR_CNPJ_CPF");
            entity.Property(e => e.NrDdd)
                .HasMaxLength(2)
                .HasColumnName("NR_DDD");
            entity.Property(e => e.NrDocumentoEx)
                .HasMaxLength(20)
                .HasColumnName("NR_DOCUMENTO_EX");
            entity.Property(e => e.NrEndereco)
                .HasMaxLength(10)
                .HasColumnName("NR_ENDERECO");
            entity.Property(e => e.NrInscricaoRg)
                .HasMaxLength(20)
                .HasColumnName("NR_INSCRICAO_RG");
            entity.Property(e => e.NrSuframa)
                .HasMaxLength(20)
                .HasColumnName("NR_SUFRAMA");
            entity.Property(e => e.NrTelefone)
                .HasMaxLength(20)
                .HasColumnName("NR_TELEFONE");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpPessoas)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_ERP_PESSOA");

            entity.HasOne(d => d.ErpPessoaTipo).WithMany(p => p.ErpPessoas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoaTipo })
                .HasConstraintName("FK_ERP_PESSOA_TIPO");
        });

        modelBuilder.Entity<ErpPessoaCliente>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPessoa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_pessoa_cliente");

            entity.HasIndex(e => new { e.NrLicenca, e.IdAtividade }, "FK_ERP_ATIVIDADE_ERP_PESSOA_CLIENTE");

            entity.HasIndex(e => new { e.NrLicenca, e.IdCarteira }, "FK_ERP_BANCO_CARTEIRA_PESSOA_CLIENTE");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGrupo }, "FK_ERP_GRUPO_PESSOA_PESSOA_CLIENTE");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTabelaPreco }, "FK_ERP_TABELA_PRECO_PESSOA_CLIENTE");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.DmBloquearLimiteAtingido)
                .HasMaxLength(1)
                .HasColumnName("DM_BLOQUEAR_LIMITE_ATINGIDO");
            entity.Property(e => e.DmConsumidorFinal)
                .HasMaxLength(1)
                .HasColumnName("DM_CONSUMIDOR_FINAL");
            entity.Property(e => e.IdAtividade)
                .HasPrecision(4)
                .HasColumnName("ID_ATIVIDADE");
            entity.Property(e => e.IdCarteira)
                .HasPrecision(4)
                .HasColumnName("ID_CARTEIRA");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.IdPessoaVendedor)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA_VENDEDOR");
            entity.Property(e => e.IdTabelaPreco)
                .HasPrecision(8)
                .HasColumnName("ID_TABELA_PRECO");
            entity.Property(e => e.VlLimiteCredito)
                .HasPrecision(15, 2)
                .HasColumnName("VL_LIMITE_CREDITO");

            entity.HasOne(d => d.ErpAtividadePessoa).WithMany(p => p.ErpPessoaClientes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdAtividade })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ATIVIDADE_ERP_PESSOA_CLIENTE");

            entity.HasOne(d => d.ErpBancoCarteira).WithMany(p => p.ErpPessoaClientes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdCarteira })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_BANCO_CARTEIRA_PESSOA_CLIENTE");

            entity.HasOne(d => d.ErpGrupoPessoa).WithMany(p => p.ErpPessoaClientes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGrupo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_GRUPO_PESSOA_PESSOA_CLIENTE");

            entity.HasOne(d => d.ErpPessoa).WithOne(p => p.ErpPessoaCliente)
                .HasForeignKey<ErpPessoaCliente>(d => new { d.NrLicenca, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PESSOA_CLIENTE");

            entity.HasOne(d => d.ErpTabelaPreco).WithMany(p => p.ErpPessoaClientes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTabelaPreco })
                .HasConstraintName("FK_ERP_TABELA_PRECO_PESSOA_CLIENTE");
        });

        modelBuilder.Entity<ErpPessoaClienteLiberacaoBloqueio>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPessoa, e.DthrEvento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_pessoa_cliente_liberacao_bloqueio");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.DthrEvento)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_EVENTO");
            entity.Property(e => e.DmBloqueioLibera)
                .HasMaxLength(1)
                .HasColumnName("DM_BLOQUEIO_LIBERA");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(4)
                .HasColumnName("ID_USUARIO");

            entity.HasOne(d => d.ErpPessoaCliente).WithMany(p => p.ErpPessoaClienteLiberacaoBloqueios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PESSOA_CLIENTE_LIBERACAO_BLOQUEIO");
        });

        modelBuilder.Entity<ErpPessoaMigracao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.Identificador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_pessoa_migracao");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.DmProcessado)
                .HasMaxLength(1)
                .HasColumnName("DM_PROCESSADO");
            entity.Property(e => e.DsBairro)
                .HasMaxLength(60)
                .HasColumnName("DS_BAIRRO");
            entity.Property(e => e.DsComplemento)
                .HasMaxLength(30)
                .HasColumnName("DS_COMPLEMENTO");
            entity.Property(e => e.DsEmail)
                .HasMaxLength(255)
                .HasColumnName("DS_EMAIL");
            entity.Property(e => e.DsEndereco)
                .HasMaxLength(120)
                .HasColumnName("DS_ENDERECO");
            entity.Property(e => e.DsMunicipio)
                .HasMaxLength(120)
                .HasColumnName("DS_MUNICIPIO");
            entity.Property(e => e.IdMunicipio)
                .HasPrecision(8)
                .HasColumnName("ID_MUNICIPIO");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.NmFantasia)
                .HasMaxLength(120)
                .HasColumnName("NM_FANTASIA");
            entity.Property(e => e.NmRazaoSocial)
                .HasMaxLength(120)
                .HasColumnName("NM_RAZAO_SOCIAL");
            entity.Property(e => e.NrCep)
                .HasMaxLength(8)
                .HasColumnName("NR_CEP");
            entity.Property(e => e.NrCnpjCpf)
                .HasMaxLength(14)
                .HasColumnName("NR_CNPJ_CPF");
            entity.Property(e => e.NrDdd)
                .HasMaxLength(2)
                .HasColumnName("NR_DDD");
            entity.Property(e => e.NrEndereco)
                .HasMaxLength(10)
                .HasColumnName("NR_ENDERECO");
            entity.Property(e => e.NrInscricaoRg)
                .HasMaxLength(20)
                .HasColumnName("NR_INSCRICAO_RG");
            entity.Property(e => e.NrTelefone)
                .HasMaxLength(20)
                .HasColumnName("NR_TELEFONE");
        });

        modelBuilder.Entity<ErpPessoaTipo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPessoaTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_pessoa_tipo");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPessoaTipo)
                .HasPrecision(4)
                .HasColumnName("ID_PESSOA_TIPO");
            entity.Property(e => e.DsPessoaTipo)
                .HasMaxLength(60)
                .HasColumnName("DS_PESSOA_TIPO");
        });

        modelBuilder.Entity<ErpPessoaUsuario>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPessoa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_pessoa_usuario");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
        });

        modelBuilder.Entity<ErpPessoaVendedor>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPessoa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_pessoa_vendedor");

            entity.HasIndex(e => e.CodigoBanco, "FK_ERP_BANCO_PESSOA_VENDEDOR");

            entity.HasIndex(e => new { e.NrLicenca, e.IdSetor }, "FK_ERP_SETOR_ERP_VENDEDOR");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.CodigoBanco)
                .HasMaxLength(5)
                .HasColumnName("CODIGO_BANCO");
            entity.Property(e => e.DmTipoConta)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_CONTA");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.IdSetor)
                .HasPrecision(4)
                .HasColumnName("ID_SETOR");
            entity.Property(e => e.NrAgencia)
                .HasMaxLength(10)
                .HasColumnName("NR_AGENCIA");
            entity.Property(e => e.NrConta)
                .HasMaxLength(20)
                .HasColumnName("NR_CONTA");
            entity.Property(e => e.PercComissao)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_COMISSAO");

            entity.HasOne(d => d.CodigoBancoNavigation).WithMany(p => p.ErpPessoaVendedors)
                .HasForeignKey(d => d.CodigoBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_BANCO_PESSOA_VENDEDOR");

            entity.HasOne(d => d.ErpPessoa).WithOne(p => p.ErpPessoaVendedor)
                .HasForeignKey<ErpPessoaVendedor>(d => new { d.NrLicenca, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PESSOA_ERP_PESSOA_VENDEDOR");

            entity.HasOne(d => d.ErpSetor).WithMany(p => p.ErpPessoaVendedors)
                .HasForeignKey(d => new { d.NrLicenca, d.IdSetor })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_SETOR_ERP_VENDEDOR");
        });

        modelBuilder.Entity<ErpPolo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdPolo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_polo");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdPolo)
                .HasPrecision(4)
                .HasColumnName("ID_POLO");
            entity.Property(e => e.DsPolo)
                .HasMaxLength(100)
                .HasColumnName("DS_POLO");
        });

        modelBuilder.Entity<ErpProducaoFicha>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdProducaoFicha })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_producao_ficha");

            entity.HasIndex(e => new { e.NrLicenca, e.IdAlmoxarifado }, "FK_ERP_ALMOXARIFADO_PRODUCAO_FICHA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_PRODUCAO_FICHA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdUsuario }, "FK_ERP_USUARIO_PRODUCAO_FICHA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdUsuarioFinalizou }, "FK_ERP_USUARIO_PRODUCAO_FICHA_FINALIZOU");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdProducaoFicha)
                .HasPrecision(20)
                .HasColumnName("ID_PRODUCAO_FICHA");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtInicioProducao)
                .HasColumnType("datetime")
                .HasColumnName("DT_INICIO_PRODUCAO");
            entity.Property(e => e.DtTerminoProducao)
                .HasColumnType("datetime")
                .HasColumnName("DT_TERMINO_PRODUCAO");
            entity.Property(e => e.IdAlmoxarifado)
                .HasPrecision(4)
                .HasColumnName("ID_ALMOXARIFADO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.IdUsuarioFinalizou)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO_FINALIZOU");
            entity.Property(e => e.QuantidadeAProduzir)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE_A_PRODUZIR");
            entity.Property(e => e.QuantidadeProduzida)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE_PRODUZIDA");

            entity.HasOne(d => d.ErpAlmoxarifado).WithMany(p => p.ErpProducaoFichas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdAlmoxarifado })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_ALMOXARIFADO_PRODUCAO_FICHA");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProducaoFichas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_PRODUCAO_FICHA");

            entity.HasOne(d => d.ErpUsuario).WithMany(p => p.ErpProducaoFichaErpUsuarios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdUsuario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_USUARIO_PRODUCAO_FICHA");

            entity.HasOne(d => d.ErpUsuarioNavigation).WithMany(p => p.ErpProducaoFichaErpUsuarioNavigations)
                .HasForeignKey(d => new { d.NrLicenca, d.IdUsuarioFinalizou })
                .HasConstraintName("FK_ERP_USUARIO_PRODUCAO_FICHA_FINALIZOU");
        });

        modelBuilder.Entity<ErpProducaoFichaKardex>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdProducaoFicha })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_producao_ficha_kardex");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdProducaoFicha)
                .HasPrecision(20)
                .HasColumnName("ID_PRODUCAO_FICHA");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");

            entity.HasOne(d => d.ErpProducaoFicha).WithOne(p => p.ErpProducaoFichaKardex)
                .HasForeignKey<ErpProducaoFichaKardex>(d => new { d.NrLicenca, d.IdEmpresa, d.IdProducaoFicha })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUCAO_FICHA_KARDEX");
        });

        modelBuilder.Entity<ErpProducaoFichaLote>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdProducaoFicha, e.IdSerialLote })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_producao_ficha_lote");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdProducaoFicha)
                .HasPrecision(20)
                .HasColumnName("ID_PRODUCAO_FICHA");
            entity.Property(e => e.IdSerialLote)
                .HasMaxLength(60)
                .HasColumnName("ID_SERIAL_LOTE");

            entity.HasOne(d => d.ErpProducaoFicha).WithMany(p => p.ErpProducaoFichaLotes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdProducaoFicha })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUCAO_FICHA_LOTE");
        });

        modelBuilder.Entity<ErpProducaoFichaMateriaPrima>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdProducaoFicha, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_producao_ficha_materia_prima");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdProducaoFicha)
                .HasPrecision(20)
                .HasColumnName("ID_PRODUCAO_FICHA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");

            entity.HasOne(d => d.ErpProducaoFicha).WithMany(p => p.ErpProducaoFichaMateriaPrimas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdProducaoFicha })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUCAO_FICHA_MATERIA_PRIMA");
        });

        modelBuilder.Entity<ErpProducaoFichaMateriaPrimaKardex>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdProducaoFicha, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_producao_ficha_materia_prima_kardex");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdProducaoFicha)
                .HasPrecision(20)
                .HasColumnName("ID_PRODUCAO_FICHA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdKardex)
                .HasMaxLength(60)
                .HasColumnName("ID_KARDEX");

            entity.HasOne(d => d.ErpProducaoFichaMateriaPrima).WithOne(p => p.ErpProducaoFichaMateriaPrimaKardex)
                .HasForeignKey<ErpProducaoFichaMateriaPrimaKardex>(d => new { d.NrLicenca, d.IdEmpresa, d.IdProducaoFicha, d.NrItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUCAO_FICHA_MATERIA_PRIMA_KARDEX");
        });

        modelBuilder.Entity<ErpProducaoFichaMateriaPrimaLote>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdProducaoFicha, e.NrItem, e.Identificador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_producao_ficha_materia_prima_lote");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdProducaoFicha)
                .HasPrecision(20)
                .HasColumnName("ID_PRODUCAO_FICHA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");

            entity.HasOne(d => d.ErpProducaoFichaMateriaPrima).WithMany(p => p.ErpProducaoFichaMateriaPrimaLotes)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdProducaoFicha, d.NrItem })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUCAO_FICHA_MATERIA_PRIMA_LOTE");
        });

        modelBuilder.Entity<ErpProdutoLote>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdSerialLote })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_produto_lote");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdSerialLote)
                .HasMaxLength(60)
                .HasColumnName("ID_SERIAL_LOTE");
            entity.Property(e => e.DtFabricacao)
                .HasColumnType("datetime")
                .HasColumnName("DT_FABRICACAO");
            entity.Property(e => e.DtVencimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_VENCIMENTO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.NrLote)
                .HasMaxLength(255)
                .HasColumnName("NR_LOTE");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");
        });

        modelBuilder.Entity<ErpProdutoLoteMovimento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.Identificador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_produto_lote_movimento");

            entity.HasIndex(e => new { e.NrLicenca, e.IdSerialLote }, "FK_ERP_PRODUTO_LOTE_MOVIMENTO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.DmEntradaSaida)
                .HasMaxLength(1)
                .HasColumnName("DM_ENTRADA_SAIDA");
            entity.Property(e => e.IdSerialLote)
                .HasMaxLength(60)
                .HasColumnName("ID_SERIAL_LOTE");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");

            entity.HasOne(d => d.ErpProdutoLote).WithMany(p => p.ErpProdutoLoteMovimentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdSerialLote })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_LOTE_MOVIMENTO");
        });

        modelBuilder.Entity<ErpProdutoSaldo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico, e.DtSaldo, e.IdEmpresa, e.IdAlmoxarifado })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_produto_saldo");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa }, "FK_ERP_EMPRESA_PRODUTO_SALDO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.DtSaldo)
                .HasColumnType("datetime")
                .HasColumnName("DT_SALDO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdAlmoxarifado)
                .HasPrecision(4)
                .HasColumnName("ID_ALMOXARIFADO");
            entity.Property(e => e.QtdAnterior)
                .HasPrecision(15, 4)
                .HasColumnName("QTD_ANTERIOR");
            entity.Property(e => e.QtdEntrada)
                .HasPrecision(15, 4)
                .HasColumnName("QTD_ENTRADA");
            entity.Property(e => e.QtdSaida)
                .HasPrecision(15, 4)
                .HasColumnName("QTD_SAIDA");
            entity.Property(e => e.QtdSaldoAtual)
                .HasPrecision(15, 4)
                .HasColumnName("QTD_SALDO_ATUAL");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpProdutoSaldos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_PRODUTO_SALDO");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProdutoSaldos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SALDO_PRODUTO");
        });

        modelBuilder.Entity<ErpProdutoServico>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_produto_servico");

            entity.HasIndex(e => new { e.NrLicenca, e.IdCategoria }, "FK_ERP_CATEGORIA_PRODUTO_SERVICO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGrupo }, "FK_ERP_GRUPO_ERP_PRODUTO_SERVICO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGrupoPrecoProduto }, "FK_ERP_GRUPO_PRECO_PRODUTO_SERVICO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdSubgrupo }, "FK_ERP_SUBGRUPO_ERP_PRODUTO_SERVICO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.CdCest)
                .HasMaxLength(7)
                .HasColumnName("CD_CEST");
            entity.Property(e => e.CdProdutoExterno)
                .HasMaxLength(60)
                .HasColumnName("CD_PRODUTO_EXTERNO");
            entity.Property(e => e.CdProdutoServico)
                .HasMaxLength(60)
                .HasColumnName("CD_PRODUTO_SERVICO");
            entity.Property(e => e.DmControlaLote)
                .HasMaxLength(1)
                .HasColumnName("DM_CONTROLA_LOTE");
            entity.Property(e => e.DmOrigem)
                .HasMaxLength(1)
                .HasColumnName("DM_ORIGEM");
            entity.Property(e => e.DmProdutoBalanca)
                .HasMaxLength(1)
                .HasColumnName("DM_PRODUTO_BALANCA");
            entity.Property(e => e.DmProdutoServico)
                .HasMaxLength(1)
                .HasColumnName("DM_PRODUTO_SERVICO");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DmTipoItem)
                .HasMaxLength(2)
                .HasColumnName("DM_TIPO_ITEM");
            entity.Property(e => e.DsObservacao).HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DsProdutoServico)
                .HasMaxLength(120)
                .HasColumnName("DS_PRODUTO_SERVICO");
            entity.Property(e => e.DthrAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_ATUALIZACAO");
            entity.Property(e => e.DthrInclusao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_INCLUSAO");
            entity.Property(e => e.IdCategoria)
                .HasPrecision(4)
                .HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.IdCor)
                .HasPrecision(4)
                .HasColumnName("ID_COR");
            entity.Property(e => e.IdEan13)
                .HasMaxLength(14)
                .HasColumnName("ID_EAN13");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.IdGrupoPrecoProduto)
                .HasPrecision(8)
                .HasColumnName("ID_GRUPO_PRECO_PRODUTO");
            entity.Property(e => e.IdNcm)
                .HasPrecision(8)
                .HasColumnName("ID_NCM");
            entity.Property(e => e.IdSubgrupo)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO");
            entity.Property(e => e.IdUnidadeMedida)
                .HasMaxLength(6)
                .HasColumnName("ID_UNIDADE_MEDIDA");
            entity.Property(e => e.NmImpressora)
                .HasMaxLength(255)
                .HasColumnName("NM_IMPRESSORA");
            entity.Property(e => e.NrAltura)
                .HasPrecision(20, 2)
                .HasColumnName("NR_ALTURA");
            entity.Property(e => e.NrComprimento)
                .HasPrecision(20, 2)
                .HasColumnName("NR_COMPRIMENTO");
            entity.Property(e => e.NrDiasValidadeBalanca)
                .HasMaxLength(3)
                .HasColumnName("NR_DIAS_VALIDADE_BALANCA");
            entity.Property(e => e.NrLargura)
                .HasPrecision(20, 2)
                .HasColumnName("NR_LARGURA");
            entity.Property(e => e.NrPesoBruto)
                .HasPrecision(15, 3)
                .HasColumnName("NR_PESO_BRUTO");
            entity.Property(e => e.NrPesoLiquido)
                .HasPrecision(15, 3)
                .HasColumnName("NR_PESO_LIQUIDO");
            entity.Property(e => e.NrReferencia)
                .HasMaxLength(60)
                .HasColumnName("NR_REFERENCIA");
            entity.Property(e => e.NrTamanho)
                .HasMaxLength(30)
                .HasColumnName("NR_TAMANHO");
            entity.Property(e => e.QtdeEmbalagem)
                .HasPrecision(10)
                .HasColumnName("QTDE_EMBALAGEM");
            entity.Property(e => e.VlCusto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_CUSTO");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpProdutoServicos)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_ERP_PRODUTO_SERVICO");

            entity.HasOne(d => d.ErpCategoriaProduto).WithMany(p => p.ErpProdutoServicos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdCategoria })
                .HasConstraintName("FK_ERP_CATEGORIA_PRODUTO_SERVICO");

            entity.HasOne(d => d.ErpGrupoProduto).WithMany(p => p.ErpProdutoServicos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGrupo })
                .HasConstraintName("FK_ERP_GRUPO_ERP_PRODUTO_SERVICO");

            entity.HasOne(d => d.ErpGrupoPrecoProduto).WithMany(p => p.ErpProdutoServicos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGrupoPrecoProduto })
                .HasConstraintName("FK_ERP_GRUPO_PRECO_PRODUTO_SERVICO");

            entity.HasOne(d => d.ErpSubgrupoProduto).WithMany(p => p.ErpProdutoServicos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdSubgrupo })
                .HasConstraintName("FK_ERP_SUBGRUPO_ERP_PRODUTO_SERVICO");
        });

        modelBuilder.Entity<ErpProdutoServicoCaracteristica>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NrReferencia, e.IdCaracteristica })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_caracteristica");

            entity.HasIndex(e => new { e.NrLicenca, e.IdCaracteristica }, "FK_ERP_CARACTERISTICA_PRODUTO_SERVICO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NrReferencia)
                .HasMaxLength(60)
                .HasColumnName("NR_REFERENCIA");
            entity.Property(e => e.IdCaracteristica)
                .HasPrecision(4)
                .HasColumnName("ID_CARACTERISTICA");

            entity.HasOne(d => d.ErpCaracteristica).WithMany(p => p.ErpProdutoServicoCaracteristicas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdCaracteristica })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_CARACTERISTICA_PRODUTO_SERVICO");
        });

        modelBuilder.Entity<ErpProdutoServicoCodigo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutosCodigos })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_produto_servico_codigos");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_CODIGOS");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTabelaPreco }, "FK_ERP_PRODUTO_SERVICO_CODIGOS_TABELA_PRECO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.DmCodigoPrincipal)
                .HasMaxLength(1)
                .HasColumnName("DM_CODIGO_PRINCIPAL");
            entity.Property(e => e.DsProdutoCodigo)
                .HasMaxLength(255)
                .HasColumnName("DS_PRODUTO_CODIGO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdTabelaPreco)
                .HasPrecision(8)
                .HasColumnName("ID_TABELA_PRECO");
            entity.Property(e => e.IdUnidadeMedida)
                .HasMaxLength(6)
                .HasColumnName("ID_UNIDADE_MEDIDA");
            entity.Property(e => e.QtdeFatorEntrada)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_FATOR_ENTRADA");
            entity.Property(e => e.QtdeFatorSaida)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_FATOR_SAIDA");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProdutoServicoCodigos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_CODIGOS");

            entity.HasOne(d => d.ErpTabelaPreco).WithMany(p => p.ErpProdutoServicoCodigos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTabelaPreco })
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_CODIGOS_TABELA_PRECO");
        });

        modelBuilder.Entity<ErpProdutoServicoCodigoFornecedor>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NrCnpjEmitente, e.CdProdutoEmitente })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_codigo_fornecedor");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NrCnpjEmitente)
                .HasMaxLength(14)
                .HasColumnName("NR_CNPJ_EMITENTE");
            entity.Property(e => e.CdProdutoEmitente)
                .HasMaxLength(120)
                .HasColumnName("CD_PRODUTO_EMITENTE");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
        });

        modelBuilder.Entity<ErpProdutoServicoComponente>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico, e.IdProdutoServicoComponente })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_componente");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServicoComponente }, "FK_ERP_PRODUTO_SERVICO_COMPONENTE2");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutoServicoComponente)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO_COMPONENTE");
            entity.Property(e => e.Quantidade)
                .HasPrecision(15, 4)
                .HasColumnName("QUANTIDADE");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProdutoServicoComponenteErpProdutoServicos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_COMPONENTE");

            entity.HasOne(d => d.ErpProdutoServicoNavigation).WithMany(p => p.ErpProdutoServicoComponenteErpProdutoServicoNavigations)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServicoComponente })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_COMPONENTE2");
        });

        modelBuilder.Entity<ErpProdutoServicoCorImagem>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NrReferencia, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_cor_imagem");

            entity.HasIndex(e => e.IdImagem, "FK_ERP_IMAGEM_PRODUTO_COIR-IMAGEM");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NrReferencia)
                .HasMaxLength(60)
                .HasColumnName("NR_REFERENCIA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.CdImagemExterno)
                .HasMaxLength(60)
                .HasColumnName("CD_IMAGEM_EXTERNO");
            entity.Property(e => e.IdCor)
                .HasPrecision(4)
                .HasColumnName("ID_COR");
            entity.Property(e => e.IdImagem)
                .HasMaxLength(60)
                .HasColumnName("ID_IMAGEM");

            entity.HasOne(d => d.IdImagemNavigation).WithMany(p => p.ErpProdutoServicoCorImagems)
                .HasForeignKey(d => d.IdImagem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_IMAGEM_PRODUTO_COIR-IMAGEM");
        });

        modelBuilder.Entity<ErpProdutoServicoDesossa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico, e.IdProdutoServicoPeca })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_desossa");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServicoPeca }, "FK_ERP_PRODUTO_SERVICO_DESOSSA_PECA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutoServicoPeca)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO_PECA");
            entity.Property(e => e.FatorPercentual)
                .HasPrecision(15, 4)
                .HasColumnName("FATOR_PERCENTUAL");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProdutoServicoDesossaErpProdutoServicos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_DESOSSA");

            entity.HasOne(d => d.ErpProdutoServicoNavigation).WithMany(p => p.ErpProdutoServicoDesossaErpProdutoServicoNavigations)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServicoPeca })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_DESOSSA_PECA");
        });

        modelBuilder.Entity<ErpProdutoServicoDesossaPerdum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico, e.IdTipoMovimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_desossa_perda");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProdutoServicoDesossaPerda)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_DESOSSA_PERDA");
        });

        modelBuilder.Entity<ErpProdutoServicoEcommerce>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NrReferencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_produto_servico_ecommerce");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NrReferencia)
                .HasMaxLength(60)
                .HasColumnName("NR_REFERENCIA");
            entity.Property(e => e.DescricaoCompleta)
                .HasMaxLength(1000)
                .HasColumnName("DESCRICAO_COMPLETA");
            entity.Property(e => e.DescricaoMetaKeywords)
                .HasMaxLength(1000)
                .HasColumnName("DESCRICAO_META_KEYWORDS");
            entity.Property(e => e.DescricaoResumida)
                .HasMaxLength(1000)
                .HasColumnName("DESCRICAO_RESUMIDA");
            entity.Property(e => e.DescricaoTags)
                .HasMaxLength(1000)
                .HasColumnName("DESCRICAO_TAGS");
            entity.Property(e => e.DsProdutoLoja)
                .HasMaxLength(255)
                .HasColumnName("DS_PRODUTO_LOJA");
            entity.Property(e => e.IdPessoaMarca)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA_MARCA");
        });

        modelBuilder.Entity<ErpProdutoServicoEmpresaPreco>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutosCodigos, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_empresa_preco");

            entity.HasIndex(e => new { e.NrLicenca, e.Identificador }, "IDX001_ERP_PRODUTO_SERVICO_EMPRESA_PRECO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdTabelaPreco)
                .HasPrecision(8)
                .HasColumnName("ID_TABELA_PRECO");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");

            entity.HasOne(d => d.ErpProdutoServicoCodigo).WithMany(p => p.ErpProdutoServicoEmpresaPrecos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutosCodigos })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_CODIGOS_EMPRESA_PRECO");
        });

        modelBuilder.Entity<ErpProdutoServicoFornecedoresCotacao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico, e.IdPessoa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_fornecedores_cotacao");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoa }, "FK_ERP_PESSOA_FORNECEDORES_COTACAO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");

            entity.HasOne(d => d.ErpPessoa).WithMany(p => p.ErpProdutoServicoFornecedoresCotacaos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PESSOA_FORNECEDORES_COTACAO");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProdutoServicoFornecedoresCotacaos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_FORNECEDORES_COTACAO");
        });

        modelBuilder.Entity<ErpProdutoServicoLock>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_produto_servico_lock");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");

            entity.HasOne(d => d.ErpProdutoServico).WithOne(p => p.ErpProdutoServicoLock)
                .HasForeignKey<ErpProdutoServicoLock>(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_PRODUTO_LOCK");
        });

        modelBuilder.Entity<ErpProdutoServicoMigracao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.Identificador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_produto_servico_migracao");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.CdNcm)
                .HasMaxLength(8)
                .HasColumnName("CD_NCM");
            entity.Property(e => e.DmControlaLote)
                .HasMaxLength(1)
                .HasColumnName("DM_CONTROLA_LOTE");
            entity.Property(e => e.DmOrigem)
                .HasMaxLength(1)
                .HasColumnName("DM_ORIGEM");
            entity.Property(e => e.DmProcessado)
                .HasMaxLength(1)
                .HasColumnName("DM_PROCESSADO");
            entity.Property(e => e.DmProdutoBalanca)
                .HasMaxLength(1)
                .HasColumnName("DM_PRODUTO_BALANCA");
            entity.Property(e => e.DsCategoriaProduto)
                .HasMaxLength(60)
                .HasColumnName("DS_CATEGORIA_PRODUTO");
            entity.Property(e => e.DsGrupoProduto)
                .HasMaxLength(60)
                .HasColumnName("DS_GRUPO_PRODUTO");
            entity.Property(e => e.DsProdutoServico)
                .HasMaxLength(120)
                .HasColumnName("DS_PRODUTO_SERVICO");
            entity.Property(e => e.DsRegraFiscalSat)
                .HasMaxLength(255)
                .HasColumnName("DS_REGRA_FISCAL_SAT");
            entity.Property(e => e.DsSubgrupoProduto)
                .HasMaxLength(60)
                .HasColumnName("DS_SUBGRUPO_PRODUTO");
            entity.Property(e => e.IdPerfilTributarioNfe)
                .HasPrecision(4)
                .HasColumnName("ID_PERFIL_TRIBUTARIO_NFE");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.IdUnidadeMedida)
                .HasMaxLength(6)
                .HasColumnName("ID_UNIDADE_MEDIDA");
            entity.Property(e => e.PesoBruto)
                .HasPrecision(15, 3)
                .HasColumnName("PESO_BRUTO");
            entity.Property(e => e.PesoLiquido)
                .HasPrecision(15, 3)
                .HasColumnName("PESO_LIQUIDO");
            entity.Property(e => e.QtdeEmbalagem)
                .HasPrecision(15, 3)
                .HasColumnName("QTDE_EMBALAGEM");
            entity.Property(e => e.QtdeEstoque)
                .HasPrecision(15, 3)
                .HasColumnName("QTDE_ESTOQUE");
            entity.Property(e => e.VlCusto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_CUSTO");
            entity.Property(e => e.VlPreco)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRECO");
        });

        modelBuilder.Entity<ErpProdutoServicoOutro>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_produto_servico_outros");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPerfilTributario }, "FK_ERP_PERFIL_TRIBUTARIO_PRODUTO_SERVICO_OUTROS");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DsLocalizacaoProduto)
                .HasMaxLength(100)
                .HasColumnName("DS_LOCALIZACAO_PRODUTO");
            entity.Property(e => e.DsRegraTributacaoSat)
                .HasMaxLength(255)
                .HasColumnName("DS_REGRA_TRIBUTACAO_SAT");
            entity.Property(e => e.IdPerfilTributario)
                .HasPrecision(4)
                .HasColumnName("ID_PERFIL_TRIBUTARIO");
            entity.Property(e => e.PercComissao)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_COMISSAO");
            entity.Property(e => e.QtdeMaximaEstoque)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_MAXIMA_ESTOQUE");
            entity.Property(e => e.QtdeMinimaEstoque)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_MINIMA_ESTOQUE");

            entity.HasOne(d => d.ErpPerfilTributario).WithMany(p => p.ErpProdutoServicoOutros)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPerfilTributario })
                .HasConstraintName("FK_ERP_PERFIL_TRIBUTARIO_PRODUTO_SERVICO_OUTROS");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProdutoServicoOutros)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_OUTROS");
        });

        modelBuilder.Entity<ErpProdutoValorMedio>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdProdutoServico, e.DtValorMedio, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_produto_valor_medio");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa }, "FK_ERP_EMPRESA_PRODUTO_VALOR_MEDIO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.DtValorMedio)
                .HasColumnType("datetime")
                .HasColumnName("DT_VALOR_MEDIO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.ValorMedio)
                .HasPrecision(15, 2)
                .HasColumnName("VALOR_MEDIO");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpProdutoValorMedios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_PRODUTO_VALOR_MEDIO");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpProdutoValorMedios)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_VALOR_MEDIO_PRODUTO");
        });

        modelBuilder.Entity<ErpPromocao>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPromocao })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_promocao");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoPromocao }, "FK_ERP_PROMOCAO_TIPO_ERP_PROMOCAO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPromocao)
                .HasPrecision(8)
                .HasColumnName("ID_PROMOCAO");
            entity.Property(e => e.DmLiberado)
                .HasMaxLength(1)
                .HasColumnName("DM_LIBERADO");
            entity.Property(e => e.DsPromocao)
                .HasMaxLength(100)
                .HasColumnName("DS_PROMOCAO");
            entity.Property(e => e.DtInicio)
                .HasColumnType("datetime")
                .HasColumnName("DT_INICIO");
            entity.Property(e => e.DtTermino)
                .HasColumnType("datetime")
                .HasColumnName("DT_TERMINO");
            entity.Property(e => e.IdTipoPromocao)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_PROMOCAO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpPromocaos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_ERP_PROMOCAO");

            entity.HasOne(d => d.ErpPromocaoTipo).WithMany(p => p.ErpPromocaos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoPromocao })
                .HasConstraintName("FK_ERP_PROMOCAO_TIPO_ERP_PROMOCAO");
        });

        modelBuilder.Entity<ErpPromocaoPack>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPromocao })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_promocao_packs");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPromocao)
                .HasPrecision(8)
                .HasColumnName("ID_PROMOCAO");
            entity.Property(e => e.AutorPromocao)
                .HasMaxLength(255)
                .HasColumnName("AUTOR_PROMOCAO");
            entity.Property(e => e.DsPromocao)
                .HasMaxLength(255)
                .HasColumnName("DS_PROMOCAO");
            entity.Property(e => e.DsPromocaoTitulo)
                .HasMaxLength(255)
                .HasColumnName("DS_PROMOCAO_TITULO");
            entity.Property(e => e.DtInicio)
                .HasColumnType("datetime")
                .HasColumnName("DT_INICIO");
            entity.Property(e => e.DtTermino)
                .HasColumnType("datetime")
                .HasColumnName("DT_TERMINO");
            entity.Property(e => e.LimiteTicket)
                .HasPrecision(8)
                .HasColumnName("LIMITE_TICKET");
        });

        modelBuilder.Entity<ErpPromocaoPacksDescontoVariado>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPromocao, e.NrItem, e.IdProdutosCodigos })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_promocao_packs_desconto_variado");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPromocao)
                .HasPrecision(8)
                .HasColumnName("ID_PROMOCAO");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.PercDesconto)
                .HasPrecision(15, 4)
                .HasColumnName("PERC_DESCONTO");
            entity.Property(e => e.Qtde)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE");

            entity.HasOne(d => d.ErpPromocaoPack).WithMany(p => p.ErpPromocaoPacksDescontoVariados)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdPromocao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PROMOCAO_PACKS_DESCONTO_VARIADO");
        });

        modelBuilder.Entity<ErpPromocaoPacksLevaPaga>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPromocao, e.IdProdutosCodigos })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_promocao_packs_leva_paga");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPromocao)
                .HasPrecision(8)
                .HasColumnName("ID_PROMOCAO");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.QtdeLeva)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_LEVA");
            entity.Property(e => e.QtdePaga)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_PAGA");

            entity.HasOne(d => d.ErpPromocaoPack).WithMany(p => p.ErpPromocaoPacksLevaPagas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdPromocao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PROMOCAO_PACKS_LEVA_PAGA");
        });

        modelBuilder.Entity<ErpPromocaoPacksPrecoFixo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdPromocao, e.NrItem, e.IdProdutosCodigos })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("erp_promocao_packs_preco_fixo");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdPromocao)
                .HasPrecision(8)
                .HasColumnName("ID_PROMOCAO");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.Qtde)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE");
            entity.Property(e => e.ValorFixo)
                .HasPrecision(15, 2)
                .HasColumnName("VALOR_FIXO");

            entity.HasOne(d => d.ErpPromocaoPack).WithMany(p => p.ErpPromocaoPacksPrecoFixos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdPromocao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PROMOCAO_PACKS_PRECO_FIXO");
        });

        modelBuilder.Entity<ErpPromocaoProdutosCodigo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.Identificador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_promocao_produtos_codigos");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutosCodigos }, "FK_ERP_PRODUTO_SERVICO_CODIGOS_PRODUTOS_PROMOCAO");

            entity.HasIndex(e => new { e.NrLicenca, e.IdEmpresa, e.IdPromocao }, "FK_ERP_PROMOCAO_PRODUTOS_CODIGOS");

            entity.HasIndex(e => new { e.NrLicenca, e.IdRecebimento }, "FK_PDV_TIPO_RECEBIMENTO_PROMOCAO_PRODUTOS_CODIGOS");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.DmValor)
                .HasMaxLength(1)
                .HasColumnName("DM_VALOR");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.IdPromocao)
                .HasPrecision(8)
                .HasColumnName("ID_PROMOCAO");
            entity.Property(e => e.IdRecebimento)
                .HasPrecision(8)
                .HasColumnName("ID_RECEBIMENTO");
            entity.Property(e => e.QtdeFinal)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_FINAL");
            entity.Property(e => e.QtdeInicial)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_INICIAL");
            entity.Property(e => e.Valor)
                .HasPrecision(15, 2)
                .HasColumnName("VALOR");

            entity.HasOne(d => d.ErpProdutoServicoCodigo).WithMany(p => p.ErpPromocaoProdutosCodigos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutosCodigos })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_CODIGOS_PRODUTOS_PROMOCAO");

            entity.HasOne(d => d.PdvTipoRecebimento).WithMany(p => p.ErpPromocaoProdutosCodigos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdRecebimento })
                .HasConstraintName("FK_PDV_TIPO_RECEBIMENTO_PROMOCAO_PRODUTOS_CODIGOS");

            entity.HasOne(d => d.ErpPromocao).WithMany(p => p.ErpPromocaoProdutosCodigos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdPromocao })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PROMOCAO_PRODUTOS_CODIGOS");
        });

        modelBuilder.Entity<ErpPromocaoTipo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipoPromocao })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_promocao_tipo");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipoPromocao)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_PROMOCAO");
            entity.Property(e => e.DsTipoPromocao)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO_PROMOCAO");
        });

        modelBuilder.Entity<ErpProxCodigo>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.NmEntidade })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_prox_codigo");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(60)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.NmEntidade)
                .HasMaxLength(60)
                .HasColumnName("NM_ENTIDADE");
            entity.Property(e => e.NrUltimoCodigo)
                .HasPrecision(19)
                .HasColumnName("NR_ULTIMO_CODIGO");
        });

        modelBuilder.Entity<ErpRegraFiscalSat>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdRegraFiscal })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_regra_fiscal_sat");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdRegraFiscal)
                .HasPrecision(4)
                .HasColumnName("ID_REGRA_FISCAL");
            entity.Property(e => e.DsDescricao)
                .HasMaxLength(60)
                .HasColumnName("DS_DESCRICAO");
            entity.Property(e => e.DsRegraFiscal)
                .HasMaxLength(60)
                .HasColumnName("DS_REGRA_FISCAL");
        });

        modelBuilder.Entity<ErpSetor>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdSetor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_setor");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPolo }, "FK_ERP_POLO_ERP_SETOR");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdSetor)
                .HasPrecision(4)
                .HasColumnName("ID_SETOR");
            entity.Property(e => e.DsSetor)
                .HasMaxLength(100)
                .HasColumnName("DS_SETOR");
            entity.Property(e => e.IdPolo)
                .HasPrecision(4)
                .HasColumnName("ID_POLO");

            entity.HasOne(d => d.ErpPolo).WithMany(p => p.ErpSetors)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPolo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_POLO_ERP_SETOR");
        });

        modelBuilder.Entity<ErpSinc>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdSinc })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_sinc");

            entity.HasIndex(e => new { e.NrLicenca, e.DmSinc, e.DthrGeracao }, "IDX_0001_ERP_SINC");

            entity.HasIndex(e => new { e.NrLicenca, e.DmSinc }, "IDX_0002_ERP_SINC");

            entity.HasIndex(e => new { e.NrLicenca, e.DmSinc, e.NmTabela }, "IDX_0003_ERP_SINC");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdSinc)
                .HasMaxLength(60)
                .HasColumnName("ID_SINC");
            entity.Property(e => e.DmPrioridade)
                .HasPrecision(8)
                .HasColumnName("DM_PRIORIDADE");
            entity.Property(e => e.DmSinc)
                .HasMaxLength(1)
                .HasColumnName("DM_SINC");
            entity.Property(e => e.DsErroExecucao)
                .HasMaxLength(5000)
                .HasColumnName("DS_ERRO_EXECUCAO");
            entity.Property(e => e.DthrGeracao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_GERACAO");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.NmTabela)
                .HasMaxLength(60)
                .HasColumnName("NM_TABELA");
            entity.Property(e => e.VlChave)
                .HasMaxLength(5000)
                .HasColumnName("VL_CHAVE");

            entity.HasOne(d => d.ErpEmpresa).WithMany(p => p.ErpSincs)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_EMPRESA_ERP_SINC");
        });

        modelBuilder.Entity<ErpSincCodigo>(entity =>
        {
            entity.HasKey(e => new { e.GuidIdentificador, e.NrLicenca })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_sinc_codigos");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutosCodigos }, "FK_ERP_SINC_CODGOS_ERP_PRODUTO_SERVICO_CODIGOS");

            entity.HasIndex(e => new { e.NrLicenca, e.IdComputador }, "FK_ERP_SNC_CODIGOS_ERP_COMPUTADOR");

            entity.Property(e => e.GuidIdentificador)
                .HasMaxLength(60)
                .HasColumnName("GUID_IDENTIFICADOR");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DthrGeracao)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_GERACAO");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");

            entity.HasOne(d => d.ErpComputador).WithMany(p => p.ErpSincCodigos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdComputador })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_SNC_CODIGOS_ERP_COMPUTADOR");

            entity.HasOne(d => d.ErpProdutoServicoCodigo).WithMany(p => p.ErpSincCodigos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutosCodigos })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_SINC_CODGOS_ERP_PRODUTO_SERVICO_CODIGOS");
        });

        modelBuilder.Entity<ErpSincEcommerce>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdSinc, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_sinc_ecommerce");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdSinc)
                .HasMaxLength(60)
                .HasColumnName("ID_SINC");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DmPrioridade)
                .HasPrecision(8)
                .HasColumnName("DM_PRIORIDADE");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DsSinc)
                .HasMaxLength(60)
                .HasColumnName("DS_SINC");
            entity.Property(e => e.DthrGeracao).HasColumnName("DTHR_GERACAO");
            entity.Property(e => e.VlSinc)
                .HasMaxLength(255)
                .HasColumnName("VL_SINC");
        });

        modelBuilder.Entity<ErpSubgrupoDespesa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdSubgrupoDespesa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_subgrupo_despesa");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGrupoDespesa }, "FK_ERP_GRUPO_SUBGRUPO_DESPESA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdSubgrupoDespesa)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO_DESPESA");
            entity.Property(e => e.DsSubgrupoDespesa)
                .HasMaxLength(60)
                .HasColumnName("DS_SUBGRUPO_DESPESA");
            entity.Property(e => e.IdGrupoDespesa)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO_DESPESA");

            entity.HasOne(d => d.ErpGrupoDespesa).WithMany(p => p.ErpSubgrupoDespesas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGrupoDespesa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_GRUPO_SUBGRUPO_DESPESA");
        });

        modelBuilder.Entity<ErpSubgrupoProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdSubgrupo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_subgrupo_produto");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGrupo }, "FK_ERP_GRUPO_SUBGRUPO_PRODUTO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdSubgrupo)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO");
            entity.Property(e => e.DsSubgrupo)
                .HasMaxLength(60)
                .HasColumnName("DS_SUBGRUPO");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");

            entity.HasOne(d => d.ErpGrupoProduto).WithMany(p => p.ErpSubgrupoProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGrupo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_GRUPO_SUBGRUPO");
        });

        modelBuilder.Entity<ErpSubgrupoReceitum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdSubgrupoReceita })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_subgrupo_receita");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGrupoReceita }, "FK_ERP_GRUPO_SUBGRUPO_RECEITA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdSubgrupoReceita)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO_RECEITA");
            entity.Property(e => e.DsSubgrupoReceita)
                .HasMaxLength(60)
                .HasColumnName("DS_SUBGRUPO_RECEITA");
            entity.Property(e => e.IdGrupoReceita)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO_RECEITA");

            entity.HasOne(d => d.ErpGrupoReceitum).WithMany(p => p.ErpSubgrupoReceita)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGrupoReceita })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_GRUPO_SUBGRUPO_RECEITA");
        });

        modelBuilder.Entity<ErpSugestaoCompra>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.DtCompra, e.IdProdutoServico, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_sugestao_compras");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_SUGESTAO_COMPRA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.DtCompra)
                .HasColumnType("datetime")
                .HasColumnName("DT_COMPRA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DtUltimaCompra).HasColumnName("DT_ULTIMA_COMPRA");
            entity.Property(e => e.QtdeComprar)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_COMPRAR");
            entity.Property(e => e.QtdeEstoque)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_ESTOQUE");
            entity.Property(e => e.QtdeSugestao)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_SUGESTAO");
            entity.Property(e => e.QtdeVendida30Dias)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_VENDIDA_30_DIAS");
            entity.Property(e => e.QtdeVendida60Dias)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_VENDIDA_60_DIAS");
            entity.Property(e => e.QtdeVendida90Dias)
                .HasPrecision(15, 4)
                .HasColumnName("QTDE_VENDIDA_90_DIAS");
            entity.Property(e => e.VlPrecoPedido)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRECO_PEDIDO");
            entity.Property(e => e.VlUltimaCompra)
                .HasPrecision(15, 2)
                .HasColumnName("VL_ULTIMA_COMPRA");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpSugestaoCompras)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_SUGESTAO_COMPRA");
        });

        modelBuilder.Entity<ErpTabelaPreco>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTabelaPreco })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_tabela_preco");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTabelaPreco)
                .HasPrecision(8)
                .HasColumnName("ID_TABELA_PRECO");
            entity.Property(e => e.DsTabelaPreco)
                .HasMaxLength(255)
                .HasColumnName("DS_TABELA_PRECO");
            entity.Property(e => e.DtInicioVigencia).HasColumnName("DT_INICIO_VIGENCIA");
            entity.Property(e => e.DtTerminoVigencia).HasColumnName("DT_TERMINO_VIGENCIA");
        });

        modelBuilder.Entity<ErpTabelaPrecoProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTabelaPreco, e.DtInicio, e.IdProdutoServico })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_tabela_preco_produto");

            entity.HasIndex(e => new { e.NrLicenca, e.IdProdutoServico }, "FK_ERP_PRODUTO_SERVICO_PRECOS");

            entity.HasIndex(e => new { e.NrLicenca, e.IdUsuario }, "FK_ERP_USUARIO_ERP_TABELA_PRECO_PRODUTO");

            entity.HasIndex(e => new { e.NrLicenca, e.Identificador }, "IDX001_ERP_TABELA_PRECO_PRODUTO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTabelaPreco)
                .HasPrecision(8)
                .HasColumnName("ID_TABELA_PRECO");
            entity.Property(e => e.DtInicio)
                .HasColumnType("datetime")
                .HasColumnName("DT_INICIO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.PercMargem)
                .HasPrecision(15, 4)
                .HasColumnName("PERC_MARGEM");
            entity.Property(e => e.VlCusto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_CUSTO");
            entity.Property(e => e.VlPreco)
                .HasPrecision(15, 2)
                .HasColumnName("VL_PRECO");

            entity.HasOne(d => d.ErpProdutoServico).WithMany(p => p.ErpTabelaPrecoProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdProdutoServico })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PRODUTO_SERVICO_PRECOS");

            entity.HasOne(d => d.ErpTabelaPreco).WithMany(p => p.ErpTabelaPrecoProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTabelaPreco })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TABELA_PRECO_PRODUTO");

            entity.HasOne(d => d.ErpUsuario).WithMany(p => p.ErpTabelaPrecoProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdUsuario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_USUARIO_ERP_TABELA_PRECO_PRODUTO");
        });

        modelBuilder.Entity<ErpTeste>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTeste })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_teste");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTeste)
                .HasPrecision(8)
                .HasColumnName("ID_TESTE");
            entity.Property(e => e.DsTeste)
                .HasMaxLength(60)
                .HasColumnName("DS_TESTE");
        });

        modelBuilder.Entity<ErpTipoDespesa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipoDespesa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_tipo_despesa");

            entity.HasIndex(e => new { e.NrLicenca, e.IdSubgrupoDespesa }, "FK_ERP_SUBGRUPO_TIPO_DESPESA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipoDespesa)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_DESPESA");
            entity.Property(e => e.DsTipoDespesa)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO_DESPESA");
            entity.Property(e => e.IdSubgrupoDespesa)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO_DESPESA");

            entity.HasOne(d => d.ErpSubgrupoDespesa).WithMany(p => p.ErpTipoDespesas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdSubgrupoDespesa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_SUBGRUPO_TIPO_DESPESA");
        });

        modelBuilder.Entity<ErpTipoMovimentoBanco>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipoMovimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_tipo_movimento_banco");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");
            entity.Property(e => e.DmEntradaSaida)
                .HasMaxLength(1)
                .HasColumnName("DM_ENTRADA_SAIDA");
            entity.Property(e => e.DsTipoMovimento)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO_MOVIMENTO");
        });

        modelBuilder.Entity<ErpTipoMovimentoEstoque>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipoMovimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_tipo_movimento_estoque");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");
            entity.Property(e => e.DmCalculoCustoMedio)
                .HasMaxLength(1)
                .HasColumnName("DM_CALCULO_CUSTO_MEDIO");
            entity.Property(e => e.DmEntradaSaida)
                .HasMaxLength(1)
                .HasColumnName("DM_ENTRADA_SAIDA");
            entity.Property(e => e.DsSigla)
                .HasMaxLength(6)
                .HasColumnName("DS_SIGLA");
            entity.Property(e => e.DsTipoMovimento)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO_MOVIMENTO");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpTipoMovimentoEstoques)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_TIPO_MOVIMENTO_ESTOQUE");
        });

        modelBuilder.Entity<ErpTipoPagamento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipoPagamento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_tipo_pagamento");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoMovimento }, "FK_ERP_TIPO_PAGAMENTO_MOVIMENTO_BANCO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipoPagamento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_PAGAMENTO");
            entity.Property(e => e.DsTipoPagamento)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO_PAGAMENTO");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");

            entity.HasOne(d => d.ErpTipoMovimentoBanco).WithMany(p => p.ErpTipoPagamentos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoMovimento })
                .HasConstraintName("FK_ERP_TIPO_PAGAMENTO_MOVIMENTO_BANCO");
        });

        modelBuilder.Entity<ErpTipoRecebimento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipoRecebimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_tipo_recebimento");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipoRecebimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_RECEBIMENTO");
            entity.Property(e => e.DsTipoRecebimento)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO_RECEBIMENTO");
            entity.Property(e => e.IdTipoMovimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_MOVIMENTO");
        });

        modelBuilder.Entity<ErpTipoReceitum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipoReceita })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_tipo_receita");

            entity.HasIndex(e => new { e.NrLicenca, e.IdSubgrupoReceita }, "FK_ERP_SUBGRUPO_TIPO_RECEITA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipoReceita)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_RECEITA");
            entity.Property(e => e.DsTipoReceita)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO_RECEITA");
            entity.Property(e => e.IdSubgrupoReceita)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO_RECEITA");

            entity.HasOne(d => d.ErpSubgrupoReceitum).WithMany(p => p.ErpTipoReceita)
                .HasForeignKey(d => new { d.NrLicenca, d.IdSubgrupoReceita })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_SUBGRUPO_TIPO_RECEITA");
        });

        modelBuilder.Entity<ErpTipoSangriaAporte>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTipoSangriaAporte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_tipo_sangria_aporte");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTipoSangriaAporte)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_SANGRIA_APORTE");
            entity.Property(e => e.DmSangriaAporte)
                .HasMaxLength(1)
                .HasColumnName("DM_SANGRIA_APORTE");
            entity.Property(e => e.DsTipoSangriaAporte)
                .HasMaxLength(60)
                .HasColumnName("DS_TIPO_SANGRIA_APORTE");
        });

        modelBuilder.Entity<ErpTituloGuidsProcessado>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.GuidTitulo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_titulo_guids_processados");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.GuidTitulo).HasColumnName("GUID_TITULO");
            entity.Property(e => e.DmProcessado)
                .HasMaxLength(1)
                .HasColumnName("DM_PROCESSADO");
            entity.Property(e => e.DsProcessamento).HasColumnName("DS_PROCESSAMENTO");
            entity.Property(e => e.DtLancamento)
                .HasColumnType("datetime")
                .HasColumnName("DT_LANCAMENTO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
        });

        modelBuilder.Entity<ErpTituloPagar>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTitulo, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_titulo_pagar");

            entity.HasIndex(e => new { e.NrLicenca, e.IdGem, e.IdEmpresa }, "FK_ERP_GEM_TITULO_PAGAR");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoa }, "FK_ERP_PESSOA_TITULO_PAGAR");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoDespesa }, "FK_ERP_TIPO_DESPESA_TITULO_PAGAR");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTitulo)
                .HasPrecision(20)
                .HasColumnName("ID_TITULO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtEmissao)
                .HasColumnType("datetime")
                .HasColumnName("DT_EMISSAO");
            entity.Property(e => e.DtPagamento)
                .HasColumnType("datetime")
                .HasColumnName("DT_PAGAMENTO");
            entity.Property(e => e.DtVencimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_VENCIMENTO");
            entity.Property(e => e.IdGem)
                .HasPrecision(20)
                .HasColumnName("ID_GEM");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.IdTipoDespesa)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_DESPESA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.NrDocumento)
                .HasMaxLength(20)
                .HasColumnName("NR_DOCUMENTO");
            entity.Property(e => e.NrParcela)
                .HasPrecision(4)
                .HasColumnName("NR_PARCELA");
            entity.Property(e => e.QtdeParcelas)
                .HasPrecision(4)
                .HasColumnName("QTDE_PARCELAS");
            entity.Property(e => e.VlDocumento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DOCUMENTO");
            entity.Property(e => e.VlSaldo)
                .HasPrecision(15, 2)
                .HasColumnName("VL_SALDO");

            entity.HasOne(d => d.ErpPessoa).WithMany(p => p.ErpTituloPagars)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PESSOA_TITULO_PAGAR");

            entity.HasOne(d => d.ErpTipoDespesa).WithMany(p => p.ErpTituloPagars)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoDespesa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_DESPESA_TITULO_PAGAR");

            entity.HasOne(d => d.ErpEntradaGem).WithMany(p => p.ErpTituloPagars)
                .HasForeignKey(d => new { d.NrLicenca, d.IdGem, d.IdEmpresa })
                .HasConstraintName("FK_ERP_GEM_TITULO_PAGAR");
        });

        modelBuilder.Entity<ErpTituloPagarBaixa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdBaixaPagar })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_titulo_pagar_baixa");

            entity.HasIndex(e => new { e.NrLicenca, e.IdBancoConta }, "FK_ERP_BANCO_CONTA_PAGAR_BAIXA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoPagamento }, "FK_ERP_TIPO_PAGAMENTO_PAGAR_BAIXA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTitulo, e.IdEmpresa }, "FK_ERP_TITULO_PAGAR_BAIXA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdBaixaPagar)
                .HasMaxLength(60)
                .HasColumnName("ID_BAIXA_PAGAR");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtBaixa).HasColumnName("DT_BAIXA");
            entity.Property(e => e.IdBancoConta)
                .HasPrecision(4)
                .HasColumnName("ID_BANCO_CONTA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdTipoPagamento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_PAGAMENTO");
            entity.Property(e => e.IdTitulo)
                .HasPrecision(20)
                .HasColumnName("ID_TITULO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.VlBaixa)
                .HasPrecision(15, 2)
                .HasColumnName("VL_BAIXA");

            entity.HasOne(d => d.ErpBancoContum).WithMany(p => p.ErpTituloPagarBaixas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdBancoConta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_BANCO_CONTA_PAGAR_BAIXA");

            entity.HasOne(d => d.ErpTipoPagamento).WithMany(p => p.ErpTituloPagarBaixas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoPagamento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_PAGAMENTO_PAGAR_BAIXA");

            entity.HasOne(d => d.ErpTituloPagar).WithMany(p => p.ErpTituloPagarBaixas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTitulo, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TITULO_PAGAR_BAIXA");
        });

        modelBuilder.Entity<ErpTituloPagarBaixaMovimentoBanco>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdBaixaPagar, e.IdMovimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_titulo_pagar_baixa_movimento_banco");

            entity.HasIndex(e => new { e.NrLicenca, e.IdMovimento }, "FK_ERP_MOVIMENTO_BANCO_BAIXA_MOVIMENTO");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdBaixaPagar)
                .HasMaxLength(60)
                .HasColumnName("ID_BAIXA_PAGAR");
            entity.Property(e => e.IdMovimento)
                .HasMaxLength(60)
                .HasColumnName("ID_MOVIMENTO");

            entity.HasOne(d => d.ErpTituloPagarBaixa).WithMany(p => p.ErpTituloPagarBaixaMovimentoBancos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdBaixaPagar })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TITULO_PAGAR_BAIXA_MOVIMENTO_BANCO");

            entity.HasOne(d => d.ErpMovimentoBanco).WithMany(p => p.ErpTituloPagarBaixaMovimentoBancos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_BANCO_BAIXA_MOVIMENTO");
        });

        modelBuilder.Entity<ErpTituloReceber>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdTitulo, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_titulo_receber");

            entity.HasIndex(e => new { e.NrLicenca, e.IdCarteira }, "FK_ERP_BANCO_CARTEIRA_TITULO_RECEBER");

            entity.HasIndex(e => new { e.NrLicenca, e.IdPessoa }, "FK_ERP_PESSOA_TITULO_RECEBER");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoReceita }, "FK_ERP_TIPO_RECEITA_TITULO_RECEBER");

            entity.HasIndex(e => new { e.NrLicenca, e.IdVenda }, "IDX0002_ERP_TITULO_RECEBER");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdTitulo)
                .HasPrecision(20)
                .HasColumnName("ID_TITULO");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtEmissao)
                .HasColumnType("datetime")
                .HasColumnName("DT_EMISSAO");
            entity.Property(e => e.DtRecebimento).HasColumnName("DT_RECEBIMENTO");
            entity.Property(e => e.DtVencimento).HasColumnName("DT_VENCIMENTO");
            entity.Property(e => e.IdCarteira)
                .HasPrecision(4)
                .HasColumnName("ID_CARTEIRA");
            entity.Property(e => e.IdMovimento)
                .HasPrecision(20)
                .HasColumnName("ID_MOVIMENTO");
            entity.Property(e => e.IdPessoa)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA");
            entity.Property(e => e.IdPessoaVendedor)
                .HasPrecision(8)
                .HasColumnName("ID_PESSOA_VENDEDOR");
            entity.Property(e => e.IdTipoReceita)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_RECEITA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.IdVenda)
                .HasMaxLength(60)
                .HasColumnName("ID_VENDA");
            entity.Property(e => e.NrDocumento)
                .HasPrecision(10)
                .HasColumnName("NR_DOCUMENTO");
            entity.Property(e => e.NrParcela)
                .HasPrecision(4)
                .HasColumnName("NR_PARCELA");
            entity.Property(e => e.PercDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_DESCONTO");
            entity.Property(e => e.QtdeParcelas)
                .HasPrecision(4)
                .HasColumnName("QTDE_PARCELAS");
            entity.Property(e => e.TxJuros)
                .HasPrecision(15, 2)
                .HasColumnName("TX_JUROS");
            entity.Property(e => e.VlComissao)
                .HasPrecision(15, 2)
                .HasColumnName("VL_COMISSAO");
            entity.Property(e => e.VlCustoAdm)
                .HasPrecision(15, 2)
                .HasColumnName("VL_CUSTO_ADM");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(15, 2)
                .HasColumnName("VL_DESCONTO");
            entity.Property(e => e.VlJuros)
                .HasPrecision(15, 2)
                .HasColumnName("VL_JUROS");
            entity.Property(e => e.VlMulta)
                .HasPrecision(15, 2)
                .HasColumnName("VL_MULTA");
            entity.Property(e => e.VlSaldo)
                .HasPrecision(15, 2)
                .HasColumnName("VL_SALDO");
            entity.Property(e => e.VlTitulo)
                .HasPrecision(15, 2)
                .HasColumnName("VL_TITULO");
            entity.Property(e => e.VlTotalBaixa)
                .HasPrecision(15, 2)
                .HasColumnName("VL_TOTAL_BAIXA");

            entity.HasOne(d => d.ErpBancoCarteira).WithMany(p => p.ErpTituloRecebers)
                .HasForeignKey(d => new { d.NrLicenca, d.IdCarteira })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_BANCO_CARTEIRA_TITULO_RECEBER");

            entity.HasOne(d => d.ErpPessoa).WithMany(p => p.ErpTituloRecebers)
                .HasForeignKey(d => new { d.NrLicenca, d.IdPessoa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_PESSOA_TITULO_RECEBER");

            entity.HasOne(d => d.ErpTipoReceitum).WithMany(p => p.ErpTituloRecebers)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoReceita })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_RECEITA_TITULO_RECEBER");
        });

        modelBuilder.Entity<ErpTituloReceberBaixa>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdBaixaReceber })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_titulo_receber_baixa");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTipoRecebimento }, "FK_ERP_TIPO_RECEBIMENTO_BAIXA");

            entity.HasIndex(e => new { e.NrLicenca, e.IdTitulo, e.IdEmpresa }, "FK_ERP_TITULO_RECEBER_BAIXA");

            entity.HasIndex(e => new { e.NrLicenca, e.NrLote }, "IDX_0001_ERP_TITULO_RECEBER_BAIXA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdBaixaReceber)
                .HasMaxLength(60)
                .HasColumnName("ID_BAIXA_RECEBER");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.DtRecebimento)
                .HasColumnType("datetime")
                .HasColumnName("DT_RECEBIMENTO");
            entity.Property(e => e.IdBancoConta)
                .HasPrecision(4)
                .HasColumnName("ID_BANCO_CONTA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdTipoRecebimento)
                .HasPrecision(4)
                .HasColumnName("ID_TIPO_RECEBIMENTO");
            entity.Property(e => e.IdTitulo)
                .HasPrecision(20)
                .HasColumnName("ID_TITULO");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.NrLote)
                .HasMaxLength(60)
                .HasColumnName("NR_LOTE");
            entity.Property(e => e.VlRecebimento)
                .HasPrecision(15, 2)
                .HasColumnName("VL_RECEBIMENTO");

            entity.HasOne(d => d.ErpTipoRecebimento).WithMany(p => p.ErpTituloReceberBaixas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTipoRecebimento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TIPO_RECEBIMENTO_BAIXA");

            entity.HasOne(d => d.ErpTituloReceber).WithMany(p => p.ErpTituloReceberBaixas)
                .HasForeignKey(d => new { d.NrLicenca, d.IdTitulo, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TITULO_RECEBER_BAIXA");
        });

        modelBuilder.Entity<ErpTituloReceberBaixaMovimentoBanco>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdBaixaReceber, e.IdMovimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_titulo_receber_baixa_movimento_banco");

            entity.HasIndex(e => new { e.NrLicenca, e.IdMovimento }, "FK_ERP_MOVIMENTO_BANCO_BAIXA_MOVIMENTO_RECEBER");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdBaixaReceber)
                .HasMaxLength(60)
                .HasColumnName("ID_BAIXA_RECEBER");
            entity.Property(e => e.IdMovimento)
                .HasMaxLength(60)
                .HasColumnName("ID_MOVIMENTO");

            entity.HasOne(d => d.ErpTituloReceberBaixa).WithMany(p => p.ErpTituloReceberBaixaMovimentoBancos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdBaixaReceber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_TITULO_RECEBER_BAIXA_MOVIMENTO");

            entity.HasOne(d => d.ErpMovimentoBanco).WithMany(p => p.ErpTituloReceberBaixaMovimentoBancos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdMovimento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_MOVIMENTO_BANCO_BAIXA_MOVIMENTO_RECEBER");
        });

        modelBuilder.Entity<ErpTituloReceberBaixaUsuarioConvenio>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdBaixaReceber, e.IdUsuario, e.IdComputador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_titulo_receber_baixa_usuario_convenio");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdBaixaReceber)
                .HasMaxLength(60)
                .HasColumnName("ID_BAIXA_RECEBER");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(4)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
        });

        modelBuilder.Entity<ErpUf>(entity =>
        {
            entity.HasKey(e => e.IdUf).HasName("PRIMARY");

            entity.ToTable("erp_uf");

            entity.Property(e => e.IdUf)
                .HasMaxLength(2)
                .HasColumnName("ID_UF");
            entity.Property(e => e.DsUf)
                .HasMaxLength(60)
                .HasColumnName("DS_UF");
        });

        modelBuilder.Entity<ErpUnidadeMedidum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdUnidadeMedida })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_unidade_medida");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdUnidadeMedida)
                .HasMaxLength(6)
                .HasColumnName("ID_UNIDADE_MEDIDA");
            entity.Property(e => e.DsUnidadeMedida)
                .HasMaxLength(60)
                .HasColumnName("DS_UNIDADE_MEDIDA");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.ErpUnidadeMedida)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_UNIDADE_MEDIDA");
        });

        modelBuilder.Entity<ErpUsuario>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_usuario");

            entity.HasIndex(e => new { e.NrLicenca, e.NmLogin }, "IDX_0001_ERP_USUARIO").IsUnique();

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.DmCaixa)
                .HasMaxLength(1)
                .HasColumnName("DM_CAIXA");
            entity.Property(e => e.DmFiscal)
                .HasMaxLength(1)
                .HasColumnName("DM_FISCAL");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DmTipoUsuario)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_USUARIO");
            entity.Property(e => e.DsEmail)
                .HasMaxLength(100)
                .HasColumnName("DS_EMAIL");
            entity.Property(e => e.DsSenhaFiscal)
                .HasMaxLength(60)
                .HasColumnName("DS_SENHA_FISCAL");
            entity.Property(e => e.HashAtivacao)
                .HasMaxLength(100)
                .HasColumnName("HASH_ATIVACAO");
            entity.Property(e => e.NmCompleto)
                .HasMaxLength(60)
                .HasColumnName("NM_COMPLETO");
            entity.Property(e => e.NmLogin)
                .HasMaxLength(60)
                .HasColumnName("NM_LOGIN");
            entity.Property(e => e.NmUsuario)
                .HasMaxLength(60)
                .HasColumnName("NM_USUARIO");
            entity.Property(e => e.SenhaFiscal)
                .HasMaxLength(60)
                .HasColumnName("SENHA_FISCAL");
            entity.Property(e => e.SenhaUsuario)
                .HasMaxLength(60)
                .HasColumnName("SENHA_USUARIO");
            entity.Property(e => e.SenhaUsuarioMd5)
                .HasMaxLength(60)
                .HasColumnName("SENHA_USUARIO_MD5");
        });

        modelBuilder.Entity<ErpUsuario1>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_usuarios");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.DmCaixa)
                .HasMaxLength(1)
                .HasColumnName("DM_CAIXA");
            entity.Property(e => e.DmFiscal)
                .HasMaxLength(1)
                .HasColumnName("DM_FISCAL");
            entity.Property(e => e.DmStatus)
                .HasMaxLength(1)
                .HasColumnName("DM_STATUS");
            entity.Property(e => e.DmTipoUsuario)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_USUARIO");
            entity.Property(e => e.DsEmail)
                .HasMaxLength(100)
                .HasColumnName("DS_EMAIL");
            entity.Property(e => e.DsSenhaFiscal)
                .HasMaxLength(60)
                .HasColumnName("DS_SENHA_FISCAL");
            entity.Property(e => e.HashAtivacao)
                .HasMaxLength(100)
                .HasColumnName("HASH_ATIVACAO");
            entity.Property(e => e.NmCompleto)
                .HasMaxLength(60)
                .HasColumnName("NM_COMPLETO");
            entity.Property(e => e.NmLogin)
                .HasMaxLength(60)
                .HasColumnName("NM_LOGIN");
            entity.Property(e => e.NmUsuario)
                .HasMaxLength(60)
                .HasColumnName("NM_USUARIO");
            entity.Property(e => e.SenhaFiscal)
                .HasMaxLength(60)
                .HasColumnName("SENHA_FISCAL");
            entity.Property(e => e.SenhaUsuarioMd5)
                .HasMaxLength(60)
                .HasColumnName("SENHA_USUARIO_MD5");
        });

        modelBuilder.Entity<ErpUsuarioIp>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdUsuario, e.NrIp })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_usuario_ip");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.NrIp)
                .HasMaxLength(20)
                .HasColumnName("NR_IP");

            entity.HasOne(d => d.ErpUsuario).WithMany(p => p.ErpUsuarioIps)
                .HasForeignKey(d => new { d.NrLicenca, d.IdUsuario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_USUARIO_IP");
        });

        modelBuilder.Entity<ErpUsuarioSession>(entity =>
        {
            entity.HasKey(e => e.IdSession).HasName("PRIMARY");

            entity.ToTable("erp_usuario_session");

            entity.HasIndex(e => new { e.NrLicenca, e.IdUsuario }, "FK_ERP_USUARIO_ERP_SESSION");

            entity.Property(e => e.IdSession)
                .HasMaxLength(100)
                .HasColumnName("ID_SESSION");
            entity.Property(e => e.DthrLogin)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_LOGIN");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");

            entity.HasOne(d => d.ErpUsuario).WithMany(p => p.ErpUsuarioSessions)
                .HasForeignKey(d => new { d.NrLicenca, d.IdUsuario })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_USUARIO_ERP_SESSION");
        });

        modelBuilder.Entity<ErpVendaProduto>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdVenda, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("erp_venda_produto");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdVenda)
                .HasMaxLength(60)
                .HasColumnName("ID_VENDA");
            entity.Property(e => e.NrItem)
                .HasPrecision(4)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.DsProdutoServico)
                .HasMaxLength(120)
                .HasColumnName("DS_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.VlQuantidade)
                .HasPrecision(15, 4)
                .HasColumnName("VL_QUANTIDADE");
            entity.Property(e => e.VlSubTotal)
                .HasPrecision(15, 2)
                .HasColumnName("VL_SUB_TOTAL");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(15, 2)
                .HasColumnName("VL_UNITARIO");

            entity.HasOne(d => d.ErpVendum).WithMany(p => p.ErpVendaProdutos)
                .HasForeignKey(d => new { d.NrLicenca, d.IdEmpresa, d.IdVenda })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_VENDA_ERP_VENDA_PRODUTO");
        });

        modelBuilder.Entity<ErpVendum>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdEmpresa, e.IdVenda })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("erp_venda");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdEmpresa)
                .HasPrecision(8)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.IdVenda)
                .HasMaxLength(60)
                .HasColumnName("ID_VENDA");
            entity.Property(e => e.DmSituacao)
                .HasMaxLength(1)
                .HasColumnName("DM_SITUACAO");
            entity.Property(e => e.DsObservacao)
                .HasMaxLength(255)
                .HasColumnName("DS_OBSERVACAO");
            entity.Property(e => e.IdCliente)
                .HasPrecision(8)
                .HasColumnName("ID_CLIENTE");
            entity.Property(e => e.IdUsuario)
                .HasPrecision(8)
                .HasColumnName("ID_USUARIO");
            entity.Property(e => e.NmCliente)
                .HasMaxLength(120)
                .HasColumnName("NM_CLIENTE");
            entity.Property(e => e.NrComanda)
                .HasPrecision(8)
                .HasColumnName("NR_COMANDA");
            entity.Property(e => e.NrVenda)
                .HasPrecision(8)
                .HasColumnName("NR_VENDA");
        });

        modelBuilder.Entity<ErpWebLog>(entity =>
        {
            entity.HasKey(e => new { e.IdSession, e.DthrLog })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("erp_web_log");

            entity.Property(e => e.IdSession)
                .HasMaxLength(100)
                .HasColumnName("ID_SESSION");
            entity.Property(e => e.DthrLog)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_LOG");
            entity.Property(e => e.DsUrl)
                .HasMaxLength(100)
                .HasColumnName("DS_URL");
        });

        modelBuilder.Entity<PdvCartoesBandeira>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdCartoesBandeira })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("pdv_cartoes_bandeira");

            entity.HasIndex(e => e.IdBandeira, "FK_CARTOES_BANDEIRA_PDV_CARTOES_BANDEIRA");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdCartoesBandeira)
                .HasMaxLength(60)
                .HasColumnName("ID_CARTOES_BANDEIRA");
            entity.Property(e => e.DiaCompensacao)
                .HasPrecision(3)
                .HasColumnName("DIA_COMPENSACAO");
            entity.Property(e => e.DmDebitoCredito)
                .HasMaxLength(1)
                .HasColumnName("DM_DEBITO_CREDITO");
            entity.Property(e => e.IdBandeira)
                .HasMaxLength(60)
                .HasColumnName("ID_BANDEIRA");
            entity.Property(e => e.PercTarifa)
                .HasPrecision(15, 2)
                .HasColumnName("PERC_TARIFA");

            entity.HasOne(d => d.IdBandeiraNavigation).WithMany(p => p.PdvCartoesBandeiras)
                .HasForeignKey(d => d.IdBandeira)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARTOES_BANDEIRA_PDV_CARTOES_BANDEIRA");
        });

        modelBuilder.Entity<PdvGrupoTipoRecebimento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdGrupo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("pdv_grupo_tipo_recebimento");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(8)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.DsGrupo)
                .HasMaxLength(60)
                .HasColumnName("DS_GRUPO");
        });

        modelBuilder.Entity<PdvTipoRecebimento>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdRecebimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("pdv_tipo_recebimento");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdRecebimento)
                .HasPrecision(8)
                .HasColumnName("ID_RECEBIMENTO");
            entity.Property(e => e.DmOperacaotef)
                .HasMaxLength(1)
                .HasColumnName("DM_OPERACAOTEF");
            entity.Property(e => e.DmOrdemTotal)
                .HasPrecision(8)
                .HasColumnName("DM_ORDEM_TOTAL");
            entity.Property(e => e.DmParcelamento)
                .HasMaxLength(1)
                .HasColumnName("DM_PARCELAMENTO");
            entity.Property(e => e.DmPreencheValor)
                .HasMaxLength(1)
                .HasColumnName("DM_PREENCHE_VALOR");
            entity.Property(e => e.DmTeclaAtalho)
                .HasMaxLength(5)
                .HasColumnName("DM_TECLA_ATALHO");
            entity.Property(e => e.DmTef)
                .HasMaxLength(1)
                .HasColumnName("DM_TEF");
            entity.Property(e => e.DmTipoRecebimento)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_RECEBIMENTO");
            entity.Property(e => e.DsRecebimento)
                .HasMaxLength(50)
                .HasColumnName("DS_RECEBIMENTO");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(8)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.Observacao)
                .HasMaxLength(255)
                .HasColumnName("OBSERVACAO");

            entity.HasOne(d => d.NrLicencaNavigation).WithMany(p => p.PdvTipoRecebimentos)
                .HasForeignKey(d => d.NrLicenca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_LICENCA_PDV_TIPO_RECEBIMENTO");
        });

        modelBuilder.Entity<PdvTipoRecebimentoComputador>(entity =>
        {
            entity.HasKey(e => new { e.NrLicenca, e.IdComputador, e.IdRecebimento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("pdv_tipo_recebimento_computador");

            entity.HasIndex(e => new { e.NrLicenca, e.IdRecebimento }, "FK_PDV_TIPO_RECEBIMENTO_COMPUTADOR");

            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.IdRecebimento)
                .HasPrecision(8)
                .HasColumnName("ID_RECEBIMENTO");

            entity.HasOne(d => d.ErpComputador).WithMany(p => p.PdvTipoRecebimentoComputadors)
                .HasForeignKey(d => new { d.NrLicenca, d.IdComputador })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERP_COMPUTADOR_RECEBIMENTO_COMPUTADOR");

            entity.HasOne(d => d.PdvTipoRecebimento).WithMany(p => p.PdvTipoRecebimentoComputadors)
                .HasForeignKey(d => new { d.NrLicenca, d.IdRecebimento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PDV_TIPO_RECEBIMENTO_COMPUTADOR");
        });

        modelBuilder.Entity<ScantechUrl>(entity =>
        {
            entity.HasKey(e => e.DsUrl).HasName("PRIMARY");

            entity.ToTable("scantech_urls");

            entity.Property(e => e.DsUrl).HasColumnName("DS_URL");
            entity.Property(e => e.DmAtivo)
                .HasMaxLength(1)
                .HasColumnName("DM_ATIVO");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<VersaoArquivo>(entity =>
        {
            entity.HasKey(e => e.IdArquivo).HasName("PRIMARY");

            entity.ToTable("versao_arquivos");

            entity.Property(e => e.IdArquivo)
                .HasMaxLength(60)
                .HasColumnName("ID_ARQUIVO");
            entity.Property(e => e.ConteudoArquivo).HasColumnName("CONTEUDO_ARQUIVO");
        });

        modelBuilder.Entity<VersaoListaArquivo>(entity =>
        {
            entity.HasKey(e => new { e.IdVersao, e.NrItem })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("versao_lista_arquivos");

            entity.HasIndex(e => e.IdArquivo, "FK_VERSAO_ARQUIVOS_LISTA_ARQUIVOS");

            entity.Property(e => e.IdVersao)
                .HasMaxLength(60)
                .HasColumnName("ID_VERSAO");
            entity.Property(e => e.NrItem)
                .HasPrecision(8)
                .HasColumnName("NR_ITEM");
            entity.Property(e => e.DmTipoArquivo)
                .HasMaxLength(1)
                .HasColumnName("DM_TIPO_ARQUIVO");
            entity.Property(e => e.IdArquivo)
                .HasMaxLength(60)
                .HasColumnName("ID_ARQUIVO");
            entity.Property(e => e.NmArquivo)
                .HasMaxLength(255)
                .HasColumnName("NM_ARQUIVO");

            entity.HasOne(d => d.IdArquivoNavigation).WithMany(p => p.VersaoListaArquivos)
                .HasForeignKey(d => d.IdArquivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VERSAO_ARQUIVOS_LISTA_ARQUIVOS");

            entity.HasOne(d => d.IdVersaoNavigation).WithMany(p => p.VersaoListaArquivos)
                .HasForeignKey(d => d.IdVersao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VERSAO_VERSAO_LISTA_ARQUIVOS");
        });

        modelBuilder.Entity<VersaoSistema>(entity =>
        {
            entity.HasKey(e => e.IdVersao).HasName("PRIMARY");

            entity.ToTable("versao_sistema");

            entity.Property(e => e.IdVersao)
                .HasMaxLength(60)
                .HasColumnName("ID_VERSAO");
            entity.Property(e => e.DsVersao)
                .HasMaxLength(60)
                .HasColumnName("DS_VERSAO");
            entity.Property(e => e.DthrLiberacaoVersao).HasColumnName("DTHR_LIBERACAO_VERSAO");
            entity.Property(e => e.NmTipoSistema)
                .HasMaxLength(60)
                .HasColumnName("NM_TIPO_SISTEMA");
            entity.Property(e => e.NrVersao)
                .HasPrecision(20)
                .HasColumnName("NR_VERSAO");
            entity.Property(e => e.ObservacaoVersao)
                .HasMaxLength(2048)
                .HasColumnName("OBSERVACAO_VERSAO");
        });

        modelBuilder.Entity<ViewErpCategoriaProduto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_erp_categoria_produto");

            entity.Property(e => e.DsCategoria)
                .HasMaxLength(186)
                .HasDefaultValueSql("''")
                .HasColumnName("DS_CATEGORIA");
            entity.Property(e => e.IdCategoria)
                .HasPrecision(4)
                .HasColumnName("ID_CATEGORIA");
            entity.Property(e => e.IdSubgrupo)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<ViewErpComputador>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_erp_computador");

            entity.Property(e => e.IdComputador)
                .HasMaxLength(60)
                .HasColumnName("ID_COMPUTADOR");
            entity.Property(e => e.NmComputador)
                .HasMaxLength(275)
                .HasDefaultValueSql("''")
                .HasColumnName("NM_COMPUTADOR");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<ViewErpEmpresaScantech>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_erp_empresa_scantech");

            entity.Property(e => e.NmFantasia)
                .HasMaxLength(100)
                .HasColumnName("NM_FANTASIA");
            entity.Property(e => e.NrCnpj)
                .HasMaxLength(20)
                .HasColumnName("NR_CNPJ");
            entity.Property(e => e.NrEmpresaScantech)
                .HasMaxLength(20)
                .HasColumnName("NR_EMPRESA_SCANTECH");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<ViewErpProdutoServicoCodigo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_erp_produto_servico_codigos");

            entity.Property(e => e.DsProdutoServico)
                .HasMaxLength(120)
                .HasColumnName("DS_PRODUTO_SERVICO");
            entity.Property(e => e.DsProdutoServicoUnMedida)
                .HasMaxLength(129)
                .HasDefaultValueSql("''")
                .HasColumnName("DS_PRODUTO_SERVICO_UN_MEDIDA");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.IdProdutosCodigos)
                .HasMaxLength(60)
                .HasColumnName("ID_PRODUTOS_CODIGOS");
            entity.Property(e => e.IdUnidadeMedida)
                .HasMaxLength(6)
                .HasColumnName("ID_UNIDADE_MEDIDA");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<ViewErpProdutoServicoPesquisa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_erp_produto_servico_pesquisa");

            entity.Property(e => e.DsProdutoServicoCodigo)
                .HasMaxLength(183)
                .HasDefaultValueSql("''")
                .HasColumnName("DS_PRODUTO_SERVICO_CODIGO");
            entity.Property(e => e.IdProdutoServico)
                .HasPrecision(8)
                .HasColumnName("ID_PRODUTO_SERVICO");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<ViewErpSubgrupoProduto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_erp_subgrupo_produto");

            entity.Property(e => e.DsSubgrupo)
                .HasMaxLength(123)
                .HasColumnName("DS_SUBGRUPO");
            entity.Property(e => e.IdGrupo)
                .HasPrecision(4)
                .HasColumnName("ID_GRUPO");
            entity.Property(e => e.IdSubgrupo)
                .HasPrecision(4)
                .HasColumnName("ID_SUBGRUPO");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
        });

        modelBuilder.Entity<YandehProcessamento>(entity =>
        {
            entity.HasKey(e => e.Identificador).HasName("PRIMARY");

            entity.ToTable("yandeh_processamento");

            entity.HasIndex(e => new { e.NrLicenca, e.DsCmd, e.VlCmd }, "IDX0001_YANDEH_PROCESSAMENTO");

            entity.Property(e => e.Identificador)
                .HasMaxLength(60)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.CdRetorno)
                .HasMaxLength(10)
                .HasColumnName("CD_RETORNO");
            entity.Property(e => e.DsCmd).HasColumnName("DS_CMD");
            entity.Property(e => e.DsRetorno)
                .HasMaxLength(1000)
                .HasColumnName("DS_RETORNO");
            entity.Property(e => e.DthrEnvio)
                .HasColumnType("datetime")
                .HasColumnName("DTHR_ENVIO");
            entity.Property(e => e.NrLicenca)
                .HasMaxLength(20)
                .HasColumnName("NR_LICENCA");
            entity.Property(e => e.VlCmd).HasColumnName("VL_CMD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
