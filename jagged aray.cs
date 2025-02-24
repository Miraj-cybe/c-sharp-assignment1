/*
1 2
3 4 5
2 3
1
4 5 6 7


*/

//jagged array ....

class Program{
    public static void Main(){

int[][] jaggedArray = new int[][]

{
new int[] {1,2},
new int[] {3,4,5},
new int[] {2,3},
new int[] {1},
new int[] {4,5,6,7}
};
//for each row we define the  column


//create loop
foreach(var row in jaggedArray){
    foreach(var item in row){
        Console.Write($"{item}");
    }
    Console.WriteLine();
    
}



    }
    }