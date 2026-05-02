class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
       unordered_map<int,int> m; 

       for (const int num : nums) {
            ++m[num];
       }

        multimap<int,int, greater<>> om;

        for(const auto [num, f] : m) {
            om.insert({f,num});
        }

        vector<int> ret;
        for (const auto [f, num] : om) {
            ret.push_back(num);
            if(--k==0) break;
        }

        return ret;
    }
};
