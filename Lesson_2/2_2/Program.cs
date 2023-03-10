Console.Write("first=");
int first = int.Parse(Console.ReadLine()!);
Console.Write("second=");
int second = int.Parse(Console.ReadLine()!);


if (first%second==0){
    Console.WriteLine("Кратно");
} else {
    Console.WriteLine("Не кратно, остаток "+ first%second);
}

