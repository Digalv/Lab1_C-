class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.WriteLine(Cube(rnd.Next(5000) - rnd.Next(5000), rnd.Next(5000) - rnd.Next(5000)));
    }

    static double Cube(int num1, int num2)
    {
        return Math.Pow((int)num1 + num2, 3);
    }
}