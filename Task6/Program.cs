// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число: ");
string strNum = Console.ReadLine();
int Num = int.Parse(strNum);

int remains = Num % 2;

if(remains == 0)
{
    Console.WriteLine($"Да, число {Num} является чётным");
}
else
{
    Console.WriteLine($"Нет, число {Num} не является чётным");
}
