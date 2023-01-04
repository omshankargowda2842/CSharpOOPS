using system;
public class ClassA{
    public string housename;
     public string city;
      public string state;
      
      public ClassA(string D,string E,string F){
          this.houseno=D;
          this.city=E;
          this.state=F;
          
      }
    
}
public class ClassB{
    public int id;
    public string name;
    public ClassA address;
    
    public ClassB(int A,string B,ClassA Add){
        this.id=A;
        this.name=B;
        this.address=Add;
        
    }
    public void display(){
        Console.WriteLine($"Id:{id}  \n Name:{name} \n Houseno:{address.houseno} \n City:{address.city}");
    }
    
}
public class ClassC{
    public static void Main(string[] args){
        ClassA obj1=new ClassA("abc-100","kuppam","andhrapradesh");
        
        ClassB obj2= new ClassB(101,"omshankar",obj1);
        
        
    }
    obj2.display
}