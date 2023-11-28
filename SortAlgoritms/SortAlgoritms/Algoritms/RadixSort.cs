
namespace SortAlgoritms.Algoritms
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
                return values;
            }

            int max = values.Max();
            int exp = 1;

            while (max / exp > 0)
            {
                CountingSort(values, exp);
                exp *= 10;
            }

            return values;
        }

        public int[] GetDisorder(int numberValues)
        {
            Random random = new();
            return Enumerable.Range(1, numberValues).Select(x => random.Next(-100, 100)).ToArray();
        }

        public bool Validation(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] > values[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        private static void CountingSort(int[] values, int exp)
        {
            int n = values.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                count[(values[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(values[i] / exp) % 10] - 1] = values[i];
                count[(values[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                values[i] = output[i];
            }
        }
    }
}
