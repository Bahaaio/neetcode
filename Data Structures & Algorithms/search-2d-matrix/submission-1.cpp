class Solution {
   public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        if (target < matrix[0][0] or target > matrix.back().back()) return false;

        int i = 0;
        for (; i < matrix.size(); i++) {
            if (target < matrix[i][0]) break;
        }
        i--;

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
