using System;

namespace maior_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] n = new float[10];
            float maiorvalor = 0, menorvalor = 0, comp = 0;

            Console.WriteLine("Digite 10 numeros:");
            for (var i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º valor");
                n[i] = float.Parse(Console.ReadLine());

                comp = n[i];
                if(n[i] < comp)
                {
                    menorvalor = n[i];
                }
                else if (n[i] > comp)
                {
                    maiorvalor = n[i];
                }
            }
            Console.WriteLine($"O maior valor é {maiorvalor} e o menor valor é {menorvalor}");
        }
    }
}
