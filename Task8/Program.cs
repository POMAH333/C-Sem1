// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
string strNum = Console.ReadLine();
int Num = int.Parse(strNum);

Console.WriteLine();

int i = 1;       //Индексная переменная
int remains;     //Переменная остатка

if (Num < 2)
{
    Console.WriteLine("Вводимое число должно быть положительным и больше единицы");
}
else
{
    while (Num >= i)
    {
        remains = i % 2;
        if(remains == 0)
        {
            Console.WriteLine(i);
        }
        i++;
    }
}
