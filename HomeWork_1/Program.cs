namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            int a;

            try
            {
                Console.Write("Enter the value of square side: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, enter an integer value");
                return;
            }

            int area = a * a;
            int perimeter = a * 4;

            Console.WriteLine($"Area of the square = {area}");
            Console.WriteLine($"Peirmeter of the square = {perimeter}");


            Console.WriteLine("\nTask 2");
            Console.Write("What is your name? ");
            string? name = Console.ReadLine();
            int age;

            try
            {
                Console.Write($"How old are you, {name}? ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, enter an integer value");
                return;
            }

            Console.WriteLine($"Your name is {name} and you are {age} y.o.");


            Console.WriteLine("\nTask 3");
            double radius;
            try
            {
                Console.Write("Enter circle radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, enter an integer value");
                return;
            }

            const double PI = 3.14;

            double circleLength = 2 * PI * radius;
            double circleArea = PI * radius * radius;
            double circleVolume = 4.0 / 3 * PI * radius * radius * radius;

            Console.WriteLine($"Circle length = {circleLength:F2} ");
            Console.WriteLine($"Circle area = {circleArea:F2}");
            Console.WriteLine($"Circle volume = {circleVolume:F2}");

            Console.ReadKey();
        }
    } 
}