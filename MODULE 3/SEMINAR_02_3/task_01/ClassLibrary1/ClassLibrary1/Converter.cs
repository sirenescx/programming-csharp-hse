using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib1
{
    public delegate string ConvertRule(string x);
    public class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }
}
