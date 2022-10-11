using CsvHelper;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Forescasting
{
    public partial class SalesForescasting : Form
    {
        //bindingSource for datagridview
        BindingSource bsSalesByState = new BindingSource();
        //total sales in a year and next year
        double totalSalesInAYear = 0.0;
        double totalSalesNextYear = 0.0;

        public SalesForescasting()
        {
            InitializeComponent();
        }

        //on button SeeSalesInAYear click
        private void BtnSeeSalesInAYear_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //check if text boxes has data
            string pattern = @"[0-9]{4}";
            Regex rg = new Regex(pattern);
            if (tbSalesYear.Text != "" && rg.Match(tbSalesYear.Text).Success)
            {
                lbNumberSalesIncrement.Text = "0.0";
                lbNumberTotalSalesNextYear.Text = "0.0";
                tbPercentageIncrement.Text = "";
                //fill datagridview
                ShowSales();
            }
            else
            {
                MessageBox.Show("Write a year to show data. Format of 4 digits (E.g.: 2022)");
            }
            Cursor.Current = Cursors.Default;
        }

        //on button incrementPercetage click
        private void BtnPercetageIncrement_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string patternYear = @"[0-9]{4}";
            string patternPercentage = @"[0-9]";
            Regex rgYear = new Regex(patternYear);
            Regex rgPercentage = new Regex(patternPercentage);

            //check if text boxes has data
            if (rgYear.Match(tbSalesYear.Text).Success && rgPercentage.Match(tbPercentageIncrement.Text).Success)
            {
                //check which button is pressed
                if (((Button)sender).Text == "Apply All")
                {
                    ApplyIncrementOnSales(true);
                }
                else
                {
                    ApplyIncrementOnSales(false);
                }
                //load data to charts
                LoadDataToChartSalesByYear();
                LoadDataToChartSalesByState();
            }
            else
            {
                MessageBox.Show("Write a year and a percentage before");
            }
            Cursor.Current = Cursors.Default;
        }
        
        //on button download data click
        private void BtnDownloadData_Click(object sender, EventArgs e)
        {
            //path to download csv
            string path = SelectDownloadPath();
            if (path != "-1")
            {
                //get data from bs
                var records = new List<ForecastedDataExport>();
                foreach (ForecastedData fd in bsSalesByState)
                {
                    ForecastedDataExport dataToWrite = new ForecastedDataExport(fd.State, fd.PercentageIncrease, fd.PredictedSales);
                    records.Add(dataToWrite);
                }
                //write in csv
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, CultureInfo.CurrentCulture))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    csv.WriteRecords(records);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Data downloaded");
                }
            }
        }


        //select path for download csv file
        private string SelectDownloadPath()
        {
            string selectedPath = "";
            Thread t = new Thread((ThreadStart)(() => {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.Cancel)
                    return;

                selectedPath = fbd.SelectedPath;
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            if (selectedPath == "")
            {
                return "-1";
            }
            else
            {
                return SetFileName(selectedPath, "\\Sales_Forescasting_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year, ".csv");
            }
        }

        //Set file name. Check if file exist
        private string SetFileName(string path, string name, string extension)
        {
            string res = path + name + extension;
            int i = 0;
            while (File.Exists(res))
            {
                i++;
                res = path + name + "_(" + i + ")" + extension;
            }
            return res;
        }

        //apply and show percentage of increments
        private void ApplyIncrementOnSales(Boolean applyAll)
        {
            //show sales increment in label after calculate the increment
            double salesIncrement = CalculateIncrementSales(double.Parse(tbPercentageIncrement.Text), totalSalesInAYear);
            lbNumberSalesIncrement.Text = salesIncrement.ToString("#,##0.00") + " €";
            //show total sales in next year
            totalSalesNextYear = totalSalesInAYear + salesIncrement;
            lbNumberTotalSalesNextYear.Text = totalSalesNextYear.ToString("#,##0.00") + " €";

            //fill sales increment column in datagridview with the increment by state
            foreach(ForecastedData fd in bsSalesByState)
            {
                //if apply percentage for all rows
                if (applyAll)
                {
                    //set increment percentage
                    fd.PercentageIncrease = double.Parse(tbPercentageIncrement.Text);
                    //set sales increment
                    fd.SalesIncrement = CalculateIncrementSales(double.Parse(tbPercentageIncrement.Text), fd.Sales);
                    //set total sales in next yeat in column 4
                    fd.PredictedSales = Math.Round(fd.Sales + fd.SalesIncrement, 3);
                    //dgvSalesByState.Rows[i].Cells[4].Value = (fd.Sales + incremenSales).ToString("#,##0.00") + " €";
                }
                else
                {
                    //only for data no modified
                    if (!fd.Edited)
                    {
                        //set increment percentage
                        fd.PercentageIncrease = double.Parse(tbPercentageIncrement.Text);
                        //set sales increment
                        fd.SalesIncrement = CalculateIncrementSales(double.Parse(tbPercentageIncrement.Text), fd.Sales);
                        //set total sales
                        fd.PredictedSales = Math.Round(fd.Sales + fd.SalesIncrement, 3);
                    }
                }
            }
        }

        // Get sum of all sales in the specified year and show data
        private void ShowSales()
        {
            //specified year  
            int year = int.Parse(tbSalesYear.Text);
            //connection string
            string connectionString = ConfigurationManager.ConnectionStrings["SpauldingRidgeConnectionString"].ConnectionString;

            //show results
            try
            {
                //sql connection
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                //show total sales by state in datagridview
                var hasData = ShowTotalSalesByState(con, year);

                //show total sales in the year
                if (hasData)
                {
                    ShowTotalSales(con, year);
                }

                //close connection
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //show total sales in the year
        private void ShowTotalSales(SqlConnection con, int year)
        {
            //sql query for total sales in a year
            string sqlQueryTotalSales = "SELECT SUM(p.Sales) as totalSales FROM dbo.Products p WHERE p.OrderId " +
                "IN(SELECT o.OrderId FROM dbo.Orders o WHERE o.OrderDate >= '" + year + "' and o.OrderDate < '" + (year + 1) +
                "' and o.OrderId not in (SELECT o1.OrderId FROM dbo.OrdersReturns o1))";
            //sql command and datareader
            SqlCommand cmd = new SqlCommand(sqlQueryTotalSales, con);
            SqlDataReader dr = cmd.ExecuteReader();

            // check if database return something
            if (dr != null)
            {
                while (dr.Read())
                {
                    // show year in label
                    lbTotalSalesInAYear.Text = "Total sales in " + year.ToString() + ":";
                    lbIncrementSales.Text = "Increment sales in " + (year + 1).ToString() + ":";
                    lbTotalSalesNextYear.Text = "Predicted sales in " + (year + 1).ToString() + ":";
                    // add value to label
                    totalSalesInAYear = double.Parse(dr["totalSales"].ToString());
                    lbNumberTotalSalesInAYear.Text = totalSalesInAYear.ToString("#,##0.00") + " €";
                }
            }

            dr.Close();
        }

        //show total sales by state in datagridview
        private bool ShowTotalSalesByState(SqlConnection con, int year)
        {
            //clear datagridview and bindingsource before add new rows
            dgvSalesForecast.Columns.Clear();
            bsSalesByState.Clear();

            //sql query for sales by state
            string sqlQuerySalesByState = "SELECT o.State, SUM(p.Sales) as totalSales FROM Products p INNER JOIN Orders o ON" +
                " p.OrderId = o.OrderId WHERE o.OrderId IN(SELECT o1.OrderId FROM Orders o1 WHERE o1.State = o.State and " +
                "o1.OrderDate >= '" + year + "' and o1.OrderDate < '" + (year + 1) + "' and o1.OrderId not in " +
                "(SELECT o2.OrderId FROM dbo.OrdersReturns o2)) GROUP BY o.State";

            //sql command and datareader
            SqlCommand cmd = new SqlCommand(sqlQuerySalesByState, con);
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr != null)
            {
                //check if database return something
                if (dr.HasRows)
                {
                    //enabled percentage button
                    btnPercetageIncrement.Enabled = true;
                    btnPercentageIncrementAll.Enabled = true;

                    while (dr.Read())
                    {
                        //fill bindingsource
                        bsSalesByState.Add(new ForecastedData(dr["State"].ToString(), double.Parse(dr["totalSales"].ToString()), 0.0, 0.0, 0.0, false));
                    }
                    //set datagridview and columns configuration
                    dgvSalesForecast.DataSource = bsSalesByState;
                    dgvSalesForecast.AutoGenerateColumns = true;
                    dgvSalesForecast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSalesForecast.Columns[0].ReadOnly = true;
                    dgvSalesForecast.Columns[1].ReadOnly = true;
                    dgvSalesForecast.Columns[3].ReadOnly = true;
                    dgvSalesForecast.Columns[4].ReadOnly = true;


                    //Set columns header correctly
                    dgvSalesForecast.Columns[2].HeaderText = "Increment Percentage";
                    dgvSalesForecast.Columns[4].HeaderText = "Predicted Sales in " + (year + 1);

                    //set format to columns
                    dgvSalesForecast.Columns[1].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
                    dgvSalesForecast.Columns[1].DefaultCellStyle.Format = String.Format("c");
                    dgvSalesForecast.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
                    dgvSalesForecast.Columns[3].DefaultCellStyle.Format = String.Format("c");
                    dgvSalesForecast.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
                    dgvSalesForecast.Columns[4].DefaultCellStyle.Format = String.Format("c");


                    //hide edited column
                    dgvSalesForecast.Columns["Edited"].Visible = false;
                }
                else
                {
                    //show no data
                    MessageBox.Show("No data for this year");
                    return false;
                }
            }
            dr.Close();
            return true;
        }

        //apply specific percentage of increment by state. this function is called when the user finishes editing the cell
        private void DgvSalesByState_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (ForecastedData fd in bsSalesByState)
            {
                if (fd.State == dgvSalesForecast.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    //get new percentage
                    double newPercentage = double.Parse(dgvSalesForecast.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    //set new percentage increment
                    fd.PercentageIncrease = newPercentage;
                    //set new sales increments
                    fd.SalesIncrement = CalculateIncrementSales(newPercentage, fd.Sales);
                    //set new total sales
                    fd.PredictedSales = Math.Round(fd.Sales + fd.SalesIncrement, 3);
                    //data modified
                    fd.Edited = true;

                    //update chart
                    LoadDataToChartSalesByState();
                    break;
                }
            }
        }

        //load data to chart sales by year
        private void LoadDataToChartSalesByYear()
        {
            lbNoticeFillDataForShowChartByYear.Visible = false;
            chartSalesByYear.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = (int.Parse(tbSalesYear.Text)).ToString(),
                    Values = new ChartValues<double> { totalSalesInAYear }
                },
                new ColumnSeries
                {
                    Title = (int.Parse(tbSalesYear.Text) + 1).ToString(),
                    Values = new ChartValues<double> { totalSalesNextYear },
                }
            };
            chartSalesByYear.AxisX[0].Title = "Years";
            chartSalesByYear.AxisY[0].Title = "Sales";
            chartSalesByYear.AxisX[0].Labels = new string[] { (int.Parse(tbSalesYear.Text)).ToString() + " - " + (int.Parse(tbSalesYear.Text) + 1).ToString() };
            //chartSalesByYear.AxisX[0].ShowLabels = false;
        }

        //load data to chart sales by state
        private void LoadDataToChartSalesByState()
        {
            chartSalesByState.Series.Clear();
            lbNoticeFillDataForShowChartByState.Visible = false;

            chartSalesByState.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = tbSalesYear.Text,
                    Values = new ChartValues<double> { }
                }
            };

            chartSalesByState.Series.Add(new ColumnSeries
            {
                Title = (int.Parse(tbSalesYear.Text)+1).ToString(),
                Values = new ChartValues<double> { }
            });

            var states = new List<string>();
            foreach(ForecastedData fd in bsSalesByState)
            {
                chartSalesByState.Series[0].Values.Add(fd.Sales);
                chartSalesByState.Series[1].Values.Add(fd.PredictedSales);
                states.Add(fd.State);

            }
            chartSalesByState.AxisX[0].Title = "States";
            chartSalesByState.AxisY[0].Title = "Sales";
            chartSalesByState.AxisX[0].Labels = states;
        }

        //calculate increment sales
        private double CalculateIncrementSales(double percetageIncrement, double sales)
        {
            return Math.Round(sales * (percetageIncrement / 100), 3);
        }

    }
}
