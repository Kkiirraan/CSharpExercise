using System;
using Gee.External.Capstone.Arm64;


namespace ProgramNames
{
    public class Program 
    {  
        public static bool IncreasingSequence(List<int> numbers)
        {
            int x=0;
            for(int i=0;i<numbers.Count-2;i++)
            {
                if(numbers[i]>=numbers[i+1])
                {
                    x++;
                }
                if(i+2<numbers.Count && numbers[i]>=numbers[i+2])
                {
                    x++;
                }
            }
            return x<=2;
        }
        public static void Main(string[] args)
        {
         List<int> numbers=new List<int>(){1, 3, 1, 3};
         Console.WriteLine(IncreasingSequence(numbers));
        }
    }
}
