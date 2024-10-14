using QuebraGalho.ConsomeWebService.ConsumoWs;

using (var chamaWs = new ChamadaWebService()) 
{
    Console.WriteLine(chamaWs.EnviaWsAsync("9999T","1", "ERP_RETORNA_PESSOA", "16").Result);
}