class MinStack {
    stack<int> arr;
    stack<int> rev;
public:
    MinStack() {}
    
    void push(int val) {
        if(not rev.empty()) rev.push(std::min(rev.top(), val));
        else rev.push(val);
        arr.push(val);
    }
    
    void pop() {
        arr.pop();
        rev.pop();
    }
    
    int top() {
        return arr.top();
    }
    
    int getMin() {
        return rev.top();
    }
};
