using System.Collections.Generic;

namespace GameOfLife.HelperClasses
{
    public class Cell
    {
        public static void ExpandLivingArea(int pos1, int pos2, int pos3, IReadOnlyList<int[]> cells, int totalCellCount)
        {
            if (pos2 > 0)
            {
                if (cells[pos2 - 1][pos3] == 0)
                {
                    cells[pos2 - 1][pos3] = pos1;
                }

                if (pos3 > 0)
                {
                    if (cells[pos2 - 1][pos3 - 1] == 0)
                    {
                        cells[pos2 - 1][pos3 - 1] = pos1;
                    }
                }

                if (pos3 < totalCellCount)
                {
                    if (cells[pos2 - 1][pos3 + 1] == 0)
                    {
                        cells[pos2 - 1][pos3 + 1] = pos1;
                    }
                }
            }

            if (pos3 > 0)
            {
                if (cells[pos2][pos3 - 1] == 0)
                {
                    cells[pos2][pos3 - 1] = pos1;
                }
            }

            if (pos3 < totalCellCount)
            {
                if (cells[pos2][pos3 + 1] == 0)
                {
                    cells[pos2][pos3 + 1] = pos1;
                }
            }

            if (pos2 >= totalCellCount) return;
            if (cells[pos2 + 1][pos3] == 0)
            {
                cells[pos2 + 1][pos3] = pos1;
            }

            if (pos3 > 0)
            {
                if (cells[pos2 + 1][pos3 - 1] == 0)
                {
                    cells[pos2 + 1][pos3 - 1] = pos1;
                }
            }

            if (pos3 >= totalCellCount) return;
            if (cells[pos2 + 1][pos3 + 1] == 0)
            {
                cells[pos2 + 1][pos3 + 1] = pos1;
            }
        }
    }
}
