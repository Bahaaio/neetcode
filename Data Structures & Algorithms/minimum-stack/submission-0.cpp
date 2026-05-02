class MinStack {
    vector<int> arr;
    vector<int> rev;
public:
    MinStack() {}
    
    void push(int val) {
        if(rev.size()) rev.push_back(std::min(rev.back(), val));
        else rev.push_back(val);
        arr.push_back(val);
    }
    
    void pop() {
        arr.pop_back();
        rev.pop_back();
    }
    
    int top() {
        return arr.back();
    }
    
    int getMin() {
        return rev.back();
    }
};
