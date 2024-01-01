class Program
{
    static void Main(string[] args)
    {
        int t, i;
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
       // int[,] table = new int[3, 4];
        for (t = 0; t < 3; ++t)
        {
            for (i = 0; i < 3; ++i)
            {
                a[t, i] = (t * 3) + i + 1;
                Console.Write(a[t, i] + "     ");
            }

            Console.WriteLine();

        }
        Console.ReadLine();
    }
}