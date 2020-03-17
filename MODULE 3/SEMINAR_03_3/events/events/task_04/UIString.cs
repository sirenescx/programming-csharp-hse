using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_04
{
    public class UIString
    {
        string str = "Default text";
        public string Str { get => str;  set => str = value; }
        public void NewStringValueHappenedHandler(string s)
        {
            Str = s;
        } 

    }
}
