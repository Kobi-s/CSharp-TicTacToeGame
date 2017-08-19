using System;
using System.Collections.Generic;
using System.Text;

namespace XoProg
{
    public enum eCellValue
    {
        emptyValue,
        player1,
        player2
    }

    public class Cell
    {
        private eCellValue m_CellValue = eCellValue.emptyValue;

        public eCellValue CellValue
        {
            get { return m_CellValue; }
            set
            {
               if(m_CellValue == eCellValue.emptyValue)
                m_CellValue = value;
            }
        }
    }
}
