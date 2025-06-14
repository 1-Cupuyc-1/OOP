class Class0 <T> where T: Class1 
{
    public T? field;
    public Class0(T? field)
    {
        this.field = field;
    }

    public void PrintTypeField()
    {
        if(field != null) Console.WriteLine($"{field.GetType().Name} field");
    }
}
