class Class1 : Class0
{
    public override void PrintAbstractMes() { Console.WriteLine("Абстрактный метод из Class1"); }
    public override void PrintVirtualMes()
    {
        Console.WriteLine("Виртуальный метод из Class1");
        base.PrintVirtualMes();

    }

}
