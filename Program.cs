//Создать консольное приложение, в котором объявить класс, содержащий в себе два целочисленных автоматически реализуемых свойства.
//Внутри класса переопределить оператор «+», который позволит складывать элементы данного класса между собой.  
using System.Reflection;

class Program
{
    static void Main()
    {
        Class0 cls1 = new(), cls2 = new();
        Console.WriteLine($"cls1: \t number1 = {cls1.number1} \t number2 = {cls1.number2}");
        Console.WriteLine($"cls2: \t number1 = {cls2.number1} \t number2 = {cls2.number2}\n");
        cls1.number1 = 1;
        cls1.number2 = 2;
        cls2.number1 = 3;
        cls2.number2 = 4;
        Console.WriteLine($"cls1: \t number1 = {cls1.number1} \t number2 = {cls1.number2}");
        Console.WriteLine($"cls2: \t number1 = {cls2.number1} \t number2 = {cls2.number2}\n");
        Class0 cls3 = cls1 + cls2;
        Console.WriteLine($"cls3: \t number1 = {cls3.number1} \t number2 = {cls3.number2}");

    }
}
