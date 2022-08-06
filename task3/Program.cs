/*
Задача 29: (необязательная) Напишите программу, 
которая создает массив из введенных через запятую цифр и 
выводит этот массив на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
void PrintArray(string[] inputArray)
{
    
    int i= 0;
    while (i < inputArray.Length)
    {
        if (i<inputArray.Length && i!=inputArray.Length-1)
        {
            Console.Write($"{inputArray[i]} ,");
        }
        else Console.Write($"{inputArray[i]}");
        i++;
    }
}

bool flag=false;
Console.WriteLine("введите несколько чисел через зяпятую");
string test=Console.ReadLine();
string[] array =test.Split(',');
int [] array_result = new int [array.Length];
//Console.WriteLine("["+test+"]");
if (test.Contains(" ") || String.IsNullOrEmpty(test) ) 
{
    Console.WriteLine("в строке пробелы или отсутствуют цифры, введите верно");
    flag=false;
}
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
    Console.Write($" [");
    PrintArray(array);
    Console.Write($"] ");
    
}



