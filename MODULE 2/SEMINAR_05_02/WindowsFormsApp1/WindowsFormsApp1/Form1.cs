using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = label1.Text;
            int v = int.Parse(txt);
            label1.Text = (++v).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);
            uint color = 1231243 + 0xFF000000;
            //Color cl = Color.FromArgb((int)color);
            Color c = Color.FromArgb(r, g, b);
            this.BackColor = c;
            //цвет - одно число типа инт;
            //this.BackColor = cl;

        }

        int x, y, xC, yC;

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            x = button.Location.X;
            y = button.Location.Y;
            xC = e.X;
            yC = e.Y;


        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            int dx = e.X - xC,
                dy = e.Y - yC;
            button.Location = new Point(Math.Max(x + dx, 0), Math.Max(y + dy, 0));
        }
    }
}
