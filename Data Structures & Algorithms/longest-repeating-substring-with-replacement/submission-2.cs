public class Solution {
    public int CharacterReplacement(string s, int k) {
        int start = 0, max = 1;
        var d = new Dictionary<char, int>();

        for (int end = 0; end < s.Length; end++) {
            d[s[end]] = d.GetValueOrDefault(s[end]) + 1;

            int cur = d.Values.Max();
            int sum = d.Values.Sum();

            if (sum - cur <= k) {
                max = Math.Max(max, sum);
            } else {
                d[s[start]] = d.GetValueOrDefault(s[start++]) - 1;
            }
        }

        return max;
    }
}
