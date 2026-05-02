class Solution {
private:
    std::unordered_map<char, char> brackets{
        {')', '('},
        {'}', '{' },
        {']', '['}
    };
public:
    bool isValid(const string& s) {
        std::stack<char> p;
        
        for(const char c : s) {
            if (not brackets.contains(c)) p.push(c);
            else if(not p.empty() and p.top() == brackets[c]) p.pop();
            else return false;
        }

        return p.empty();
    }
};
