public class Solution {
    record r(int i, bool f);
    
    public int Rob(int[] nums) {
        Dictionary<r, int> d = new();

        int dfs(int i, bool f = false) {
            if (i >= nums.Length || i < 0 || (f && i == nums.Length - 1))
                return 0;

            if(d.TryGetValue(new r(i, f), out int a)){
                return a;
            }

            int sol = Math.Max(nums[i] + dfs(i + 2, f), dfs(i + 1, f));
            d[new r(i, f)] = sol;
            return sol;
        }

        if(nums.Length == 1)
            return nums[0];

        return Math.Max(dfs(0, true), dfs(1));
    }
}