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
            // Genera valores desordenados
            Random random = new Random();
            int[] values = new int[numberValues];
            for (int i = 0; i < numberValues; i++)
            {
                values[i] = random.Next(-100,100); // Valores aleatorios dentro del rango
            }
            return values;
        }
        public int[] Sort(int[] values)
        {
             if (values == null || values.Length <= 1)
                return values;
            int max = values[0];
            int min = values[0];
            // Encontrar el valor máximo y mínimo en el arreglo
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
                if (values[i] < min)
                    min = values[i];
            }
            // Crear un arreglo de frecuencia para contar las ocurrencias de cada valor
            int[] count = new int[max - min + 1];
            // Contar las ocurrencias de cada valor
            for (int i = 0; i < values.Length; i++)
            {
                count[values[i] - min]++;
            }
            // Reconstruir el arreglo ordenado
            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    values[index] = i + min;
                    index++;
                    count[i]--;
                }
            }
            return values;
        }
        public bool Validation(int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < values[i - 1])
                {
                    return false; // El arreglo no está ordenado
                }
            }
            return true; 
        }
    }
}