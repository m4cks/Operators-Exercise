namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DIVISION
            DivisionExercise();

            //AREA OF CIRCLE
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a cicle with radius of {radius} is {area}");

            //THOUGHT EXERCISE
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            //++i will return 3+1=4
            //j++ will return 4+1=5
            //therefore k will return 4*5 = 
            Console.WriteLine(k);
        }

        //SECTION: DIVISION
        public static void DivisionExercise() 
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"17/4 is {quotient} remainder {remainder}");
        }

        //SECTION: AREA OF CIRCLE
        public static double AreaOfCircle(double radius)
        {   
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}