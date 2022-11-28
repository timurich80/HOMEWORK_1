/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */


Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
if (a%2==0)
{
    System.Console.WriteLine($" {a} -> да");
}
else
{
    System.Console.WriteLine($" {a} -> нет");
}