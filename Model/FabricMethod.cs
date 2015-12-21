using mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using mvvm.Model;
namespace mvvm
{
   public abstract class FunctionBase
    {
       public string Name { get; set; }
       public  double XMin { get; set; }
       public  double   XMax { get; set; }
       abstract public   PointCollection GetChart(Double min,Double max);     
    }
    
    class Sin : FunctionBase
    {
        public  override PointCollection GetChart(Double min,Double max )
        {
          PointCollection ex = new PointCollection();
            double y;
            for (double i = 10*min; i <=10*max; i++)
            {
                y = -10 * Math.Sin(0.1 * i);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
        public Sin()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "SIN(X)";
        }        
    }
    class Cos : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            PointCollection ex = new PointCollection();
            double y;
            for (double i = 10 * min; i <= 10*max; i++)
            {
                y = -10 * Math.Cos(0.1 * i);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
           public Cos()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "COS(X)";
        }        
    }
    class Pow2 : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            PointCollection ex = new PointCollection();
            double y;
            for (double i = 10 * min; i <= 10*max; i++)
            {
                y = -10 * Math.Pow(0.1 * i,2);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }              
        public Pow2()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "X^2";
        }     
    }
    class Pow3 : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            PointCollection ex = new PointCollection();
            double y;
            for (double i = 10 * min; i <= 10*max; i++)
            {
                y = -10 * Math.Pow(0.1 * i,3);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
                
        public Pow3()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "X^3";
        }     
    }
    class Pow4 : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            PointCollection ex = new PointCollection();
            double y;
            for (double i= 10 * min; i <= 10*max; i++)
            {
                y = -10 * Math.Pow(0.1 * i, 4);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
          public Pow4()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "X^4";
        }   
    }
    class Tan : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            PointCollection ex = new PointCollection();
            double y;
            for (double i = 10 * min; i <= 10*max; i+=0.1)
            {                
                y = -10 * Math.Tan(0.1 * i);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
          public Tan()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "TAN(X)";
        }   
    }
    class Sqrt : FunctionBase
    {
        public  override PointCollection GetChart(Double min,Double max)
        {
            PointCollection ex = new PointCollection();
            if (min < 0) MessageBox.Show("Argument Error");
            double y;
            for (double i = 10 * min; i <= 10*max; i++)
            {
                y = -10 * Math.Sqrt(0.1 * i);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
         public Sqrt()
        {
            XMin = 0;
            XMax = 1000;
            Name = "SQRT(X)";
        }   
    }   
    class Ln : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            if (min < 0)
            {
                MessageBox.Show("Argument Error");
                return null;
            }
            else
            {
                PointCollection ex = new PointCollection();
                double y;
                for (double i = 10 * (min+0.000001); i <= 10 * max; i++)
                {
                    y = -10 * Math.Log(0.1 * i);
                    ex.Add(new Point(i + 200, y + 200));
                }
                return ex;
            }
        }
         public Ln()
        {
            XMin = 0;
            XMax = 1000;
            Name = "LN(X)";
        }   
    }
    class OneDivX : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            if ((min == 0)||(max==0)) MessageBox.Show("Argument Error");
            PointCollection ex = new PointCollection();
            double y;
            for (double i = 10 * min; i <= 10*max; i++)
            {
                if (i == 0) continue;
                y = -10 * Math.Pow(0.1 * i, -1);
                ex.Add(new Point(i + 200, y + 200));           
            }
            return ex;
        }
        public OneDivX()
        {
            XMin = 0;
            XMax = 1000;
            Name = "LN(X)";
        }
    }
    class E : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            PointCollection ex = new PointCollection();
            double y;
            for (double i = 10 * min; i <= 10 * max; i += 0.1)
            {
                y = -10 * Math.Pow(Math.E, 0.1 * i);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
        public E()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "TAN(X)";
        }
    }
    class Abs : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            PointCollection ex = new PointCollection();
            double y;
            for (double i = 10 * min; i <= 10 * max; i += 0.1)
            {
                y = -10 * Math.Abs( 0.1 * i);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
        public Abs()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "TAN(X)";
        }
    }
    class ArcTg : FunctionBase
    {
        public override PointCollection GetChart(Double min, Double max)
        {
            PointCollection ex = new PointCollection();
            double y;
            for (double i = 10 * min; i <= 10 * max; i++)
            {
                y = -10 * Math.Atan(0.1*i);
                ex.Add(new Point(i + 200, y + 200));
            }
            return ex;
        }
        public ArcTg()
        {
            XMin = -1000;
            XMax = 1000;
            Name = "SIN(X)";
        }
    }


    abstract class FunctionCreator
    {
        public abstract FunctionBase FunctionFactoryMethod();
    }
    class SinCreator : FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new Sin(); }
    }
    class CosCreator: FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new Cos(); }
    }
    class Pow2Creator : FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new Pow2(); }
    }
    class Pow3Creator : FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new Pow3(); }
    }
    class Pow4Creator : FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new Pow4(); }
    }
    class TanCreator : FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new Tan(); }
    }
    class SqrtCreator : FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new Sqrt(); }
    }
    class LnCreator : FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new Ln(); }
    }
     class OneDivXCreator : FunctionCreator
    {
        public override FunctionBase FunctionFactoryMethod() { return new OneDivX(); }
    }
     class ECreator : FunctionCreator
     {
         public override FunctionBase FunctionFactoryMethod() { return new E(); }
     }
     class AbsCreator : FunctionCreator
     {
         public override FunctionBase FunctionFactoryMethod() { return new Abs(); }
     }
     class ArcTgCreator : FunctionCreator
     {
         public override FunctionBase FunctionFactoryMethod() { return new ArcTg(); }
     }
}
