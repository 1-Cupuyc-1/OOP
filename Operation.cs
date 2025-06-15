class Operation {
    int sum = 100;
    public delegate void Delegate(int num);
    Delegate operation;
    public event Delegate Op
    {
        add
        {
            operation += value;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Добавлен новая функция {value.Method.Name}");
            Console.ResetColor();
        }
        remove
        {
            if(operation != null){
                operation -= value;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Удалена функция {value.Method.Name}");
                Console.ResetColor();
            }
        }
    }
    public void PrintEvent(int sum) => operation?.Invoke(sum);


}

