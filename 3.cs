using System;

namespace TestClient
{
    public class Program3
    {
        public void Run(string[] args)
        {
            int x = 0, y = 1, z = 0;

            Console.Write("Masukkan jumlah bilangan fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                Console.Write(z + " ");
                x = y;
                y = z;
                z = x + y;
            }
            Console.Read();
        }
    }
}
