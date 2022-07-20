// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Equality(int num)
{
    int first = num;
    int temp;
    string second = "";

    while (num > 0)
    {
        temp = num % 10;
        num = num / 10;
        second = second + temp;
    }
    return first == Convert.ToInt32(second);
}

if (Equality(number))
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else Console.WriteLine($"Число {number} не является палиндромом");