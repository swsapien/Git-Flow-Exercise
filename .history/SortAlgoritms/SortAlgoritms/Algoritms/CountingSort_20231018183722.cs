using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgoritms.Algoritms
{
    /// <summary>
    /// Este algoritmo es adecuado para conjuntos de datos con valores enteros dentro de un rango específico. 
    /// Cuenta la frecuencia de cada elemento y utiliza esa información para ordenar los elementos. 
    /// Es eficiente cuando se cumplen sus condiciones de uso.
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public class CountingSort : IAlgoritm
    {
        public int[] GetDisorder(int numberValues)
        {
            throw new NotImplementedException();
        }

        public int[] Sort(int[] values)
        {

        int max = arr[0];
        int min = arr[0];
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }

        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
            count[arr[i] - min]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }

        for (int i = 0; i < arr.Length; i++)
            arr[i] = output[i];
    }

        }

        public bool Validation(int[] values)
        {
            throw new NotImplementedException();
        }
    }
}
