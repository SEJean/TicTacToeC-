using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace TicTacToe
{

    


    public partial class Form1 : Form
    {
        const float PEN_SIZE = 1.0f;
        
        private bool m_MoveDone = false;

        private Pen m_GridPen;
        private GameManager m_TicTacToeGame;



        public Pen Pen
        {
            get { return m_GridPen; }
            set { m_GridPen = value; }
        }



        public Form1()
        {
            InitializeComponent();

            Pen = new Pen(Color.Black, PEN_SIZE);
            m_TicTacToeGame = new GameManager();
            pnlGrid.Width = 182;
            pnlGrid.Height = 182;

          
            Point p = new Point(1, 1);

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Panel pnl = new Panel();
                    pnl.Paint += SquarePainted;
                    pnl.Click += SquareClicked;
                    pnl.BackColor = Color.Green;
                    pnl.Width = 60;
                    pnl.Height = 60;
                    pnl.Location = p;
                    pnlGrid.Controls.Add(pnl);
                    p.X = p.X + 60;
                    m_TicTacToeGame.GameSquares.Add(pnl, new Point(i, j));
                }
                p.X = 1;
                p.Y = p.Y + 60;
            }
        }

        private void SquareClicked(object sender, EventArgs e)
        {
            //Debug.WriteLine("Coord :    X : " + m_TicTacToeGame.GameSquares[((Panel)sender)].X + " Y : " + m_TicTacToeGame.GameSquares[((Panel)sender)].Y);
            //Debug.WriteLine(m_TicTacToeGame.GameSquares.Count);

            m_TicTacToeGame.Play(sender);
            DrawSymbol(sender);
        }

        private void DrawSymbol(object p_Square)
        {
            ((Panel)p_Square).Invalidate();
            m_MoveDone = true;
        }
    
        private void SquarePainted(object sender, PaintEventArgs e)
        {
            Panel currentPanel = (Panel)sender;
            Graphics g = e.Graphics;
            g.DrawLine(Pen, 0, currentPanel.Height - 1, currentPanel.Width - 1, currentPanel.Height - 1);
            g.DrawLine(Pen, currentPanel.Width - 1, currentPanel.Height - 1 , currentPanel.Width - 1, 0);

            if(m_MoveDone)
            {
                if (m_TicTacToeGame.X_Turn)
                {
                    g.DrawLine(Pen, 0, 0, 60, 60);
                    g.DrawLine(Pen, 0, 60, 60, 0);
                }
                else
                {
                    //g.DrawEllipse(Pen, currentPanel.Width / 2, currentPanel.Height / 2, 40, 40);
                    g.DrawEllipse(Pen, 0, 0, 59, 59);
                }

                m_TicTacToeGame.X_Turn = !m_TicTacToeGame.X_Turn;
                m_MoveDone = false;
            }

        }
 

        private void pnlGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;

            graphic.DrawRectangle(Pen, 0, 0, pnlGrid.Width - PEN_SIZE, pnlGrid.Height - PEN_SIZE);
        }

   
    }
}
