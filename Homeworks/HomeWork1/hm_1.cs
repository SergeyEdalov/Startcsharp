using System;

class hm_1
{
    private static void Main(string[] args)
    {
        inputData(args);
        double result = calculateCount(args);
        Console.WriteLine("Результат = " + result);       
    }

    private static string[] inputData(string[] args)
    {
        if (args.Length == 3)
        {
            try
            {
                double a = double.Parse(args[0]);
                double b = double.Parse(args[2]);
                String c = args[1];
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Введен неверный формат данных");
            }
            return args;
        }
        else
        {
            Console.WriteLine("Введено неправильное количество аргументов");
        }
        return null;
    }

    private static double calculateCount(string[] args) 
    {
        double a = double.Parse(args[0]);
        double b = double.Parse(args[2]);
        String c = args[1];
        double result = 0;
        switch (c)
        {
            case "+": { result = a + b; break; }
            case "-": { result = a - b; break; }
            case "/": { result = a / b; break; }
            case "*": { result = a * b; break; }
            default: { Console.WriteLine("Калькулятор такое не считает."); break; }
        }
        return result;
    }

}