using System.Security.Cryptography;

public static class StructuralSequence
{
    private static int op = 9;
    private static int num;
    private static double km;
    public static void get_StructSeq()
    {
        Console.WriteLine("-------  Structural Sequence exercises  -------");

        while (op != 0)
        {
            Console.WriteLine("1 - triple your number\n2 - km to miles\n0 - exit\n");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Insert a number: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    int triple = getTriple(num);

                    Console.WriteLine("The triple of your number is: " + triple + "\n");
                    break;

                case 2:
                    Console.WriteLine("Insert a kilometer to transform into miles: ");
                    km = Convert.ToDouble(Console.ReadLine());

                    double miles = getMiles(km);

                    Console.WriteLine("The triple of your number is: " + miles + "\n");
                    break;

                case 0:
                    Console.WriteLine("Exiting code!\n");
                    break;

                default:
                    Console.WriteLine("Insert a valid option!\n");
                    break;
            }
        }
    }

    public static int getTriple(int num)
    {
        return num * 3;
    }

    public static double getMiles(double km)
    {
        return km * 0.621371;
    }
}