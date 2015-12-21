using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace mvvm.Model
{
   public class Chart
    {
        public static PointCollection AddSimplePoints()
        {
            PointCollection ex = new PointCollection();
            double y;
            for (int i = -1000; i <= 1000; i++)
            {
                y = -i;
                ex.Add(new Point(i + 500, y + 500));
            }
            return ex;
        }

        public static double GetValueOfArg(PointCollection pc,double arg)
        {
            double q=0;
            if (pc != null)
            {
                foreach (Point p in pc)
                {
                    if (Math.Round(p.X, 2) == arg * 10 + 200) q = -(p.Y - 200) / 10;
                }
                return Math.Round(q,3);
            }
            else return 0;
        }

    }
}
