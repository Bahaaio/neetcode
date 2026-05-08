class Solution {
   public:
    vector<vector<int>> threeSum(vector<int>& nums) {
        std::sort(nums.begin(), nums.end());
        vector<vector<int>> ret;
        unordered_map<int, int> m;
        unordered_map<int, vector<pair<int, int>>> s;

        for (int i = 0; i < nums.size(); i++) m[nums[i]] = i;

        for (int i = 0; i < nums.size(); i++) {
            for (int j = i + 1; j < nums.size(); j++) {
                int needed = -(nums[i] + nums[j]);

                if (not m.contains(needed)) continue;

                int idx = m[needed];
                if (idx == i or idx == j) continue;

                for (auto num : {nums[i], nums[j], needed}) {
                    bool ok = true;
                    auto ps = s[needed];
                    for (auto p : ps) {
                        if (nums[i] == p.first or nums[i] == p.second or nums[j] == p.first or
                            nums[j] == p.second) {
                            ok = false;
                            break;
                        }
                    }

                    if (ok) {
                        ret.push_back({nums[i], nums[j], needed});
                        s[needed].push_back({nums[i], nums[j]});
                        s[nums[i]].push_back({needed, nums[j]});
                        s[nums[j]].push_back({nums[i], needed});
                        break;
                    }
                }
            }
        }

        return ret;
    }
};
