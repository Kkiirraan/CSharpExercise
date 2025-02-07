using System;
namespace ProgramNamespace
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the total number of calls:");
            int totalCalls=Convert.ToInt32(Console.ReadLine());
            double bill=0;

            if(totalCalls<=100)
            {
                bill=300;
            }
            else
            {
                bill=300;
                int reminingCalls=totalCalls-100;
                if(reminingCalls<=500)
                {
                    bill+=reminingCalls*2;
                }
                else
                {
                    bill+=500*2;
                    reminingCalls-=500;
                    if(reminingCalls<=2000)
                    {
                        bill+=reminingCalls;
                    }
                    else
                    {
                        bill+=2000;
                        reminingCalls-=2000;
                        Console.WriteLine($"Note: Extra calls rate are not charged in this  scenerio{reminingCalls}");
                    }
                }
            }
            bill+=300; // fixed meter charge
            Console.WriteLine($"The total bill is :{bill}");

        }
    }
}
