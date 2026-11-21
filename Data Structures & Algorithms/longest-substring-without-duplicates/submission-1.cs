public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0, max = 0;
        var set = new HashSet<char>();

        for (int r = 0; r < s.Length; r++) {
            while (l < r && set.Contains(s[r])) {
                set.Remove(s[l++]);
            }

            set.Add(s[r]);
            max = Math.Max(max, set.Count);
        }

        return max;
    }
}
