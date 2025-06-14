//Создать консольное приложение, в котором объявить класс, использующий обобщенный тип данных.
//Внутри класса объявить метод, который выводит на консоль название типа данных, который был использован в качестве обобщенного при создании элемента класса.  
using System.Reflection;

class Program
{
    static void Main()
    {
        Class0<int> cls1 = new(1);
        Class0<string> cls2 = new("1");
        Class0<bool> cls3 = new(true);
        cls1.PrintTypeField();
        cls2.PrintTypeField();
        cls3.PrintTypeField();
    }
}
