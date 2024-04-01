namespace PrimeiroProjeto
{
    using System;

    class Program
    {
        static char DeterminarCaminho(int p, int r)
        {
            if (p == 1 && r == 0)
                return 'B';
            else if (p == 0 && r == 0)
                return 'C';
            else
                return 'A';
        }

        static void Main()
        {
            // Entrada
            Console.WriteLine("Digite as posições das portinhas P e R (0 ou 1):");
            string[] entrada = Console.ReadLine().Split();
            int p = int.Parse(entrada[0]);
            int r = int.Parse(entrada[1]);

            // Saída
            char caminho = DeterminarCaminho(p, r);
            Console.WriteLine(caminho);
        }
    }
}