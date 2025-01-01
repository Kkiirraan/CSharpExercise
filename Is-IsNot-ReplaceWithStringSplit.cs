using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
            
            Console.WriteLine("Enter a string : ");
            string str=Console.ReadLine();
            string[] words=str.Split(" ");
            for(int i=0;i<words.Length;i++){
                if(words[i]=="is"){
                    words[i]="is not";
                }
            }
            string result=string.Join(" ",words);
            Console.WriteLine(result);
        }
    }
}
