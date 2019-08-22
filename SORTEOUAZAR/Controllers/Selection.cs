using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTEOUAZAR
{
    class Selection
    {
        public static long comparacoes;
        public static long movimentos;

        //Selection
        public static int[] selectionSort(int[] vetor)
        {
            int min, aux;
            comparacoes = 0;
            movimentos = 0;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    comparacoes++;
                    if (vetor[j] < vetor[min]) min = j;
                }

                comparacoes++;
                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                    movimentos++;
                }
            }
            return vetor;
        }
    }
}
