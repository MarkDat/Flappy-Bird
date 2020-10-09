namespace Flappy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptBase = new System.Windows.Forms.PictureBox();
            this.timerOfBird = new System.Windows.Forms.Timer(this.components);
            this.timerColum = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ptBase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 329);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // ptBase
            // 
            this.ptBase.Image = ((System.Drawing.Image)(resources.GetObject("ptBase.Image")));
            this.ptBase.Location = new System.Drawing.Point(0, 259);
            this.ptBase.Name = "ptBase";
            this.ptBase.Size = new System.Drawing.Size(300, 70);
            this.ptBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBase.TabIndex = 0;
            this.ptBase.TabStop = false;
            // 
            // timerOfBird
            // 
            this.timerOfBird.Enabled = true;
            this.timerOfBird.Interval = 20;
            this.timerOfBird.Tick += new System.EventHandler(this.timerOfBird_Tick);
            // 
            // timerColum
            // 
            this.timerColum.Enabled = true;
            this.timerColum.Interval = 5;
            this.timerColum.Tick += new System.EventHandler(this.timerColum_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 329);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptBase;
        private System.Windows.Forms.Timer timerOfBird;
        private System.Windows.Forms.Timer timerColum;
    }
}

