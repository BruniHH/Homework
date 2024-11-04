using System;


namespace MethodExample
{
    // Определение класса Person
    public class Player
    {
        // Приватное поле для хранения имени
        private string name;

        // Публичное поле для хранения возраста
        private int age;

        public string Name
        {
            get {return name; }
            set {name = value; }
        }

        public int Age
        {
            get {return age; }
            set {age = value; }
        }

        // Конструктор для инициализации объекта
        public Player(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Определение метода SayHello
        // Метод не возвращает значение (void) и принадлежит классу Person
        public void SayHello()
        {
            // Вывод приветственного сообщения с именем
            Console.WriteLine($"Hello, {name}!");
        }

        // Определение метода DisplayInfo
        // Метод не возвращает значение (void) и принадлежит классу Person
        public void DisplayInfo()
        {
            // Вывод информации о человеке
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Commands
    {
        public void SayHello(Player p)
        {
            // Вывод приветственного сообщения с именем
            Console.WriteLine($"Hello, {p.Name}!");
        }

        // Определение метода DisplayInfo
        // Метод не возвращает значение (void) и принадлежит классу Person
        public void DisplayInfo(Player p)
        {
            // Вывод информации о человеке
            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
        }

    }

    // Класс Program с точкой входа в программу
    class Program
    {
        // Точка входа в программу
        static void Main(string[] args)
        {
            // Создание объекта класса Person
            Console.WriteLine("Привет! Придумайте имя вашего персонажа -->");
            string newname = Console.ReadLine();

            Console.WriteLine("А теперь id -->");
            int userid = int.Parse(Console.ReadLine());

            Player person = new Player(newname, userid);

            // Вызов метода SayHello
            for(int i = 0; i<10;i++){
                string a = Console.ReadLine();
                if (a == "/display")
            {
                person.DisplayInfo();
            }
            if (a == "/create")
            {
            }
            }
        }
    }
}
