using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_01
{
    public partial class Form1 : Form
    {
        string result;
        public Form1()
        {
            InitializeComponent();
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
            this.FormClosed += Form1_FormClosed;
            this.FormClosing += Form1_FormClosing;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.Resize += Form1_Resize;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Text = "Form1_Activated";
            result += "\nActivated";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Text = "Form1_Deactivate";
            result += "\nDeactivate";
        }

        private void Form1_FormClosed(object sender, EventArgs e)
        {
            this.Text = "Form1_FormClosed";
            result += "\nFormClosed";
            MessageBox.Show(result);
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            this.Text = "Form1_FormClosing";
            result += "\nFormClosing";
            MessageBox.Show("FormClosing event");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Form1_Load";
            result += "\nLoad";
            MessageBox.Show("Load event");
        }

        private void Form1_Paint(object sender, EventArgs e)
        {
            this.Text = "Form1_Paint";
            result += "\nPaint";
            MessageBox.Show("Paint event");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Text = "Form1_Resize";
            result += "\nResize";
            MessageBox.Show("Resize event");
        }
    }
}
