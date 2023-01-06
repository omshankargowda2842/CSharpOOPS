// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
abstract class employee{
   public abstract void m1();

}
class emp1:employee{
    public override void m1(){
        Console.WriteLine("impleminting parent class");
    }
}
public class display{
    public static void Main(string[] args){
        emp1 obj=new emp1();
        obj.m1();
    }
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
abstract class employee{
   public abstract void m1();
   
}
 class employee1:employee{
    public override void m1(){
       Console.WriteLine("implemented") ;
    }
} 
public class test{
    public static void Main(string[] args){
        employee1 obj=new employee1();
        obj.m1();
    }
}
