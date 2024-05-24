using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Rest.Models
{
    class Petitions
    {
        public async Task GetPetition()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            // Crea un hilo hasta await.
            var httpResponse = await client.GetAsync(url);

            Console.WriteLine("Algo");

            if (httpResponse.IsSuccessStatusCode)
            {
                var res = await httpResponse.Content.ReadAsStreamAsync();

                List<Post> des = JsonSerializer.Deserialize<List<Post>>(res);

            }

        }

        public async Task PostPetition()
        {
            string url = "https://jsonplaceholder.typicode.com/posts/99";
            HttpClient client = new HttpClient();

            Post post = new Post()
            {
                userId = 1,
                title = "asd",
                body = "asd"
            };

            var data =  JsonSerializer.Serialize<Post>(post);

            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStreamAsync(); 

                var postResult = JsonSerializer.Deserialize<Post>(result);

            }


        }

    }

}
