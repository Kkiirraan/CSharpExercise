using System;
using System.Collections;
using System.Net.Security;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
         int[] num={10,20,30,40,50};

        int maxProduct=1;
        for(int i=1;i<num.Length;i++){
            int temp=num[i]*num[i-1];
            maxProduct=Math.Max(temp,maxProduct);
        }    
        Console.WriteLine(maxProduct);

        }
    }
}
