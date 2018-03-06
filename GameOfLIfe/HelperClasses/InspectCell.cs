namespace GameOfLife.HelperClasses
{
    public class InspectCell
    {
        public static int CheckCellSurrounding(int pos1, int pos2, int[][] cells, int totalCellCount)
        {
            var counter = 0;
            if (pos1 > 0)
            {
                if (cells[pos1 - 1][pos2] > 0)
                {
                    counter += 1;
                }

                if (pos2 > 0)
                {
                    if (cells[pos1 - 1][pos2 - 1] > 0)
                    {
                        counter += 1;
                    }
                }

                if (pos2 < totalCellCount)
                {
                    if (cells[pos1 - 1][pos2 + 1] > 0)
                    {
                        counter += 1;
                    }
                }
            }

            if (pos2 > 0)
            {
                if (cells[pos1][pos2 - 1] > 0)
                {
                    counter += 1;
                }
            }

            if (pos2 < totalCellCount)
            {
                if (cells[pos1][pos2 + 1] > 0)
                {
                    counter += 1;
                }
            }

            if (pos1 >= totalCellCount) return counter;
            if (cells[pos1 + 1][pos2] > 0)
            {
                counter += 1;
            }

            if (pos2 > 0)
            {
                if (cells[pos1 + 1][pos2 - 1] > 0)
                {
                    counter += 1;
                }
            }

            if (pos2 >= totalCellCount) return counter;
            if (cells[pos1 + 1][pos2 + 1] > 0)
            {
                counter += 1;
            }

            return counter;
        }
    }
}
