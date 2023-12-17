// Задание 1
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// void NaturNum(int n, int m)
// {   
//     if(n<0 || m<0)
//     {
//         Console.WriteLine("Numb must be graiter then 0");
//         return;
//     }

//     if (n > m-1)
//     {
//         NaturNum(n-1, m);
//         Console.Write(n + " ");
//     }
//     else if (n-1 < m)
//     {
//         NaturNum(n, m-1);
//         Console.Write(m + " ");
//     }  
      
// }

// NaturNum(10, 15);

// Задание 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Console.Write("Введите положительное значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите положительное значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return akkerman(m - 1, 1);
// else return akkerman(m - 1, akkerman(m, n - 1));
// }

// Console.Write($"Функция Аккермана равно {akkerman(m, n)}");

// Задание 3
// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

