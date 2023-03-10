int MaxNum (int num){
    Console.WriteLine(num);
if (num/10 > num%10) {
    return num/10;
}

return num%10;
}

int n=new Random().Next(10,100);
Console.Write(MaxNum(n));