//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

Console.Write("n=");
int n = int.Parse(Console.ReadLine()!);


void MyFunc(int num)
{
    Console.WriteLine(num);
    int res = num / 100 % 10;
    if (res != 0)
    {
        Console.Write(res);
    }
    else
    {
        Console.Write("Третьей цифры нет");
    }
}
MyFunc(n);