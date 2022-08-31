public class Task3
{
    public static void Main(string[] args)
    {
        palindromeCheck();
    }

    static void palindromeCheck()
    {
        Console.Write("Enter number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = number;
        int rev = 0;
        int div = 0;

        if (number < 0)
        {
             Console.WriteLine("Число не удовлетворяет заданным критериям");
        
        }

        else
        while (number > 0)
        {
            div = number % 10;
            rev = rev * 10 + div;
            number = number / 10;

            if (temp == rev) 
            {
                Console.WriteLine("Число является палиндромом");
            }

            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
        }


    }

}