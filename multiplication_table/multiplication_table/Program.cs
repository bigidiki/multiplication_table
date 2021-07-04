using System;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] up = new int[5] {  1, 2, 3, 4, 5 };
            int[] down = new int[5] { 1, 2, 3, 4, 5 };
            Create_multiplication_table(up, down);

            Console.ReadLine();
        }

        public static void Create_multiplication_table(int[] up,int[]down)// вверхний массив и нижний массив
        {
            Console.ForegroundColor = ConsoleColor.Green; // цвет зеленый у вверхенго массива
            Console.Write(" ");
            foreach(int i in up)
            {
                Console.Write(" {0} ",i);
            }
            Console.WriteLine(" ");
            
            //foreach (int i in down)
            //{
            //    Console.WriteLine(" {0} ", i);
            //}
            
            

            int index = 0;
            int[] composition = new int[up.Length];
            while (index != 5)
            {
                for(int i = 0; i < up.Length; i++)
                {
                    composition[i] = down[index] * up[i]; 
                }

                Console.ForegroundColor = ConsoleColor.Red; // цвет red у нижнего массива
                Console.Write(" {0} ", down[index]);

                Console.ResetColor(); // збрасываем до обычного белого цвета
                foreach (int i in composition)
                {
                    Console.Write(" {0} ",i);
                }
                Console.WriteLine(" ");
                index++;
            }
        }
    }
}
