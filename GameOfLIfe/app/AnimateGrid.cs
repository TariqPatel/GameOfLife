using System.Threading;
using GameOfLife.HelperClasses;

namespace GameOfLife.app
{
    public class AnimateGrid
    {
        public bool Cancelled;
        private readonly exDGV _lifeGridControl;
        private readonly int[][] _cells = new int[100][];
        private const int TotalCellCount = 99;

        public AnimateGrid(exDGV lifeGrid)
        {
            _lifeGridControl = lifeGrid;
            for (var count = 0; count <= 99; count++)
            {
                _cells[count] = new int[100];
            }
        }

        public void GiveLifeOrDeath(object mainCount)
        {
            var index = (int) mainCount;
            Cancelled = false;
            const int sleepCount = 50;

            var check1 = 0;
            var check2 = 0;
            var check3 = 0;
            var check4 = 0;

            if (index != 1 && index != 3)
            {
                if (index == 2)
                {
                    check2 = 48;
                    check4 = 51;
                    check1 = 48;
                    check3 = 51;
                }
            }
            else
            {
                check2 = 47;
                check4 = 52;
                check1 = 47;
                check3 = 52;
            }

            var secondaryCheck = 2;
            while (!Cancelled)
            {
                for (var count1 = check2; count1 <= check4; count1++)
                {
                    for (var count2 = check1; count2 <= check3; count2++)
                    {
                        if (Cancelled)
                        {
                            return;
                        }

                        if (_cells[count1][count2] > 0 && _cells[count1][count2] < secondaryCheck)
                        {
                            Cell.ExpandLivingArea(secondaryCheck, count1, count2, _cells, TotalCellCount);
                        }
                    }
                }

                Thread.Sleep(sleepCount);
                for (var count3 = check2; count3 <= check4; count3++)
                {
                    for (var count4 = check1; count4 <= check3; count4++)
                    {
                        if (Cancelled)
                        {
                            return;
                        }

                        if (_cells[count3][count4] <= 0 || _cells[count3][count4] >= secondaryCheck) continue;
                        var count = InspectCell.CheckCellSurrounding(count3, count4,_cells, TotalCellCount);
                        if (count < 2)
                        {
                            _cells[count3][count4] = -1;
                        }
                        else if (count > 3)
                        {
                            _cells[count3][count4] = -1;
                        }
                    }
                }

                Thread.Sleep(sleepCount);
                for (var count5 = check2; count5 <= check4; count5++)
                {
                    for (var count4 = check1; count4 <= check3; count4++)
                    {
                        if (Cancelled)
                        {
                            return;
                        }

                        if (_cells[count5][count4] != -1) continue;
                        var count = InspectCell.CheckCellSurrounding(count5, count4, _cells, TotalCellCount);
                        if (count == 3)
                        {
                            _cells[count5][count4] = 1;
                        }
                    }
                }

                Thread.Sleep(sleepCount);
                check2 -= 1;
                check1 -= 1;
                check4 += 1;
                check3 += 1;
                secondaryCheck += 1;
                if (check2 < 0 || check1 < 0)
                {
                    Cancelled = true;
                }

                Painter.Paint(_lifeGridControl, Cancelled,TotalCellCount, _cells);
            }
        }
        
        public void SetInitalValue()
        {

            for (var count1 = 48; count1 >= 47; count1--)
            {
                for (var count4 = 49; count4 <= 50; count4++)
                {
                    _cells[count1][count4] = 1;
                }
            }

            for (var count2 = 54; count2 >= 48; count2--)
            {
                for (var count5 = 49; count5 <= 50; count5++)
                {
                    _cells[count2][count5] = -1;
                }
            }

            for (var count3 = 50; count3 >= 49; count3--)
            {
                for (var count6 = 51; count6 <= 52; count6++)
                {
                    _cells[count3][count6] = 1;
                }
            }

            Painter.Paint(_lifeGridControl, Cancelled, TotalCellCount, _cells);
        }

    }
}
