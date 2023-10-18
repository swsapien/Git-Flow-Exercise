using System;
using System.Linq;

namespace SortAlgorithms.Algorithms
{
    /// <summary>
    /// Radix Sort es útil para ordenar números enteros o cadenas alfabéticas. 
    /// Se basa en la idea de ordenar los elementos por sus dígitos o caracteres más significativos y luego combinarlos. 
    /// Es eficiente para conjuntos de datos grandes y tiene una complejidad de tiempo lineal.
    /// </summary>
    public class RadixSort : IAlgoritm
    {
        public int[] Sort(int[] values)
        {
            if (values == null || values.Length <= 1)
            {
                // No es necesario ordenar
                return values;
            }

            // Encuentra el valor máximo para determinar el número de dígitos
            int max = values.Max();
            int exp = 1; // Inicializa la posición del dígito menos significativo

            // Hace el counting sort para cada posición del dígito
            while (max / exp > 0)
            {
                CountingSort(values, exp);
                exp *= 10; // Mueve a la siguiente posición del dígito
            }

            return values;
        }

        private void CountingSort(int[] values, int exp)
        {
            int n = values.Length;
            int[] output = new int[n];
            int[] count = new int[10]; // Hay 10 dígitos posibles (0-9)

            // Inicializa el arreglo de conteo
            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }

            // Almacena la cuenta de ocurrencias de cada dígito
            for (int i = 0; i < n; i++)
            {
                count[(values[i] / exp) % 10]++;
            }

            // Ajusta el conteo para obtener la posición correcta de cada elemento
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Construye el arreglo de salida
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(values[i] / exp) % 10] - 1] = values[i];
                count[(values[i] / exp) % 10]--;
            }

            // Copia el arreglo de salida al arreglo original
            for (int i = 0; i < n; i++)
            {
                values[i] = output[i];
            }
        }
    }
}
