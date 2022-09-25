/*Задача  Напишите цикл, который принимает на вход два числа А и В и возводит число А 
в натуральную степень В.

int a = 3;
int b = 5;

int GetExponent (int a, int b){
    int result=1;
    for (int i = 1; i <= b; i++)
    {
     result=result*a;
    }
    return result;
}

System.Console.WriteLine(GetExponent(a,b));*/

/*Задача Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

int n = 159584;
int GetSumNumbers(int n)
{
    int length = Convert.ToString(n).Length;
    int count = 0;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        count = n - n % 10;
        result = result + (n - count);
        n = n / 10;
    }
    return result;
}
System.Console.WriteLine($"Сумма цифр в числе {n} -> {GetSumNumbers(n)} ");

Задача Напишите программу, которая задает массив из 8 элементов и выводит их на экран.*/

int[] GetArray(){
    int[] result = new int [8];

for (int i = 0; i < result.Length; i++)
{
    result[i]=new Random().Next(0,100);
}
return result;
}

void PrintArray(int[]arr){
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
}
 PrintArray(GetArray());