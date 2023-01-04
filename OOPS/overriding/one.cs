using System;

public class overloading{

public virtual void reading(){
Console.WriteLine("iam reading");
}

}

public  class overloading1: overloading{
    public override void reading()
    { 
        Console.WriteLine("iam writing");

}

}

public class overloading2: overloading {
    public override void reading(){

Console.WriteLine("iam coading");

 }
}
public class testing{
    public static void Main(string[] args){
        overloading obj1=new overloading();
        overloading obj2=new overloading1();
        overloading obj3=new overloading2();
        obj1.reading();
        obj2.reading();
        obj3.reading();
        
        
    }
    
}