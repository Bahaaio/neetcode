class Solution {
    public boolean isAnagram(String s, String t) {
        var a = s.toCharArray();
        var b = t.toCharArray();

        Arrays.sort(a);
        Arrays.sort(b);

        return Arrays.equals(a, b);
    }
}