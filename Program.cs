using System.Net;
using RestSharp;
namespace TestApplication
{
    class Test
    {
        static void Main(string[] args)
        {
            var options = new RestClientOptions()
            {
                Proxy = new WebProxy()
                {
                    Address = new Uri("http://proxy.zenrows.com:8001"),
                    Credentials = new NetworkCredential("4fe05cea01dae79bfb53fe87793cafcab7c804b5", "")
                },
                RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
            };

            var client = new RestClient(options);
            var request = new RestRequest("https://theparadise.pk");

            var response = client.Get(request);
            Console.WriteLine(response.Content);
        }
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Task t = new Task(DownloadPageAsync);
//        t.Start();
//        Console.ReadLine();
//    }



//static async void DownloadPageAsync()
//{
//    string page = "http://ip.smartproxy.com/";

//    var proxy = new WebProxy("gate.smartproxy.com:1000")
//    {
//        UseDefaultCredentials = false,

//        Credentials = new NetworkCredential(
//            userName: "spbo7f3xbs",
//            password: "iq4MkjmlkC1z3vT1Rn")
//    };

//    var httpClientHandler = new HttpClientHandler()
//    {
//        Proxy = proxy,
//    };

//    var client = new HttpClient(handler: httpClientHandler, disposeHandler: true);
//    var response = await client.GetAsync(page);
//    using (HttpContent content = response.Content)
//    {
//        string result = await content.ReadAsStringAsync();
//        Console.WriteLine(result);
//        Console.WriteLine("Press any key to exit.");
//        Console.ReadKey();

//    }
//}
//}