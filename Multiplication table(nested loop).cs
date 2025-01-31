using System;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics.CodeAnalysis;
class Program{

public static void Main()
{
  Console.Write("Enter start number: ");
int startnumber=Convert.ToInt32(Console.ReadLine());

 Console.Write("Enter ending number: ");
int endingnumber=Convert.ToInt32(Console.ReadLine());

for( int i=startnumber;i<=endingnumber;i++){

for(int j=1;j<=10;j++){

  Console.WriteLine($"{i} X {j} = {i*j} ");
}


Console.WriteLine("---------------");
}


}

}

