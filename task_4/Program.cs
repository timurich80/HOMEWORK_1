/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int c = int.Parse(Console.ReadLine());
if (a>b && a>c)
{
    System.Console.WriteLine($"{a} {b} {c} -> {a}");
}
else if  (b>a && b>c)
{
    System.Console.WriteLine($"{a} {b} {c} -> {b}");

}
else
{
    System.Console.WriteLine($"{a} {b} {c} -> {c}");
}