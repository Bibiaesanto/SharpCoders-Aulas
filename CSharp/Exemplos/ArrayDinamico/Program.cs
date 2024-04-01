namespace ArrayDinamico;

public class Program
{
    public static void ExibeArray(int[] array){
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine();
    }

    public static int[] PushAndReturn(int[] array, int valor){
        int tamanho = array.Length;
        int[] copy = array;
        array = new int[tamanho + 1];

        // copy = [5, 7, 9]
        // array = [ , , , ]

        for (int i = 0; i < copy.Length; i++)
        {
           array[i] = copy[i]; 
        }
        // [5, 7, 9]
        // [ 5, 7, 9, ]
        int ultimaPos = array.Length -1;
        array[ultimaPos] = valor;

         //[5, 7, 9]
        // [ 5, 7, 9, 12]
        return array;
    }

   public static void Main(string[] args)
    {
        int[] array = new int[3];

        array[0] = 5;
        array[1] = 7;
        array[2] = 9;
        
        Console.WriteLine("antes: ");
        ExibeArray(array);

        array = PushAndReturn(array, 12);
        array = PushAndReturn(array, 13);
        array = PushAndReturn(array, 14);
        array = PushAndReturn(array, 15);

        Console.WriteLine("depois: ");
        ExibeArray(array);
    }
}
