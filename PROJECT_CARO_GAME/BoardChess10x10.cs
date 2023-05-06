using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace PROJECT_CARO_GAME
{
    class BoardChess10x10
    {
        public int Rows { set; get; }
        public int Columns { set; get; }

        Image ChessPieceX, ChessPieceO;

        //BoardChess kích thước 10x10
        public BoardChess10x10()
        {
            Rows = 10;
            Columns = 10;

            ChessPieceO = new Bitmap(Properties.Resources.o, CellChess.Width - 1, CellChess.Height - 1);
            ChessPieceX = new Bitmap(Properties.Resources.x, CellChess.Width - 1, CellChess.Height - 1);
        }

        //Vẽ quân cờ X
        public void drawX(Graphics g, Point p)
        {
            g.DrawImage(ChessPieceX, p.X + 1, p.Y + 1);
        }

        //Vẽ quân cờ O
        public void drawO(Graphics g, Point p)
        {
            g.DrawImage(ChessPieceO, p.X + 1, p.Y + 1);
        }

        //Vẽ bàn cờ
        public void drawBoard(Graphics g, Pen p)
        {
            for (int i = 0; i <= Rows; i++)
            {
                g.DrawLine(p, 0, i * CellChess.Height, Columns * CellChess.Width, i * CellChess.Height);
            }
            for (int i = 0; i <= Columns; i++)
            {
                g.DrawLine(p, i * CellChess.Width, 0, i * CellChess.Width, Rows * CellChess.Height);
            }
        }

        //Quân cờ vừa đánh
        public void lastCell(Graphics g, Point po, Pen pe)
        {
            g.DrawRectangle(pe, po.X, po.Y, CellChess.Width, CellChess.Height);
        }
    }
}
