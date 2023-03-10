//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

Console.Write("n=");
int n = int.Parse(Console.ReadLine()!);


void MyFunc(int num)
{
    Console.WriteLine(num);

    while (num>=1000){
         num=num/10;
    }

    if (num<100){
        Console.Write("Третьего числа нет");
    
    } else {
         Console.Write(num%10);
    }

}

MyFunc(n);