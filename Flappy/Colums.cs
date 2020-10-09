using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    class Colums
    {
        PictureBox colTop;
        PictureBox colBotom;
        private int distance = 100;
        public Colums(PictureBox colTop, PictureBox colBotom)
        {
            this.colTop = colTop;
            this.colBotom = colBotom;
            this.colTop.Location = new Point(
                    colBotom.Location.X, colBotom.Location.Y - 100 - colTop.Height
                );
        }

        public PictureBox getColTop() { return this.colTop; }
        public PictureBox getColBotom() { return this.colBotom; }

       // public void setColTop(PictureBox colTop) { this.colTop = colTop; }
        public void setColBotom(PictureBox colBotom) { this.colBotom = colBotom;
                 this.colTop.Location = new Point(
                    colBotom.Location.X, colBotom.Location.Y - 100 - colTop.Height
                 );
        }

        public int getDistance() { return this.distance; }

        public void setDistance(int distance) { this.distance = distance; }
    }
}
