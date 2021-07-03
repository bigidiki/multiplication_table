using System;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.ReadLine();
        }

        public static void Create_multiplication_table(int[] up,int[]down)// вверхний массив нижний массив
        {
            Console.ForegroundColor = ConsoleColor.Green; // цвет зеленый у вверхенго
            foreach(int i in up)
            {
                Console.Write(" {0} ",i);
            }
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red; // цвет red у нижнего
            foreach (int i in down)
            {
                Console.WriteLine(" {0} ", i);
            }
            Console.ResetColor(); // збрасываем до обычного белого цвета
            Console.WriteLine(" ");

            int index = 0;
            int[] composition = new int[up.Length];
            while (index == 6)
            {
                for(int i = 0; i < up.Length-1; i++)
                {
                    composition[i] = down[index] * up[i]; 
                }
                index++;
                foreach(int i in composition)
                {
                    Console.Write(" {0} ",i);
                }
            }
        }
    }
}
