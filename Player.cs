﻿using System;
using System.Collections.Generic;
using System.Text;


namespace C17_Ex02_Yakov_Hason
{
    public class Player
    {
        int m_PlayerScore = 0;
        private readonly string r_PlayerName;

        public Player(string i_PlayerName)
        {
            r_PlayerName = i_PlayerName;
        }
        public string PlayerName
        { 
            get { return r_PlayerName; }

         }
        public int PlayerScore
        {
            get { return m_PlayerScore;  }
            set { m_PlayerScore = value; }
        }


    }
}
