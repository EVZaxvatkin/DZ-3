// See https://aka.ms/new-console-template for more information


//Задача 19: Напишите программу, которая принимает на 
//вход пятизначное число и проверяет, является ли оно 
//палиндромом.

void Zadacha19()
{
    Console.WriteLine ("Введите пятизначное число");
    string numberText = Console.ReadLine();
    if (numberText[0] == numberText[4] & numberText[1] == numberText[3])
    Console.WriteLine ("Заданное число является полиндромом");
    else
    Console.WriteLine ("Заданное число не является полиндромом");
}
//Zadacha19();



//Задача 21: Напишите программу, которая принимает на 
//вход координаты двух точек и находит расстояние между 
//ними в 3D пространстве.

void Zadacha21()
{
    {
Console.WriteLine ("Введите координату X1");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y1");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Z1");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату X2");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y1");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Z1");
int Z2 = Convert.ToInt32(Console.ReadLine());
double result = 0;
result = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));

Console.WriteLine ();
Console.WriteLine (result);
    }
}
//Zadacha21();

//Задача 23: Напишите программу, которая принимает на 
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Zadacha23()
{
    Console.WriteLine ("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    int count =1;
    Console.WriteLine ();
    while (N >= count)
    {
        double result = 0;
        result = (Math.Pow(count,3));
        Console.WriteLine(result);
        count++;
    }
}
//Zadacha23();
