//Создать консольное приложение, в котором объявить класс, содержащий конструктор, принимающий 2 параметра (строковый и логический (bool)).
//Значения передаваемых в конструктор параметров записать в автоматически реализуемые свойства. Объявить класс, который является наследником данного класса.
//Создать два массива элементов класса наследника, размерность массива ввести с клавиатуры (размерность массивов одинаковая).
//Массивы заполнить произвольными значениями (в автоматическом режиме) и вывести на консоль информацию о том, в каком из массивов чаще встречается значение false. 
class Program
{
    static void Main()
    {
        uint size = 1;
        bool flag = true;
        while (flag)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                size = Convert.ToUInt32(Console.ReadLine());
                flag = false;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}\n");
            }
        }
        Class1[] array1 = new Class1[size];
        Class1[] array2 = new Class1[size];

        Random random = new();

        bool[] array_bool = new bool[2] { false, true };

        for(int i = 0; i < 2;i++)
        {
            for(int j = 0; j< size;j++)
            {
                string random_str = Convert.ToString(random.Next((int)size));
                bool random_bool = array_bool[random.Next(2)];
                if (i == 0) array1[j] = new Class1(random_str, random_bool);
                else array2[j] = new Class1(random_str, random_bool);
            }
        }
        int quant_false = 0;
        Console.WriteLine("Массив1: ");
        for (int i = 0; i < array1.Length; i++){
            if (array1[i].boolean == false) quant_false++;
            Console.WriteLine($"str: {array1[i].str} \t bool: {array1[i].boolean}"); 
        }

        Console.WriteLine("\nМассив2: ");
        for (int i = 0; i < array2.Length; i++)
        {
            if (array2[i].boolean == false) quant_false--;
            Console.WriteLine($"str: {array2[i].str} \t bool: {array2[i].boolean}");
        }
        if (quant_false > 0) Console.WriteLine($"\nВ массиве1 чаще встречается значение false");
        else if(quant_false < 0) Console.WriteLine($"\nВ массиве2 чаще встречается значение false");
        else Console.WriteLine($"\nВ массивах одинаковое кол-во значений false");

    }


}
