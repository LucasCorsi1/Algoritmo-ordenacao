using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTEOUAZAR
{
    class Bubble
    {
        public static long comparacoes; // Variavel global
        public static long movimentos;
        public static void bubbleSort(ref int[] vetor)
        {
            int tamanho = vetor.Length;
            comparacoes = 0;
            movimentos = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        movimentos++;
                    }
                }
            }
        }
    }
}
