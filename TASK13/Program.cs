// Напишите программу, которая 
// 1.выводит третью цифру заданного числа
// 2.или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int number)
{
 int firstDigit = (number / 100) * 100;
    int thirdDigit = number % 10;
    int secondDigit = ((number - firstDigit - thirdDigit) / 10);
    //int thirdDigit = secondDigit % 10;
    return secondDigit;
}
int thirdDigit = ThirdDigit(num);
if (num <= 99)
{
    Console.WriteLine($"третьей цифры нет.");
}
else
{
    Console.WriteLine(ThirdDigit(num));
}

