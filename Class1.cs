class Class1
{
    public int num { get; set; }
    public string? str { get; set; }
    public Class1(int num, string? str)
    {
        this.num = num;
        this.str = str;
    }
}

class Class2 : Class1
{
    public bool boolean;
    public Class2(int num, string str, bool boolean): base(num, str)
    {
        this.boolean = boolean;
    }
}