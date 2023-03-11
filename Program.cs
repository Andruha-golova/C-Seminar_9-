int M = ReadInt("enter number M: ");
int N = ReadInt("enter number N: ");
if (M < N) 
{
    int temp = M;
    M = N;
    N = temp;
}
  System.Console.WriteLine(Print(M, N));


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Print(int numN, int numM)
{
    int result = numN;
    if (numN > numM)
    {
        return result + Print(numN-1, numM);
    }
    return result;
}