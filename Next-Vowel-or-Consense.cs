using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
        Console.Write("Enter a string : ");
        string? str=Console.ReadLine();
        if(!str.All(char.IsLetter)){
            Console.WriteLine("Wrong input");
        }
        else{
             string vowels="aeiou";
             string consense="abcdefghijklmnopqrstuvwxyz"; 
             string newStr="";
             int index;   
             for(int i=0;i<str.Length;i++){
                if(vowels.Contains(str[i])){
                    index=vowels.IndexOf(str[i]);
                    newStr+=(char)((int)vowels[index]+1);
                }
                else{
                    if(str[i]=='v' || str[i]=='w' || str[i]=='x' || str[i]=='y' || str[i]=='z'){
                        newStr+='a';
                    }
                    else{
                        index=consense.IndexOf(str[i]);
                        while (consense[index]!='a' && consense[index]!='e'&& consense[index]!='i' && consense[index]!='o' && consense[index]!='u'){
                            index+=1;
                            // Console.WriteLine(consense[index]);
                        }
                        newStr+=consense[index];
                    }
                }
             }
             Console.WriteLine(newStr);
        } 
    }
    }
}
