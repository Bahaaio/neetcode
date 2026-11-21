public class Solution {
    public int CharacterReplacement(string s, int k) {
        int start = 0, max = 1, maxFreq = 0;
        int[] freq = new int[26];

        for (int end = 0; end < s.Length; end++) {
            maxFreq = Math.Max(maxFreq, ++freq[s[end] - 'A']);

            while (end - start + 1 - maxFreq > k) {
                freq[s[start++] - 'A']--;
            }

            max = Math.Max(max, end - start + 1);
        }

        return max;
    }
}
