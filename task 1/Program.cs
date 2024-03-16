void WriteBetween(int m, int n) 
{
    if(m > n) return;
    Console.WriteLine(m);
    WriteBetween(++m, n);
}

int n,m;
Console.WriteLine("Введите M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
n = Convert.ToInt32(Console.ReadLine());

WriteBetween(m,n);