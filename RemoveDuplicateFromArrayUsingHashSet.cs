using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
        // Removing duplicates using for loop
        int[] nums={1,1,2,2,3,3,4};
        HashSet<int> unique=new HashSet<int>(nums);
        Console.WriteLine($"[{string.Join(",",unique)}]");
        }
    }
}
