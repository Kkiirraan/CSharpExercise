using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
            // Entering the number of string
           Console.WriteLine("Enter the number of strings : ");
           int number=int.Parse(Console.ReadLine());
           
           // Enter the strins into the array
           Console.WriteLine("Enter the Strings : ");
           string[] strings=new string[number];
           for(int i=0;i<number;i++){
            strings[i]=Console.ReadLine();
           }

           int sum=0;
           bool hasSpecialChar=false;
           foreach(string word in strings){
            foreach(char ch in word){
                if(char.IsDigit(ch)){
                    // Console.WriteLine("ente");
                    sum+=(int)char.GetNumericValue(ch);
                    // Console.WriteLine("sum"+sum);
                }
                else if(!char.IsLetter(ch) && !char.IsWhiteSpace(ch)){
                    Console.WriteLine("Hi");
                    hasSpecialChar=true;
                    break;
                }
            }
            if(hasSpecialChar==true){
                sum=-1;
                break;
            }
           }
           Console.WriteLine(sum);

        }
    }
}
