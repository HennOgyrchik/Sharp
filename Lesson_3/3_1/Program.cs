Console.Write("Четверть:");
int n = int.Parse(Console.ReadLine()!);

void Points(int r)
{
    switch (r)
    {
        case 1:
            Console.WriteLine("1-я четверть: x>0 и y>0");
            break;
        case 2:
            Console.WriteLine("2-я четверть: x<0 и y>0");
            break;
        case 3:
            Console.WriteLine("3-я четверть: x<0 и y<0");
            break;
        case 4:
            Console.WriteLine("4-я четверть: x>0 и y<0");
            break;
        default: Console.Write("Некорректный ввод");
        break;

    }

}

Points(n);