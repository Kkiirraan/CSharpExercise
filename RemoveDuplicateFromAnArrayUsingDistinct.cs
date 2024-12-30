using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
        // Removing duplicates using for loop
        int[] num={1,1,2,3,3,5,5};
        num=num.Distinct().ToArray();
        Console.WriteLine($"[{string.Join(",",num)}]");
        }
    }
}
