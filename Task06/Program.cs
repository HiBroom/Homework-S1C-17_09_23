// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 == 0)
{
    Console.WriteLine($"{n} -> Number divides into two");
}
else
{
    Console.WriteLine($"{n} -> Number doesn't divides into two ");
}