using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgoritms.Algoritms
{
    public class HeapSort : IAlgoritm
    {
        public int[] GetDisorder(int numberValues)
        {
            Random rng = new Random();
            return Enumerable.Range(1, numberValues).OrderBy(x => rng.Next()).ToArray();
        }

        public int[] Sort(int[] values)
        {
            int length = values.Length;

            // Construye un montículo
            for (int i = length / 2 - 1; i >= 0; i--)
                Heapify(values, length, i);

            // Extrae elementos uno por uno desde el montículo
            for (int i = length - 1; i > 0; i--)
            {
                // Mueve el elemento actual de la raíz al final
                int temp = values[0];
                values[0] = values[i];
                values[i] = temp;

                // Llama a la función heapify en la lista reducida
                Heapify(values, i, 0);
            }

            return values;
        }

        private void Heapify(int[] values, int length, int i)
        {
            int largest = i; // Inicializa largest como raíz
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            // Si el hijo izquierdo es mayor que la raíz
            if (left < length && values[left] > values[largest])
                largest = left;

            // Si el hijo derecho es mayor que largest
            if (right < length && values[right] > values[largest])
                largest = right;

            // Si largest no es la raíz
            if (largest != i)
            {
                int swap = values[i];
                values[i] = values[largest];
                values[largest] = swap;

                // Recursivamente heapify el subárbol afectado
                Heapify(values, length, largest);
            }
        }

        public bool Validation(int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i - 1] > values[i])
                    return false; // Si encuentra valores desordenados, retorna falso
            }
            return true; // Si recorrió toda la lista y todo está en orden, retorna verdadero
        }
    }
}