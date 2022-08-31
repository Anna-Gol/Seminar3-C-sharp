public class Task1
{
    public static void Main(string[] args)
    {
        distance3d();
    }

    static void distance3d()
    {
        Console.Write("Enter x1 : ");
        int x1 = int.Parse(Console.ReadLine());

        Console.Write("Enter y1 : ");
        int y1 = int.Parse(Console.ReadLine());

        Console.Write("Enter z1 : ");
        int z1 = int.Parse(Console.ReadLine());

        Console.Write("Enter x2 : ");
        int x2 = int.Parse(Console.ReadLine());

        Console.Write("Enter y2 : ");
        int y2 = int.Parse(Console.ReadLine());

        Console.Write("Enter z2 : ");
        int z2 = int.Parse(Console.ReadLine());

        double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));

        Console.WriteLine($"Distance between A and B = {result:f2}");
    }
}