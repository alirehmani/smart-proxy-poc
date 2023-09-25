using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Task t = new Task(DownloadPageAsync);
        t.Start();
        Console.ReadLine();
    }

    static async void DownloadPageAsync()
    {
        string page = "http://ip.smartproxy.com/";

        var proxy = new WebProxy("gate.smartproxy.com:1000")
        {
            UseDefaultCredentials = false,

            Credentials = new NetworkCredential(
                userName: "spbo7f3xbs",
                password: "iq4MkjmlkC1z3vT1Rn")
        };

        var httpClientHandler = new HttpClientHandler()
        {
            Proxy = proxy,
        };

        var client = new HttpClient(handler: httpClientHandler, disposeHandler: true);
        var response = await client.GetAsync(page);
        using (HttpContent content = response.Content)
        {
            string result = await content.ReadAsStringAsync();
            Console.WriteLine(result);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}