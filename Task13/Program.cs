// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите число");
int  number = Convert.ToInt32(Console.ReadLine());
int numder2 = 0;
if (numder <= 99){
Console.WriteLine("В этом числе нет третьей цифры ");

while (number>1000)
{
    number=number/10;

}
if (number > 99 ){
    number2 = number % 10;
}
}
Console.WriteLine($"Третья цифра" + number2);