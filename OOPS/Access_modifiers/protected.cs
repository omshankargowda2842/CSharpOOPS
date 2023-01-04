using System;
 
 public class  Omshankar{
    public int num=101;
    public  string name="kiran";
 }
 public class kumar : Omshankar{
    public static void Main(string[] args){
        kumar s1=new kumar();
        Console.WriteLine(s1.num);
         Console.WriteLine(s1.name);

    }
 }