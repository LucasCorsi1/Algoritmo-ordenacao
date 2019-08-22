using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTEOUAZAR
{
    class QuickSort
    {
        public static long comparacoes;
        public static long movimentos;

        //QUICKSORT
        public static int[] quickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            comparacoes = 0;
            movimentos = 0;
            quickSort(vetor, inicio, fim);

            return vetor;
        }

        private static void quickSort (int[] vetor, int primeiro, int ultimo)
        {

            int baixo, alto, meio, pivo, repositorio;
            baixo = primeiro;
            alto = ultimo;
            meio = (int)((baixo + alto) / 2);

            pivo = vetor[meio];

            while (baixo <= alto)
            {
                while (vetor[baixo] < pivo)
                {
                    baixo++;
                    comparacoes++;
                }
                    
                while (vetor[alto] > pivo)
                {
                    alto--;
                    comparacoes++;
                }
                    
                if (baixo < alto)
                {
                    repositorio = vetor[baixo];
                    vetor[baixo++] = vetor[alto];
                    vetor[alto--] = repositorio;
                    movimentos++;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }
            }

            if (alto > primeiro)
                quickSort(vetor, primeiro, alto);
            if (baixo < ultimo)
                quickSort(vetor, baixo, ultimo);
        }

    }
}
