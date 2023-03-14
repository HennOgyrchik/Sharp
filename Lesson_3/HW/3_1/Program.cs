Console.Write("n=");
int n=int.Parse(Console.ReadLine()!);

void MyFunc (int x){
    if (n/10000==n%10 && n/1000%10==n%100/10) Console.Write("Да");
    else Console.Write("Нет");
}

MyFunc(n);