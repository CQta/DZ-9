int Print_sum(int a, int b)
{
    int sum =0;
    if(a==b) return a;
    if(a>b) (a,b)=(b,a);
    for(;a<b+1;a++)
    {
        sum +=a;
    }
    return sum;
}
System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите 2 число");
int num2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Print_sum(num, num2));
