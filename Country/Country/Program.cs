namespace Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("Azerbaycan", 110000000);
            country.City.Add(new City("Baku", 1000000));
            country.City.Add(new City("Sheki", 28000));
            country.City.Add(new City("Sumqayit", 270000));
            country.City.Add(new City("Qusar", 26000));
            Console.WriteLine("Zehmet olmasa min ehali sayini daxil edin");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa max ehali sayini daxil edin");
            int num2=Convert.ToInt32(Console.ReadLine());
            country.FindAllByPopulation(num1, num2);
        }
    }
}