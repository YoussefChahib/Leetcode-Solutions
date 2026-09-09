public class PathCrossing
{
    public bool IsPathCrossing(string path)
    {
        int len = path.Length;

        bool[,] matrix = new bool[2000, 2000];
        matrix[1000, 1000] = true;

        int currentCol = 1000;
        int currentRow = 1000;

        for (int i = 0; i < len; i++)
        {
            switch (path[i])
            {
                case 'N':
                    currentRow--;
                    break;
                case 'S':
                    currentRow++;
                    break;
                case 'E':
                    currentCol++;
                    break;
                case 'W':
                    currentCol--;
                    break;
            }

            if (matrix[currentRow, currentCol]) return true;
            matrix[currentRow, currentCol] = true;
        }
        return false;
    }
}