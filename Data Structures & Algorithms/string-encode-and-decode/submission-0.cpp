class Solution {
    char delim = ',';
    char esc = '|';
public:

    string encode(vector<string>& strs) {
        stringstream ss;

        for(const string s : strs) {
            for(const char c : s) {
                if(c == delim or c == esc) {
                    ss << esc;
                }

                ss << c;
            }

            ss << delim;
        }

        return ss.str();
    }

    vector<string> decode(string s) {
        vector<string> ret;

        stringstream ss;
        for(int i = 0; i < s.length(); i++) {
            const char c = s[i];
            if(c == esc && i != s.length() -1 ) {
                ss << s[++i];
            }else if(c == delim) {
                ret.push_back(ss.str());
                ss.str(std::string());
            }else {
                ss << s[i];
            }
        }

        return ret;
    }
};
