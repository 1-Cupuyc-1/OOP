class Class0
{
    public int number1 { get; set; } = 0;
    public int number2 { get; set; } = 0;
    public static Class0 operator+ (Class0 cls1, Class0 cls2)
    {
        int num1 = cls1.number1 + cls2.number1;
        int num2 = cls1.number2 + cls2.number2;
        Class0 new_class = new();
        new_class.number1 = num1;
        new_class.number2 = num2;
        return new_class;
    }

}
