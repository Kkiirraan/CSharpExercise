using System;

namespace ProgramNameSpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            int row,col;
            Console.WriteLine("Enter the number of rows: ");
            row=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            col=Convert.ToInt32(Console.ReadLine());
            int [,] matrix=new int[row,col];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.WriteLine($"Enter the value for array[{i},{j}]:");
                    matrix[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }

            // printing the values from the matrix
            Console.WriteLine("-----------------Matrix----------------------");
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
