using System;
using BenchmarkDotNet.Exporters;
using Microsoft.Diagnostics.Tracing.Stacks;


namespace ProgramNameSpace
{
    class Program 
    {
        public static int[,] Rotate90(int[,] matrix)
        {
            int row=matrix.GetLength(0);
            int col=matrix.GetLength(1);
            int[,] newMatrix=new int[col,row];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    // newMatrix[j, row-1-i]=matrix[i,j]; rotating to the right 
                    newMatrix[col-1-j,i]=matrix[i,j]; // rotating to the left
                }
            }
            return newMatrix;
        }
        public static int[,] Rotate180(int[,] matrix)
        {
            int n=matrix.GetLength(0);
            int[,] rotated=new int[n,n];
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    rotated[n-i-1,n-j-1]=matrix[i,j];
                }
            }
            return rotated;
        }
        public static int[,] CompareAndReplace(int[,] original,int[,] rotated)
        {
            int n=original.GetLength(0);
            int[,] result=new int[n,n];
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    result[i,j]=original[i,j]==rotated[i,j] ? original[i,j]:0;
                }
            }
            return result;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            int row=matrix.GetLength(0); // length of 1st dimension ie. row here
            int col=matrix.GetLength(1); // length of 2nd dimension ie. col here

            Console.WriteLine("-----------------");
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            int[,] matrix={{1,2,3},{4,5,6},{7,8,9}};
            PrintMatrix(matrix);

            int[,] matrix90=Rotate90(matrix);
            PrintMatrix(matrix90);

            int[,] matrix180=Rotate180(matrix);
            PrintMatrix(matrix180);


            int[,] compared=CompareAndReplace(matrix,matrix90);
            PrintMatrix(compared);
        }
    }
}
