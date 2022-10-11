namespace Sales_Forescasting
{
    partial class SalesForescasting
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbTotalSalesInAYear = new System.Windows.Forms.Label();
            this.lbNumberSalesIncrement = new System.Windows.Forms.Label();
            this.lbIncrementSales = new System.Windows.Forms.Label();
            this.lbNumberTotalSalesNextYear = new System.Windows.Forms.Label();
            this.lbTotalSalesNextYear = new System.Windows.Forms.Label();
            this.lbNumberTotalSalesInAYear = new System.Windows.Forms.Label();
            this.btnDownloadData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPercentageIncrement = new System.Windows.Forms.TextBox();
            this.tbSalesYear = new System.Windows.Forms.TextBox();
            this.btnPercentageIncrementAll = new System.Windows.Forms.Button();
            this.btnPercetageIncrement = new System.Windows.Forms.Button();
            this.btnSeeSalesInAYear = new System.Windows.Forms.Button();
            this.lbNoticeFillDataForShowChartByYear = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvSalesForecast = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hChartSalesByYear = new System.Windows.Forms.Integration.ElementHost();
            this.chartSalesByYear = new LiveCharts.Wpf.CartesianChart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbNoticeFillDataForShowChartByState = new System.Windows.Forms.Label();
            this.hChartSalesByState = new System.Windows.Forms.Integration.ElementHost();
            this.chartSalesByState = new LiveCharts.Wpf.CartesianChart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesForecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnDownloadData);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPercentageIncrement);
            this.panel1.Controls.Add(this.tbSalesYear);
            this.panel1.Controls.Add(this.btnPercentageIncrementAll);
            this.panel1.Controls.Add(this.btnPercetageIncrement);
            this.panel1.Controls.Add(this.btnSeeSalesInAYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1164, 147);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.lbTotalSalesInAYear);
            this.panel6.Controls.Add(this.lbNumberSalesIncrement);
            this.panel6.Controls.Add(this.lbIncrementSales);
            this.panel6.Controls.Add(this.lbNumberTotalSalesNextYear);
            this.panel6.Controls.Add(this.lbTotalSalesNextYear);
            this.panel6.Controls.Add(this.lbNumberTotalSalesInAYear);
            this.panel6.Location = new System.Drawing.Point(471, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 147);
            this.panel6.TabIndex = 42;
            // 
            // lbTotalSalesInAYear
            // 
            this.lbTotalSalesInAYear.AutoSize = true;
            this.lbTotalSalesInAYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTotalSalesInAYear.Location = new System.Drawing.Point(12, 31);
            this.lbTotalSalesInAYear.Name = "lbTotalSalesInAYear";
            this.lbTotalSalesInAYear.Size = new System.Drawing.Size(81, 17);
            this.lbTotalSalesInAYear.TabIndex = 36;
            this.lbTotalSalesInAYear.Text = "Total sales:";
            // 
            // lbNumberSalesIncrement
            // 
            this.lbNumberSalesIncrement.AutoSize = true;
            this.lbNumberSalesIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNumberSalesIncrement.Location = new System.Drawing.Point(189, 68);
            this.lbNumberSalesIncrement.Name = "lbNumberSalesIncrement";
            this.lbNumberSalesIncrement.Size = new System.Drawing.Size(28, 17);
            this.lbNumberSalesIncrement.TabIndex = 41;
            this.lbNumberSalesIncrement.Text = "0.0";
            // 
            // lbIncrementSales
            // 
            this.lbIncrementSales.AutoSize = true;
            this.lbIncrementSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbIncrementSales.Location = new System.Drawing.Point(12, 68);
            this.lbIncrementSales.Name = "lbIncrementSales";
            this.lbIncrementSales.Size = new System.Drawing.Size(113, 17);
            this.lbIncrementSales.TabIndex = 37;
            this.lbIncrementSales.Text = "Sales increment:";
            // 
            // lbNumberTotalSalesNextYear
            // 
            this.lbNumberTotalSalesNextYear.AutoSize = true;
            this.lbNumberTotalSalesNextYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNumberTotalSalesNextYear.Location = new System.Drawing.Point(189, 104);
            this.lbNumberTotalSalesNextYear.Name = "lbNumberTotalSalesNextYear";
            this.lbNumberTotalSalesNextYear.Size = new System.Drawing.Size(28, 17);
            this.lbNumberTotalSalesNextYear.TabIndex = 40;
            this.lbNumberTotalSalesNextYear.Text = "0.0";
            // 
            // lbTotalSalesNextYear
            // 
            this.lbTotalSalesNextYear.AutoSize = true;
            this.lbTotalSalesNextYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTotalSalesNextYear.Location = new System.Drawing.Point(12, 104);
            this.lbTotalSalesNextYear.Name = "lbTotalSalesNextYear";
            this.lbTotalSalesNextYear.Size = new System.Drawing.Size(96, 17);
            this.lbTotalSalesNextYear.TabIndex = 38;
            this.lbTotalSalesNextYear.Text = "Total sales in:";
            // 
            // lbNumberTotalSalesInAYear
            // 
            this.lbNumberTotalSalesInAYear.AutoSize = true;
            this.lbNumberTotalSalesInAYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNumberTotalSalesInAYear.Location = new System.Drawing.Point(189, 31);
            this.lbNumberTotalSalesInAYear.Name = "lbNumberTotalSalesInAYear";
            this.lbNumberTotalSalesInAYear.Size = new System.Drawing.Size(28, 17);
            this.lbNumberTotalSalesInAYear.TabIndex = 39;
            this.lbNumberTotalSalesInAYear.Text = "0.0";
            // 
            // btnDownloadData
            // 
            this.btnDownloadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDownloadData.Location = new System.Drawing.Point(1022, 13);
            this.btnDownloadData.Name = "btnDownloadData";
            this.btnDownloadData.Size = new System.Drawing.Size(130, 31);
            this.btnDownloadData.TabIndex = 35;
            this.btnDownloadData.Text = "Download data";
            this.btnDownloadData.UseVisualStyleBackColor = true;
            this.btnDownloadData.Click += new System.EventHandler(this.BtnDownloadData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Percentage increment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "See sales for the year:";
            // 
            // tbPercentageIncrement
            // 
            this.tbPercentageIncrement.Location = new System.Drawing.Point(170, 104);
            this.tbPercentageIncrement.Name = "tbPercentageIncrement";
            this.tbPercentageIncrement.Size = new System.Drawing.Size(100, 20);
            this.tbPercentageIncrement.TabIndex = 2;
            // 
            // tbSalesYear
            // 
            this.tbSalesYear.Location = new System.Drawing.Point(170, 31);
            this.tbSalesYear.Name = "tbSalesYear";
            this.tbSalesYear.Size = new System.Drawing.Size(100, 20);
            this.tbSalesYear.TabIndex = 0;
            // 
            // btnPercentageIncrementAll
            // 
            this.btnPercentageIncrementAll.Enabled = false;
            this.btnPercentageIncrementAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPercentageIncrementAll.Location = new System.Drawing.Point(357, 98);
            this.btnPercentageIncrementAll.Name = "btnPercentageIncrementAll";
            this.btnPercentageIncrementAll.Size = new System.Drawing.Size(75, 31);
            this.btnPercentageIncrementAll.TabIndex = 4;
            this.btnPercentageIncrementAll.Text = "Apply All";
            this.btnPercentageIncrementAll.UseVisualStyleBackColor = true;
            this.btnPercentageIncrementAll.Click += new System.EventHandler(this.BtnPercetageIncrement_Click);
            // 
            // btnPercetageIncrement
            // 
            this.btnPercetageIncrement.Enabled = false;
            this.btnPercetageIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPercetageIncrement.Location = new System.Drawing.Point(276, 98);
            this.btnPercetageIncrement.Name = "btnPercetageIncrement";
            this.btnPercetageIncrement.Size = new System.Drawing.Size(75, 31);
            this.btnPercetageIncrement.TabIndex = 3;
            this.btnPercetageIncrement.Text = "Apply";
            this.btnPercetageIncrement.UseVisualStyleBackColor = true;
            this.btnPercetageIncrement.Click += new System.EventHandler(this.BtnPercetageIncrement_Click);
            // 
            // btnSeeSalesInAYear
            // 
            this.btnSeeSalesInAYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSeeSalesInAYear.Location = new System.Drawing.Point(276, 25);
            this.btnSeeSalesInAYear.Name = "btnSeeSalesInAYear";
            this.btnSeeSalesInAYear.Size = new System.Drawing.Size(75, 31);
            this.btnSeeSalesInAYear.TabIndex = 1;
            this.btnSeeSalesInAYear.Text = "Get";
            this.btnSeeSalesInAYear.UseVisualStyleBackColor = true;
            this.btnSeeSalesInAYear.Click += new System.EventHandler(this.BtnSeeSalesInAYear_Click);
            // 
            // lbNoticeFillDataForShowChartByYear
            // 
            this.lbNoticeFillDataForShowChartByYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNoticeFillDataForShowChartByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNoticeFillDataForShowChartByYear.Location = new System.Drawing.Point(0, 10);
            this.lbNoticeFillDataForShowChartByYear.Name = "lbNoticeFillDataForShowChartByYear";
            this.lbNoticeFillDataForShowChartByYear.Size = new System.Drawing.Size(649, 240);
            this.lbNoticeFillDataForShowChartByYear.TabIndex = 36;
            this.lbNoticeFillDataForShowChartByYear.Text = "Fill year and percentage to visualiced charts";
            this.lbNoticeFillDataForShowChartByYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 147);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvSalesForecast);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1164, 653);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvSalesForecast
            // 
            this.dgvSalesForecast.AllowUserToAddRows = false;
            this.dgvSalesForecast.AllowUserToDeleteRows = false;
            this.dgvSalesForecast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesForecast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesForecast.Location = new System.Drawing.Point(10, 10);
            this.dgvSalesForecast.Name = "dgvSalesForecast";
            this.dgvSalesForecast.Size = new System.Drawing.Size(470, 633);
            this.dgvSalesForecast.TabIndex = 1;
            this.dgvSalesForecast.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalesByState_CellEndEdit);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(10, 10);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Size = new System.Drawing.Size(650, 633);
            this.splitContainer2.SplitterDistance = 298;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbNoticeFillDataForShowChartByYear);
            this.panel2.Controls.Add(this.hChartSalesByYear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(648, 260);
            this.panel2.TabIndex = 2;
            // 
            // hChartSalesByYear
            // 
            this.hChartSalesByYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hChartSalesByYear.Location = new System.Drawing.Point(10, 10);
            this.hChartSalesByYear.Name = "hChartSalesByYear";
            this.hChartSalesByYear.Size = new System.Drawing.Size(628, 240);
            this.hChartSalesByYear.TabIndex = 0;
            this.hChartSalesByYear.Text = "Sales comparison chart by year";
            this.hChartSalesByYear.Child = this.chartSalesByYear;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 36);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-2, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(650, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comparison of sales between years";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbNoticeFillDataForShowChartByState);
            this.panel4.Controls.Add(this.hChartSalesByState);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(648, 292);
            this.panel4.TabIndex = 0;
            // 
            // lbNoticeFillDataForShowChartByState
            // 
            this.lbNoticeFillDataForShowChartByState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNoticeFillDataForShowChartByState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNoticeFillDataForShowChartByState.Location = new System.Drawing.Point(-1, 10);
            this.lbNoticeFillDataForShowChartByState.Name = "lbNoticeFillDataForShowChartByState";
            this.lbNoticeFillDataForShowChartByState.Size = new System.Drawing.Size(650, 272);
            this.lbNoticeFillDataForShowChartByState.TabIndex = 37;
            this.lbNoticeFillDataForShowChartByState.Text = "Fill year and percentage to visualiced charts";
            this.lbNoticeFillDataForShowChartByState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hChartSalesByState
            // 
            this.hChartSalesByState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hChartSalesByState.Location = new System.Drawing.Point(10, 10);
            this.hChartSalesByState.Name = "hChartSalesByState";
            this.hChartSalesByState.Size = new System.Drawing.Size(628, 272);
            this.hChartSalesByState.TabIndex = 3;
            this.hChartSalesByState.Text = "elementHost1";
            this.hChartSalesByState.Child = this.chartSalesByState;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(648, 37);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(-2, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(650, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Comparison between years by state";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesForescasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 800);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "SalesForescasting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Forecasting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesForecast)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Integration.ElementHost hChartSalesByYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private LiveCharts.Wpf.CartesianChart chartSalesByYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPercentageIncrement;
        private System.Windows.Forms.TextBox tbSalesYear;
        private System.Windows.Forms.Button btnPercentageIncrementAll;
        private System.Windows.Forms.Button btnPercetageIncrement;
        private System.Windows.Forms.Button btnSeeSalesInAYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownloadData;
        //private System.Windows.Forms.Label lbTotalSalesInAYear;
        //private System.Windows.Forms.Label lbNoticeFillDataForShowChartByYear;
        //private System.Windows.Forms.Label lbNoticeFillDataForShowChartByState;
        //private System.Windows.Forms.Label lbNumberTotalSalesNextYear;
        //private System.Windows.Forms.Label lbNumberSalesIncrement;
        //private System.Windows.Forms.Label lbNumberTotalSalesInAYear;
        //private System.Windows.Forms.Label lbTotalSalesNextYear;
        //private System.Windows.Forms.Label lbIncrementSales;
        private System.Windows.Forms.Integration.ElementHost hChartSalesByState;
        private System.Windows.Forms.Label lbNoticeFillDataForShowChartByYear;
        private System.Windows.Forms.Label lbNoticeFillDataForShowChartByState;
        private System.Windows.Forms.Label lbTotalSalesNextYear;
        private System.Windows.Forms.Label lbIncrementSales;
        private System.Windows.Forms.Label lbTotalSalesInAYear;
        private System.Windows.Forms.Label lbNumberSalesIncrement;
        private System.Windows.Forms.Label lbNumberTotalSalesNextYear;
        private System.Windows.Forms.Label lbNumberTotalSalesInAYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LiveCharts.Wpf.CartesianChart chartSalesByState;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvSalesForecast;
    }
}

