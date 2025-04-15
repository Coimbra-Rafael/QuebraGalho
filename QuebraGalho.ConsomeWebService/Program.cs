using QuebraGalho.ConsomeWebService.ConsumoWs;

using var chamaWs = new ChamadaWebService();

Console.WriteLine(DateTime.Now);

var result = await chamaWs.EnviaWsAsync("9999T", "1", "ERP_RETORNA_PRODUTO_PENDENTES", "c7ed4e8791b54f129cd926589481cfff");

Console.WriteLine(result);

static string GetTagXml(string tag, string texto)
{
    int posicaoInicial = texto.IndexOf("<" + tag + ">");
    int posicaoFinal = texto.IndexOf("</" + tag + ">");

    if (posicaoInicial >= 0 && posicaoFinal >= 0)
    {
        int inicio = posicaoInicial + tag.Length + 2;
        int tamanho = posicaoFinal - inicio;

        return texto.Substring(inicio, tamanho);
    }
    
    return "";
}