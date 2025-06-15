using System.Runtime.Serialization;

class Class:Interface
{
    public void Hello() => Console.WriteLine("Hello, World!");
    public void DateNow() => Console.WriteLine($"{DateTime.Now}");
    public void Bye() => Console.WriteLine("Bye, World!");
}