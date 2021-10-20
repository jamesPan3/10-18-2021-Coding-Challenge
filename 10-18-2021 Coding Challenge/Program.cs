using System;

namespace _10_18_2021_Coding_Challenge
{
    class Program
    {
        static int[,] PrintGrid(int row, int col)
        {
            int[,] GridArray = new int[row, col];

            int temp1 = 1;

            for (int c = 0; c < col; c++)
            {
                for (int r = 0; r < row; r++)
                {
                    GridArray[r,c] = temp1;
                    temp1++;
                }
             }

            return GridArray;
        }


        static void ShowGrid(int[,] TestArray)
        {
            int rowLength = TestArray.GetLength(0);
            int colLength = TestArray.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write("{0} ", TestArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[,] Test1 = PrintGrid(3,6);
            int[,] Test2 = PrintGrid(5,3);
            int[,] Test3 = PrintGrid(4,1);


            ShowGrid(Test1);
            ShowGrid(Test2);
            ShowGrid(Test3);
        }

       
    }
}
