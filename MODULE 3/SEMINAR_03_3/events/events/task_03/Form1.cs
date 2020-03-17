using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_03
{

    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        static int counter;
        public Form1()
        {
            InitializeComponent();
            this.MouseEnter += (object sender, EventArgs e) =>
            {
                this.Text = ("My Form " + counter++);
                this.BackColor = DefaultBackColor;
            };

            this.MouseClick += (object sender, MouseEventArgs e) =>
            {
                this.BackColor = Color.Red;
            };

            this.MouseDoubleClick += (object sender, MouseEventArgs e) =>
            {
                this.Width = rnd.Next(100, 1000);
                this.Height = rnd.Next(100, 1000);
            };


        }
    }
}
