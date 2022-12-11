int Print_num(int a, int i)
{
    if(a==i) return a;
    else System.Console.Write(Print_num(a, i+1)+" ");
    return i;
}
System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Print_num(num, 1));
