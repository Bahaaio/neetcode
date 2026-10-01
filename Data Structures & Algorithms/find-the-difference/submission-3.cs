public class Solution {
    public char FindTheDifference(string s, string t) {
        int[] a = new int[26], b = new int[26];

        foreach (var c in s) a[c - 'a']++;
        foreach (var c in t) b[c - 'a']++;

        for (int i = 0; i < 27; i++)
            if (a[i] != b[i])
                return (char)(i + 'a');

        return ' ';
    }
}