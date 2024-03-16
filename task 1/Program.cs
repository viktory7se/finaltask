void WriteBetween(int m, int n) 
{
    if(m > n) return;
    Console.WriteLine(m);
    WriteBetween(++m, n);
}

int n,m;
Console.WriteLine("Введите M: ");
int.TryParse(Console.ReadLine(),out m);
Console.WriteLine("Введите N: ");
int.TryParse(Console.ReadLine(), out n);

WriteBetween(m,n);