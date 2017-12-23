using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace TicTacToe
{

    

    public class GameManager
    {
        private const char PLAYER_X = 'X';
        private const char PLAYER_O = 'O';


        private HudManager m_HudManager;
        private Dictionary<Panel,Point> m_GameSquares;

        private int m_TurnLeft;
        private bool m_IsXPlayerTurn;
        private bool m_IsGameWon;
        private char[,] m_GridData;

        public GameManager()
        {
            m_IsGameWon = false;
            m_IsXPlayerTurn = true;
            m_TurnLeft = 9;
            m_GridData = new char[3, 3] { { ' ',' ',' ' },
                                          { ' ',' ',' ' },
                                          { ' ',' ',' ' },
                                        };
            m_GameSquares = new Dictionary<Panel, Point>();
            m_HudManager = new HudManager();
        }
        
        public int TurnLeft
        {
            get { return m_TurnLeft; }
            set { m_TurnLeft = value; }
        }

        public char[,] Data
        {
            get { return m_GridData; }
            set { m_GridData = value; }
        }

        public bool IsGameWon
        {
            get { return m_IsGameWon;  }
            set { m_IsGameWon = value; }
        }

        public HudManager HudManager
        {
            get { return m_HudManager; }
        }

        public bool X_Turn
        {
            get { return m_IsXPlayerTurn; }
            set { m_IsXPlayerTurn = value; }
        }

        public Dictionary<Panel, Point> GameSquares
        {
            get { return m_GameSquares; }
        }

        public void Play(object sender)
        {
            m_TurnLeft--;
            Panel square = (Panel)sender;
            Point positionInGrid = m_GameSquares[square];
            char player = ' ';
            if(m_IsXPlayerTurn)
            {
                player = PLAYER_X;
                m_GridData[positionInGrid.X, positionInGrid.Y] = PLAYER_X;
            }
            else
            {
                player = PLAYER_O;
                m_GridData[positionInGrid.X, positionInGrid.Y] = PLAYER_O;
            }

            m_IsGameWon = CheckForVictory(player);
            if (m_IsGameWon)
            {
                Debug.WriteLine("Won");
                m_HudManager.SetStatus(player.ToString() + " won!");
                m_HudManager.SetScore(player);
            }
            else if (m_TurnLeft == 0)
            {
                m_HudManager.SetStatus("Draw!");
            }

            Debug.WriteLine("Time to play for : " + player);
            
            //Debugging log
            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Debug.Write(m_GridData[i, j]);
            //    }
            //    Debug.WriteLine("");
            //}
        }

        private bool CheckForVictory(char p_Symbol)
        {
            return CheckForLines(p_Symbol) || CheckForColumns(p_Symbol) || CheckForDiags(p_Symbol); 
        }

        private bool CheckForLines(char p_Symbol)
        {
            return m_GridData[0, 0] == p_Symbol && m_GridData[0, 1] == p_Symbol && m_GridData[0, 2] == p_Symbol ||
                   m_GridData[1, 0] == p_Symbol && m_GridData[1, 1] == p_Symbol && m_GridData[1, 2] == p_Symbol ||
                   m_GridData[2, 0] == p_Symbol && m_GridData[2, 1] == p_Symbol && m_GridData[2, 2] == p_Symbol;
        }

        private bool CheckForColumns(char p_Symbol)
        {
            return m_GridData[0, 0] == p_Symbol && m_GridData[1, 0] == p_Symbol && m_GridData[2, 0] == p_Symbol ||
                   m_GridData[0, 1] == p_Symbol && m_GridData[1, 1] == p_Symbol && m_GridData[2, 1] == p_Symbol ||
                   m_GridData[0, 2] == p_Symbol && m_GridData[1, 2] == p_Symbol && m_GridData[2, 2] == p_Symbol;
        }

        private bool CheckForDiags(char p_Symbol)
        {
            return m_GridData[0, 0] == p_Symbol && m_GridData[1, 1] == p_Symbol && m_GridData[2, 2] == p_Symbol ||
                   m_GridData[2, 0] == p_Symbol && m_GridData[1, 1] == p_Symbol && m_GridData[0, 2] == p_Symbol;
        }
    }
}
