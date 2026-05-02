class Solution {
public:
    int longestConsecutive(vector<int>& nums) {
        if(nums.size() <= 1) return nums.size();

        std::sort(nums.begin(), nums.end());

        int prev = nums[0];
        int maxLen = -1, len = 1;
        
        for(int i = 1; i < nums.size(); i++) {
            if(nums[i] == prev) continue;

            if(nums[i] == 1 + prev) {
                maxLen = std::max(maxLen, ++len);
            } else {
                len = 1;
            }

            prev = nums[i];
        }

        return maxLen == -1 ? 1 : maxLen;
    }
};
