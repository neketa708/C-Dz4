/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int ReadInt(string x)
{
    System.Console.Write(x);
    return Convert.ToInt32(Console.ReadLine());
}
int ReadInt2(string y)
{
    System.Console.Write(y);
    return Convert.ToInt32(Console.ReadLine());
}

double Sum(int A, int B)
{
    double sum = 0;
    sum = Math.Pow(A, B);
    return sum;
}
int number = ReadInt("Введите число: ");

int num = ReadInt2("Введите степень: ");
System.Console.WriteLine($"Число {number} в степени {num} = {Sum(number, num)}");
