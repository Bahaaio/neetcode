class Solution {
public:
    int longestConsecutive(const vector<int>& nums) {
        unordered_set<int> s(nums.begin(), nums.end());

        int maxLen = 0;
        for(const int num : s) {
            if(!s.contains(num - 1)) {
                int len = 1;
                int n = num;

                while(s.contains(++n)) len++;
                maxLen = max(maxLen, len);
            }
        }

        return maxLen;
    }
};
