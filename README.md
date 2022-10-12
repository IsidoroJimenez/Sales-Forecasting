# Sales-Forecasting

# Technology used
- Visual Studio 2022
- Project developed in WinForms .NET 4.7.2
- Database used: SQL Server 2019
- Library for charts: LiveCharts (https://lvcharts.net/)
- Library to exports CSV: CsvHelper (https://joshclose.github.io/CsvHelper/)

# How to open
1. Open Visual Studio and click on "Clone a repository".
2. Use de repository URL to clone it (https://github.com/IsidoroJimenez/Sales-Forecasting.git).
3. Once opened, in Solutions explorer window, right click in "Sales Forecasting" (Project) and click on "Manage NuGet packages".
4. At the top of the opened window should pop up a message with a button to resolve conflicts between packages, click on it.
5. Click on Start to run the program. 

# How to use
- In the upper corner of the program, you will find a field where you can enter a year to obtain the sales for that year (Seeding Year). Click on the Get button to show the data in the table below.
- Below the year field you will find a percentage field to enter the increase in total sales expected for the next year. This percentage can also be manually specified for each state, entering it in the corresponding cell in the table. There are two different buttons next to the percentage field: “Apply” and “Apply All”. “Apply” is used to apply the percentage to all states except the ones that have been manually modified. “Apply All” serves to reset all states to the same percentage.
- Charts are visible in the right part of the screen. The upper one shows the difference in sales between the seeding year and the forecasted year (next year). The lower chart shows a similar comparison with a breakdown per state. Moving the pointer to a column allows to see its value. 
- In the upper right corner can be find the “Download data” button used to download a .csv file containing the forecast analysis (State, Percentage increase, Predicted Sales). The folder where the file is saved is selected by the user when pressing the button. 
