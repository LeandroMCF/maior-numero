using System;

namespace maior_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];

            int maiorvalor, menorvalor;

            maiorvalor = 0;
            menorvalor = 0;
            Console.WriteLine("Digite 10 numeros:");
            for (var i = 0; i < 10; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < 10; i++)
            {
                if (n[i] > n[0] && n[i] > n[1] && n[i] > n[2] && n[i] > n[3] && n[i] > n[4] && n[i] > n[5] && n[i] > n[6] && n[i] > n[7] && n[i] > n[8] && n[i] > n[9])
                {
                   maiorvalor = n[i]; 
                }
                else if (n[i] < n[0] && n[i] < n[1] && n[i] < n[2] && n[i] < n[3] && n[i] < n[4] && n[i] < n[5] && n[i] < n[6] && n[i] < n[7] && n[i] < n[8] && n[i] < n[9])
                {
                    menorvalor = n[i];
                }
            }
            Console.WriteLine($"O maior valor é {maiorvalor} e o menor valor é {menorvalor}");
        }
    }
}
