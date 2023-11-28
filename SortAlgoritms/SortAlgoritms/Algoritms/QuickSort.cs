using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortAlgoritms.Algoritms
{
    public class QuickSort : IAlgoritm
    {
        public int[] GetDisorder(int numberValues)
        {
            Random random = new Random();
            int[] values = new int[numberValues];

            for (int i = 0; i < numberValues; i++)
            {
                values[i] = random.Next(-100, 101); // Genera números aleatorios entre -100 y 100.
            }

            return values;
        }

        public int[] Sort(int[] values)
        {
            if (values == null || values.Length <= 1)
            {
                return values;
            }

            QuickSortAlgorithm(values, 0, values.Length - 1);
            return values;
        }

        public bool Validation(int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < values[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        private void QuickSortAlgorithm(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                QuickSortAlgorithm(arr, low, partitionIndex - 1);
                QuickSortAlgorithm(arr, partitionIndex + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
