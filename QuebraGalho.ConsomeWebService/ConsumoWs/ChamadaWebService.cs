using ACBrLib.ConsultaCNPJ;
using ServiceReference1;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;

namespace QuebraGalho.ConsomeWebService.ConsumoWs;

public sealed class ChamadaWebService : IDisposable
{
    private ErpWsClient erpWsClient = new ErpWsClient() ;
    public async Task<string> EnviaWsAsync(string licenca, string idEmpresa, string nomeServico, string conteudo) 
    {
        try
        {
            var binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = int.MaxValue;

            var endpoint = new EndpointAddress("http://santsystemsrv07.ddns.net:8087/ERP_WEB/ErpWsService/ErpWs?wsdl");
            //var endpoint = new EndpointAddress(erpWsClient.Endpoint.Address.Uri);
            erpWsClient = new ErpWsClient(binding, endpoint);
            erpWsClient.InnerChannel.OperationTimeout = new TimeSpan(0, 25, 0);
            var enviaRecebeDados = new EnviaRecebeDados(new EnviaRecebeDadosBody(
                    licenca,
                    idEmpresa,
                    nomeServico,
                    conteudo
                )
            );
            var response = await erpWsClient.EnviaRecebeDadosAsync(enviaRecebeDados).ConfigureAwait(true);
            Console.WriteLine("Buscando informações");
            return HttpUtility.HtmlDecode(response.Body.@return);
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }

    public void Executando() 
    {
        Console.WriteLine("Executando");
        
    }
   
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
