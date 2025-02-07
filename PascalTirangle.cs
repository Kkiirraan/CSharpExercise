using System;
namespace ProgramNamespace
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int size=Convert.ToInt32(Console.ReadLine());
            int[,] pascalTriangle=new int[size,size];
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    if(j==0 || j==i)
                    {
                        pascalTriangle[i,j]=1;
                    }
                    else
                    {
                        pascalTriangle[i,j]=pascalTriangle[i-1,j-1]+pascalTriangle[i-1,j];
                    }
                }
            }
            // Printing the triangle
            Console.WriteLine("-------Pascal Triangle--------");
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write(pascalTriangle[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
