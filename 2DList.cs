using System;

namespace ProgramNameSpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> matrix=new List<List<int>>{new List<int>{1,2,3},new List<int>{4,5,6,10}, new List<int>{7,8,9}};

            foreach(List<int> row in matrix)
            {
                foreach(int col in row)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }

            int rowNumber = matrix.Count;
            // int colNumber= matrix[0].Count;

            // if the maximum count of the col is not same 
            int colcount=0;
            foreach(List<int> col in matrix)
            {
                if(col.Count>colcount)
                {
                    colcount=col.Count;
                }
            }

            Console.WriteLine($"Row: {rowNumber}");
            Console.WriteLine($"Cols: {colcount}");
        }
    }
}
