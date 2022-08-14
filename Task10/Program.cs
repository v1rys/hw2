// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите Трёхpзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number /10;
int number2 = number1 % 10;
if ( 99 >number)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
    if (-99 > number)
    {
       Console.WriteLine("Вы ввели не трёхзначное число");
       if ( 1000 <= number)
       {
        Console.WriteLine("Вы ввели не трёхзначное число");
        if (-1000 >=number)
        {
          Console.WriteLine("Вы ввели не трёхзначное число");  
        
        }
       }

    }
}
else
{
  Console.WriteLine("Второе число " + number2);  
}