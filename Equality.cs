public class Equality
{
    private int op = 9;
    private int num1;
    private int num2;

    public void get_equality()
    {
        Console.WriteLine("---------  Equality exercises  ---------");

        while (op != 0)
        {
            Console.WriteLine("1 - bigger than\n2 - equals\n0 - exit\n");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Enter number 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter number 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    bool bigger = getBigger(num1, num2);

                    Console.WriteLine(num1 + " is bigger than " + num2 + ": " + bigger + "\n");
                    break;

                case 2:
                    Console.WriteLine("Enter number 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter number 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    bool equals = getEquals(num1, num2);

                    Console.WriteLine(num1 + " is equal " + num2 + ": " +equals + "\n");
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

    public bool getBigger(int num1, int num2)
    {
        return num1 > num2;
    }

    public bool getEquals(int num1, int num2)
    {
        return num1 == num2;
    }
}