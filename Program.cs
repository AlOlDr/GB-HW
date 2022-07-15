// Exercise2. Напишите программу, которая на вход принимает два числа и выдает, какое большее, а ккое меньшее

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"{a} больше, чем {b}");
}
else {
    Console.WriteLine($"{b} больше, чем {a}");
}

// Exercise4. Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
   max = b;}

if (c > max)
{
   max = c;}

Console.WriteLine($"{max}");


// Exercise6. Напишите программу, которая на вход принимает число и выдает является ли число четным

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}
