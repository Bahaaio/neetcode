public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int sum = n * (n + 1) / 2, asum = 0;

        foreach(int num in nums) asum += num;

        return sum - asum;
    }
}
