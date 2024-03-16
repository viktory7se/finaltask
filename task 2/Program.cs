int Ack(int n, int m)
{
    if(n == 0) return m + 1;
    else if(m == 0) return Ack(n - 1,1);
    
    return Ack(n - 1, Ack(n,m - 1));
}

int n,m;
Console.WriteLine("Введите M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ack(n,m));

/*
если n = 0
     вернуть m + 1
   иначе, если m = 0
     вернуть ack (n - 1, 1)
   еще
     вернуть ack(n - 1, ack (n, m - 1))
*/