
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.

Console.Write("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num%10;
int num2 = num/100;
Console.WriteLine($"Сумма {num2} и {num1} равна {num1+num2}");




