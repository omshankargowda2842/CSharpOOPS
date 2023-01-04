using System;

public class overloading
{
    public void m1(int x){
        Console.WriteLine(x);
    }
     public void m2(int x,int y){
        Console.WriteLine(x+y);
    }
    public static void Main(string[] args)
    {
        overloading obj=new overloading();
        obj.m1(1);
        obj.m2(2,3);
    }
