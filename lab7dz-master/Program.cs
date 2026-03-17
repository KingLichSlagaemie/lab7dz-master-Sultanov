using System;  

namespace lab7dz
{
    //Задание 1

    //internal class Program
    ////{
    //    class Book
    //    {
    //        public string? title;
    //        public string? author;
    //        public int year;
    //        public bool isAvailable;

    //        public Book()
    //        {
    //            title = "Неизвестно";
    //            author = "Неизвестен"; 
    //            year = 0;
    //            isAvailable = false;
    //        }

    //        public Book(string title, string author, int year, bool isAvailable)
    //        {
    //            this.title = title;
    //            this.author = author;
    //            this.year = year;
    //            this.isAvailable = isAvailable;
    //        }

    //        public void PrintInfo()
    //        {
    //            string availability = isAvailable ? "Да" : "Нет";
    //            Console.WriteLine($"Название: \"{title}\", Автор: {author}, Год: {year}, Доступна: {availability}");
    //        }
    //    }


    //    static void Main(string[] args)
    //    {
    //        Book book1 = new Book(); 
    //        Book book2 = new Book("Война и мир", "Толстой", 1869, true);

    //        book2.PrintInfo();
    //        book1.PrintInfo();
    //    }
    //}


    //Задание 2



    //using System;  

    //class BankAccount1
    //{
    //    public string? accountNumber;
    //    private decimal balance = 0m;

    //    public void Deposit_1(decimal amount)
    //    {
    //        if (amount <= 0)
    //        {
    //            Console.WriteLine("Сумма пополнения должна быть положительной.");
    //            return;
    //        }

    //        this.balance += amount;  
    //        Console.WriteLine($"Пополнение: {amount}₽. Текущий баланс: {this.balance}₽");
    //    }

    //    public void Withdraw1(decimal amount)
    //    {
    //        if (amount <= 0)
    //        {
    //            Console.WriteLine("Сумма снятия должна быть положительной.");
    //            return;
    //        }

    //        if (amount <= this.balance)
    //        {
    //            this.balance -= amount;
    //            Console.WriteLine($"Снятие: {amount}₽. Остаток: {this.balance}₽");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Недостаточно средств!");
    //        }
    //    }

    //    public void PrintBalance()
    //    {
    //        Console.WriteLine($"Текущий баланс: {this.balance}₽");  
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        var acc = new BankAccount1 { accountNumber = "ACC-777" };
    //        acc.Deposit_1(1000);   
    //        acc.Withdraw1(500);    
    //        acc.PrintBalance();    
    //    }
    //}


    //Задание 3

    //using System;

    //namespace lab7dz
    //{
    //    internal class Car_DZ_
    //    {
    //        public string? Model;
    //        public int Speed;
    //        public int MaxSpeed;

    //        public Car_DZ_(string model, int maxSpeed)
    //        {
    //            Model = model;
    //            Speed = 0;
    //            MaxSpeed = maxSpeed;
    //            Console.WriteLine($"Модель: {Model}, Максимальная скорость: {MaxSpeed} км/ч");
    //        }

    //        public void Accelerate1(int delta)
    //        {
    //            if (delta < 0)
    //            {
    //                Console.WriteLine("Ускорение должно быть положительным.");
    //                return;
    //            }
    //            Speed += delta;
    //            if (Speed > MaxSpeed)
    //                Speed = MaxSpeed;
    //            Console.WriteLine($"Разгон: текущая скорость {Speed} км/ч");
    //        }

    //        public void Brake()
    //        {
    //            Speed = 0;
    //            Console.WriteLine($"После торможения: {Speed} км/ч");
    //        }

    //        static void Main(string[] args)
    //        {
    //            Car_DZ_ car = new Car_DZ_("Toyota Camry", 200);
    //            car.Accelerate1(60);
    //            car.Accelerate1(100);
    //            car.Brake();
    //        }
    //    }
    //}


    //Задание 4


    //using System;

    //namespace lab7dz
    //{
    //    internal class Program
    //    {
    //        class Dice
    //        {
    //            private int _sides;

    //            public Dice(int sides = 6)
    //            {
    //                _sides = sides;
    //            }

    //            public int Roll()
    //            {
    //                return new Random().Next(1, _sides + 1);
    //            }
    //        }

    //        static void Main(string[] args)
    //        {
    //            Dice d6 = new Dice(6);
    //            Dice d12 = new Dice(12);

    //            Console.Write("6-гранный кубик: ");
    //            for (int i = 0; i < 3; i++)
    //            {
    //                Console.Write(d6.Roll());
    //                if (i < 2) Console.Write(", ");
    //            }
    //            Console.WriteLine();

    //            Console.Write("12-гранный кубик: ");
    //            for (int i = 0; i < 3; i++)
    //            {
    //                Console.Write(d12.Roll());
    //                if (i < 2) Console.Write(", ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}

    //Задание 5


    using System;

    namespace lab7dz
    {
        internal class Program
        {
            class Character
            {
                public int Health;
                public int Mana;

                public Character(int health, int mana)
                {
                    Health = health;
                    Mana = mana;
                }

                public void Attack()
                {
                    Console.WriteLine("Персонаж атакует!");
                }
            }

            static void Main(string[] args)
            {
                Character warrior = new Character(100, 0);
                Character mage = new Character(60, 100);
                Character archer = new Character(80, 20);

                warrior.Attack();
                mage.Attack();
                archer.Attack();
            }
        }
    }

}