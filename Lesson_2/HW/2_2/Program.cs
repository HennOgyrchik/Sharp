//напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

int n=new Random().Next(100,1000);

void DelSecondDigital(int num){
    Console.WriteLine(num);
    int result=num/100*10+num%10;
    Console.WriteLine(result);
}

DelSecondDigital(n);