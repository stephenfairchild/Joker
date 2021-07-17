using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Joker
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await fetchJoke();
        }


        private static async Task fetchJoke() {
            var stream = client.GetStreamAsync("https://official-joke-api.appspot.com/random_joke");
            var joke = await JsonSerializer.DeserializeAsync<Joke>(await stream);

            Console.WriteLine(joke.Setup);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".........");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".........");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".........");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(joke.Punchline);
        }
    }
}
