// Задача 2. Принимает на вход два числа и выдаёт, какое число большее, а какое меньшее.

/* 
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a>b)
{
    Console.WriteLine(max);
}
if(a<b)
{
    Console.WriteLine(b);
}
*/

// Задача 4. Принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(max<n2)
{
    Console.WriteLine(n2);
}
if(max<n3)
{
    Console.WriteLine(n3);
}
*/
// Задача 6. Принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}