using GuitarAppOOAD.Models;

namespace GuitarAppOOAD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GuitarInventory inventory = new GuitarInventory();

            GuitarSpecifications guitarSpecs1 = new GuitarSpecifications(12, GuitarBuilder.FENDER, "Model1", GuitarType.ELECTRIC, GuitarWood.REDWOOD, GuitarWood.ALDER);
            GuitarSpecifications guitarSpecs2 = new GuitarSpecifications(10, GuitarBuilder.FENDER, "Model2", GuitarType.ELECTRIC, GuitarWood.REDWOOD, GuitarWood.MAHOGANY);
            GuitarSpecifications guitarSpecs3 = new GuitarSpecifications(11, GuitarBuilder.GIBSON, "Model3", GuitarType.ACOUSTIC, GuitarWood.MAPLE, GuitarWood.COCOBOLO);

            inventory.AddGuitar("101", 12000, guitarSpecs1);
            inventory.AddGuitar("102", 14000, guitarSpecs2);
            inventory.AddGuitar("103", 15000, guitarSpecs3);

            Guitar guitar = inventory.GetGuitar("103");
            Console.WriteLine($"{guitar}\n");

            GuitarSpecifications guitarSearch = new GuitarSpecifications(12, GuitarBuilder.FENDER, "Model1", GuitarType.ELECTRIC, GuitarWood.REDWOOD, GuitarWood.ALDER);

            List<Guitar> foundGuitars = inventory.SearchForGuitar(guitarSearch);
            PrintAvailableGuitars(foundGuitars);
        }

        public static void PrintAvailableGuitars(List<Guitar> foundGuitars)
        {
            if (foundGuitars == null && foundGuitars.Count <= 0)
            {
                Console.WriteLine("No guitars found matching the Specifications.");
            }

            Console.WriteLine("Found the following Guitars: ");
            foreach(Guitar item in foundGuitars)
                Console.WriteLine($"{item.ToString()}\n");
        }
    }
}