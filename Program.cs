//Создать консольное приложение, в котором объявить класс с приватным методом, выводящим на консоль сообщение, переданное в данном методе.
//Вызвать приватный метод из вне класса, в котором он объявлен (использование рефлексии).  

using System.Reflection;

class Program
{
    static void Main()
    {
        Message message = new();
        var print = typeof(Message).GetMethod("Print", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        print?.Invoke(message, new object[] { "Hello, world!" });
    }
} 
 