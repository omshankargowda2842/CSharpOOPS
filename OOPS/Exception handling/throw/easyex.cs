// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class test{
    static  int Divide(int a,int b){
        return a/b;
    }
    static void Main(string[] args){
        int a=2;
        int b=0;
        if(b==0)throw new DivideByZeroException("dividing by 0 not allowed");
        else 
        Console.WriteLine(Divide(a,b));
    }
}