using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
           Console.WriteLine("Enter the number : ");
           int num=int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the numbers : ");
           int[] numbers=new int[num];
           for(int i=0;i<num;i++){
                numbers[i]=int.Parse(Console.ReadLine());
           }
           int sum=numbers.Sum();
           Console.WriteLine("sum is : "+sum);

        }
    }
}
