public class Solution {
    private int[] dx = [0, 0, 1, -1];
    private int[] dy = [-1, 1, 0, 0];

    private int dfs(int[][] grid, int x, int y) {
        if (grid[x][y] == 0) return 0;

        int area = 1;
        grid[x][y] = 0;

        for (int i = 0; i < dx.Length; i++) {
            int nx = x + dx[i];
            int ny = y + dy[i];

            if (nx < 0 || nx >= grid.Length || ny < 0 || ny >= grid[x].Length)
                continue;

            area += dfs(grid, nx, ny);
        }

        return area;
    }

    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;

        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) {
                    var area = dfs(grid, i, j);
                    max = Math.Max(max, area);
                }
            }
        }

        return max;
    }
}
