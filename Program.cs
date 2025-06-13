//Создайте консольное приложение, в котором определите класс Person с автоматическими свойствами Name(строковое) и Address (объект другого класса Address с полями City и Street).
//Реализуйте конструктор для Person, принимающий параметры для инициализации всех свойств.
//Создайте массив объектов Person размером, введённым с клавиатуры, заполните его случайными значениями и выведите данные всех объектов на консоль.  

using System;

class Program
{
    static void Main()
    {
        uint number = 1;
        bool flag = true;
        Console.WriteLine("Создайте консольное приложение, в котором определите класс Person с автоматическими свойствами Name(строковое) и Address (объект другого класса Address с полями City и Street).Реализуйте конструктор для Person, принимающий параметры для инициализации всех свойств.Создайте массив объектов Person размером, введённым с клавиатуры, заполните его случайными значениями и выведите данные всех объектов на консоль.\n");
        while (flag)
        {
            try
            {
                flag = false;
                Console.Write("Введите размер массива: ");
                number = Convert.ToUInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                flag = true;
                Console.WriteLine($"\nОшибка: {ex.Message}\n");
            }
        }
        string[] names = {"1", "2", "3", "4", "5"};
        string[] cyties = { "1", "2", "3", "4", "5" };
        string[] streets = { "1", "2", "3", "4", "5" };

        Random random = new Random();
        Person[] person = new Person[number];
        for(int i = 0; i < number; i++)
        {
            string random_name = names[random.Next(names.Length)];
            string random_city = cyties[random.Next(names.Length)];
            string random_street = streets[random.Next(names.Length)];

            person[i] = new Person(random_name, random_city, random_street);
        }
        for(int i = 0; i<number; i++)
        {
            Console.WriteLine($"{i+1}) {person[i].Name} прописан по адресу: г. {person[i].address.City}, ул. {person[i].address.Street}");
        }

    }
} 
 