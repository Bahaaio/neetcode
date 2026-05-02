class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board) {
        // rows
        for(const auto vec : board) {
           unordered_set<char> s; 
           for(const char c : vec) {
                if(c == '.') continue;
                if(s.count(c)) return false;
                s.insert(c);
           }
        }

        // columns
        for(int i =0;i<board.size(); i++ ) {
            unordered_set<char> s; 
            for(int j = 0 ; j<board.size() ; j++) {
                if(board[j][i] == '.') continue;
                if(s.count(board[j][i])) return false;
                s.insert(board[j][i]);
            }
        }


        // boxes
        for(int i = 0; i < board.size(); i+=3 ) {
            for(int j = 0; j < board.size();j+=3) {
                unordered_set<char> s;
                for(int k = i; k < i+3; k++) {
                    for (int l = j; l < j+3; l++) {
                        if(board[k][l] == '.') continue;
                        if(s.count(board[k][l])) return false;
                        s.insert(board[k][l]);
                    }
                }
            }
        }

        return true;
    }
};
