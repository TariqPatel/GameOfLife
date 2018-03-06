using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife.HelperClasses
{
    public class Painter
    {
        public static void Paint(exDGV lifeGridControl, bool cancelled, int totalCellCount, IReadOnlyList<int[]> cells)
        {
            //loop through current grid and set back color of cells
            if (cancelled) return;
            for (var count1 = 0; count1 <= totalCellCount; count1++)
            {
                for (var count2 = 0; count2 <= totalCellCount; count2++)
                {
                    lifeGridControl.Rows[count1].Cells[count2].Style.BackColor =
                        cells[count1][count2] > 0 ? Color.Black : Color.White;
                }
            }
        }

    }
}
