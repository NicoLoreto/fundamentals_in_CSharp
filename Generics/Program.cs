// Sirven para decir con que tipo de objeto va a trabajar.

using fundamentals_in_CSharp.Models;
using Generics.Service;

class Program
{
    static async Task Main(string[] args)
    {
        var cerveza = new Cerveza(2)
        {
            Alcohol = 5,
            Cantidad = 500,
            Marca = "Quilmes",
            Nombre = "Stout"
        };

        SendRequest<Cerveza> service = new SendRequest<Cerveza>();

        var CervezaResponse = await service.Send(cerveza);
    }
}