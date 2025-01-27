using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProgramNameSpace
{
    class Program 
    {
        public static int FindLowestUniqueIndex(int[] arr)
        {
            Dictionary<int,int> frequency=new Dictionary<int, int>();
            foreach(int num in arr)
            {
                if(frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else{
                    frequency[num]=1;
                }
            }
            for(int i=0;i<arr.Length;i++)
            {
                if(frequency[arr[i]]==1)
                {
                    return i;
                }
            }
            return -1;
        }
        
        public static void Main(string[] args)
        {
        int[] arr1={1,2,3};
        int[] arr2={1,1,2,3,4,3};
        Console.WriteLine(FindLowestUniqueIndex(arr1));
        Console.WriteLine(FindLowestUniqueIndex(arr2));
        }
    }
}
