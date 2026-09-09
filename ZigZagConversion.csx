
public string Convert(string s, int numRows)
{
    int len = s.Length;
    if (numRows == 1) return s;

    char?[][] matrix = new char?[numRows][];
    for (int i = 0; i < numRows; i++)
    {
        matrix[i] = new char?[len];
    }

    int currentRow = -1;
    int currentCol = 0;
    bool downDirection = true;

    for (int i = 0; i < len; i++)
    {
        if (downDirection)
        {
            currentRow++;
            matrix[currentRow][currentCol] = s[i];

            if (currentRow == numRows - 1) downDirection = false;
        }
        else
        {
            currentRow--;
            currentCol++;
            matrix[currentRow][currentCol] = s[i];

            if (currentRow == 0) downDirection = true;
        }
    }
    StringBuilder zigzag = new StringBuilder();
    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < len; j++)
        {
            if (matrix[i][j] != null)
            {
                zigzag.Append(matrix[i][j]);
            }
        }
    }
    return zigzag.ToString();
}
