namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool z)
        {
            var b = x + y;

            if (z == true && b == 1)
            {
                return $"{x + y} dollar";
            }
            else if (z == true && b > 1)
            {
                return $"{b} dollars";
            }
            else if (z == true && b < 1)
            {
                return $"{b} dollars";
            }

            else
            {
                return b.ToString();
            }
        }
        
        
        static void Main(string[] args)
        {
            var x = 45;
            var y = 67;

            var answer = Add(x, y);

            var h = 0.43m;
            var k = 3.45m;

            var decimalTurn = Add(h, k);

            var thirdTurn = Add(0, 1, true);

            Console.WriteLine($"add: {answer} decimal add: {decimalTurn}");

            Console.WriteLine($"{thirdTurn}");
        }
    }
}
