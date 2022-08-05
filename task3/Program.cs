/*
Задача 29: (необязательная) Напишите программу, 
которая создает массив из введенных через запятую цифр и 
выводит этот массив на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
void PrintArray(int[] inputArray)
{
    //int count = col.Length;
    int i= 0;
    while (i < inputArray.Length)
    {
        Console.Write($" {inputArray[i]} ");
        i++;
    }
}

bool flag=false;
Console.WriteLine("введите нескольк чисел через зяпятую");
string test=Console.ReadLine();
string[] array =test.Split(',');
int [] array_result = new int [array.Length];

if (test.Contains("") || test.Contains(" ")) Console.WriteLine("в строке пробелы или отсутствуют цифры, введите верно");
else
{
    for (int i=0 ;i<array.Length ;i++ )
    { 
        array_result[i] = int.Parse(array[i].ToString());
        flag=true;
    }
}

if (flag==true)
{
    Console.Write($" [ ");
    PrintArray(array_result);
    Console.Write($" ] ");
    
}



