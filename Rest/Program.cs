using Rest.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {

        var get = new Petitions();
        var petitionGet = get.GetPetition();

        var post = new Petitions();
        var petitionPost = post.PostPetition();


    }

}