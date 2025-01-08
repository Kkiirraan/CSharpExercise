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
           foreach(var i in arrayList){
                Console.Write(i);
           }
            Console.WriteLine();
           arrayList.Remove(1);
           arrayList.RemoveAt(0);
           arrayList.Insert(0,10);
           int index=arrayList.IndexOf(10);
           foreach(var i in arrayList){
            Console.Write(i);
           }
           Console.WriteLine();
           Console.WriteLine(index);
        }
    }
}
