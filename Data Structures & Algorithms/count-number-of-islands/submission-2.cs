public class Solution {
    private int[] dx = [-1, 1, 0, 0];
    private int[] dy = [0, 0, -1, 1];

    private void dfs(char[][] grid, int x, int y) {
        if (grid[x][y] == '0')
            return;

        grid[x][y] = '0';

        for (int i = 0; i < dx.Length; i++) {
            int newx = x + dx[i];
            int newy = y + dy[i];

            if (newx < 0 || newx >= grid.Length || newy < 0 || newy >= grid[x].Length)
                continue;

            dfs(grid, newx, newy);
        }
    }

    public int NumIslands(char[][] grid) {
        int count = 0;

        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[i].Length; j++)
                if (grid[i][j] == '1') {
                    dfs(grid, i, j);
                    count++;
                }

        return count;
    }
}
