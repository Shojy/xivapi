using System;
using System.Threading.Tasks;
using XIVApi.Data;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var xiv = new XIVApi.ApiEngine();

            var results = await xiv.SearchFreeCompany("uwu", Server.All);

            foreach(var res in results)
                Console.WriteLine(res.Name);

            Console.ReadLine();
        }
    }
}
