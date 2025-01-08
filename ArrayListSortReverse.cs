using System;
using System.Collections;
using System.IO;

namespace FileHandlingAndExceptionHandling
{
    class Program
    {
       public static void Main(string[] args)
        {
           ArrayList arrayList=new ArrayList(){4,3,6,1,2,9};
           arrayList.Sort();
           arrayList.Reverse();
           foreach(int i in arrayList){
                Console.WriteLine(i);
           }
        }
    }
}
