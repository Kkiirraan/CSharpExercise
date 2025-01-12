using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
   public static void Main(string[] args)
   {
      Dictionary<int,int> dictionarys=new Dictionary<int, int>(){{1,100},{2,200},{3,300}};
      List<int> numbers=new List<int>(){1,1,2,3,4,4,4,5,6};


      foreach(var dictionary in dictionarys)
      {
        Console.WriteLine(dictionary.Key);
        Console.WriteLine(dictionary.Value);
      }

      List<int> keys=new List<int>(dictionarys.Keys);
      foreach(var key in keys)
      {
        Console.WriteLine(key);
      }
      List<int> values=new List<int>(dictionarys.Values);
      foreach(var value in values)
      {
        Console.WriteLine(value);
      }
   
   }
    
    }
