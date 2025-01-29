using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProgramNameSpace
{
    class Program 
    {
        public static void DisplayPersonInfo((string name, int age, string city) Person)
        {
            Console.WriteLine($"Name: {Person.name} Age: {Person.age} City: {Person.city}");
        }
        public static (string name, int age, string city) GetPersonInfo()
        {
            string name="Kiran";
            int age=23;
            string city="LA";
            return (name,age,city);
        }
        public static void Main(string[] args)
        {
             var personInfo=("Kiran",23,"LA");
             DisplayPersonInfo(personInfo);

             var result=GetPersonInfo();
             Console.WriteLine($"Returned values are : Name: {result.name} Age: {result.age} City: {result.city}");
        }
    }
}
