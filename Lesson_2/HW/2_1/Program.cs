//Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.

int n= new Random().Next(100,1000);

int SecondDigital (int num){
    Console.WriteLine(num);
    return num%100/10;
}

Console.Write(SecondDigital(n));