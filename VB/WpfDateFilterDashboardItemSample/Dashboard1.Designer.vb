Namespace WpfDateFilterDashboardItemSample
	Partial Public Class Dashboard1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dateTimePeriod1 As New DevExpress.DashboardCommon.DateTimePeriod()
			Dim flowDateTimePeriodLimit1 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim flowDateTimePeriodLimit2 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim dateTimePeriod2 As New DevExpress.DashboardCommon.DateTimePeriod()
			Dim flowDateTimePeriodLimit3 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim flowDateTimePeriodLimit4 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim dateTimePeriod3 As New DevExpress.DashboardCommon.DateTimePeriod()
			Dim flowDateTimePeriodLimit5 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim flowDateTimePeriodLimit6 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim dateTimePeriod4 As New DevExpress.DashboardCommon.DateTimePeriod()
			Dim fixedDateTimePeriodLimit1 As New DevExpress.DashboardCommon.FixedDateTimePeriodLimit()
			Dim fixedDateTimePeriodLimit2 As New DevExpress.DashboardCommon.FixedDateTimePeriodLimit()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dateFilterDashboardItem1 = New DevExpress.DashboardCommon.DateFilterDashboardItem()
			Me.dashboardItemGroup1 = New DevExpress.DashboardCommon.DashboardItemGroup()
			Me.dashboardExcelDataSource1 = New DevExpress.DashboardCommon.DashboardExcelDataSource()
			DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dateFilterDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardItemGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' chartDashboardItem1
			' 
			dimension1.DataMember = "OrderDate"
			dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
			Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.chartDashboardItem1.AxisX.TitleVisible = False
			Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
			measure1.DataMember = "Extended Price"
			Me.chartDashboardItem1.DataItemRepository.Clear()
			Me.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.chartDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartDashboardItem1.Name = ""
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries1.AddDataItem("Value", measure1)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartDashboardItem1.ParentContainer = Me.dashboardItemGroup1
			Me.chartDashboardItem1.ShowCaption = False
			' 
			' dateFilterDashboardItem1
			' 
			Me.dateFilterDashboardItem1.ArrangementMode = DevExpress.DashboardCommon.DateFilterArrangementMode.Vertical
			Me.dateFilterDashboardItem1.ComponentName = "dateFilterDashboardItem1"
			dimension2.DataMember = "OrderDate"
			dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
			dimension2.UniqueId = "orderDateId"
			Me.dateFilterDashboardItem1.DataItemRepository.Clear()
			Me.dateFilterDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
			Me.dateFilterDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			dateTimePeriod1.End = flowDateTimePeriodLimit1
			dateTimePeriod1.Name = "Last Year"
			flowDateTimePeriodLimit2.Offset = -1
			dateTimePeriod1.Start = flowDateTimePeriodLimit2
			flowDateTimePeriodLimit3.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day
			flowDateTimePeriodLimit3.Offset = 8
			dateTimePeriod2.End = flowDateTimePeriodLimit3
			dateTimePeriod2.Name = "Next Seven Days"
			flowDateTimePeriodLimit4.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day
			flowDateTimePeriodLimit4.Offset = 1
			dateTimePeriod2.Start = flowDateTimePeriodLimit4
			flowDateTimePeriodLimit5.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day
			flowDateTimePeriodLimit5.Offset = 1
			dateTimePeriod3.End = flowDateTimePeriodLimit5
			dateTimePeriod3.Name = "Month-to-Date"
			flowDateTimePeriodLimit6.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month
			dateTimePeriod3.Start = flowDateTimePeriodLimit6
			fixedDateTimePeriodLimit1.Date = New Date(2019, 1, 18, 0, 0, 0, 0)
			dateTimePeriod4.End = fixedDateTimePeriodLimit1
			dateTimePeriod4.Name = "Jul 18, 2018 - Jan 18, 2019"
			fixedDateTimePeriodLimit2.Date = New Date(2018, 7, 18, 0, 0, 0, 0)
			dateTimePeriod4.Start = fixedDateTimePeriodLimit2
			Me.dateFilterDashboardItem1.DateTimePeriods.AddRange(New DevExpress.DashboardCommon.DateTimePeriod() { dateTimePeriod1, dateTimePeriod2, dateTimePeriod3, dateTimePeriod4})
			Me.dateFilterDashboardItem1.Dimension = dimension2
			Me.dateFilterDashboardItem1.Name = ""
			Me.dateFilterDashboardItem1.ParentContainer = Me.dashboardItemGroup1
			Me.dateFilterDashboardItem1.ShowCaption = False
			Me.dateFilterDashboardItem1.VisibleComponents = DevExpress.DashboardCommon.DateFilterComponent.QuickFilters
			' 
			' dashboardItemGroup1
			' 
			Me.dashboardItemGroup1.ComponentName = "dashboardItemGroup1"
			Me.dashboardItemGroup1.InteractivityOptions.IgnoreMasterFilters = True
			Me.dashboardItemGroup1.InteractivityOptions.IsMasterFilter = False
			Me.dashboardItemGroup1.Name = "Sales by Date"
			Me.dashboardItemGroup1.ShowCaption = True
			' 
			' dashboardExcelDataSource1
			' 
			Me.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1"
			Me.dashboardExcelDataSource1.FileName = "SalesPerson.xlsx"
			Me.dashboardExcelDataSource1.Name = "Excel Data Source 1"
			Me.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable")
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetName = "Data"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExcelDataSource1})
			Me.Groups.AddRange(New DevExpress.DashboardCommon.DashboardItemGroup() { Me.dashboardItemGroup1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.chartDashboardItem1, Me.dateFilterDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.dateFilterDashboardItem1
			dashboardLayoutItem1.Weight = 30R
			dashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
			dashboardLayoutItem2.Weight = 70R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Me.dashboardItemGroup1
			dashboardLayoutGroup2.Weight = 100R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Dashboard"
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dateFilterDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardItemGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
		Private dashboardExcelDataSource1 As DevExpress.DashboardCommon.DashboardExcelDataSource
		Private dashboardItemGroup1 As DevExpress.DashboardCommon.DashboardItemGroup
		Private dateFilterDashboardItem1 As DevExpress.DashboardCommon.DateFilterDashboardItem
	End Class
End Namespace
