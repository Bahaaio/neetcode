class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        var m = new HashMap<String, List<String>>();

        for (var s : strs) {
            var arr = s.toCharArray();
            Arrays.sort(arr);
            var key = new String(arr);

            if (m.get(key) == null) {
                m.put(key, new ArrayList());
            }

            m.get(key).add(s);
        }

        var ret = new ArrayList();

        for (var l : m.values()) {
            ret.add(l);
        }

        return ret;
    }
}
