// Deligates are nothing but passing methods as a arguments to another method

using System;
delegate int calculator(int a);
public class Deligation{
    static int number=100;
    public static int add( int a){
    number=number+a;
    return number;
    }
     public static int multi( int a){
   number=number*a;
   return number;
    }
    public static int getnumber(){
        return number;
    }
    public static void Main(string[] args){
        calculator obj=new calculator(add);
        obj(20);
        Console.WriteLine("after obj deligatenumber is : "+getnumber());
        calculator obj1=new calculator(multi);
        obj1(12);
        Console.WriteLine("after obj deligatenumber is : "+getnumber());
        
        
    }
}


