using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTEOUAZAR
{
    class ShellSort
    {
        public static long comparacoes;
        public static long movimentos;

        // shell sort

        public static void shell(int[] vetor)
        {
             comparacoes = 0;
             movimentos = 0;

            int h = 1;
            int n = vetor.Length;

            while (h < n)
            {
                h = h * 3 + 1;
            }

            h = h / 3;
            int c, j;
            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    movimentos++;
                    j = i;
                    comparacoes++;
                    while (j >= h && vetor[j - h] > c)
                    {
                        comparacoes++;
                        vetor[j] = vetor[j - h];
                        movimentos++;
                        j = j - h;

                    }
                    vetor[j] = c;
                    movimentos++;
                }
                h = h / 2;
            }

        }


    }
}
