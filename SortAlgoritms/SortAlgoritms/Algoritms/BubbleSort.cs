namespace SortAlgoritms.Algoritms;

/// <summary>
/// Este es un algoritmo simple que recorre la lista repetidamente y compara elementos adyacentes, 
/// intercambiándolos si están en el orden incorrecto. Aunque es fácil de entender, no es eficiente en 
/// términos de tiempo y generalmente no se utiliza en aplicaciones prácticas para conjuntos de datos grandes.
/// </summary>
/// <param name="values"></param>
/// <returns></returns>
public class BubbleSort : IAlgoritm
{
    private Random random = new Random();

    public int[] GetDisorder(int numberValues)
    {
        int[] values = new int[numberValues];
        for (int i = 0; i < numberValues; i++)
        {
            values[i] = random.Next(-100, 100); // Random values between -100 and 100
        }
        return values;
    }

    public int[] Sort(int[] values)
    {
        int n = values.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (values[j] > values[j + 1])
                {
                    // Swap values[j] and values[j+1]
                    int temp = values[j];
                    values[j] = values[j + 1];
                    values[j + 1] = temp;
                }
            }
        }
        return values;
    }

    public bool Validation(int[] values)
    {
        for (int i = 1; i < values.Length; i++)
        {
            if (values[i - 1] > values[i])
            {
                return false; // Array is not sorted
            }
        }
        return true; // Array is sorted
    }
}