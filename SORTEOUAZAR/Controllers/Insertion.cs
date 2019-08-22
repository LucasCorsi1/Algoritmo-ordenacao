using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTEOUAZAR
{
    class Insertion
    {
        public static long comparacoes;
        public static long movimentos;

        public static void sort(ref int[] arr)
        {
            int n = arr.Length;
            comparacoes = 0;
            movimentos = 0;

            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                comparacoes++;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    movimentos++;
                }
                arr[j + 1] = key;
            }
        }
    }
}
