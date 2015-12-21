using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using mvvm.Model;
using mvvm;
namespace mvvm
{
    public interface IGraphicBuilder
    {
        PointCollection BuildGraphic(Double a,Double b);
          
    }
    public class SinGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a,Double b)
        {
            FunctionCreator s = new SinCreator();
            return  s.FunctionFactoryMethod().GetChart(a,b);
        }    
    }
    public class CosGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new CosCreator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class Pow2Graphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new Pow2Creator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class Pow3Graphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new Pow3Creator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class Pow4Graphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new Pow4Creator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class TanGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new TanCreator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class SqrtGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new SqrtCreator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class LnGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new LnCreator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class OneDivXGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new OneDivXCreator();
            return s.FunctionFactoryMethod().GetChart(a,b);
        }
    }
    public class EGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new ECreator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class AbsGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new AbsCreator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public class ArcTgGraphic : IGraphicBuilder
    {
        public PointCollection BuildGraphic(Double a, Double b)
        {
            FunctionCreator s = new ArcTgCreator();
            return s.FunctionFactoryMethod().GetChart(a, b);
        }
    }
    public abstract class GraphicBase
    {
      public  Double XMin { get; set; }
      public  Double XMax { get; set; }
      public  IGraphicBuilder Builder { get; set; }
    }
   

}

