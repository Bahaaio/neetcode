class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        vector<int> leftToRight(nums.size());
        vector<int> rightToLeft(nums.size());

        leftToRight[0] = nums[0];
        for(int i =1;i<nums.size(); i++) leftToRight[i] = leftToRight[i-1] * nums[i];

        rightToLeft[nums.size()-1] = nums[nums.size()-1];
        for(int i = nums.size() - 2; i>=0; i--) rightToLeft[i] = rightToLeft[i+1] * nums[i];

        vector<int> ret(nums.size());
        ret[0] = rightToLeft[1];
        ret[nums.size()-1] = leftToRight[nums.size()-2];

        for(int i = 1;i<nums.size()-1;i++) {
            ret[i] = leftToRight[i-1] * rightToLeft[i+1];
        }
    
        return ret;
    }
};
