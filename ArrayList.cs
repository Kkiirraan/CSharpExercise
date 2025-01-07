using System;
using System.Collections;
using System.Net.Security;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
            ArrayList arrayList=new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Kiran Vijayan");
            arrayList.Add('c');
            arrayList.Add(12.34f);
            for(int i=0;i<arrayList.Count;i++){
                Console.Write(arrayList[i]+" ");
                Console.WriteLine(arrayList[i].GetType());
            }
        }
    }
}
