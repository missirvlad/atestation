// Однострочный комментарий 

/*
    Это
    многострочный
    комментарий
*/


//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Кадрат от этого числа: " + num * num );

// Console.Write("Введите номер дня недели: ");
// int numOfDay = Convert.ToInt32(Console.ReadLine());
// if (numOfDay == 1)
// {
//  Console.WriteLine("Понедельник");
// }
// else if (numOfDay == 2)
// {
//  Console.WriteLine("Вторник");
// }
// else if (numOfDay == 3)
// {
//  Console.WriteLine("Среда");
// }
// else if (numOfDay == 4)
// {
//  Console.WriteLine("Четверг");
// }
// else if (numOfDay == 5)
// {
//  Console.WriteLine("Пятница");
// }
// else if (numOfDay == 6)
// {
//  Console.WriteLine("Суббота");
// }
// else if (numOfDay == 7)
// {
//  Console.WriteLine("Воскресенье");
// }



// 5. Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 0)
// {
//     N *= -1; // N = N * -1
//     Console.WriteLine("Вы ввели отрц. число N, я умножил его на -1 :)");
// }
// int negativeN = N * -1; // -N

// while (negativeN <= N)
// {
//     Console.Write(negativeN + "   "); 
//     negativeN += 1; // negativeN = negativeN + 1
// }


// int number = new Random().Next(10, 100);
// Console.WriteLine($"Рандомное число : {number}");
// int first = number / 10;
// int second = number % 10;
// if (first > second)
// {
//   Console.WriteLine($"Максмальная цифра числа {first}");
// }
// else if(first < second)
// {
//   Console.WriteLine($"Максмальная цифра числа {second}");
// }
// else if(first == second)
// {
//   Console.WriteLine($"Обе цифры числа равны {first}");
// }

// int number = new Random().Next(100, 1000);
// int first = number / 100;
// int third = number % 10;
// Console.WriteLine(number);
// Console.WriteLine(first + "" + third);

// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();
// // Строчка - массив символов
// int number; // Ничего не клал в нее
// // TryParse(строчка, out переменная для результата)
// bool isNumber = int.TryParse(stringNumber, out number);
// // Если isNumber == True, значит строчка stringNumber 
// // состоит ТОЛЬКО из цифр; False - в строке есть буквы.
// // Если в stringNumber только цифры, то 
// // в переменную number попадет само число; иначе - 0
// Console.WriteLine($"Длина строки(кол-во символов): {stringNumber.Length}");
// if (isNumber && stringNumber.Length > 4) // isNumber == True
// {
//     Console.WriteLine("Ваша строчка состоит ТОЛЬКО из цифр");
//     Console.WriteLine($"{stringNumber} => {stringNumber[0]}{stringNumber[2]}");
// }
// else
// {
//     Console.WriteLine("В строчке присутсвуют буквы ИЛИ длина строки < 3 символов");
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number % 7 == 0) && (number % 23 == 0))
// {
// Console.WriteLine("Число делится и на 7, и на 23 одновременно");
// }
// else
// {
//     Console.WriteLine("Не делится на 7 или на 23 :(");
// }

// int Prompt(string msg)
// {

// System.Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите число");
// string ss = "Это не день недели";
// string check(int number)
// {
// if (number >= 6 && number < 8) ss = "Это выходной";
// if (number >= 1 && number < 6) ss = "Это будний день";
// return ss;
// }
// System.Console.WriteLine(check(number));

// int Prompt(string msg)
// {

// System.Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите трехзначное число");
// if (number >=100 && number <1000)
// {
// int mid = (number % 100 - number % 10) / 10;
// System.Console.WriteLine($"Вторая цифра числа {number} является {mid}");
// }
// else
// System.Console.WriteLine("Это число не трехзначное");

// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// // A (3,6); B (2,1) -> 5,09 
// // x1 = 3, y1 = 6; x2 =2, y2 = 1
// // A (7,-5); B (1,-1) -> 7,21
// Console.Write("Введите х1 : ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите у1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите х2 : ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите у2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// // d = distance (расстояние между 2 точками)
// // AB = √(x1 - x2)2 + (y1 - y2)2
// // Math.Sqrt(25) = 5 - извлечение корня
// // Math.Pow(число, степень) => Math.Pow(2, 3) => 2*2*2 = 8 - возв. в степень
// double d = Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)));
// // Math.Round(число, кол-во знаков): Math.Round(1.275, 2) => 1.27
// Console.WriteLine($"d = {Math.Round(d, 2)}"); // d до 2 знаков
// // $"Текст {переменная} текст"
// // "\t" - табуляция, автоматически проставляет 4 пробела
// Console.WriteLine($"d = {d:f2}"); // {имя:fкол-во_знаков}




// int calculate(int a, int b, char sign)
// {
//     if (sign == '+')
//     {
//        return a + b;
//     }
//      else if (sign == '-')
//     {
//        return a - b;
//     }
//     else if (sign == '*')
//     {
//        return a * b;
//     }
//     else if (sign == '/')
//     {
//         return a / b;
//     }
//     else
//     {
//         Console.WriteLine("неверный ввод");
//         return 0;
//     }
// }
// Console.WriteLine(calculate(11, 2, '/'));



// Console.Write("Введите число А: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// // Вызов метода
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {GetSum(limit)}");
// // тип_метода ИмяМетода (параметр1, параметр2...параметрN)
// int GetSum (int A)
// {
//     int sum = 0;
//     // i = 1 - начало, 
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i; // sum = sum + i
//     }
//     return sum;
// }


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Количество цифр в числе {number} = {GetCountNumbers(number)}");
// int GetCountNumbers(int num)
// {
//     if (num == 0)
//     {
//         return 1;
//     }
//     else
//     {
//         int count = 0; // Изначально 0 цифр в числе
//         while (num > 0)
//         {
//             count++; // Инкремент: count = count + 1
//             num /= 10; // num = num / 10
//         }
//         return count;
//     }
// }


// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 1;
// if (b<1)
// {
//     Console.Write("Число B должно быть натуральным");
// }
// else
// {
// while (b!=0)
// {
//  c = c * a;
//  b = b - 1;
// }
// Console.Write($"Число A в натуральной степени B равно {c}");
// }


// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int len = Length(a);
// Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

// // Подсчет количества символов в числе
// int Length(int a)
// {
//  int index = 0;
//  while (a > 0)
//  {
//   a /= 10;
//   index++;
//  }
//  return index;
// }

// int Sum(int a, int len)
// {
//  int sum = 0;
//  for (int i = 1; i <= len; i++)
//  {
//   sum += a % 10;
//   a /= 10;
//  }
//  return sum;
// }



// int[] randomArray = new int[8];
// Console.Write("Введите начало диапазона: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int stope = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < 8; i++)
// {
//  randomArray[i] = new Random().Next(start,stope);
//  Console.Write(randomArray[i] + " ");
// }
