using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Form1 : Form
    {
        Bird bird;
        Colums col1;
        Colums col2;
        Colums col3;

        public Form1()
        {
            InitializeComponent();
            definBird();
            defineColums();
           
        }

        void definBird() {
            PictureBox tempBird = new PictureBox();
            tempBird.Location = new System.Drawing.Point(50,129);
            tempBird.Image = new Bitmap(Application.StartupPath + @"./bird.gif");
            tempBird.SizeMode = PictureBoxSizeMode.AutoSize;
            tempBird.BackColor = Color.Transparent;
            panel1.Controls.Add(tempBird);
            bird = new Bird(tempBird);
        }

        void defineColums()
        {
           col1 =  defineColum(300);
           col2 =  defineColum(col1.getColBotom().Location.X+col1.getColBotom().Width+ 100);
           col3 = defineColum(col2.getColBotom().Location.X + col2.getColBotom().Width + 100);
        }

        Random rd = new Random();
        Colums defineColum(int distance)
        {

            PictureBox colBotom = new PictureBox();
            colBotom.Location = new System.Drawing.Point(distance, rd.Next(110, 234));
            colBotom.Image = new Bitmap(Application.StartupPath + @"./cotDuoi.png");
            colBotom.SizeMode = PictureBoxSizeMode.AutoSize;
            colBotom.BackColor = Color.Transparent;
            panel1.Controls.Add(colBotom);

            PictureBox colTop = new PictureBox();
            colTop.Image = new Bitmap(Application.StartupPath + @"./cotTren.png");
            colTop.SizeMode = PictureBoxSizeMode.AutoSize;
            colTop.BackColor = Color.Transparent;
            panel1.Controls.Add(colTop);

            Colums col = new Colums(colTop, colBotom);
            return col;
        }

        private void timerOfBird_Tick(object sender, EventArgs e)
        {
            birImpact();
            bird.getBird().Top += 3;
            checkImpactBase();
        }
        private void timerColum_Tick(object sender, EventArgs e)
        {
            columMove(col1);
            columMove(col2);
            columMove(col3);

            circleLifeColums(col3,col1);
            circleLifeColums(col1, col2);
            circleLifeColums(col2, col3);
        }

        void columMove(Colums col)
        {
            col.getColBotom().Left -= 1;
            col.getColTop().Left -= 1;
        }

        int pointBrefore;
        PictureBox temp;
        void circleLifeColums(Colums before, Colums current)
        {
            pointBrefore = before.getColBotom().Location.X + before.getColBotom().Width+100;
            if (current.getColBotom().Location.X + 43 <= 0)
            {
                temp = current.getColBotom();
                temp.Location = new Point(pointBrefore, rd.Next(110, 234));

                current.setColBotom(temp);
            }
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            bird.getBird().Top -= 40;
        }
        
         void checkImpactBase()
        {
             int heightBird = bird.getBird().Height;
             if (bird.getBird().Location.Y + heightBird >= ptBase.Location.Y) {
                 timerOfBird.Enabled = false;
                 timerColum.Enabled = false;
             }
        }

         int birdX,birdY,colTopX,colTopY,colBotomX,colBotomY;
         void checkBirdImpact( Colums colTemp)
         {
             //Lấy chim ra
             birdX = bird.getBird().Location.X;
              birdY = bird.getBird().Location.Y;

             //Cột dưới
             colBotomX = colTemp.getColBotom().Location.X;
             colBotomY = colTemp.getColBotom().Location.Y;

             if(
                 (colBotomX <= birdX + 33 && birdY+28 >=colBotomY) &&
                    birdX <= colBotomX+43
                ){
                    timerColum.Enabled = false;
                    timerOfBird.Enabled = false;
                 }
                //Cột trên
             colTopX = colTemp.getColTop().Location.X;
             colTopY = colTemp.getColTop().Location.Y;

             if (
                 (colTopX <= birdX + 33 && birdY  <= colTopY + colTemp.getColTop().Height) &&
                    birdX <= colTopX + 43
                )
             {
                 timerColum.Enabled = false;
                 timerOfBird.Enabled = false;
             }
         }
         void birImpact() {
             checkBirdImpact(col1);
             checkBirdImpact(col2);
             checkBirdImpact(col3);
         }



    }
}
