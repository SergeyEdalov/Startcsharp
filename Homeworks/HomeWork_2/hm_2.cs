namespace HomeWork_2
{
    internal class Program
    {

        //Дан двумерный массив.
        //732
        //496
        //185
        //Отсортировать данные в нем по возрастанию.
        //123
        //456
        //789
        //Вывести результат на печать.

        static void Main(string[] args)
        {

            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            List<int> list = new List<int>();

            // добавление элементов массива в список
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    list.Add(a[i, j]);
                }
            }
            list.Sort();

            // добавление отсортированных элементов списка в двумерный массив
            int k = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = list[k];
                    k++;
                }
            }
            // вывод двумерного массива
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
