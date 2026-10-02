public class Solution {
    public int MissingNumber(int[] nums) {
        int c = 0;
        
        for (int i = 0; i <= nums.Length; i++) c ^= i;
        foreach (int num in nums) c ^= num;

        return c;
    }
}
