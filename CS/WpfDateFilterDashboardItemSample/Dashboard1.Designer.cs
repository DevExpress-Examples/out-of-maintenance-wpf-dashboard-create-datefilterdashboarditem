namespace WpfDateFilterDashboardItemSample
{
    partial class Dashboard1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DateTimePeriod dateTimePeriod1 = new DevExpress.DashboardCommon.DateTimePeriod();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit1 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit2 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.DateTimePeriod dateTimePeriod2 = new DevExpress.DashboardCommon.DateTimePeriod();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit3 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit4 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.DateTimePeriod dateTimePeriod3 = new DevExpress.DashboardCommon.DateTimePeriod();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit5 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit6 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.DateTimePeriod dateTimePeriod4 = new DevExpress.DashboardCommon.DateTimePeriod();
            DevExpress.DashboardCommon.FixedDateTimePeriodLimit fixedDateTimePeriodLimit1 = new DevExpress.DashboardCommon.FixedDateTimePeriodLimit();
            DevExpress.DashboardCommon.FixedDateTimePeriodLimit fixedDateTimePeriodLimit2 = new DevExpress.DashboardCommon.FixedDateTimePeriodLimit();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dateFilterDashboardItem1 = new DevExpress.DashboardCommon.DateFilterDashboardItem();
            this.dashboardItemGroup1 = new DevExpress.DashboardCommon.DashboardItemGroup();
            this.dashboardExcelDataSource1 = new DevExpress.DashboardCommon.DashboardExcelDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFilterDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardItemGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExcelDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // chartDashboardItem1
            // 
            dimension1.DataMember = "OrderDate";
            dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            measure1.DataMember = "Extended Price";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.chartDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            this.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ParentContainer = this.dashboardItemGroup1;
            this.chartDashboardItem1.ShowCaption = false;
            // 
            // dateFilterDashboardItem1
            // 
            this.dateFilterDashboardItem1.ArrangementMode = DevExpress.DashboardCommon.DateFilterArrangementMode.Vertical;
            this.dateFilterDashboardItem1.ComponentName = "dateFilterDashboardItem1";
            dimension2.DataMember = "OrderDate";
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            dimension2.UniqueId = "orderDateId";
            this.dateFilterDashboardItem1.DataItemRepository.Clear();
            this.dateFilterDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0");
            this.dateFilterDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            dateTimePeriod1.End = flowDateTimePeriodLimit1;
            dateTimePeriod1.Name = "Last Year";
            flowDateTimePeriodLimit2.Offset = -1;
            dateTimePeriod1.Start = flowDateTimePeriodLimit2;
            flowDateTimePeriodLimit3.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day;
            flowDateTimePeriodLimit3.Offset = 8;
            dateTimePeriod2.End = flowDateTimePeriodLimit3;
            dateTimePeriod2.Name = "Next Seven Days";
            flowDateTimePeriodLimit4.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day;
            flowDateTimePeriodLimit4.Offset = 1;
            dateTimePeriod2.Start = flowDateTimePeriodLimit4;
            flowDateTimePeriodLimit5.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day;
            flowDateTimePeriodLimit5.Offset = 1;
            dateTimePeriod3.End = flowDateTimePeriodLimit5;
            dateTimePeriod3.Name = "Month-to-Date";
            flowDateTimePeriodLimit6.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month;
            dateTimePeriod3.Start = flowDateTimePeriodLimit6;
            fixedDateTimePeriodLimit1.Date = new System.DateTime(2019, 1, 18, 0, 0, 0, 0);
            dateTimePeriod4.End = fixedDateTimePeriodLimit1;
            dateTimePeriod4.Name = "Jul 18, 2018 - Jan 18, 2019";
            fixedDateTimePeriodLimit2.Date = new System.DateTime(2018, 7, 18, 0, 0, 0, 0);
            dateTimePeriod4.Start = fixedDateTimePeriodLimit2;
            this.dateFilterDashboardItem1.DateTimePeriods.AddRange(new DevExpress.DashboardCommon.DateTimePeriod[] {
            dateTimePeriod1,
            dateTimePeriod2,
            dateTimePeriod3,
            dateTimePeriod4});
            this.dateFilterDashboardItem1.Dimension = dimension2;
            this.dateFilterDashboardItem1.Name = "";
            this.dateFilterDashboardItem1.ParentContainer = this.dashboardItemGroup1;
            this.dateFilterDashboardItem1.ShowCaption = false;
            // 
            // dashboardItemGroup1
            // 
            this.dashboardItemGroup1.ComponentName = "dashboardItemGroup1";
            this.dashboardItemGroup1.InteractivityOptions.IgnoreMasterFilters = true;
            this.dashboardItemGroup1.InteractivityOptions.IsMasterFilter = false;
            this.dashboardItemGroup1.Name = "Sales by Date";
            this.dashboardItemGroup1.ShowCaption = true;
            // 
            // dashboardExcelDataSource1
            // 
            this.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1";
            this.dashboardExcelDataSource1.FileName = "SalesPerson.xlsx";
            this.dashboardExcelDataSource1.Name = "Excel Data Source 1";
            this.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable");
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Data";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // Dashboard1
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardExcelDataSource1});
            this.Groups.AddRange(new DevExpress.DashboardCommon.DashboardItemGroup[] {
            this.dashboardItemGroup1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartDashboardItem1,
            this.dateFilterDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.dateFilterDashboardItem1;
            dashboardLayoutItem1.Weight = 30D;
            dashboardLayoutItem2.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem2.Weight = 70D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = this.dashboardItemGroup1;
            dashboardLayoutGroup2.Weight = 100D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFilterDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardItemGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExcelDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.DashboardExcelDataSource dashboardExcelDataSource1;
        private DevExpress.DashboardCommon.DashboardItemGroup dashboardItemGroup1;
        private DevExpress.DashboardCommon.DateFilterDashboardItem dateFilterDashboardItem1;
    }
}
