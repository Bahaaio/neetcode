class Solution {
public:
    bool isValidSudoku(const vector<vector<char>>& board) {
        unordered_map<int, unordered_set<char>> rows, cols, squares;

        for(int r = 0; r < board.size(); r++) {
            for(int c = 0; c < board.size(); c++) {
                const char ch = board[r][c];
                if(ch == '.') continue;

                const int square = (r / 3) * 3 + c / 3;

                if(rows[r].count(ch) or cols[c].count(ch) or 
                squares[square].count(ch))
                    return false;

                rows[r].insert(ch);
                cols[c].insert(ch);
                squares[square].insert(ch);
            }
        }

        return true;
    }
};
