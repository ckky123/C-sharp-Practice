﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gomoku
{
    class Piece:PictureBox
    {
        public Piece(int x, int y)
        {
            this.BackColor= Color.Transparent;
            this.Location= new Point(x,y);
            this.Size= new Size(50,50);
        }
    }
}
