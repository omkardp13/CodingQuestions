public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int count = 0;
        if (nums.Length == 1)
            return;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[count++] = nums[i];
            }
        }

        while (count < nums.Length)
        {
            nums[count++] = 0;

        }
    }
}