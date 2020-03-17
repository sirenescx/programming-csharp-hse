using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace task_05
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            List<MyColor> colors = new List<MyColor>();
            using (StreamReader sr = new StreamReader("../../colors.json"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var tmp = sr.ReadLine();
                    if (tmp == "}") break;
                    var colorInfo = tmp.Split(':');
                    colorInfo[0] = colorInfo[0].Trim();
                    colorInfo[0] = colorInfo[0].Trim('"');
                    colors.Add(new MyColor(colorInfo[0], colorInfo[1]));
                }
            };
            dataGridView1.RowCount = colors.Count();
            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i].alpha == 0) dataGridView1.Rows[i].Cells[0].Style.SelectionBackColor = Color.Transparent;
                else

                dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.FromArgb(colors[i].R, colors[i].G, colors[i].B, colors[i].alpha);
            }
        }
    }

    [Serializable]
    public class MyColor
    {
        public MyColor() { }

        public string name;
        public byte R;
        public byte G;
        public byte B;
        public byte alpha;

        public MyColor(string name, string argb)
        {
            this.name = name;
            List<byte> ARGB = StringToARGB(argb);
            R = ARGB[0];
            G = ARGB[1];
            B = ARGB[2];
            alpha = ARGB[3];
        }

        public List<byte> StringToARGB(string argb)
        {
            List<byte> argbList = new List<byte>();
            if (argb.EndsWith(","))
                argb = argb.TrimEnd(',');
            argb = argb.Trim();
            argb = argb.Trim(']', '[');
            var argbStrings = argb.Split(',');
            foreach (var component in argbStrings)
            {
                argbList.Add(byte.Parse(component));
            }
            return argbList;
        }

        public override string ToString() => $"Color {name}, (R, G, B, alpha) = ({R}, {G}, {B}, {alpha})";
    }
}
