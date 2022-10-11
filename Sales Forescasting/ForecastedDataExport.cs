namespace Sales_Forescasting
{
    class ForecastedDataExport
    {
        public string State { get; set; }
        public double PercentageIncrease { get; set; }
        public double PredictedSales { get; set; }

        public ForecastedDataExport(string state, double percentageIncrease, double predictedSales)
        {
            State = state;
            PercentageIncrease = percentageIncrease;
            PredictedSales = predictedSales;
        }
    }
}
