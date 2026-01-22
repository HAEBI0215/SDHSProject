using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int minX = -5;
    public static int maxX = 6;
    public static int minY = -3;
    public static int maxY = 20;

    public static int width;
    public static int height;

    public static Transform[,] grid;

    void Awake()
    {
        width = maxX - minX + 1;
        height = maxY - minY + 1;

        grid = new Transform[width, height];
    }

    public static Vector2Int WorldToGrid(Vector2 worldPos)
    {
        int x = Mathf.RoundToInt(worldPos.x - minX);
        int y = Mathf.RoundToInt(worldPos.y - minY);
        return new Vector2Int(x, y);
    }

    public static bool IsValidPosition(Transform tetromino)
    {
        foreach (Transform block in tetromino)
        {
            Vector2 pos = Round(block.position);
            Vector2Int gPos = WorldToGrid(pos);

            if (gPos.x < 0 || gPos.x >= width ||
                gPos.y < 0 || gPos.y >= height)
                return false;

            if (grid[gPos.x, gPos.y] != null)
                return false;
        }
        return true;
    }

    public static void AddToGrid(Transform tetromino)
    {
        foreach (Transform block in tetromino)
        {
            Vector2 pos = Round(block.position);
            Vector2Int gPos = WorldToGrid(pos);
            grid[gPos.x, gPos.y] = block;
        }
    }

    public static void DeleteFullLines()
    {
        for (int y = 0; y < height; y++)
        {
            if (IsLineFull(y))
            {
                DeleteLine(y);
                MoveDownLines(y);
                y--;
            }
        }
    }

    static bool IsLineFull(int y)
    {
        for (int x = 0; x < width; x++)
        {
            if (grid[x, y] == null)
                return false;
        }
        return true;
    }

    static void DeleteLine(int y)
    {
        for (int x = 0; x < width; x++)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
    }

    static void MoveDownLines(int fromY)
    {
        for (int y = fromY + 1; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (grid[x, y] != null)
                {
                    grid[x, y - 1] = grid[x, y];
                    grid[x, y] = null;
                    grid[x, y - 1].position += Vector3.down;
                }
            }
        }
    }

    static Vector2 Round(Vector2 v)
    {
        return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
    }
}