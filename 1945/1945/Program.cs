var num=GetLucky("zbax",2);
Console.WriteLine(num);
static int GetLucky(string s, int k)
{
    int result = 0;

    foreach (char c in s)
    {
        int numValue = c-'a'+1; 
        while (numValue > 0)
        {
            result += numValue % 10; 
            numValue /= 10;         
        }
    }

    for (int i = 1; i < k; i++)
    {
        int newResult = 0;
        while (result > 0)
        {
            newResult += result % 10; 
            result /= 10;             
        }
        result = newResult;          
    }

    return result;
}


