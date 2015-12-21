using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace mvvm
{
    public interface IStrategy
    {
        PointCollection Choise(string s, double d, double dd);
    }
    public class ChoiseStrategy : IStrategy
    {
        IDictionary<String, IGraphicBuilder> ChoiseList = new Dictionary<String, IGraphicBuilder>();
        public ChoiseStrategy()
        {
            ChoiseList.Add("1/X", new OneDivXGraphic());
            ChoiseList.Add("|X|", new AbsGraphic());
            ChoiseList.Add("LN(X)", new LnGraphic());
            ChoiseList.Add("SIN(X)", new SinGraphic());
            ChoiseList.Add("COS(X)", new CosGraphic());
            ChoiseList.Add("TAN(X)", new TanGraphic());
            ChoiseList.Add("X^2", new Pow2Graphic());
            ChoiseList.Add("X^3", new Pow3Graphic());
            ChoiseList.Add("X^4", new Pow4Graphic());
            ChoiseList.Add("SQRT(X)", new SqrtGraphic());
            ChoiseList.Add("e^x", new EGraphic());
            ChoiseList.Add("ArcTg(X)", new ArcTgGraphic());
        }
        public PointCollection Choise(string TextFromTextBox, double XMin, double XMax)
        {
            return ChoiseList[TextFromTextBox].BuildGraphic(XMin, XMax);
        }
    }

    public class ErrorStrategy : IStrategy
    {
        public  PointCollection Choise(string s, double d, double dd)
        {
            MessageBox.Show("Function hasn't been found");
            return null;
        }
    }
    public class Context
    {
        private IStrategy _str;
        public Context(IStrategy s)
        {
            this._str = s;
        }
        public PointCollection ExecuteOperation(string s, double d, double dd)
        {
            return _str.Choise(s, d, dd);
        }
    }
}



