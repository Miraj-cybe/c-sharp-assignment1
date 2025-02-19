using System;
using System.Runtime.Serialization;
class Person{
 private string name;
    public string Name{
      get{ return name;}
      set{ if(value.Length ==3)
      {
name = value;
      }
      else
      {
Console.WriteLine($" Invaild lenght {name} ");
      }
      }
    }
    private int age; 

    public int Age
    {
       get{ return age ;}
       set{ if(value>=18)
       {
       age = value;
       } 
       else {
        Console.WriteLine("you aren'nt eligible for this car.");
       }
       }
    }
    /*
    //we can read and write this

    //For writable  we can use set methood

    public void SetAge(int a){
age = a;
    }

    //For Readable we can use Get Methood
    public int GetAge(){
      return age;
    }
*/
}
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person();
      p1.Name = "Liam";
p1.Age=25;
      Console.WriteLine($"p1.name: {p1.Name}, p1.age: {p1.Age}. ");



    }
  }
}
