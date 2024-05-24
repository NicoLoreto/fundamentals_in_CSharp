using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

// La T indica que va a recibir una clase que definirá el objeto con el que trabajará.
namespace Generics.Service
{
    public class SendRequest<T>
    {

        private HttpClient _client =  new HttpClient();

        public async Task<T> Send(T model)
        {
            string url = "https://jsonplaceholder.typicode.com/posts/";

            var data = JsonSerializer.Serialize<T>(model);

            HttpContent content = 
                new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _client.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStreamAsync();

                var postResult = JsonSerializer.Deserialize<T>(result);
                return postResult;

            }

            return default(T);

        }

    }
}
