

using System;

class Genericclass<O>{
public  Genericclass(O msg){
    Console.WriteLine(msg);
}
}
class  Implement{
    public static void Main(string[] args){
    Genericclass<string> obj= new Genericclass<string>("this is a string datatype");
    Genericclass<int>  obj1= new Genericclass<int>(123);
    Genericclass<double>  obj2= new Genericclass<double>(123.123456789);
    Genericclass<long>  obj3= new Genericclass<long>(123456);
    
    
}}