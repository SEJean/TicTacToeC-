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



        private Dictionary<Panel,Point> m_GameSquares;

        private bool m_IsXPlayerTurn;
        private bool m_IsGameWon;
        private char[,] m_GridData;
        private int m_PlayerXScore = 0;
        private int m_PlayerYScore = 0;

        public GameManager()
        {
            m_IsGameWon = false;
            m_IsXPlayerTurn = true;
            m_GridData = new char[3, 3] { { ' ',' ',' ' },
                                          { ' ',' ',' ' },
                                          { ' ',' ',' ' },
                                        };
            m_GameSquares = new Dictionary<Panel, Point>();

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
            Panel square = (Panel)sender;
            Point positionInGrid = m_GameSquares[square];
            if(m_IsXPlayerTurn)
            {
                m_GridData[positionInGrid.X, positionInGrid.Y] = PLAYER_X;
            }
            else
            {
                m_GridData[positionInGrid.X, positionInGrid.Y] = PLAYER_O;
            }

            m_IsGameWon = CheckForVictory();

            if(m_IsGameWon)
            {
                Debug.WriteLine("Won");
                //Tell the hudManager to Update
            }
            //Debugging log
            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Debug.Write(m_GridData[i, j]);
            //    }
            //    Debug.WriteLine("");
            //}
        }

        private bool CheckForVictory()
        {
            char symbolToCheck = (m_IsXPlayerTurn) ? 'X' : 'O';
            return CheckForLines(symbolToCheck) || CheckForColumns(symbolToCheck) || CheckForDiags(symbolToCheck); 
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
                   m_GridData[1, 0] == p_Symbol && m_GridData[1, 1] == p_Symbol && m_GridData[1, 2] == p_Symbol ||
                   m_GridData[2, 0] == p_Symbol && m_GridData[2, 1] == p_Symbol && m_GridData[2, 2] == p_Symbol;
        }

        private bool CheckForDiags(char p_Symbol)
        {
            return m_GridData[0, 0] == p_Symbol && m_GridData[1, 1] == p_Symbol && m_GridData[2, 2] == p_Symbol ||
                   m_GridData[2, 0] == p_Symbol && m_GridData[1, 1] == p_Symbol && m_GridData[0, 2] == p_Symbol;
        }
    }
}
