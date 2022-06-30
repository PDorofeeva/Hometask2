/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number1 = number/10;
int number2 = number/100; //10000000000

if (number/100 == 0)
{
    Console.WriteLine("Третьей цифры нет в заданном числе");
}
else if (99<number && number<1000)
{
    Console.WriteLine(number%10);
}
else if (999<number && number<10000)
{
    Console.WriteLine(number1%10);
}
else if (9999<number && number<100000)
{
    Console.WriteLine(number2%10);
}
/*
 Таким образом можно написать до числа 10000000000. Пробовала делать эту задачу короче,
 но получалась только третья цифра от конца, а не от начала. Хотела бы узнать решение задачи,
которое предлагаете вы.
 */