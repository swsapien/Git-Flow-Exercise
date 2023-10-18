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
                    Random rand = new Random();
        int[] randomArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            randomArray[i] = rand.Next(minValue, maxValue + 1);
        }

        return randomArray;
        }

        public int[] Sort(int[] values)
        {
            int max = values[0];
            int min = values[0];
            
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
                if (values[i] < min)
                    min = values[i];
            }

            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
                count[values[i] - min]++;

            for (int i = 1; i < range; i++)
                count[i] += count[i - 1];

            for (int i = values.Length - 1; i >= 0; i--)
            {
                output[count[values[i] - min] - 1] = values[i];
                count[values[i] - min]--;
            }

            for (int i = 0; i < values.Length; i++)
                values[i] = output[i];
        }

        public bool Validation(int[] values)
        {
            throw new NotImplementedException();
        }
    }
}
