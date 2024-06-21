namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Write("enter temperature in celsius: ");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"temperature in fahrenheit: {fahrenheit}");


            //Task 2
            Console.Write("ball's radius: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("ball's volume: " + 4f / 3f * 3.1415f * radius * radius * radius);


            //Task 3
            Console.Write("Price: ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            int count = int.Parse(Console.ReadLine());

            Console.Write("Discount: ");
            float discount = float.Parse(Console.ReadLine()) / 100;

            float total = price * count * (1 - discount);
            Console.WriteLine($"Check: {total}");


            //Task 4
            Console.Write("Enter the length of the circle: ");

            float circumference = float.Parse(Console.ReadLine());
            float radiuus = circumference / (2 * 3.14f);
            float area = 3.14f * radiuus * radiuus;0


            Console.WriteLine($"Area: {area}");


            //Task 5
            Console.Write("enter a 4 digit number: ");
            string num = Console.ReadLine();
            if (num.Length == 4)
                Console.WriteLine("Result: " + num + num[1..3] + num[0]);
            else
                Console.WriteLine("not a 4 digit number.");


            //Task 6
            Console.Write("Days: ");
            int EnteredDays = int.Parse(Console.ReadLine());
            int weeks = EnteredDays / 7;
            int days = EnteredDays % 7;

            Console.WriteLine($"{weeks} weeks {days} days.");


            //task 7 
            Console.Write("Pupils: ");
            int pupils = int.Parse(Console.ReadLine());
            Console.Write("Apples: ");
            int apples = int.Parse(Console.ReadLine());

            Console.WriteLine($"For pupils: {apples / pupils}");
            Console.WriteLine($"Int the basket: {apples % pupils}");
        }
    }
}
