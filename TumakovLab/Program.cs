namespace TumakovLab
{
    class Program
    {
        public static void ExcersizeStart(int num)
        {
            Console.WriteLine($"Задание 5.{num}:");
        }
        public static void ExcersizeEnd()
        {
            Console.WriteLine("Нажмите любую клавишу. . .");
            Console.ReadKey();
            Console.Clear();
        }

        public static int Comparison(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public static (int, int) Mimic(int num1, ref int num2)
        {

            int subNum = num1;
            num1 = num2;
            num2 = subNum;
            (int, int) result = (num1, num2);
            return result;
        }

        public static (int, bool) Factorial(int num)
        {
            try
            {
                checked
                {
                    int result = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        result *= i;
                    }
                    return (result, true);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Переполнение!");
                return (0, false);
            }
        }

        public static int FactorialRecursion(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * FactorialRecursion(num - 1);
            }
        }

        public static int GreatestCommonDivisor(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        public static int GreatestCommonDivisor(int num1, int num2, int num3)
        {
            int gcd12 = GreatestCommonDivisor(num1, num2);
            return GreatestCommonDivisor(gcd12, num3);
        }
        public static int Fibonacci(int num)
        {
            if (num <= 1)
            {
                return num;
            }
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }

        static void Main()
        {
            ExcersizeStart(1);
            Console.Write("Введите два целых числа: ");
            int num1 = int.TryParse(Console.ReadLine(), out int n11) ? n11 : 0;
            int num2 = int.TryParse(Console.ReadLine(), out int n21) ? n21 : 0;
            int max = Comparison(num1, num2);
            Console.WriteLine($"Максимальное значение: {max}");
            ExcersizeEnd();

            ExcersizeStart(2);
            Console.Write("Введите два целых числа: ");
            int num12 = int.TryParse(Console.ReadLine(), out int n12) ? n12 : 0;
            int num22 = int.TryParse(Console.ReadLine(), out int n22) ? n22 : 0;
            (int, int) swapped = Mimic(num12, ref num22);
            Console.WriteLine($"Результат выполнения программы: {swapped.Item1}, {swapped.Item2}");
            ExcersizeEnd();

            ExcersizeStart(3);
            Console.Write("Введите целое число: ");
            int num3 = int.TryParse(Console.ReadLine(), out int n3) ? n3 : 0;
            (int, bool) factorialResult = Factorial(num3);
            if (factorialResult.Item2)
            {
                Console.WriteLine($"Факториал числа {num3} равен: {factorialResult.Item1}");
            }
            else
            {
                Console.WriteLine($"Возникло переполнение, Значение checked: {factorialResult.Item2}");
            }
            ExcersizeEnd();

            ExcersizeStart(4);
            Console.Write("Введите целое число: ");
            int num4 = int.TryParse(Console.ReadLine(), out int n4) ? n4 : 0;
            int factorialResult2 = FactorialRecursion(num4);
            Console.WriteLine($"Факториал числа {num4} равен: {factorialResult2}");
            ExcersizeEnd();

            ExcersizeStart(5);
            Console.Write("Введите два целых числа: ");
            int num1_5 = int.TryParse(Console.ReadLine(), out int n1_5) ? n1_5 : 0;
            int num2_5 = int.TryParse(Console.ReadLine(), out int n2_5) ? n2_5 : 0;
            int gcdResult = GreatestCommonDivisor(num1_5, num2_5);
            Console.WriteLine($"НОД чисел {num1_5} и {num2_5} равен: {gcdResult}");
            ExcersizeEnd();

            ExcersizeStart(6);
            Console.Write("Введите три целых числа: ");
            int num1_6 = int.TryParse(Console.ReadLine(), out int n1_6) ? n1_6 : 0;
            int num2_6 = int.TryParse(Console.ReadLine(), out int n2_6) ? n2_6 : 0;
            int num3_6 = int.TryParse(Console.ReadLine(), out int n3_6) ? n3_6 : 0;
            int gcdResult2 = GreatestCommonDivisor(num1_6, num2_6, num3_6);
            Console.WriteLine($"НОД чисел {num1_6}, {num2_6} и {num3_6} равен: {gcdResult2}");
            ExcersizeEnd();

            ExcersizeStart(7);
            Console.Write("Введите целое число: ");
            int num7 = int.TryParse(Console.ReadLine(), out int n7) ? n7 : 0;
            int fibonacciResult = Fibonacci(num7);
            Console.WriteLine($"Число Фибоначчи для k = {num7} равно: {fibonacciResult}");
            ExcersizeEnd();
        }
    }
}