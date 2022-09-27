namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your preferred choice of coffee?");
            string coffee = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Your name is {name}, and you like the color {color}. At cafe's, you enjoy a {coffee} while listening to {band}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());
            int add = Add(num1, num2, 10, 30, 20);
            Console.WriteLine($"the sum is: {add}");

            Console.WriteLine("Give me a number");
            int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to subtract from the first one");
            int sub2 = int.Parse(Console.ReadLine());
            int subtract = Subtract(sub1, sub2);
            Console.WriteLine($"the total is: {subtract}");

            Console.WriteLine("Give me a number");
            int mult1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to multipy the first with");
            int mult2 = int.Parse(Console.ReadLine());
            int multiply = Multiply(mult1, mult2);
            Console.WriteLine($"the total is: {multiply}");

            Console.WriteLine("Give me a number");
            decimal div1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to divide the first with");
            decimal div2 = decimal.Parse(Console.ReadLine());
            decimal divide = Divide(div1, div2);
            Console.WriteLine($"the total is: {divide}");

            Console.WriteLine("Give me a number");
            decimal mod1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to Modulus with the first");
            decimal mod2 = decimal.Parse(Console.ReadLine());
            decimal modulus = Modulus(mod1, mod2);
            Console.WriteLine($"the total is {modulus}");
        }

        public static int Add(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }
        public static int Subtract(int sub1, int sub2)
        {
            //int Subtract = (sub1 - sub2);
            //return Subtract;

            return sub1 - sub2;
        }
        public static int Multiply(int mult1, int mult2)
        {
            //int Multiply = (mult1 * mult2);
            //return Multiply;

            return mult1 * mult2;
        }
        public static decimal Divide(decimal div1, decimal div2)
        {
            //decimal Divide = (div1 / div2);
            //return Divide;

            return div1 / div2;
        }
        public static decimal Modulus(decimal mod1, decimal mod2)
        {
            //int Modulus = (decimal1 % decimal2);
            //return Modulus;

            return mod1 % mod2;
        }
    }
}