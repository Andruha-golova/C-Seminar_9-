Metka:
int m = ReadInt("enter number m: ");
int n = ReadInt("enter number n: ");
if (n < 0 || m < 0)
{
    System.Console.WriteLine("Number must be non-negative. Repeat input!");
    goto Metka;
}
int result = FunctionAkkerman(m, n);
System.Console.Write($"Ackermann function = {result} ");

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionAkkerman(int m, int n)
{
    if (m == 0 && n > 0) return n + 1;
    else if (n == 0 && m > 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}