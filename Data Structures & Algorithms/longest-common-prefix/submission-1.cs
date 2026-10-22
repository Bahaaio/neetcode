public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var longest = strs[0];

        for (int i = 0; i < strs[0].Length; i++) {
            for (int j = 0; j < strs.Length; j++) {
                if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                    return longest.Substring(0, i);
            }
        }

        return longest;
    }
}