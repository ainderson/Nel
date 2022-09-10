// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Первое число меньше второго");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }
            Console.ReadKey();

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int a1 = 2;
int b1 = 3;
int c1 = 7;
int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
Console.WriteLine(max);

int a2 = 44;
int b2 = 5;
int c2 = 78;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
Console.WriteLine(max);

int a3 = 23;
int b3 = 3;
int c3 = 9;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;
Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число : ");
    int a = Convert.ToInt32(Console.Read());
    if (a % 2 == 0) Console.WriteLine("Четное");
    else Console.WriteLine("Нечетное");
    Console.ReadKey();


Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();         