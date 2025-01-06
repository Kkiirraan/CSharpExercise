using System;
using System.Net.Security;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
           int i=0,j,flag=0;
           char[] ch;
            Console.WriteLine("Enter a string : ");
            ch=Console.ReadLine().ToCharArray();
            j=ch.Length-1;
            while(i<=j){
                if(ch[i]==ch[j]){
                    i++;
                    j--;
                }
                else{
                    flag=1;
                    break;
                }
            }
            if(flag==0){
                Console.WriteLine("Palindrome");
            }else{
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
