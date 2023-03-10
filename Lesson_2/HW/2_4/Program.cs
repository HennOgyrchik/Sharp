//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число, обозначающее день недели: ");
int day= int.Parse(Console.ReadLine()!);

void Weekend (int n){
    if (n==6 || n==7){
        Console.Write("Да");
    }else {
         Console.Write("Нет");
    }
}

Weekend(day);