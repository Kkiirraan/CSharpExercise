using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
            Console.WriteLine("Enter an interger :");
            string? input=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input)){
                Console.WriteLine(-2);
                return;
            }
            int[] inputArray=input.Select(c=>int.Parse(c.ToString())).ToArray();
            if(inputArray.Any(n=>n<0)){
                Console.WriteLine(-1);
                return;
            }
            if(inputArray.Length==1 || inputArray.Length>10){
                Console.WriteLine(-2);
                return;
            }
            if(inputArray.Length!=inputArray.Distinct().Count()){
                Console.WriteLine(-3);
                return;
            }
            // logic to find maximum difference
            int maxDiff=0;
            int minElement=inputArray[0];
            for(int i=0;i<inputArray.Length;i++){
                maxDiff=Math.Max(maxDiff,inputArray[i]-minElement);
                minElement=Math.Min(minElement,inputArray[i]);
            }
            Console.WriteLine(maxDiff);
        }
    }
}
