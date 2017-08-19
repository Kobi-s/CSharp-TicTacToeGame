namespace C17_Ex02_Yakov_Hason
{
    public class DesplayBord
    {
        private int m_Xcounter;
        private int m_Ocounter;
        private readonly int r_BoardSize ;
        private readonly MethodAndLogic.Marks[ , ]r_BoardMatrix; 
        
        public DesplayBord (int i_BoardSize)
        {
            r_BoardSize = i_BoardSize;

            r_BoardMatrix = new MethodAndLogic.Marks[BoardSize, BoardSize];

            ClearBoard();

            this[(BoardSize / 2) - 1 , (BoardSize / 2) - 1] = this[ BoardSize / 2,      BoardSize / 2] = MethodAndLogic.Marks.O;
            this[BoardSize / 2 ,       (BoardSize / 2) - 1] = this[(BoardSize / 2) - 1, BoardSize / 2] = MethodAndLogic.Marks.X;
            
            m_Xcounter = m_Ocounter=2;
         }
        public DesplayBord(DesplayBord i_Copy_Of_prev)
        {
            this.r_BoardSize = i_Copy_Of_prev.BoardSize;
            this.r_BoardMatrix = new MethodAndLogic.Marks[BoardSize, BoardSize];


            for (int i = 0; i < BoardSize; i++)
            {
              for (int j = 0; j < BoardSize; j++)
              {
                    this[i, j] = i_Copy_Of_prev[i, j];
              }
            }
            this.m_Xcounter = i_Copy_Of_prev.m_Xcounter;
            this.m_Ocounter = i_Copy_Of_prev.m_Ocounter;
        }
        public MethodAndLogic.Marks this[int i_Row, int i_Column]
        {
            get { return r_BoardMatrix[i_Row, i_Column]; }
            set { r_BoardMatrix[i_Row, i_Column] = value; }
        }
        private void ClearBoard()
        {
            for (int i=0; i < r_BoardSize; i++)
            {
                for (int j=0; j<r_BoardSize; j++ )
                {
                    this[i, j] = MethodAndLogic.Marks.Nothing;
                }
            }
         }
        public int Xcounter
        {
            get { return m_Xcounter;  }
            set { m_Xcounter = value; }
        }
        public int Ocounter
        {
            get { return m_Ocounter; }
            set { m_Ocounter = value; }
        }
        public int BoardSize
        {
            get { return r_BoardSize; }
        }

    }
}
