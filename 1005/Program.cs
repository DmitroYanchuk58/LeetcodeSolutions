int[] nums = { 4, 2, 3 };
var result = LargestSumAfterKNegations(nums, 1);
Console.WriteLine(result);
static int LargestSumAfterKNegations(int[] nums, int k)
{
    int numberForWhile = 0;
    while (numberForWhile < k)
    {
        int minIndex = Array.IndexOf(nums, nums.Min());

        nums[minIndex] *= -1;

        numberForWhile++;
    }
    return nums.Sum();
}

