// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class AgeCalculatorException: Exception {
    public AgeCalculatorException(string message) : base(message){}
}
public class User {
    static void validate (int age) {
        if (age < 18) { throw new AgeCalculatorException("Sorry, Age must be greater than 18");}
}
public static void Main(string[] args){
try 
    validate(12);
    
}
 catch (AgeCalculatorException e) { Console.WriteLine(e); } 
 Console.WriteLine( "Rest of the code"); }}
                                                