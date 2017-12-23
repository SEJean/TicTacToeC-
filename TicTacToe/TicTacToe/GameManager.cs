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
        private char[,] m_GridData;


        public GameManager()
        {
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
    }
}
