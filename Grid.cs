using System;
using System.Collections.Generic;
using System.Text;

namespace XoProg
{


    class Grid
    {
        public Cell[,] Cells { get; set; }

        public Grid(int i_SizeOfGrid)
        {
            Cells = new Cell[i_SizeOfGrid, i_SizeOfGrid];
            for (int i = 0; i < i_SizeOfGrid; i++)
            {
                for (int j = 0; j < i_SizeOfGrid; j++)
                {
                    Cells[i, j] = new Cell();
                }
            }
        }
    }
}
