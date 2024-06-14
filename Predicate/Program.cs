//Es una implementacion que permite obviar la creación de los distntos tipos usando un predicado único (sentencia).

using LINQ.Models;

public class Program
{
    //static void Main(string[] args)
    //{
    //    var numbers =
    //        new List<int>() { 1, 2, 5, 67, 7, 5 };
    //    var predicate = new Predicate<int>(isDivider2);
    //    var dividers2 = numbers.FindAll(predicate);

    //    dividers2.ForEach(i => { Console.WriteLine(i); });
    //}

    //static bool isDivider2(int n) => n % 2 == 0;

    public class Beer
    {
        public string Nombre;
        public int Alcohol;
        static void Main(string[] args)
        {

            var cervezas = new List<Beer>()
                {
                    new Beer(){ Nombre="Pale Ale", Alcohol=2},
                    new Beer(){ Nombre="Quilmes" , Alcohol=9},
                };
           ShowBeerThatIGetDrunk(cervezas, x => x.Alcohol > 8);
  
        }
        static void ShowBeerThatIGetDrunk(List<Beer> beers, Predicate<Beer> condition)
        {
            var evilBeers = beers.FindAll(condition);
            evilBeers.ForEach(beer => { Console.WriteLine(beer.Nombre); });
        }

 
    }


}