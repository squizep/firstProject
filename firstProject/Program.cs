using System;
using System.Reflection.Emit;
using System.Text;

namespace firstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
            double health;
            int armor;
            int attack;
            int precentConverter = 100;
            int precentArmor = 6;
            double damage;
            
            Console.Write("Введите количество здоровья:");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество брони:");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество урона:");
            attack = Convert.ToInt32(Console.ReadLine());

            health -= damage = Math.Round(attack / ((health + armor * precentArmor) / precentConverter), 1);
            
            Console.WriteLine($"У вас 100 здоровья, вам нанесли {damage}, у вас осталось {health}");
            */

            /*    
            int money;
            int food;
            int foodUnitPrice = 10;
            Console.WriteLine($"Добро пожаловать в пекарню! Сегодня еда по {foodUnitPrice} монет");
            Console.Write("Сколько у вас золота?:");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам надо?:");
            food = Convert.ToInt32(Console.ReadLine());
            if (money >= foodUnitPrice * food)
            {
                money -= foodUnitPrice * food;
                Console.WriteLine($"У вас осталось {money} монет");
            }
            else
            {
                Console.WriteLine("У вас недостаточно монет");
            }
            */

            /*
            int money = 400;
            int level = 8 ;
            if(money >= 500 || level > 9)
            {
                Console.WriteLine("Проходи! Добро пожаловать в нашу гильдию");
            }
            else
            {
                Console.WriteLine("Вас выпнули за дверь");
            }
            */
            /*
            string dayOfWeek;
            dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "понедельник":
                    Console.WriteLine("Идем в кино"); 
                    Console.WriteLine("Едим попкорм"); 
                    break;
                case "вторник":
                    Console.WriteLine("Делаем дз");
                    break;
                case "среда":
                    Console.WriteLine("Учим уроки");
                    break;
                case "четверг":
                    Console.WriteLine("Дрочим");
                    break;
                case "пятница":
                    Console.WriteLine("Лох");
                    break;
                case "суббота":
                    Console.WriteLine("я лох?");
                    break;
                case "воскресенье":
                    Console.WriteLine("сам лох");
                    break;
            */
            /*
            float rublesWallet;
            float dollarsWallet;

            int rubToUsd = 64, usdToRub = 66;

            float exchangeCurrencyCount;

            string desiredOperation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей: ");
            rublesWallet = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс долларов: ");
            dollarsWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию.");
            Console.WriteLine("1 - обменять рубли в доллары.");
            Console.WriteLine("2 - обменять доллары в рубли.");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллоры.");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesWallet >= exchangeCurrencyCount)
                    {
                        rublesWallet -= exchangeCurrencyCount;
                        dollarsWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество рублей");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsWallet >= exchangeCurrencyCount)
                    {
                        dollarsWallet -= exchangeCurrencyCount;
                        rublesWallet += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество рублей");
                    }
                    break;
                default:
                    Console.WriteLine("Выбрана неверная операция");
                    break;
            }

            Console.WriteLine($"Ваш баланс: {rublesWallet} рублей, {dollarsWallet} долларов");
            */
            /*
            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            while (age-- > 0)
            {
                if (age == 5)
                {
                    continue;
                }
                Console.WriteLine("С днем Рождения");

                
                
            }
            */
            /*
            int tryCount = 5;
            string password = "123456";
            string userInput;

            for(int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите пароль: ");
                userInput= Console.ReadLine();
                if (userInput == password) {
                    Console.WriteLine("Секретики");
                    break;
                } 
                else
                {
                    Console.WriteLine("Введен неверный пароль");
                    Console.WriteLine("У вас осталось попыток: " + (tryCount - (i + 1)));
                }
            }
            */
            /*
            float money;
            int years;
            int percent;

            Console.Write("Введите количество денег: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("На сколько лет открыт вклад?: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент?: ");
            percent = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine("В этом году у вас " + money);
                Console.ReadKey();
            }
            */
            /*
            int playerHealth = 100;
            int playerDamage = 10;
            int enemyHealth = 50;
            int enemyDamage = 15;

            while(playerHealth > 0 && enemyHealth> 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;
                Console.WriteLine(playerHealth + " игрок");
                Console.WriteLine(enemyHealth + " враг");
            }

             if (playerHealth <= 0 && enemyHealth <= 0) 
            {
                Console.WriteLine("Ничья");
            }
             else if(enemyHealth <= 0) 
            {
                Console.WriteLine("Победа игрока");
            }
             else if (playerHealth <= 0) 
            {
                Console.WriteLine("Победа врага");
            }
             */

            /*

            Random rand = new Random();
            int value;

            while (true)
            {
                value = rand.Next(0, 10);
                Console.WriteLine(value);
                Console.ReadKey();
            }

            */

            /*

            Random rand = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rand.Next(0, 5));
            }

            
            */

            /*

            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower}, но меньше чем {higher}");
            Console.WriteLine($"Что это за число? У вас {triesCount} попыток отгадать.");

            while (triesCount-- > 0) {
                Console.Write("Ваш ответ: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput == number) {
                    Console.WriteLine("Вы правы, это было число " + number + ".");
                    break;
                 }
                else {
                    if (triesCount != 0)
                    {
                        Console.WriteLine("Не верно, попробуйте ещё раз. Осталось попыток " + triesCount);
                    }
                    else
                    {
                        Console.WriteLine("Вы проиграли, увы,  но повезет в следующий раз. Это было число " + number);
                    }
                 }
             }
            
            if (triesCount < 0) { 
                 Console.WriteLine("Вы проиграли, увы,  но повезет в следующий раз. Это было число " + number);
             } */

            /*

            Random rand = new Random();
            float health1 = rand.Next(90, 100);
            int damage1 = rand.Next(5, 10);
            int armor1 = rand.Next(25, 65);

            float health2 = rand.Next(80, 150);
            int damage2 = rand.Next(20, 40);
            int armor2 = rand.Next(65, 100);

            Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {damage1} наносимый урон, {armor1} броня");
            Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {damage2} наносимый урон, {armor2} броня");

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

                Console.WriteLine("Здоровье гладиатора 1: " + health1);
                Console.WriteLine("Здоровье гладиатора 2: " + health2);
            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья, оба гладиатора погибли");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Гладиатор 1 пал");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Гладиатор 2 пал");
            }

            */


            Console.WriteLine("Привет, Андрей!\nКуда ты вчера делся?\nя убежал к...");
        }
    }
}

