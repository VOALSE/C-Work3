// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите число для возведения в куб ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;

int Cube (int n)
{
    return n*n*n;
}

while (index <= num)
{
    int cub = Cube(index);
    Console.WriteLine($"| {index, 3} | {cub, 3} | ");
    index++;
}