using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PROJECT_CARO_GAME
{
    class CellChess
    {
        //Mỗi CellChess sẽ có kích thước là rộng 27, dài 27
        public const int Width = 27, Height = 27;
        public int Rows { set; get; }
        public int Columns { set; get; }
        public int Owned { set; get; }
        public Point Position { set; get; }

        public CellChess()
        {

        }

        public CellChess(int rows, int columns, Point position, int owned)
        {
            Rows = rows;
            Columns = columns;
            Position = position;
            Owned = owned;
        }
    }
}
