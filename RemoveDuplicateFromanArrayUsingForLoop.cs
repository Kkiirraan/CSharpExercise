using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
        // Removing duplicates using for loop
        int[] num={1,1,2,3,3,5,5};
        List<int> unique=new List<int>();
        foreach(int n in num){
            if(!unique.Contains(n)){
                unique.Add(n);
            }
        }
        Console.WriteLine($"[{string.Join(",",unique)}]");
        // Console.WriteLine(unique);

    }
    }
}
