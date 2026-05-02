class Solution {
   public:
    void rotate(vector<vector<int>>& matrix) {
        vector<vector<int>> v(matrix.size(), vector<int>(matrix.size()));

        for (int r = 0; r < matrix.size(); r++) {
            for (int c = 0; c < matrix.size(); c++) {
                v[c][matrix.size() - r - 1] = matrix[r][c];
            }
        }

        for (auto row : v) {
            for (int i : row) cout << i << " ";
            cout << "\n";
        }

        matrix = v;
    }
};
