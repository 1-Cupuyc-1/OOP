//Создать консольное приложение, в котором объявить два делегата для хранения ссылок на методы, обладающие следующими сигнатурами: 
//void(int, string, bool)
//int(int[], double)
//Реализовать методы, подходящие, описанным выше сигнатурам. Сохранить ссылки на данные в описанных делегатах. Вызвать методы используя созданные делегаты. 
class Program
{
    delegate void Del1(int num, string str, bool boolean);
    delegate int Del2(int[] a, double b);
    static void Main()
    {
        void CheckRepresentation(int num, string str, bool boolean)
        {
            if (boolean == false) Console.WriteLine(str);
            else Console.WriteLine("Вывод число можно представить в некомплексной форме: 13");
        }
        int AmountNum(int[] a, double b)
        {
            int quant = 0;
            foreach(var num in a) if (num > b) quant++;
            return quant;
        }

        int a = 13;
        string b = "Число нельзя представить в некомплексной форме";
        bool c = true;
        int[] d = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        double e = 5.1;

        Del1 del1 = CheckRepresentation;
        Del2 del2 = new(AmountNum);

        del1(a, b, c);
        Console.WriteLine($"В массиве {del2?.Invoke(d, e)} числа, которые > {e}");
    }
}
