/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите первое число");
string number_in = Console.ReadLine();//изначально как массив
   
    int [] array = new int [number_in.Length];
    int sum=0;
    
    for (int i=0 ;i<number_in.Length ;i++ )
    { 
        array[i] = int.Parse(number_in[i].ToString()); // parse -Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком
        sum=sum+array[i] ;
    }
Console.WriteLine(sum);