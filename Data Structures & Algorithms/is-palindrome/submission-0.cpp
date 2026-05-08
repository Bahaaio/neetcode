class Solution {
   public:
    bool isPalindrome(string s) {
        int left = 0, right = s.size() - 1;

        while (left < right) {
            if (not isAlpahnumeric(s[left])) {
                left++;
                continue;
            }

            if (not isAlpahnumeric(s[right])) {
                right--;
                continue;
            }

            if (std::tolower(s[left]) != std::tolower(s[right])) return false;
            left++, right--;
        }

        return true;
    }

   private:
    bool isAlpahnumeric(char c) { return std::isalpha(c) or (c >= '0' and c <= '9'); }
};
