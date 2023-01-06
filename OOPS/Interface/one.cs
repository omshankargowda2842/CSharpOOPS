// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
interface Iperson{
     void m1(string Name);
    }
class Employee:Iperson{
    public void m1(string Name){
        Console.WriteLine("hii varun......");
           Console.WriteLine("bye varun...... and"+Name);
    }
}
 class program{
    public static void Main (string[] args){
  Employee obj =new Employee();
  obj.m1("kiran..");
    }
 }