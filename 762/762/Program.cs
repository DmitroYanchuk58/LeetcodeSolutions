var result=CountPrimeSetBits(6, 10);
Console.WriteLine(result);
static int CountPrimeSetBits(int left, int right)
{
    int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
    int result = 0;

    for (int i = left; i <= right; i++)
    {
        if (primes.Contains(CountSetBits(i)))
        {
            result++;
        }
    }

    return result;
}

static int CountSetBits(int n)
{
    int count = 0;
    while (n > 0)
    {
        count += n & 1; 
        n >>= 1;       
    }
    return count;
}

