public class Solution {
    private bool[,] vis;
    private int[] dx = [-1, 1, 0, 0];
    private int[] dy = [0, 0, -1, 1];

    private void dfs(char[][] grid, int x, int y) {
        if (grid[x][y] == '0' || vis[x, y])
            return;

        vis[x, y] = true;

        for (int i = 0; i < dx.Length; i++) {
            int newx = x + dx[i];
            int newy = y + dy[i];

            if (newx < 0 || newx >= grid.Length || newy < 0 || newy >= grid[0].Length)
                continue;

            if (!vis[newx, newy])
                dfs(grid, newx, newy);
        }
    }

    public int NumIslands(char[][] grid) {
        int count = 0;
        vis = new bool[grid.Length, grid[0].Length];

        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                if (grid[i][j] == '1' && !vis[i, j]) {
                    dfs(grid, i, j);
                    count++;
                }

        return count;
    }
}
