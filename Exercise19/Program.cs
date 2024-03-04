namespace Exercise19
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string a = Console.ReadLine();
            var result1 = Convert.ToInt32(a);
            var result2 = Negative(result1);
            Console.WriteLine("Negative of your number is:" + result2);
        }

        public static int Negative(int a)
        {
            return a *= -1;
        }
    }

}
