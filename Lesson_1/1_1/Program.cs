// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.Write("a= ");

int a=int.Parse(Console.ReadLine()!);

Console.Write("b= ");

int b=int.Parse(Console.ReadLine()!);

if (a==b*b) {
    Console.Write("True");
}
else {
     Console.Write("False");
}