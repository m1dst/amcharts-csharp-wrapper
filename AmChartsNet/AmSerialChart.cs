namespace AmChartsNet
{
    public class AmSerialChart : AmRectangularChart
    {

        public AmSerialChart()
        {
            Type = ChartType.Serial;
        }

        /// <summary>
        /// Date format of the graph balloon (if chart parses dates and you don't use chartCursor).
        /// </summary>
        public string BalloonDateFormat { get; set; }

        /// <summary>
        /// Chart creates category axis itself.
        /// If you want to change some properties, you should get this axis from the chart and set properties to this object.
        /// </summary>
        public CategoryAxis CategoryAxis { get; set; }

        /// <summary>
        /// Category field name tells the chart the name of the field in your dataProvider object which will be used for category axis values.
        /// </summary>
        public string CategoryField { get; set; }

        /// <summary>
        /// The gap in pixels between two columns of the same category.
        /// </summary>
        public int? ColumnSpacing { get; set; }

        /// <summary>
        /// Space between 3D stacked columns.
        /// </summary>
        public int? ColumnSpacing3D { get; set; }

        /// <summary>
        /// Relative width of columns. Value range is 0 - 1.
        /// </summary>
        public int? ColumnWidth { get; set; }

        /// <summary>
        /// Even if your chart parses dates, you can pass them as strings in your data – all you need to do is to set data date format
        /// and the chart will parse dates to date objects. Check this page for available formats.
        /// 
        /// Please note that two-digit years(YY) as well as literal month names(MMM) are NOT supported in this setting.
        /// </summary>
        public string DataDateFormat { get; set; }

        /// <summary>
        /// Maximum number of series allowed to select.
        /// </summary>
        public int? MaxSelectedSeries { get; set; }

        /// <summary>
        /// The longest time span allowed to select (in milliseconds) for example, 259200000 will limit selection to 3 days. Works if equalSpacing is set to false (default).
        /// </summary>
        public int? MaxSelectedTime { get; set; }

        /// <summary>
        /// The shortest time span allowed to select (in milliseconds) for example, 1000 will limit selection to 1 second. Works if equalSpacing is set to false (default).
        /// </summary>
        public int? MinSelectedTime { get; set; }

        /// <summary>
        /// Specifies if scrolling of a chart with mouse wheel is enabled. If you press shift while rotating mouse wheel, the chart will zoom-in/out.
        /// </summary>
        public bool? MouseWheelScrollEnabled { get; set; }

        /// <summary>
        /// Specifies if zooming of a chart with mouse wheel is enabled. If you press shift while rotating mouse wheel, the chart will scroll.
        /// </summary>
        public bool? MouseWheelZoomEnabled { get; set; }

        /// <summary>
        /// If you set this to true, the chart will be rotated by 90 degrees (the columns will become bars).
        /// </summary>
        public bool? Rotate { get; set; }

        /// <summary>
        /// If your chart has more than one value axes and you set this property to true, the chart will show grid at equal intervals.
        /// Note, this is experimental property in beta stage yet. It will not work if you define axis minimum and maximum values yourself.
        /// </summary>
        public bool? SynchronizeGrid { get; set; }

        /// <summary>
        /// Value scrollbar, enables scrolling value axes.
        /// </summary>
        public ChartScrollbar ValueScrollbar { get; set; }

        /// <summary>
        /// Specifies if chart should zoom-out when data is updated.
        /// </summary>
        public bool? ZoomOutOnDataUpdate { get; set; }


    }
}