public class Solution {
    private Dictionary<int, int> d = [];

    private int Cost(int[] cost, int idx, int total = 0) {
        if (idx >= cost.Length)
            return total;

        total += cost[idx];
        if (d.TryGetValue(idx, out int val))
            return total + val;

        d[idx] = Math.Min(Cost(cost, idx + 2), Cost(cost, idx + 1));
        return total + d[idx];
    }

    public int MinCostClimbingStairs(int[] cost) {
        return Math.Min(Cost(cost, 1), Cost(cost, 0));
    }
}
