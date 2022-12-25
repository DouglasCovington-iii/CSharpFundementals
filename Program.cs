
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Beep();
            // System.Console.WriteLine("Where the fuck is my beep");
            /*

            char character = 'a';
            string name = "adf;lasf;lasjf";
            string temp1 = 'a' + " ";

            int a = System.Convert.ToInt32("23234");

            System.Console.WriteLine(a + 25);

            string bob = System.Convert.ToString(3.45667);

            System.Console.WriteLine(bob.GetType());
            */
            int a = 45;
            a += 34;

            System.Console.WriteLine("a + 34 = " + a);

            a *= 2;

            System.Console.WriteLine("a * 2 = " + a);

            double temp = System.Math.Exp(5);

            System.Console.WriteLine("e^5 = " + temp);

            System.Console.WriteLine(System.Math.Floor(-4.3));

            System.Console.Write("Please enter your phone number: ");
            string phone_number = System.Console.ReadLine();

            System.Console.WriteLine("\n I just called this phone number " + phone_number + " and the person is a bitch");
            System.Console.ReadKey();

        }
    }
}
