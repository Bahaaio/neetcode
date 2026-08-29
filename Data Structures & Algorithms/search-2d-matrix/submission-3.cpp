class Solution {
   public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        if (target < matrix[0][0] or target > matrix.back().back()) return false;

        int i = -1, f = 0, l = matrix.size();
        while (f <= l) {
            int m = (f + l) / 2;

            if (target >= matrix[m][0] and target <= matrix[m].back()) {
                i = m;
                break;
            } else if (target > matrix[m].back())
                f = m + 1;
            else
                l = m - 1;
        }
        if (i == -1) return false;

        int low = 0, high = matrix[0].size() - 1;
        while (low <= high) {
            int mid = (low + high) / 2;

            if (matrix[i][mid] == target)
                return true;
            else if (matrix[i][mid] > target)
                high = mid - 1;
            else
                low = mid + 1;
        }

        return false;
    }
};
