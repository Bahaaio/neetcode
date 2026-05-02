class Solution {
private:
    inline char opening(char c) {
        switch(c) {
            case ')': return '(';
            case '}': return '{';
            case ']': return '[';
        }
        return '.';
    }
public:
    bool isValid(const string& s) {
        std::stack<char> p;
        
        for(const char c : s) {
            if (c == '(' or c == '{' or c == '[') p.push(c);
            else if(not p.empty() and p.top() == opening(c)) p.pop();
            else return false;
        }

        return p.empty();
    }
};
