// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число а: ");
string straNum = Console.ReadLine();
int aNum = int.Parse(straNum);

Console.WriteLine("Введите число b: ");
string strbNum = Console.ReadLine();
int bNum = int.Parse(strbNum);

if(aNum > bNum)
{
    Console.WriteLine($"Число a больше числа b: max = {aNum}");
}
else
{
    Console.WriteLine($"Число b больше числа a: max = {bNum}");
}