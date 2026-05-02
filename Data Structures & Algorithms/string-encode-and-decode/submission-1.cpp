class Solution {
    char delim = '#';
public:

    string encode(vector<string>& strs) {
        string s;

        for(const auto str : strs)
            s += to_string(str.length()) + delim + str;

        return s;
    }

    vector<string> decode(string s) {
        vector<string> ans; 

        for(int i = 0; i < s.length(); ) {
            for(int j = i; j < s.length(); j++) {
                if(s[j] == delim) {
                    const int len = stoi(s.substr(i, j - i));
                    ans.push_back(s.substr(++j, len));
                    i = j + len;
                    break;
                }
            } 
        }

        return ans;
    }
};
