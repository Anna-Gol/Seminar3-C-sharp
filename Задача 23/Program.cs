public class Task2
{
    public static void Main(string[] args)
    {
        thirdPower();
    }

    static void thirdPower()
    {
        Console.Write("Enter number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Таблица кубов");

        for (int i = 1;i<=number;i++)
        {
            Console.WriteLine(Math.Pow(i,3));
        }

    }
}