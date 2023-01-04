using System;
public class Varun{
    public int id=101;
    public string name="omshankar";
    
}
public class kiran : Varun{
    public static void Main(string[] args){
        Varun obj=new Varun();
        Console.WriteLine(obj.id);
        Console.WriteLine(obj.name);
    }
}
