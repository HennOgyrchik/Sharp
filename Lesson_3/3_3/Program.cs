Console.Write("n=");
int n = int.Parse(Console.ReadLine()!);
int i=1;

void Pow (int n){
while(i<=n){
    Console.WriteLine(Math.Pow(i,2));
    i++;
}}

Pow(n);