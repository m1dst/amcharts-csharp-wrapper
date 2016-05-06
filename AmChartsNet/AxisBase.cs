using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet
{
    /// <summary>
    /// Base class for ValueAxis and CategoryAxis. It can not be instantiated explicitly.
    /// </summary>
    public class AxisBase
    {
        /// <summary>
        ///	Specifies whether number of gridCount is specified automatically, acoarding to the axis size.	
        /// </summary>
        public bool? AutoGridCount { get; set; }

        /// <summary>
        ///	Angle of label rotation, if the number of series exceeds autoRotateCount. Works on horizontal axis only. 
        /// It is not recommended to use it with charts with zoom/scroll features, as chart adjusts margin only based on initial render.	
        /// </summary>
        public int? AutoRotateAngle { get; set; }

        /// <summary>
        ///	If the number of category axis items will exceed the autoRotateCount, the labels will be rotated by autoRotateAngle degree. 
        /// Works on horizontal axis only. Not recommended with scrollable/zoomable charts.	
        /// </summary>
        public int? AutoRotateCount { get; set; }

        /// <summary>
        ///	Axis opacity. Value range is 0 - 1.
        /// </summary>
        public double? AxisAlpha { get; set; }

        /// <summary>
        ///	Axis color.
        /// </summary>
        public string AxisColor { get; set; }

        /// <summary>
        ///	Thickness of the axis
        /// </summary>
        public int? AxisThickness { get; set; }

        /// <summary>
        ///	Read-only. Returns x coordinate of the axis.	
        /// </summary>
        public int? AxisX { get; set; }

        /// <summary>
        ///	Read-only. Returns y coordinate of the axis.	
        /// </summary>
        public int? AxisY { get; set; }

        /// <summary>
        ///	Allows customizing axes balloons individually.	
        /// </summary>
        public AmBalloon Balloon { get; set; }

        /// <summary>
        ///	Specifies if axis labels should be bold or not.	
        /// </summary>
        public bool? BoldLabels { get; set; }

        /// <summary>
        ///	When parse dates is on for the category axis, the chart will try to highlight the beginning of the periods, like month, in bold. 
        /// Set this to false to disable the functionality.	
        /// </summary>
        public bool? BoldPeriodBeginning { get; set; }

        /// <summary>
        ///	This setting works only when parseDates is set to true and equalSpacing is set to false. 
        /// In case you set it to false, labels will never be centered between grid lines.
        /// </summary>
        public bool? CenterLabelOnFullPeriod { get; set; }

        /// <summary>
        ///	Force-centers labels of date-based axis (in case it's category axis, equalSpacing must be false)	
        /// </summary>
        public bool? CenterLabels { get; set; }

        /// <summary>
        ///	Color of axis value labels. Will use chart's color if not set.	
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        ///	Length of a dash. 0 means line is not dashed.
        /// </summary>
        public int? DashLength { get; set; }

        /// <summary>
        ///	Date formats of different periods. 
        /// Possible period values: fff - milliseconds, ss - seconds, mm - minutes, hh - hours, DD - days, MM - months, WW - weeks, YYYY - years.
        /// </summary>
        public List<Object> DateFormats { get; set; }

        /// <summary>
        ///	Fill opacity. Every second space between grid lines can be filled with color. 
        /// Set fillAlpha to a value greater than 0 to see the fills.
        /// </summary>
        public double? FillAlpha { get; set; }

        /// <summary>
        ///	Fill color. Every second space between grid lines can be filled with color. 
        /// Set fillAlpha to a value greater than 0 to see the fills.	
        /// </summary>
        public string FillColor { get; set; }

        /// <summary>
        ///	Sets first day of the week. 0 is Sunday, 1 is Monday, etc.
        /// </summary>
        public int? FirstDayOfWeek { get; set; }

        /// <summary>
        ///	Size of value labels text. Will use chart's fontSize if not set.	
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        ///	Opacity of grid lines.

        /// </summary>
        public double? GridAlpha { get; set; }

        /// <summary>
        ///	Color of grid lines.	
        /// </summary>
        public string GridColor { get; set; }

        /// <summary>
        ///	Number of grid lines. In case this is value axis, or your categoryAxis parses dates, the number is approximate. 
        /// The default value is 5. If you set autoGridCount to true, this property is ignored.	
        /// </summary>
        public int? GridCount { get; set; }

        /// <summary>
        ///	Thickness of grid lines.	
        /// </summary>
        public int? GridThickness { get; set; }

        /// <summary>
        ///	The array of guides belonging to this axis.	
        /// </summary>
        public List<Guide> Guides { get; set; }

        /// <summary>
        ///	If autoMargins of a chart is set to true, but you want this axis not to be measured when calculating margin, set ignoreAxisWidth to true.
        /// </summary>
        public bool? IgnoreAxisWidth { get; set; }

        /// <summary>
        ///	Specifies whether values should be placed inside or outside plot area.
        /// </summary>
        public bool? Inside { get; set; }

        /// <summary>
        ///	Frequency at which labels should be placed. Doesn't work for CategoryAxis if parseDates is set to true.
        /// </summary>
        public int? LabelFrequency { get; set; }

        /// <summary>
        ///	You can use it to adjust position of axes labels. Works both with CategoryAxis and ValueAxis.
        /// </summary>
        public int? LabelOffset { get; set; }

        /// <summary>
        ///	Rotation angle of a label. Only horizontal axis' values can be rotated. 
        /// If you set this for vertical axis, the setting will be ignored. Possible values from -90 to 90.	
        /// </summary>
        public int? LabelRotation { get; set; }

        /// <summary>
        ///	Specifies whether axis displays category axis' labels and value axis' values.	
        /// </summary>
        public bool? LabelsEnabled { get; set; }

        /// <summary>
        ///	You can add listeners of events using this property. Example: listeners = [{"event":"clickItem", "method":handleEvent}];	
        /// </summary>
        public List<Object> Listeners { get; set; }

        /// <summary>
        ///	If you set it to false, the start of longer periods won't use a different date format and won't be bold.	
        /// </summary>
        public bool? MarkPeriodChange { get; set; }

        /// <summary>
        ///	This property is used when calculating grid count (when autoGridCount is true). 
        /// It specifies minimum cell width required for one span between grid lines.	
        /// </summary>
        public int? MinHorizontalGap { get; set; }

        /// <summary>
        ///	Opacity of minor grid. In order minor to be visible, you should set minorGridEnabled to true.
        /// </summary>
        public double? MinorGridAlpha { get; set; }

        /// <summary>
        ///	Specifies if minor grid should be displayed.
        /// NOTE: If equalSpacing is set to true, this setting will be ignored.
        /// </summary>
        public bool? MinorGridEnabled { get; set; }

        /// <summary>
        ///	Length of minor grid tick.	
        /// </summary>
        public int? MinorTickLength { get; set; }

        /// <summary>
        ///	This property is used when calculating grid count (when autoGridCount is true). It specifies minimum cell height required for one span between grid lines.
        /// </summary>
        public int? MinVerticalGap { get; set; }

        /// <summary>
        ///	The distance of the axis to the plot area, in pixels. Negative values can also be used.	
        /// </summary>
        public int?	Offset	{ get; set; }

        /// <summary>
        ///	Possible values are: "top", "bottom", "left", "right". If axis is vertical, default position is "left". If axis is horizontal, default position is "bottom".
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public AxisPosition? Position { get; set; }

        /// <summary>
        ///	Whether to show first axis label or not. This works properly only on ValueAxis. 
        /// WithCategoryAxis it wont work 100%, it depends on the period, zooming, etc. 
        /// There is no guaranteed way to force category axis to show or hide first label.
        /// </summary>
        public bool? ShowFirstLabel { get; set; }

        /// <summary>
        ///	Whether to show last axis label or not. This works properly only on ValueAxis. 
        /// WithCategoryAxis it wont work 100%, it depends on the period, zooming, etc. 
        /// There is no guaranteed way to force category axis to show or hide last label.	
        /// </summary>
        public bool? ShowLastLabel { get; set; }

        /// <summary>
        ///	Length of the tick marks.
        /// </summary>
        public int? TickLength { get; set; }

        /// <summary>
        ///	Title of the axis.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///	Specifies if title should be bold or not.	
        /// </summary>
        public bool? TitleBold { get; set; }

        /// <summary>
        ///	Color of axis title. Will use text color of chart if not set any.	
        /// </summary>
        public string TitleColor { get; set; }

        /// <summary>
        ///	Font size of axis title. Will use font size of chart plus two pixels if not set any.	
        /// </summary>
        public int? TitleFontSize { get; set; }

        /// <summary>
        ///	Rotation of axis title. Useful if you want to make vertical axis title to be shown from top to down.	
        /// </summary>
        public int? TitleRotation { get; set; }

    }
}