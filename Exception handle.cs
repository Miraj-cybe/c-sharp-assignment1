using System;
class program{
  public static void Main()
  {

Console.WriteLine($"Welcom to my calculator App.");



try
{
    Console.WriteLine($"Number1: ");
    int number1 =Convert.ToInt32( Console.ReadLine());

Console.WriteLine($"Number2: ");
int number2 =Convert.ToInt32(Console.ReadLine());


if(number2>1 && number2<1000)
{


}

int result =number1  / number2;
Console.WriteLine($"result: {result}");


}

catch(OverflowException)
{
Console.WriteLine($"occured : the number of the digit is limit and small int32");

}

catch(System.FormatException)
{
Console.WriteLine($"occured : Invaild letter system.");

}
catch(System.DivideByZeroException)
{
Console.WriteLine($"occured : can not divided by zero.");

}

catch(Exception e)
{

  
Console.WriteLine($" Expection occured: {e.Message}");

}
finally{
Console.WriteLine($"good - Bye.");
}



  }
}