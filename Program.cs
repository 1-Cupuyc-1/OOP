//Создать консольное приложение, в котором объявить класс, внутри которого содержится событие, событие может хранить ссылку на метод, обладающий заданной сигнатурой: void (int).
//Реализовать метод, подходящий данной сигнатуре и подписать его на событие.
//В событии реализовать вывод на консоль информации каждый раз, когда какой-либо метод подписывается на данное событие или отписывается от него.
//Вызвать событие.  

class Program
{
    static void Main(){
        void Sum10(int sum) => Console.WriteLine($"{sum} + 10 = {sum + 10}");
        void Div5(int sum) => Console.WriteLine($"{sum} - 5 = {sum - 5}");
        Operation cls = new();
        cls.Op += Sum10;
        cls.PrintEvent(5);
        cls.Op -= Sum10;
        cls.Op += Div5;
        cls.Op += Sum10;
        cls.PrintEvent(45);
        cls.Op -= Sum10;
        cls.PrintEvent(13);
        cls.Op -= Div5;
        cls.PrintEvent(65);
    }
}
