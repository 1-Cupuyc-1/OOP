//Создать консольное приложение, в котором объявить метод расчета медианного значения в целочисленном массиве, который передается в виде параметра в метод.
//Размерность массива задается пользователем с клавиатуры, массив заполняется случайными числами от 0 до значения размерности массива.  

class Program
{
    static void Main()
    {
        bool flag = true;
        uint size = 1;
        while (flag)
        {
            try
            {
                Console.Write("Введите размерность массива: ");
                size = Convert.ToUInt32(Console.ReadLine());
                flag = false;
            }
            catch(Exception ex)
            {
                flag = true;
                Console.WriteLine($"\nОшибка: {ex.Message}\n");
            }
        }
        int[] array = new int[size];

        Random random = new();
        Console.Write("Массив:");
        for (int i = 0; i < size; i++) { 
            array[i] = random.Next((int)size);
            Console.Write($" {array[i]}");
        }
        Console.WriteLine($"\n\nМедиана ряда = {MedianRow(array)}");
    }
    static double MedianRow(int[] array)
    {
        for (int i = 0; i < array.Length; i++){
            for(int index = i, x = array[i]; index > 0;index--)
            {
                if (x < array[index - 1])
                {
                    array[index] = array[index - 1];
                    array[index - 1] = x;
                }
                else break;
            }
        }
        Console.Write("\nОтсортированный массив:");
        for (int i = 0; i < array.Length; i++) Console.Write($" {array[i]}");
        int middle = array.Length / 2;
        double median = array.Length % 2 == 0 ? (array[middle] + array[middle - 1]) / 2D : array[middle];
        return median;

    }
}
