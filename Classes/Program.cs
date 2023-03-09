namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Dodge";
            myCar.Model = "Challenger";
            myCar.Year = "2022";

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");

           
        }
    }
}
