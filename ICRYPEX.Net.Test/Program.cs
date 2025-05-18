using ICRYPEX.Net.Services;

try
{
    var client = new IcrypexClient();
    var result = await client.PublicApi.GetExchangeInfoAsync();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();