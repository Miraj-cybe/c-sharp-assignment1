using System;
class Program{
  public static void Main()
  {
//Array number start from [0,1,2,3...]


   string[] names ={"BMw", "Bugati" ,"Honda","CHR"};
Console.WriteLine($"Car:{ names[2]}");


//string[] names =new string[4] {"BMw", "Bugati" ,"Honda","CHR"};

 



//for loop
for(int index=0;index<names.Length;index++)
{

Console.WriteLine($"Car:{ names[index]}");
}



//foreach loop
string[] colors =new string[4] {"Black", "Red" ,"Green","yellow"};
foreach(string color in colors)

{

Console.WriteLine($"color:{color}");


}



  }
  }