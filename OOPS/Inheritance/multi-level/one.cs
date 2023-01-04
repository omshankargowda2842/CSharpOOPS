
using System;
public class Varun{
    public int id=101;
    public string name="omshankar";
    
}
public class Kiran:Varun{
   public int salary=20000;
   public  string company="Pay-G" ;
}
public class Kumar:Kiran{
    public static void Main(string[] args){
        Kumar obj1=new Kumar();
        Console.WriteLine(obj1.salary);
        Console.WriteLine(obj1.company);
        Console.WriteLine(obj1.name);
         Console.WriteLine(obj1.id);
    }
}


 