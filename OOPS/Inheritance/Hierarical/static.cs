
using System;
public class Varun{
    public static int id=101;
    public static string name="omshankar";
    
    }
 public class Kiran: Varun{
     public static void m1(){
         
       Console.WriteLine(Varun.id);
        Console.WriteLine(Varun.name);
       
       
     }
     
 }
  public class Kumar: Varun{
     public static void Main(string[] args){
         Kiran obj1=new Kiran();
      Kiran.m1();
     }
 }


 