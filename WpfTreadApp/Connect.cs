using System.ComponentModel;

namespace WpfTreadApp
{
    public class Connect:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _number;

        public int Number
        {
            get { return _number;}
            set { _number = value; NewMethod();}
            
        }

        private void NewMethod()
        {
            OnPropertyChanged(nameof(Sum)); OnPropertyChanged(nameof(Factorial));
        }

        public int Factorial
        {
            get { return FactorialThreadMethod.FactorialSrch(Number); }
        }

        public int Sum
        {
            get {return ThreadSum.SumSrch(Number); }
        }
    }
}