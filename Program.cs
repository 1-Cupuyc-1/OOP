//Создайте консольное приложение, определите интерфейс IVehicle с методом GetSpeed (возвращает double).
//Реализуйте два класса, реализующих интерфейс: Car и Bicycle, с автоматическим свойством MaxSpeed.
//Создайте коллекцию List<IVehicle>, заполните её случайными объектами Car и Bicycle.
//Используя LINQ, отфильтруйте транспортные средства со скоростью выше 50 и отсортируйте по убыванию скорости.
//Выведите результат. 
class Program
{
    static void Main()
    {
        List<IVehicle> list = new();
        Random random = new();

        var car1 = new Car();
        var car2 = new Car();
        var car3 = new Car();
        List <Car> list_car= new List<Car>() { car1, car2, car3};

        var bicycle1 = new Bicycle();
        var bicycle2 = new Bicycle();
        var bicycle3 = new Bicycle();
        List<Bicycle> list_bicycle = new List<Bicycle>() { bicycle1, bicycle2, bicycle3 };

        foreach(Car car in list_car) car.MaxSpeed = (double)random.Next(50, 300);
        foreach(Bicycle bicycle in list_bicycle) bicycle.MaxSpeed = (double)random.Next(10, 60);
        list.AddRange(list_car);
        list.AddRange(list_bicycle);

        Console.WriteLine("Изначальный список:");
        foreach (var element in list) Console.WriteLine($"{element.GetType().Name}: {element.GetSpeed()}");

        //var filt_list = from element in list where (element.GetSpeed() > 50) orderby -element.GetSpeed() select element; //стандартные операторы запросов LINQ
        var filt_list = list.Where(element => element.GetSpeed() > 50).OrderByDescending(element => element.GetSpeed()); //методы расширение LINQ

        Console.WriteLine("\nОтфильтрованный список:");
        foreach (var element in filt_list) Console.WriteLine($"{element.GetType().Name}: {element.GetSpeed()}");
    }
}
