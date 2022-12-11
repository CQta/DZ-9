int Fun_Akkerman(int a, int b)
{
    if(a==0) return b+1;
    if(a>0 && b==0) return Fun_Akkerman(a-1,1);
    if(a>0 && b>0) return Fun_Akkerman(a-1, Fun_Akkerman(a,b-1)); 
    return b+1;
}   
System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите 2 число");
int num2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Fun_Akkerman(num, num2));
