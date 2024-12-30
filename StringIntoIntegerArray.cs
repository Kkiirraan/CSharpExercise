using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
            string str="1234";
            int[] charInt=str.Select(c=>int.Parse(c.ToString())).ToArray();
            // charInt[0]+=1;
            Console.WriteLine($"{string.Join(",",charInt)}");
            Console.WriteLine(charInt.GetType());
        }
    }
}
