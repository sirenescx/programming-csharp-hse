using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02
{
    public delegate double ExpDel(double x);
    public delegate void ExpChanged();
    class Expression
    {
        ExpDel ex;

        public Expression(ExpDel ex)
        {
            this.ex = ex;
        }

        public event ExpChanged OnExpChanged;

        public double ExVal(double x)
        {
            return ex(x);
        }

        public ExpDel Ex { set { ex = value; OnExpChanged(); } }
    }

    class ValueStore
    {
        Expression exp;
        double x0;
        double expCurValue;

        public ValueStore(Expression exp, double x0)
        {
            this.exp = exp;
            this.x0 = x0;
            expCurValue = exp.ExVal(x0);
        }

        public double CurVal { get { return expCurValue; } }

        public void OnExpChangedHandler()
        {
            expCurValue = exp.ExVal(x0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Expression me = new Expression(x => { return x * x + 2 * x - 3; });
            ValueStore vs = new ValueStore(me, 0);
            me.OnExpChanged += vs.OnExpChangedHandler;
            Console.WriteLine(vs.CurVal);
            // изменяем выражение:
            me.Ex = x => { return Math.Sqrt(Math.Abs(x)); };
            Console.WriteLine(vs.CurVal);
            me.Ex = x => { return Math.Sin(x); };
            Console.WriteLine(vs.CurVal);
            me.Ex = x => { return x * x * x - 1; };
            Console.WriteLine(vs.CurVal);
        }
    }
}
