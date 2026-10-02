public class Solution {
    private int[] dx = [0, 0, 1, -1];
    private int[] dy = [-1, 1, 0, 0];

    public int MaxAreaOfIsland(int[][] grid) {
        int current = 0;
        int max = 0;

        void dfs(int x, int y) {
            if (grid[x][y] == 0)
                return;

            current++;
            grid[x][y] = 0;

            for (int i = 0; i < dx.Length; i++) {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx < 0 || nx >= grid.Length || ny < 0 || ny >= grid[x].Length)
                    continue;

                dfs(nx, ny);
            }
        }

        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) {
                    dfs(i, j);
                    max = Math.Max(max, current);
                    current = 0;
                }
            }
        }

        return max;
    }
}
