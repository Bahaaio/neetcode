public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1, maxArea = 0;

        while (right < heights.Length && left <= right) {
            int area = (right - left) * Math.Min(heights[left], heights[right]);
            maxArea = Math.Max(maxArea, area);

            if (heights[left] <= heights[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}
