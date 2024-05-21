public class LogicExpression
{
    private int op = 9;
    private int age;
    private int climate;
    private bool sun;
    private bool rain;

    public void get_logExpress()
    {
        Console.WriteLine("---------  Logic exercises  ---------");

        while (op != 0)
        {
            Console.WriteLine("1 - can vote\n2 - is raining\n0 - exit\n");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Enter your age: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    bool vote = canVote(age);
                    bool adult = isAdult(age);

                    Console.WriteLine("You can vote? " + vote + "\n" + "You are and adult? " + adult + "\n");
                    break;

                case 2:
                    Console.WriteLine("Is raining?\n\n1 - yes\n2 - no\n");
                    climate = Convert.ToInt32(Console.ReadLine());

                    if (climate == 1)
                    {
                        sun = false;
                        rain = true;
                    }
                    else if (climate == 2)
                    {
                        sun = true;
                        rain = false;
                    }

                    bool day = goodDay(sun, rain);

                    Console.WriteLine("Is a good day to go for a walk? " + day + "\n");
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

    public bool canVote(int age)
    {
        return age >= 16;
    }

    public bool isAdult(int age)
    {
        return age >= 18;
    }

    public bool goodDay(bool sun, bool rain)
    {
        return sun || !rain;
    }
}