using System;

public class omshankar{
    public int id;
    public string name;
   public void setvalues(int Id,string Name ){
        this.id=Id ;
        this.name=Name;
    }
    public void getvalues(){
        Console.WriteLine(id+" "+name);
    }
    public static void Main(string[] args){
        omshankar obj=new omshankar();
        obj.setvalues(101,"omshankar");
        obj.getvalues();
    }
}