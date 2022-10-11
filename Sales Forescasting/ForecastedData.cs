using System.ComponentModel;

namespace Sales_Forescasting
{
    class ForecastedData : INotifyPropertyChanged
    {
        public string StateValue;
        public double SalesValue;
        public double PercentageIncreaseValue;
        public double SalesIncrementValue;
        public double PredictedSalesValue;
        public bool EditedValue;
        public event PropertyChangedEventHandler PropertyChanged;

        public ForecastedData(string state, double sales, double percentageIncrease, double salesIncrement, double predictedSales, bool edited)
        {
            State = state;
            PercentageIncrease = percentageIncrease;
            Sales = sales;
            SalesIncrement = salesIncrement;
            PredictedSales = predictedSales;
            Edited = edited;
        }

        public string State
        {
            get { return StateValue; }
            set
            {
                StateValue = value;
                OnPropertyChanged();
            }
        }
        public double Sales
        {
            get { return SalesValue; }
            set
            {
                SalesValue = value;
                OnPropertyChanged();
            }
        }
        public double PercentageIncrease
        {
            get { return PercentageIncreaseValue; }
            set
            {
                PercentageIncreaseValue = value;
                OnPropertyChanged();
            }
        }
        public double SalesIncrement
        {
            get { return SalesIncrementValue; }
            set
            {
                SalesIncrementValue = value;
                OnPropertyChanged();
            }
        }
        public double PredictedSales
        {
            get { return PredictedSalesValue; }
            set
            {
                PredictedSalesValue = value;
                OnPropertyChanged();
            }
        }
        public bool Edited
        {
            get { return EditedValue; }
            set
            {
                EditedValue = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
