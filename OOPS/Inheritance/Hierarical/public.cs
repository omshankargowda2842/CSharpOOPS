
using System;
public class Varun{
    public  int id=101;
    public void m1(){
        Console.WriteLine(id);
    }
    }
 public class Kiran: Varun{
     public  string name="omshankar";
     public  void m2(){
        Console.WriteLine(name);
        }
 }
  public class Kumar: Varun{
     public static void Main(string[] args){
         Kiran obj1=new Kiran();
      obj1.m1();
      obj1.m2();
     }
 }


 