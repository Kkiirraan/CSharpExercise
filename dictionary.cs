using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int,string> dict=new Dictionary<int, string>();
        dict.Add(1,"Adithyan");
        dict.Add(2,"Aswin");
        dict.Add(3,"Ajay");
        dict.Add(4,"Kiran");


        foreach(var item in dict){
            Console.WriteLine($"{item.Key} : {item.Value}");
        }

        string name=dict[1];
        Console.WriteLine(name);

        if(dict.ContainsKey(4)){
            dict[4]="Arjun";
        }
        foreach(var item in dict){
            Console.WriteLine($"{item.Key} : {item.Value}");
        }

        if(dict.ContainsValue("Aswin")){
            int currentKey=dict.FirstOrDefault(k=>k.Value=="Aswin").Key;
            dict.Remove(currentKey);
            dict.Add(currentKey,"Kiran");
        }
        foreach(var item in dict){
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
    }
