using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using mvvm;
using mvvm.Model;
using System.Windows;
using System.Windows.Input;

namespace mvvm
{
    public class MyViewModel : INotifyPropertyChanged
    {
        #region private fields

        private List<String> _Box;
        private PointCollection _Points = new PointCollection();
        private string _FunctionText;
        private double _PositionOfMouse;
        private double _FunctionValue;
        private string _BoxText;
        private ICommand _clickCommand;
        private ICommand _moveCommand;
        private bool _canExecute;
        private Double _XMin;
        private Double _XMax;
        private Double _A;
        private Double _B;
    
       
        #endregion
        #region events
        public event PropertyChangedEventHandler PropertyChanged;
       
        public void OnPropertyChanged(String property)
        {
            var ev = PropertyChanged;
            if (ev != null)
            {
                ev(this, new PropertyChangedEventArgs(property));
            }
        }
        public bool KeyCheck(string t)
        {
            foreach (string s in Box)
            {
                if (t == s) return true;
            }
            return false;
        }
        #endregion
        #region properties  
        public Double A
        {
            get
            {
                return _A;
            }
            set
            {
                _A = value;
                OnPropertyChanged("A");
            }
        }
        public Double B
        {
            get
            {
                return _B;
            }
            set
            {
                _B = value;
                OnPropertyChanged("B");
            }
        }
        public List<String> Box
         {
            get
            {
                return new List<string>() { "SIN(X)", "COS(X)", "TAN(X)", "SQRT(X)", "|X|", "1/X", "LN(X)", "e^x", "X^2", "X^3", "X^4","ArcTg(X)" };
            }
            set
            {
                _Box = value;
            }

        }
        public double PositionOfMouse
        {
            get
            {
                return _PositionOfMouse;
            }
            set
            {
                _PositionOfMouse = value;
                A = _PositionOfMouse * 10 + 200-3;
                OnPropertyChanged("PositionOfMouse");
            }
        }
        public double FunctionValue
        {
            get
            {
                return _FunctionValue;
            }
            set
            {
                _FunctionValue = value;
                B =(-_FunctionValue * 10 + 200)-3;
                OnPropertyChanged("FunctionValue");
            }
        }

        public string FunctionText
        {
            get
            {
                return _FunctionText;
            }
            set
            {
                _FunctionText = value;
                OnPropertyChanged("FunctionText");
            }
        }
        public string BoxText
        {
            get
            {
                return _BoxText;
            }
            set
            {
                _BoxText = value;
                FunctionText = _BoxText;        
                OnPropertyChanged("BoxText");
            }
        }
        public PointCollection Points
        {
            get { return _Points; }
            set
            {
                _Points = value;
                OnPropertyChanged("Points");
            }
        }
        public Double XMin
        { get { return _XMin; }
            set 
            {
                _XMin=value;
                OnPropertyChanged("XMin");
            }
        }
        public Double XMax
        {
            get { return _XMax; }
            set
            {
                _XMax = value;
                OnPropertyChanged("XMax");
            }
        }     
             #endregion        
        #region constructor
        public MyViewModel()
        {
            FunctionText = "Choose function from box";           
            _canExecute = true;
            XMax = 20;
            XMin = -20;
        }
        #endregion
        #region commands
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => ClickAction(), _canExecute));
            }
        }

        public void ClickAction()
        {

            if (KeyCheck(FunctionText) == false)
            {
                Context context1 = new Context(new ErrorStrategy());
                context1.ExecuteOperation(FunctionText, XMin, XMax);
            }
            else
            {
                Context context = new Context(new ChoiseStrategy());
                Points = context.ExecuteOperation(FunctionText, XMin, XMax);
            }

        }
        public ICommand GetPosCommand 
        {
            get
            {
                return _moveCommand ?? (_moveCommand = new CommandHandler(() => MoveAction(), _canExecute));
            }
        }
        public void MoveAction()
        {
           
            PositionOfMouse = MainWindow.X;
            FunctionValue = Chart.GetValueOfArg(Points,PositionOfMouse);
          
        }
        # endregion
       
    }
}
