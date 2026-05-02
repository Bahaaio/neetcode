class MinStack {
    stack<pair<int, int>> s;

public:
    MinStack() {}

    void push(int val) {
        if (not s.empty())
            s.push({val, std::min(s.top().second, val)});
        else
            s.push({val, val});
    }

    void pop() { s.pop(); }

    int top() { return s.top().first; }

    int getMin() { return s.top().second; }
};
