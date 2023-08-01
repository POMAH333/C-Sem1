// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите число а: ");
string straNum = Console.ReadLine();
int aNum = int.Parse(straNum);

Console.WriteLine("Введите число b: ");
string strbNum = Console.ReadLine();
int bNum = int.Parse(strbNum);

Console.WriteLine("Введите число c: ");
string strcNum = Console.ReadLine();
int cNum = int.Parse(strcNum);

int maxNum = aNum;

if(bNum > maxNum) maxNum = bNum;
if(cNum > maxNum) maxNum = cNum;

Console.WriteLine($"Максимальное из введённых чисел: {maxNum}");