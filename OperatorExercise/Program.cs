namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCISE 1:");
          
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if(a == 17 && b==4)
            {
                 Console.WriteLine($"17/4 is {quotient} + {remainder}");              
            }

            Console.WriteLine("EXERCISE 2:");
            Console.WriteLine("What is the radius of your circle?");
           var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));
        }

        
        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * radius * radius); 
        }
    }
}