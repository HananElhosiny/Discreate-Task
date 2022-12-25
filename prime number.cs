using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int startingnumber ,endingnumber ,counter;
  
    Console.WriteLine("please enter the starting (smallest) number");
       startingnumber = int.Parse(Console.ReadLine());
      
  
    Console.WriteLine("please enter the ending (biggest) number");
    endingnumber = int.Parse(Console.ReadLine());
    
    
        for(int z=startingnumber; z<=endingnumber ; z++)
        {
          for(counter=2; counter<z/2; counter++)
        {
          if(z%counter==0)
          break;
        }  
       
        if(z%counter!=0 && z!=1 && z!=-1)
      
        Console.WriteLine(z);
        }
     }
   }
 }
