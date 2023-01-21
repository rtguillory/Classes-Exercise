namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Car car = new Car() ;
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Year = 2022;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

        }
    }
}
