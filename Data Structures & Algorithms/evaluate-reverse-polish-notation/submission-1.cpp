class Solution {
    stack<int> numbers;
    unordered_set<char> operators{'+' , '-', '*', '/'};

    inline int eval(int left, const char op, int right) {
        switch(op) {
            case '+': return left + right;
            case '-': return left - right;
            case '*': return left * right;
            case '/': return left / right;
        }
        return 0;
    }
public:
    int evalRPN(vector<string>& tokens) {
        for (const string token : tokens) {
            if(not operators.contains(token[0]) or token.length() > 1) {
                int number = stoi(token);
                numbers.push(number);
                continue;
            }

            int right = numbers.top();
            numbers.pop();

            int left = numbers.top();
            numbers.pop();

            numbers.push(eval(left, token[0], right));
        }

        return numbers.top();
    }
};
