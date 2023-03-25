namespace TestClient
{
    class Program1
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                    if (j == 5)
                    {
                        Console.Write("<br>");
                        for (int k = 5; k >= 1; k--)
                        {
                            Console.Write(k);
                        }
                        Console.Write("<br>");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
