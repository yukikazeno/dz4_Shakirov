namespace LatypovaFile;
    class Program
{
    public static void ExcersizeStart(int num)
    {
        Console.WriteLine($"Задание {num}:");
    }
    public static void ExcersizeEnd()
    {
        Console.WriteLine("Нажмите любую клавишу. . .");
        Console.ReadKey();
        Console.Clear();
    }

    public static int[] CreateArray()
    {
        int size = 20;
        int[] array = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 10000);
        }
        return array;

    }
    public static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] ReplacesInArray(int[] array, int num1, int num2)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num1)
            {
                array[i] = num2;
                continue;
            }
            if (array[i] == num2)
            {
                array[i] = num1;
            }
        }
        return array;
    }

    static public double ArrayOperations(ref double multiplication, out double average, params double[] array)
    {
        multiplication = 1;
        double sum = 0;
        foreach (double i in array)
        {
            multiplication *= i;
            sum += i;
        }
        average = sum / array.Length;
        return sum;
    }

    public static void DrawNumber(int? number)
    {
        switch (number)
        {
            case 0:
                Console.WriteLine(" ### \n#   #\n#   #\n#   #\n ### ");
                break;
            case 1:
                Console.WriteLine("  #  \n ##  \n  #  \n  #  \n ### ");
                break;
            case 2:
                Console.WriteLine(" ### \n#   #\n  ## \n #   \n#####");
                break;
            case 3:
                Console.WriteLine("#### \n    #\n ### \n    #\n#### ");
                break;
            case 4:
                Console.WriteLine("#   #\n#   #\n#####\n    #\n    #");
                break;
            case 5:
                Console.WriteLine("#####\n#    \n#### \n    #\n#### ");
                break;
            case 6:
                Console.WriteLine(" ### \n#    \n#### \n#   #\n ### ");
                break;
            case 7:
                Console.WriteLine("#####\n    #\n   # \n  #  \n #   ");
                break;
            case 8:
                Console.WriteLine(" ### \n#   #\n ### \n#   #\n ### ");
                break;
            case 9:
                Console.WriteLine(" ### \n#   #\n ####\n    #\n ### ");
                break;
        }
        Console.WriteLine();
    }


    static void Main()
    {
        ExcersizeStart(1);
        int[] array1_1 = CreateArray();
        PrintArray(array1_1);
        Console.WriteLine("Последовательно введите числа которые хотели бы поменять местами: ");
        int num1 = int.TryParse(Console.ReadLine(), out int n1) ? n1 : 0;
        int num2 = int.TryParse(Console.ReadLine(), out int n2) ? n2 : 0;
        int[] array2_1 = ReplacesInArray(array1_1, num1, num2);
        Console.Clear();
        Console.WriteLine("Массив после замены:");
        PrintArray(array2_1);
        ExcersizeEnd();

        ExcersizeStart(2);
        Console.WriteLine("Введите ваш массив вводя элементы через пробел: ");
        double[] array1_2 = Array.ConvertAll((Console.ReadLine() ?? "").Split(' '), s => double.TryParse(s, out double n) ? n : 0.0);
        double multiplication = 0;
        double average;
        ArrayOperations(ref multiplication, out average, array1_2);
        Console.WriteLine($"Произведение: {multiplication}");
        Console.WriteLine($"Среднее значение: {average}");
        ExcersizeEnd();

        ExcersizeStart(3);
        Console.WriteLine("Введите целое число: ");
        string input = (Console.ReadLine() ?? "").Trim().ToLower();
        if (input == "exit" || input == "выход")
        {
            Console.WriteLine("Выход из программы.");
            Environment.Exit(0);
        }

        int? number = int.TryParse(input, out int n) ? n : null;
        if (number == null)
        {
            Console.WriteLine("Ошибочный ввод, введено не число!");
        }

        if (number < 0 || number > 9)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Ошибочный ввод, введите число от 0 до 9!");
            Thread.Sleep(3000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        else
        {
            DrawNumber(number);
            ExcersizeEnd();
        }

        ExcersizeStart(4);
        string[] swearWords = new string[] { "Ш###и!", "Бл#ть", "Ёб твою мать...", "П###р", "С#ка", "С#ченыш", "Ш###и!", "расп###яй", "П###ец" };
        Grandfather father1 = new Grandfather
        {
            name = "Степан",
            phrases = new string[] { "Ш###и!", "Гады!", "Ироды!" }
        };
        Grandfather father2 = new Grandfather
        {
            name = "Максим",
            phrases = new string[] { "Вот помру я...", "Бл#ть", "Ё-моё!", "Ёб твою мать..." }
        };
        Grandfather father3 = new Grandfather
        {
            name = "Михалыч",
            phrases = new string[] { "Проститутки!", "Твари", "П###р", "С#ка", "Я тебе ноги переломаю" }
        };
        Grandfather father4 = new Grandfather
        {
            name = "Владимир",
            phrases = new string[] { "С#ченыш", "Ш###и!", "Бл#ть", "Ах ты расп###яй", }
        };
        Grandfather father5 = new Grandfather
        {
            name = "Дмитрий",
            phrases = new string[] { "Балабол!", "П###ец", "Черт" }
        };
        Console.WriteLine($"Итоговое количество синяков у: \n{father1.name} - {Grandfather.FatherOperations(father1, swearWords)} \n{father2.name} - {Grandfather.FatherOperations(father2, swearWords)} \n{father3.name} - {Grandfather.FatherOperations(father3, swearWords)} \n{father4.name} - {Grandfather.FatherOperations(father4, swearWords)} \n{father5.name} - {Grandfather.FatherOperations(father5, swearWords)}");
        ExcersizeEnd();
    }
}