using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Random rand = new Random();

        class Rate
        {
            public uint Hit { get; set; }
            public uint Fails { get; set; }
        }

        Rate gameRating = new Rate();

        public Form1()
        {
            InitializeComponent();
        }

        private void hitLabel_Click(object sender, EventArgs e)
        {

        }

        private void failsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            gameRating.Hit++;
            hitLabel.Text = gameRating.Hit.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button.Location = new Point(rand.Next(150, this.Width-150), rand.Next(150, this.Height-150));
            //button.Visible = !button.Visible;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            gameRating.Fails++;
            failsLabel.Text = gameRating.Fails.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics MyForm = this.CreateGraphics();
            LinearGradientBrush linGrBrush = new LinearGradientBrush(new Rectangle(0,0,this.Width, this.Height), Color.Aquamarine, 
                Color.BlanchedAlmond, LinearGradientMode.Horizontal);
            MyForm.FillRectangle(linGrBrush, 0, 0, this.Width, this.Height);
            GraphicsPath myPath = new GraphicsPath();
            MyForm.Dispose();
            myPath.AddEllipse(0, 0, this.button.Width, this.button.Height);
            Region myRegion = new Region(myPath);
            button.Region = myRegion;
            
        }
    }
}
