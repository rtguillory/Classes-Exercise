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
            Console.WriteLine("");
            Car car2 = new Car("Chevy") ;
            car2.Model = "Silverado";
            car2.Year = 1990;
            Console.WriteLine($"Make: {car2.Make}\nModel: {car2.Model}\nYear: {car2.Year}");
        }
    }
}
