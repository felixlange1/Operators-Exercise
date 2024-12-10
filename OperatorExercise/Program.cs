namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int diff = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} and remainder {remainder}.");
            
            Console.WriteLine("Please tell me the radius for your circle:");
            double radius = double.Parse(Console.ReadLine());
            
            double circleArea = AreaOfCircle(radius);

            Console.WriteLine($"The area of your circle with a radius of {radius} is {circleArea}.");
            
            int i = 3;
            int j = 4;
            int k = ++i * j++;

            // The value of k will be 16. The value of i will be increased BEFORE it is multiplied by j. So that means
            // the value of i will increase from 3 to 4. The value of j will stay 4 when it is multiplied by i. So
            // at the moment of multiplication it will be 4, afterwards it will be increased to 5. So therefore if 
            // i = 4 and j = 4 at the time of multiplication, the result will be 16.
            
            Console.WriteLine(k);
            
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
    }
}
