using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Block
    {
        Rectangle blockBase;
        double h;
        double oldSquare { get; set; }
        public Block(Rectangle blockBase, double h)
        {
            this.blockBase = blockBase;
            this.h = h;
            oldSquare = this.blockBase.GetS;
        }

        public Rectangle BlockBase { get => blockBase; set => blockBase = value; }
        public double H { get => h; set => h = value; }
        public double GetV()
        {
            return h * blockBase.GetS;
        }

        public void OnSideChanged(object sender, MyArgs args)
        {
            Console.WriteLine(args.info);
            // Изменение
            double delta = blockBase.GetS / oldSquare;
            // Сохранение нового значения площади для последующего сравнения
            oldSquare = blockBase.GetS;
            Console.WriteLine($"Высота изменилась с {h:f2} до {h * delta:f2} в {delta:f2} раз");
            H *= delta;
        }

    }
}
