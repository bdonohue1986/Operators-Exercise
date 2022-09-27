namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a==17&&b==4)
            Console.WriteLine($"{a}/{b} is {quotient} with the remainder {remainder}");
            Console.WriteLine("whats the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double Area = Math.PI * radius * radius;
            Console.WriteLine($"The area of a circle with the radius of {radius} is {Area}" );

        }
       

    }
}