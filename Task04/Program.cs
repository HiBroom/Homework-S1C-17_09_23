// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


using System.Numerics;

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
int numberMax = numberA;
if (numberB > numberMax)
{
    numberMax = numberB;
}
if (numberMax > numberB)
{
    numberMax = numberA;
}
if (numberC > numberMax)
{
    numberMax = numberC;
}
Console.WriteLine($"{numberMax} -> max");






