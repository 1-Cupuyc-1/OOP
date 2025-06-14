class Class0 <T>
{
    public T field { get; set; }
    public Class0(T field)
    {
        this.field = field;
    }
    public void PrintTypeField() => Console.WriteLine($"{field.GetType().Name} field");
}
