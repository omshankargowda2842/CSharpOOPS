// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

delegate void employee();
public class demo{
    static public void developer(){
        Console.WriteLine("iam coder");
    }
    static public void tester(){
        Console.WriteLine("iam tester");
    }
}
class program{
    public static void Main(string[] args){
        employee  m1= new employee(demo.developer);
        employee  m2= new employee(demo.tester);
        employee m3=m1+m2;
        employee m4=m2+m1;
        m3();
        m4();
    }
}
