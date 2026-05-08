class Solution {
   public:
    vector<int> twoSum(vector<int>& nums, int target) {
        int start = 0;
        for (int end = nums.size() - 1; end >= 0 and start < nums.size();) {
            int sum = nums[start] + nums[end];

            if (sum == target) return {start + 1, end + 1};
            if (sum > target) end--;
            else start++;
        }

        return {1, 2};
    }
};
