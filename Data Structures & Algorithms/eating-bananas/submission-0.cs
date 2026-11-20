public class Solution {
    int Hours(int[] piles, int k, int h) {
        int hours = 0;

        foreach (int pile in piles) {
            hours += (int)Math.Ceiling((double)pile / k);
            if (hours > h)
                break;
        }

        return hours;
    }

    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max();
        int minK = r;

        while (l <= r) {
            int mid = (l + r) / 2;
            int hours = Hours(piles, mid, h);

            if (hours > h) {
                l = mid + 1;
            } else {
                minK = mid;
                r = mid - 1;
            }
        }

        return minK;
    }
}
