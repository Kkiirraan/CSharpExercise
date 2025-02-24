using System;


namespace ProgramNames
{
    public class Program 
    {
        public static bool IsPrime(int number)
        {
            if(number==0) return false;
            if(number==1) return false;
            if(number==2) return true;


            for(int i=3;i<=Math.Sqrt(number);i++)
            {
                if(number%i==0)
                {
                    return false;
                }
            }
            return true;
        }
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }
    }
}
