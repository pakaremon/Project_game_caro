using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PROJECT_CARO_GAME
{
    class CaroChess15x15
    {
        BoardChess15x15 _BC;
        CellChess[,] _CC;
        Pen _p1, _p2;
        Stack<CellChess> _Saved;

        public bool readyPlay { set; get; }

        public CaroChess15x15()
        {
            _BC = new BoardChess15x15();
            _CC = new CellChess[_BC.Rows, _BC.Columns];
            _p1 = new Pen(Color.Gray);
            _p2 = new Pen(Color.Gold);
            _Saved = new Stack<CellChess>();
        }

        //Game mới
        public void _newGames()
        {
            _Saved.Clear();
            //Tạo mới mảng ô cờ
            for (int i = 0; i < _BC.Rows; i++)
            {
                for (int j = 0; j < _BC.Columns; j++)
                {
                    _CC[i, j] = new CellChess(i, j, new Point(j * CellChess.Width, i * CellChess.Height), 0);
                }
            }
        }

        //Vẽ bàn cờ
        public void _drawBoardChess(Graphics g)
        {
            _BC.drawBoard(g, _p1);
            _repaintCellChess(g);
        }

        //Vẽ lại các ô cờ đã đánh
        private void _repaintCellChess(Graphics g)
        {
            if (_Saved.Count > 0)
            {
                foreach (CellChess cc in _Saved)
                {
                    if (cc.Owned == 1)
                        _BC.drawX(g, cc.Position);
                    if (cc.Owned == 2)
                        _BC.drawO(g, cc.Position);
                }
                _BC.lastCell(g, _Saved.Peek().Position, _p2);
            }
        }

        //Đánh cờ
        public bool _playChess(int posRow, int posColumn, Graphics g, int mPiece)
        {
            if (!readyPlay)
                return false;
            //Click vào đường kẻ
            if (posRow % CellChess.Height == 0 || posColumn % CellChess.Width == 0)
                return false;
            int row = posRow / CellChess.Height;
            int column = posColumn / CellChess.Width;
            //Click vào ô cờ đã đánh
            if (_CC[row, column].Owned != 0)
                return false;

            switch (mPiece)
            {
                case 1:
                    _BC.drawX(g, _CC[row, column].Position);
                    _CC[row, column].Owned = 1;
                    break;
                case 2:
                    _BC.drawO(g, _CC[row, column].Position);
                    _CC[row, column].Owned = 2;
                    break;
            }
            //Bỏ tô viền quân cờ trước đó
            if (_Saved.Count > 0)
                _BC.lastCell(g, _Saved.Peek().Position, _p1);
            //Lưu quân cờ vừa đánh
            _Saved.Push(new CellChess(_CC[row, column].Rows, _CC[row, column].Columns, _CC[row, column].Position, _CC[row, column].Owned));
            //Tô viền quân cờ vừa đánh
            _BC.lastCell(g, _Saved.Peek().Position, _p2);
            return true;
        }

        //Đánh lại
        public bool _undoPlay()
        {
            if (_Saved.Count < 2)
                return false;
            CellChess cc = _Saved.Pop();
            _CC[cc.Rows, cc.Columns].Owned = 0;
            return true;
        }

        //Kiểm tra người chiến thằng
        public int _checkWins()
        {
            if (_Saved.Count == _BC.Rows * _BC.Columns)
                return 0;
            foreach (CellChess cc in _Saved)
            {
                bool c1 = _winVertical(cc.Rows, cc.Columns, cc.Owned);
                bool c2 = _winHorizontal(cc.Rows, cc.Columns, cc.Owned);
                bool c3 = _winDiagonal1(cc.Rows, cc.Columns, cc.Owned);
                bool c4 = _winDiagonal2(cc.Rows, cc.Columns, cc.Owned);
                if (c1 || c2 || c3 || c4)
                {
                    if (cc.Owned == 1)
                    {
                        return 1;
                    }
                    if (cc.Owned == 2)
                    {
                        return 2;
                    }
                }
            }
            return -1;
        }

        //Duyệt hàng ngang
        private bool _winHorizontal(int row, int column, int owned)
        {
            if (row + 5 > _BC.Rows)
                return false;
            for (int d = 1; d < 5; d++)
            {
                if (_CC[row + d, column].Owned != owned)
                    return false;
            }
            if (row == 0 || row + 5 == _BC.Rows)
                return true;
            if (_CC[row - 1, column].Owned == 0 || _CC[row + 5, column].Owned == 0)
                return true;
            if (_CC[row - 1, column].Owned == owned || _CC[row + 5, column].Owned == owned)
                return true;
            return false;
        }

        //Duyệt hàng dọc
        private bool _winVertical(int row, int column, int owned)
        {
            if (column + 5 > _BC.Columns)
                return false;
            for (int d = 1; d < 5; d++)
            {
                if (_CC[row, column + d].Owned != owned)
                    return false;
            }
            if (column == 0 || column + 5 == _BC.Columns)
                return true;
            if (_CC[row, column - 1].Owned == 0 || _CC[row, column + 5].Owned == 0)
                return true;
            if (_CC[row, column - 1].Owned == owned || _CC[row, column + 5].Owned == owned)
                return true;
            return false;
        }

        //Duyệt đường chéo chính
        private bool _winDiagonal1(int row, int column, int owned)
        {
            if (row + 5 > _BC.Rows || column + 5 > _BC.Columns)
                return false;
            for (int d = 1; d < 5; d++)
            {
                if (_CC[row + d, column + d].Owned != owned)
                    return false;
            }
            if (row == 0 || row + 5 == _BC.Rows || column == 0 || column + 5 == _BC.Columns)
                return true;
            if (_CC[row - 1, column - 1].Owned == 0 || _CC[row + 5, column + 5].Owned == 0)
                return true;
            if (_CC[row - 1, column - 1].Owned == owned || _CC[row + 5, column + 5].Owned == owned)
                return true;
            return false;
        }

        //Duyệt đường chéo phụ
        private bool _winDiagonal2(int row, int column, int owned)
        {
            if (row < 4 || column + 5 > _BC.Columns)
                return false;
            for (int d = 1; d < 5; d++)
            {
                if (_CC[row - d, column + d].Owned != owned)
                    return false;
            }
            if (row == 4 || row == _BC.Rows - 1 || column == 0 || column + 5 == _BC.Columns)
                return true;
            if (_CC[row + 1, column - 1].Owned == 0 || _CC[row - 5, column + 5].Owned == 0)
                return true;
            if (_CC[row + 1, column - 1].Owned == owned || _CC[row - 5, column + 5].Owned == owned)
                return true;
            return false;
        }


        
        //Phần dành cho PC
        int a4d0, a4d1, a3d0, a3d1, a2d0, a2d1, a1d0, a1d1;

        private void _resetCount()
        {
            a4d0 = 0; a4d1 = 0; a3d0 = 0; a3d1 = 0; a2d0 = 0; a2d1 = 0; a1d0 = 0; a1d1 = 0;
        }

        public void _Computer(Graphics g, int owned)
        {
            readyPlay = true;
            if (_Saved.Count == 0)
            {
                _playChess(_BC.Columns / 2 * CellChess.Width + 2, _BC.Rows / 2 * CellChess.Height + 2, g, owned);
            }
            else
            {
                CellChess cc = _findPlay(owned);
                _playChess(cc.Position.Y + 2, cc.Position.X + 2, g, owned);
            }
        }

        //PC tìm kiếm nước đi
        private CellChess _findPlay(int owned)
        {
            CellChess cc = new CellChess();
            List<int[]> pp = new List<int[]>();
            int max = 0;
            for (int i = 0; i < _BC.Rows; i++)
            {
                for (int j = 0; j < _BC.Columns; j++)
                {
                    if (_CC[i, j].Owned == 0)
                    {
                        //PC tấn công
                        _resetCount();
                        _aodH(i, j, owned, true); _aodV(i, j, owned, true); _aodD1(i, j, owned, true); _aodD2(i, j, owned, true);
                        int attackScore = _attScore(new int[] { a4d0, a4d1, a3d0, a3d1, a2d0, a2d1, a1d0, a1d1 });

                        //PC phòng thủ
                        _resetCount();
                        _aodH(i, j, owned, false); _aodV(i, j, owned, false); _aodD1(i, j, owned, false); _aodD2(i, j, owned, false);
                        int defendScore = _defScore(new int[] { a4d0, a4d1, a3d0, a3d1, a2d0, a2d1, a1d0, a1d1 });

                        int temp = attackScore > defendScore ? attackScore : defendScore;
                        if (max < temp)
                        {
                            max = temp;
                            cc = new CellChess(_CC[i, j].Rows, _CC[i, j].Columns, _CC[i, j].Position, _CC[i, j].Owned);
                            pp.Clear();
                        }
                        else if (max == temp && max > 0)
                        {
                            pp.Add(new int[] { i, j });
                        }
                    }
                }
            }
            //PC đánh random các vị trí có điểm bằng nhau
            if (pp.Count > 1)
            {
                int[] x = pp[new Random().Next(pp.Count)] as int[];
                cc = new CellChess(_CC[x[0], x[1]].Rows, _CC[x[0], x[1]].Columns, _CC[x[0], x[1]].Position, 0);
            }
            pp.Clear();

            //duyệt lần 2 với 1 ô trống
            for (int i = 0; i < _BC.Rows; i++)
            {
                for (int j = 0; j < _BC.Columns; j++)
                {
                    if (_CC[i, j].Owned == 0)
                    {
                        //tấn công
                        _resetCount();
                        _aodH(i, j, owned, true, true); _aodV(i, j, owned, true, true); _aodD1(i, j, owned, true, true); _aodD2(i, j, owned, true, true);
                        int attackScore = _attScore(new int[] { a4d0, a4d1, a3d0, a3d1, a2d0, a2d1, a1d0, a1d1 }, true);

                        //phòng thủ
                        _resetCount();
                        _aodH(i, j, owned, false, true); _aodV(i, j, owned, false, true); _aodD1(i, j, owned, false, true); _aodD2(i, j, owned, false, true);
                        int defendScore = _defScore(new int[] { a4d0, a4d1, a3d0, a3d1, a2d0, a2d1, a1d0, a1d1 }, true);

                        int temp = attackScore > defendScore ? attackScore : defendScore;
                        if (max < temp)
                        {
                            max = temp;
                            cc = new CellChess(_CC[i, j].Rows, _CC[i, j].Columns, _CC[i, j].Position, _CC[i, j].Owned);
                        }
                    }
                }
            }
            return cc;
        }
        
        //PC tính điểm tấn công
        private int _attScore(int[] ar, bool space = false)
        {
            int total = 0;
            if (!space)
            {
                if (ar[0] >= 1) return 300;
                if (ar[1] >= 1) return 280;

                if (ar[7] >= 1) total = 20;
                if (ar[6] >= 1) total = 20;
                if (ar[5] >= 1) total = 20;
                if (ar[4] == 1) total = 40;
                if (ar[3] == 1 && ar[6] >= 1) total = 60;
                if (ar[4] == 1 && ar[5] >= 1) total = 60;
                if (ar[4] == 1 && ar[6] >= 1) total = 60;

                if (ar[4] >= 2) total = 100;
                if (ar[3] == 1 && ar[4] >= 1) total = 120;
                if (ar[2] == 1 && ar[4] >= 1) total = 120;
                if (ar[2] == 1) total = 140;
                if (ar[2] == 1 && ar[3] == 1) total = 160;
                if (ar[3] >= 2) total = 180;
                if (ar[2] >= 2) total = 180;
            }
            else
            {
                if (ar[4] >= 2) total = 100;
                if (ar[3] == 1 && ar[4] >= 1) total = 120;
                if (ar[2] == 1 && ar[4] >= 1) total = 120;
                if (ar[2] == 1 && ar[3] == 1) total = 160;
                if (ar[3] >= 2) total = 180;
                if (ar[2] >= 2) total = 180;
            }
            return total;
        }

        //Tính điểm phòng thủ
        private int _defScore(int[] ar, bool space = false)
        {
            int total = 0;
            if (!space)
            {
                if (ar[0] >= 1) return 290;
                if (ar[1] >= 1) return 270;

                if (ar[7] >= 1) total = 20;
                if (ar[6] >= 1) total = 20;
                if (ar[5] >= 1) total = 20;
                if (ar[4] == 1) total = 30;
                if (ar[3] == 1 && ar[6] >= 1) total = 50;
                if (ar[4] == 1 && ar[5] >= 1) total = 50;
                if (ar[4] == 1 && ar[6] >= 1) total = 50;

                if (ar[4] >= 2) total = 90;
                if (ar[3] == 1 && ar[4] >= 1) total = 110;
                if (ar[2] == 1 && ar[4] >= 1) total = 110;
                if (ar[2] == 1) total = 130;
                if (ar[2] == 1 && ar[3] == 1) total = 150;
                if (ar[3] >= 2) total = 170;
                if (ar[2] >= 2) total = 170;
            }
            else
            {
                if (ar[4] >= 2) total = 100;
                if (ar[3] == 1 && ar[4] >= 1) total = 120;
                if (ar[2] == 1 && ar[4] >= 1) total = 120;
                if (ar[2] == 1 && ar[3] == 1) total = 160;
                if (ar[3] >= 2) total = 180;
                if (ar[2] >= 2) total = 180;
            }
            return total;
        }

        //Đếm các quân cờ để sau đó tính điểm
        private void _countPiece(int a, int d)
        {
            if (a >= 4 && d == 0) a4d0 += 1;
            if (a >= 4 && d == 1) a4d1 += 1;
            if (a == 3 && d == 0) a3d0 += 1;
            if (a == 3 && d == 1) a3d1 += 1;
            if (a == 2 && d == 0) a2d0 += 1;
            if (a == 2 && d == 1) a2d1 += 1;
            if (a == 1 && d == 0) a1d0 += 1;
            if (a == 1 && d == 1) a1d1 += 1;
        }

        //PC duyệt hàng ngang
        private void _aodH(int row, int column, int owned, bool attack, bool space = false)
        {
            int att = 0, def = 0, spc = 0;
            int chk;
            for (int d = 1; d < 6 && (column + d) < _BC.Columns; d++)
            {
                chk = _CC[row, column + d].Owned;
                if (chk != 0 && chk == owned)
                {
                    att += 1;
                    if (!attack)
                        break;
                }
                else if (chk != 0 && chk != owned)
                {
                    def += 1;
                    if (attack)
                        break;
                }
                else
                {
                    if (space)
                    {
                        spc += 1;
                        if (spc == 2)
                        {
                            spc = 0;
                            break;
                        }
                    }
                    else
                        break;
                }
            }
            for (int d = 1; d < 6 && (column - d) >= 0; d++)
            {
                chk = _CC[row, column - d].Owned;
                if (chk != 0 && chk == owned)
                {
                    att += 1;
                    if (!attack)
                        break;
                }
                else if (chk != 0 && chk != owned)
                {
                    def += 1;
                    if (attack)
                        break;
                }
                else
                {
                    if (space)
                    {
                        spc += 1;
                        if (spc == 2)
                        {
                            spc = 0;
                            break;
                        }
                    }
                    else
                        break;
                }
            }
            if (attack && def < 2)
                _countPiece(att, def);
            else if (!attack && att < 2)
                _countPiece(def, att);
        }

        //PC duyệt hàng dọc
        private void _aodV(int row, int column, int owned, bool attack, bool space = false)
        {
            int att = 0, def = 0, spc = 0;
            int chk;
            for (int d = 1; d < 6 && (row + d) < _BC.Rows; d++)
            {
                chk = _CC[row + d, column].Owned;
                if (chk != 0 && chk == owned)
                {
                    att += 1;
                    if (!attack)
                        break;
                }
                else if (chk != 0 && chk != owned)
                {
                    def += 1;
                    if (attack)
                        break;
                }
                else
                {
                    if (space)
                    {
                        spc += 1;
                        if (spc == 2)
                        {
                            spc = 0;
                            break;
                        }
                    }
                    else
                        break;
                }
            }
            for (int d = 1; d < 6 && (row - d) >= 0; d++)
            {
                chk = _CC[row - d, column].Owned;
                if (chk != 0 && chk == owned)
                {
                    att += 1;
                    if (!attack)
                        break;
                }
                else if (chk != 0 && chk != owned)
                {
                    def += 1;
                    if (attack)
                        break;
                }
                else
                {
                    if (space)
                    {
                        spc += 1;
                        if (spc == 2)
                        {
                            spc = 0;
                            break;
                        }
                    }
                    else
                        break;
                }
            }
            if (attack && def < 2)
                _countPiece(att, def);
            else if (!attack && att < 2)
                _countPiece(def, att);
        }

        //PC duyệt chéo xuôi
        private void _aodD1(int row, int column, int owned, bool attack, bool space = false)
        {
            int att = 0, def = 0, spc = 0;
            int chk;
            for (int d = 1; d < 6 && (row + d) < _BC.Rows && (column + d) < _BC.Columns; d++)
            {
                chk = _CC[row + d, column + d].Owned;
                if (chk != 0 && chk == owned)
                {
                    att += 1;
                    if (!attack)
                        break;
                }
                else if (chk != 0 && chk != owned)
                {
                    def += 1;
                    if (attack)
                        break;
                }
                else
                {
                    if (space)
                    {
                        spc += 1;
                        if (spc == 2)
                        {
                            spc = 0;
                            break;
                        }
                    }
                    else
                        break;
                }
            }
            for (int d = 1; d < 6 && (row - d) >= 0 && (column - d) >= 0; d++)
            {
                chk = _CC[row - d, column - d].Owned;
                if (chk != 0 && chk == owned)
                {
                    att += 1;
                    if (!attack)
                        break;
                }
                else if (chk != 0 && chk != owned)
                {
                    def += 1;
                    if (attack)
                        break;
                }
                else
                {
                    if (space)
                    {
                        spc += 1;
                        if (spc == 2)
                        {
                            spc = 0;
                            break;
                        }
                    }
                    else
                        break;
                }
            }
            if (attack && def < 2)
                _countPiece(att, def);
            else if (!attack && att < 2)
                _countPiece(def, att);
        }

        //PC duyệt chéo ngược
        private void _aodD2(int row, int column, int owned, bool attack, bool space = false)
        {
            int att = 0, def = 0, spc = 0;
            int chk;
            for (int d = 1; d < 6 && (row - d) >= 0 && (column + d) < _BC.Columns; d++)
            {
                chk = _CC[row - d, column + d].Owned;
                if (chk != 0 && chk == owned)
                {
                    att += 1;
                    if (!attack)
                        break;
                }
                else if (chk != 0 && chk != owned)
                {
                    def += 1;
                    if (attack)
                        break;
                }
                else
                {
                    if (space)
                    {
                        spc += 1;
                        if (spc == 2)
                        {
                            spc = 0;
                            break;
                        }
                    }
                    else
                        break;
                }
            }
            for (int d = 1; d < 6 && (row + d) < _BC.Rows && (column - d) >= 0; d++)
            {
                chk = _CC[row + d, column - d].Owned;
                if (chk != 0 && chk == owned)
                {
                    att += 1;
                    if (!attack)
                        break;
                }
                else if (chk != 0 && chk != owned)
                {
                    def += 1;
                    if (attack)
                        break;
                }
                else
                {
                    if (space)
                    {
                        spc += 1;
                        if (spc == 2)
                        {
                            spc = 0;
                            break;
                        }
                    }
                    else
                        break;
                }
            }
            if (attack && def < 2)
                _countPiece(att, def);
            else if (!attack && att < 2)
                _countPiece(def, att);
        }
    }
}

