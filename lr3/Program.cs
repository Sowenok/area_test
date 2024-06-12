using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, p, S;
            double a, b, Rad;
            int variant;

            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Треугольник");
            //Console.WriteLine("4. Трапеция");
            //Console.WriteLine("5. Сектор");
            


            string temp = Console.ReadLine();
            try
            {

                variant = Convert.ToInt32(temp);    // преобразование в число
            }
                catch { variant = 0; }

            try
            {



                switch (variant)
                {

                    case 1:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Сторона B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь прямоугольника = " + a * b);
                        break;

                    case 2:
                        Console.Write("Радиус R = ");
                        temp = Console.ReadLine();
                        Rad = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь круга = " + Math.PI * Math.Pow(Rad, 2));
                        break;

                    case 3:
                        Console.WriteLine("Введите сторону A: ");
                        A = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите сторону B: ");
                        B = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите сторону C: ");
                        C = Convert.ToDouble(Console.ReadLine());

                        p = (A + B + C) / 2;

                        S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

                        Console.WriteLine("Площадь равна: {0}", S);
                        Console.ReadLine();
                        break;

                    default: Console.WriteLine("Выбор неверен "); break;

                }
            }
            catch { Console.WriteLine("Ошибка при вводе числа"); }
        }     
    }
}       


