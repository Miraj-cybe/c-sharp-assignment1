using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
class Person{                //creating class
  public  string value;        //class .. feild
  public int age;                 //class .. feild

public Person(){
    Console.WriteLine("I am default .");
}

public Person( string n , int y){
   value=n;
   age=y;
}

}
class Program{
    public static void Main(){
Person p1= new Person();
Console.WriteLine($" Name:{p1.value} , Age:{p1.age}");

Person p2= new Person("sajida", 17);
Console.WriteLine($"Name:{p2.value}, Age:{p2.age}");


Person p3= new Person("Kazi Selina", 29);
Console.WriteLine($" Name:{p3.value} , Age:{p3.age}");
    }
}