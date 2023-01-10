// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result1 = num % 10;
int result2 = (num/10)%10;
Console.WriteLine(result2);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = ReadInt("Введите число: ");
int count = num.ToString().Length;
Console.Write(MakeArray(num, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число дня недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5) 
{ 
    Console.Write(" Нет, это не выходной"); 
} 
else if (num >= 6 && num <= 7) 
{ 
    Console.Write(" Да, это выходной"); 
} 
else Console.Write(" Не существует такого дня недели"); 

  