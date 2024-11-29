namespace Task_enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("mercedes", "e200",Type.Sport);
            Car car1 = new Car("bmw", "f10",Type.Sedan);
            Console.WriteLine(car);
            Console.WriteLine(car1);
        }
    }
}
