﻿
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using QuebraGalho.Core.Models;

namespace QuebraGalho.Relatorios.GeradorPdf;

public class GerarRelatorioDeProdutosCondensadosPorCliente : IDisposable
{
    public void GerarPdf(List<RelatorioProdutosVendidosCondensadosPorCliente> dadosRelatorio)
    {
        try
        {
            string dest = "C:\\Projects\\QuebraGalho\\QuebraGalho.Relatorios\\GeradorPdf\\Relatorios";

            if (!Directory.Exists(dest)) {
                Directory.CreateDirectory(dest);
            }


            if (Directory.Exists(dest))
            {
                // Cria o PDF
                using (var writer = new PdfWriter(dest + "relatorio-itens_condensados.pdf"))
                using (var pdf = new PdfDocument(writer))
                using (var document = new Document(pdf))
                {
                    // Adiciona título
                    document.Add(new Paragraph("Relatório de Produtos Condensados")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(12));

                    Table tableHeader = new Table(4);
                    tableHeader.SetWidth(UnitValue.CreatePercentValue(100));

                    tableHeader.AddCell("Nome Fantasia:");
                    tableHeader.AddCell(dadosRelatorio[1].NM_FANTASIA_EMPRESA);

                    tableHeader.AddCell("Cliente:");
                    tableHeader.AddCell("");

                    tableHeader.AddCell("Razão Social:");
                    tableHeader.AddCell(dadosRelatorio[1].NM_RAZAO_SOCIAL_EMPRESA);

                    tableHeader.AddCell("Nome:");
                    tableHeader.AddCell(dadosRelatorio[1].NM_RAZAO_SOCIAL);

                    tableHeader.AddCell("CNPJ:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_CPF_CNPJ_EMPRESA);

                    tableHeader.AddCell("CPF/CNPJ:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_CPF_CNPJ);

                    tableHeader.AddCell("Logradouro:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_ENDERECO_EMPRESA);

                    tableHeader.AddCell("Logradouro:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_ENDERECO);

                    tableHeader.AddCell("Bairro:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_BAIRRO_EMPRESA);

                    tableHeader.AddCell("Bairro:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_BAIRRO);

                    tableHeader.AddCell("Município:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_MUNICIPIO_EMPRESA);

                    tableHeader.AddCell("Município:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_ENDERECO_EMPRESA);

                    tableHeader.AddCell("Fone:");
                    tableHeader.AddCell(dadosRelatorio[1].NR_TELEFONE_EMPRESA);

                    tableHeader.AddCell("Fone:");
                    tableHeader.AddCell(dadosRelatorio[1].NR_TELEFONE);

                    tableHeader.AddCell("E-mail:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_EMAIL_EMPRESA);

                    tableHeader.AddCell("E-mail:");
                    tableHeader.AddCell(dadosRelatorio[1].DS_EMAIL);

                    document.Add(tableHeader);

                    // Adiciona uma linha em branco
                    document.Add(new Paragraph("\n"));


                    // Cria uma tabela com 3 colunas
                    Table tableBody = new Table(5);
                    tableBody.SetWidth(UnitValue.CreatePercentValue(100));

                    // Adiciona cabeçalhos
                    tableBody.AddHeaderCell("CÓDIGO");
                    tableBody.AddHeaderCell("PRODUTO");
                    tableBody.AddHeaderCell("QUANTIDADE");
                    tableBody.AddHeaderCell("VALOR UNÍTARIO");
                    tableBody.AddHeaderCell("VALOR SUBTOTAL");

                    // Adiciona dados à tabela
                    foreach (var produto in dadosRelatorio)
                    {
                        tableBody.AddCell(produto.NR_ITEM.ToString());
                        tableBody.AddCell(produto.DS_PRODUTO_SERVICO);
                        tableBody.AddCell(produto.QUANTIDADE.ToString());
                        tableBody.AddCell(produto.VL_UNITARIO.ToString());
                        tableBody.AddCell(produto.VL_SUBTOTAL.ToString()); // Formata como moeda
                    }

                    // Adiciona a tabela ao documento
                    document.Add(tableBody);

                    Table tableFooter = new Table(4);
                    tableFooter.SetWidth(UnitValue.CreatePercentValue(100));
                    tableFooter.SetTextAlignment(TextAlignment.RIGHT);

                    tableFooter = new Table(3);
                }
            }

            Console.WriteLine("Relatório gerado com sucesso: " + dest);
        }

        catch (Exception)
        {
            throw;
        }
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
