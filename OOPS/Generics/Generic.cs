using System;
class Genericclass{
    public void show<O>(O msg){
        Console.WriteLine(msg);
    }
}
class program{
    static void Main(string[] args){
        Genericclass obj=new  Genericclass();
        obj.show("this is a string ");
         obj.show(47563478);
          obj.show( "l");
    }
}
