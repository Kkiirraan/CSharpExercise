using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
   public static void Main(string[] args)
   {
    List<int> numbers=new List<int>(){1,2,3,4,5,2,3};

    HashSet<int> seen=new HashSet<int>();
    HashSet<int> duplicate=new HashSet<int>();

    foreach(var number in numbers)
    {
        if(!seen.Add(number))
        {
            duplicate.Add(number);
        }
    }

    foreach(var dup in duplicate)
    {
        Console.WriteLine(dup);
    }

   } 
    
    }
