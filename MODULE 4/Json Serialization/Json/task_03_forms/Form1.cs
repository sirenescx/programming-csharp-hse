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

namespace task_03_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<MyColor> colors = new List<MyColor>();
            using (StreamReader sr = new StreamReader("../../css-color-names.json"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var tmp = sr.ReadLine();
                    if (tmp == "}") break;
                    var colorInfo = tmp.Split(':');
                    colorInfo[0] = colorInfo[0].Trim();
                    colorInfo[0] = colorInfo[0].Trim('"');
                    colorInfo[1] = colorInfo[1].Trim();
                    colorInfo[1] = colorInfo[1].Trim('"', ',');
                    colors.Add(new MyColor(colorInfo[0], colorInfo[1]));
                }
            };
            dataGridView1.RowCount = colors.Count();
            for (int i = 0; i < colors.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.FromArgb(colors[i].R, colors[i].G, colors[i].B);
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

        public MyColor(string name, string hex)
        {
            this.name = name;
            List<byte> RGB = HEXtoRGB(hex);
            R = RGB[0];
            G = RGB[1];
            B = RGB[2];
        }

        public List<byte> HEXtoRGB(string hex)
        {
            List<byte> RGB = new List<byte>();
            hex = hex.TrimStart('#');
            string rhex, ghex, bhex;
            rhex = hex.Substring(0, 2);
            ghex = hex.Substring(2, 2);
            bhex = hex.Substring(4, 2);
            RGB.Add(Convert.ToByte(rhex, 16));
            RGB.Add(Convert.ToByte(ghex, 16));
            RGB.Add(Convert.ToByte(bhex, 16));
            return RGB;
        }
        public override string ToString() => $"Color {name}, (R, G, B) = ({R}, {G}, {B})";
    }
}
