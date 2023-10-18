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
            // Implementa el método para generar un arreglo desordenado si es necesario.
            throw new NotImplementedException();
        }

        public int[] Sort(int[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            // Llama al método QuickSort para ordenar el arreglo.
            QuickSortArray(values, 0, values.Length - 1);

            return values;
        }

        public bool Validation(int[] values)
        {
            // Implementa el método para validar el arreglo ordenado si es necesario.
            throw new NotImplementedException();
        }

        private void QuickSortArray(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSortArray(arr, low, pivotIndex - 1);
                QuickSortArray(arr, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }
    }
}
