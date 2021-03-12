using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProgramm
{
    class Program
    {
        static void Main(string[] args)
        {


            string name;
            int age, pol, hobbi;
            Console.WriteLine("Привет, как я могу обращаться к тебе?");
            name = Console.ReadLine();
            Console.WriteLine($"Очень приятно познакомиться, {name}. Скажи мне, а сколько тебе лет?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ого, ты молодо выглядишь молодо для {age}.Какой твой пол? 1 - муж, 2 - жен");
            pol = Convert.ToInt32(Console.ReadLine());
            if(pol == 1)
            {
                Console.WriteLine("Наверное твой любимый цвет синий? А какие увлечения тебе нравятся? 1-спорт, 2-пиво, 3-мото, 4-авто, 5-велосипед,6-трактор,7-путин ");
                hobbi = Convert.ToInt32(Console.ReadLine());
                if(hobbi == 1)
                {
                    Console.WriteLine("Мне тоже нравится спорт");
                    Console.ReadKey();
                }
                else if(hobbi == 2)
                {
                    Console.WriteLine("Мне тоже нравится пиво");
                    Console.ReadKey();
                }
                else if (hobbi == 3)
                {
                    Console.WriteLine($"Мне тоже нравится мото");
                    Console.ReadKey();
                }
                else if (hobbi == 4)
                {
                    Console.WriteLine($"Мне тоже нравится авто");
                    Console.ReadKey();
                }
                else if (hobbi == 5)
                {
                    Console.WriteLine($"Мне тоже нравится велосипед");
                    Console.ReadKey();
                }
                else if (hobbi == 6)
                {
                    Console.WriteLine($"Мне тоже нравится трактор");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Мне тоже нравится путин");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Наверное твой любимый цвет розовый? А какие увлечения тебе нравятся  1-спорт, 2-куклы, 3-караоке, 4-авто, 5-велосипед,6-трактор,7-путин");
                hobbi = Convert.ToInt32(Console.ReadLine());
                if (hobbi == 1)
                {
                    Console.WriteLine($"Мне тоже нравится спорт");
                    Console.ReadKey();
                }
                else if (hobbi == 2)
                {
                    Console.WriteLine($"Мне тоже нравится куклы");
                    Console.ReadKey();
                }
                else if (hobbi == 3)
                {
                    Console.WriteLine($"Мне тоже нравится караоке");
                    Console.ReadKey();
                }
                else if (hobbi == 4)
                {
                    Console.WriteLine($"Мне тоже нравится авто");
                    Console.ReadKey();
                }
                else if (hobbi == 5)
                {
                    Console.WriteLine($"Мне тоже нравится велосипед");
                    Console.ReadKey();
                }
                else if (hobbi == 6)
                {
                    Console.WriteLine($"Мне тоже нравится трактор");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Мне тоже нравится путин");
                    Console.ReadKey();
                }
                Console.WriteLine($"Пока,{name}");
            }

            //1.Программа должна спросить ваше имя и использовать его в дальнейшем
            //2. программа должна знать ваш возраст
            //3.Программа должна знать ваш пол и исходя из этого спросить ваш любимый цвет, 
            //розовый для девочки или синий для мальчика
            //4.Программа должна спросить про ваши увлечения, минимум 7 увлечений, она должна подароваться за вас
            //5.Спросить у вас, нравится ли вам ваш код. Да, программа говорит, что вы молодец, нет - отключается
        }
    }
}
