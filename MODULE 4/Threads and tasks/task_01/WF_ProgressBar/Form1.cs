using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WF_ProgressBar
{
    public partial class Form1 : Form
    {
        static BackgroundWorker backgroundWorker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker.WorkerReportsProgress = true;
        }

        public static Random random = new Random();
        public static double DoubleRandom(double a, double b)
        {
            return ((b - a) * random.NextDouble() + a);
        }

        static int Count(int n, int i, int j)
        {
            int count = 0;
            double x, y;
            if ((i == 0 & j == 0) || (i == 0 & j == 1) || (i == 1 & j == 0) || (i == 1 & j == 1)) count += n / 9;
            else
            {
                for (int k = 0; k < n / 9; k++)
                {
                    x = DoubleRandom(i / 3.0, (i + 1) / 3.0);
                    y = DoubleRandom(j / 3.0, (j + 1) / 3.0);
                    if (x * x + y * y <= 1)
                    {
                        count++;
                    }
                    Report(k, n / 9);
                }
            }
            return count;
        }


        public static void Report(int k, int n)
        {
            backgroundWorker.ReportProgress(k * 100 / n);
        }

        static async Task<int> CountAsync(int n, BackgroundWorker worker)
        {
            Random rnd = new Random();
            int res = 0;

            Task<int>[] tasks = new Task<int>[9];
            for (int i = 0; i < 3; i++)
            {
                var i_c = i;
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var index = (i * 3) + j;
                        var j_c = j;
                        tasks[index] = Task.Run(() => Count(n, i_c, j_c));
                    }
                }
            }

            int[] results = await Task.WhenAll(tasks);

            foreach (var i in results)
            {
                res += i;
            }

            return res;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            this.progressBar1.BeginInvoke(new Action((delegate () { this.progressBar1.Value = e.ProgressPercentage; })));
            Task.Delay(1);
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            int n = 10000000;
            var val = await CountAsync(n, backgroundWorker);

            label2.Text = (4.0 * val / n).ToString();
        }
    }
}

