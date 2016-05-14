using System;
using System.Diagnostics;

namespace MazeProblem
{
    class Maze
    {
        private int[,] maze;
        private int[,] traverse;
        private int[,] dir;
        private int ArrayXBound;
        private int ArrayYBound;

        public Maze(int[,] maze)
        {
            this.maze = maze;

            ArrayXBound = maze.GetUpperBound(0);
            ArrayYBound = maze.GetUpperBound(1);

            this.traverse = new int[ArrayXBound + 1, ArrayYBound + 1];
            this.dir = new int[4,2]{ {-1,0}, {0,1}, {0,-1}, {1,0}};
            Boolean isPath = FindPath(0, 1, 1);

        }

        private bool FindPath(int rowIndex, int iCurrentIndex, int MaxIndex)
        {
            for (int iCol = 0; iCol < ArrayYBound; iCol++)
            {
                if (true == Find(rowIndex, iCol, iCurrentIndex, MaxIndex))
                {
                    Debug.WriteLine("" + rowIndex + "  " + iCol);
                    return true;
                }
            }

            return false;
        }


        private bool Find(int rowIndex, int iColumnIndex, int iCurrentIndex, int MaxIndex)
        {
            if (maze[rowIndex, iColumnIndex] == iCurrentIndex)
            {
                traverse[rowIndex, iColumnIndex] = 1;

                if (rowIndex == ArrayXBound)
                    return true;

                if (iCurrentIndex == MaxIndex)
                {
                    MaxIndex += 1;
                    iCurrentIndex = 1;
                }
                else
                {
                    iCurrentIndex += 1;
                }

                for (int i = 0; i < 4; i++)
                {
                    int newRow, newColumn;

                    newRow = rowIndex + dir[i, 0];
                    newColumn = iColumnIndex + dir[i, 1];

                    if (newRow < 0 || newColumn < 0 || newRow > ArrayXBound || newColumn > ArrayYBound)
                        continue;

                    if (traverse[newRow, newColumn] == 1)
                        continue;

                    if (maze[newRow, newColumn] != iCurrentIndex)
                        continue;

                    if(true == Find(newRow, newColumn, iCurrentIndex, MaxIndex))
                    {
                        Debug.WriteLine("" + newRow + "  " + newColumn);
                        return true;
                    }
                }

                iCurrentIndex--;
                if (0 == iCurrentIndex)
                {
                    MaxIndex--;
                    iCurrentIndex = MaxIndex;
                }

                traverse[rowIndex, iColumnIndex] = 0;
            }
            return false;
        }


    }
}
