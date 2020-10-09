using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    class Bird
    {
        PictureBox bird;
        public Bird(PictureBox bird)
        {
            this.bird = bird;
        }

        public PictureBox getBird() { return bird; }
        public void setBird(PictureBox bird) { this.bird = bird; }
    }
}
