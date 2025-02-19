using System;
using System.Runtime.Serialization;
class Person{
    public string name;
    private int age; 


      // Properties of age.
    public int Age                
    {
       get{ return age ;}  // For Readable      
       set{ age = value ;}  //For Writeable
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
      p1.name = "Liam";
p1.Age=25;
      Console.WriteLine($"p1.name: {p1.name}, p1.age: {p1.Age}. ");



    }
  }
}
