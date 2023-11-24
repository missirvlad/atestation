/*
Чтобы проверить одну задачу 
Закоментируйте остальные
*/


// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void Numbers(int m, int n)
{
if (m > n)
return;

Console.Write($"{m}, ");

Numbers(m+1,n);

}
Numbers(m,n);
 
 

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Число N: ");
int N = Convert.ToInt32(Console.ReadLine());


int Pow(int number, int power)
{
    if (power == number) return number; 
    
    return number + Pow(number + 1, power);
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {Pow(M,N)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Значение функции Аккермана равно {akkerman(m, n)} ");