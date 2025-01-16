using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
   public static int SumOfPrimeFactors(int num)
   {
    int sum=0;
    while(num%2==0)
    {
      sum+=2;
      num/=2;
    }
    for(int i=3;i<=Math.Sqrt(num);i=i+2)
    {
      while(num%i==0)
      {
        sum+=i;
        num/=i;
      }
    }
    if(num>2)
    {
      sum+=num;
    }
    return sum;
   }
   public static void Main(string[] args)
   {
    Console.WriteLine("Enter a number: ");
    int num=int.Parse(Console.ReadLine());
    Console.WriteLine(SumOfPrimeFactors(num));
   }
    
}
