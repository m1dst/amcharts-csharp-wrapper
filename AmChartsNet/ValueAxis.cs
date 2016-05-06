using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet
{
    public class ValueAxis : AxisBase
    {

        /// <summary>
        /// Works with Radar chart only. If you have a big number of axes, this property will help you to show every x axis only.
        /// </summary>
        public int? AxisFrequency { get; set; }

        /// <summary>
        /// Radar chart only. Specifies distance from axis to the axis title (category)
        /// </summary>
        public int? AxisTitleOffset { get; set; }

        /// <summary>
        /// You can use this function to format balloon text of the axis. This function is called and balloon text or date (if axis is date-based) is passed as an argument. It should return string which will be displayed in the balloon.
        /// </summary>
        public string BalloonTextFunction { get; set; }

        /// <summary>
        /// Specifies base value of the axis.
        /// </summary>
        public double? BaseValue { get; set; }

        /// <summary>
        /// If your values represents time units, and you want value axis labels to be formatted as duration, you have to set the duration unit. Possible values are: "ss", "mm", "hh" and "DD".
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// If duration property is set, you can specify what string should be displayed next to day, hour, minute and second.
        /// </summary>
        public string DurationUnits { get; set; }

        /// <summary>
        /// Radar chart only. Possible values are: "polygons" and "circles". Set "circles" for polar charts.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public GridType? GridType { get; set; }

        /// <summary>
        /// Unique id of value axis. It is not required to set it, unless you need to tell the graph which exact value axis it should use.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// If you set it to true, minimum and maximum of value axis will not change while zooming/scrolling.
        /// </summary>
        public bool? IncludeAllValues { get; set; }

        /// <summary>
        /// Specifies whether guide values should be included when calculating min and max of the axis.
        /// </summary>
        public bool? IncludeGuidesInMinMax { get; set; }

        /// <summary>
        /// If true, the axis will include hidden graphs when calculating min and max values.
        /// </summary>
        public bool? IncludeHidden { get; set; }

        /// <summary>
        /// Specifies whether values on axis can only be integers or both integers and doubles.
        /// </summary>
        public bool? IntegersOnly { get; set; }

        /// <summary>
        /// You can use this function to format Value axis labels. This function is called and these parameters are passed: labelFunction(value, valueText, valueAxis);
        /// Where value is numeric value, valueText is formatted string and valueAxis is a reference to valueAxis object.
        /// If axis type is "date", labelFucntion will pass different arguments:
        /// labelFunction(valueText, date, valueAxis)
        /// Your function should return string.
        /// </summary>
        public string LabelFunction { get; set; }

        /// <summary>
        /// Specifies if this value axis' scale should be logarithmic.
        /// </summary>
        public bool? Logarithmic { get; set; }

        /// <summary>
        /// If you don't want max value to be calculated by the chart, set it using this property.
        /// This value might still be adjusted so that it would be possible to draw grid at rounded intervals.
        /// </summary>
        public double? Maximum { get; set; }

        /// <summary>
        /// If your value axis is date-based, you can specify maximum date of the axis.
        /// Can be set as date object, timestamp number or string if dataDateFormat is set.
        /// </summary>
        public DateTime? MaximumDate { get; set; }

        /// <summary>
        /// If you don't want min value to be calculated by the chart, set it using this property.
        /// This value might still be adjusted so that it would be possible to draw grid at rounded intervals.
        /// </summary>
        public double? Minimum { get; set; }

        /// <summary>
        /// If your value axis is date-based, you can specify minimum date of the axis.
        /// Can be set as date object, timestamp number or string if dataDateFormat is set.
        /// </summary>
        public DateTime? MinimumDate { get; set; }

        /// <summary>
        /// If set value axis scale (min and max numbers) will be multiplied by it. I.e. if set to 1.2 the scope of values will increase by 20%.
        /// </summary>
        public double? MinMaxMultiplier { get; set; }

        /// <summary>
        /// Works with radar charts only. If you set it to “middle”, labels and data points will be placed in the middle between axes.
        /// </summary>
        public string PointPosition { get; set; }

        /// <summary>
        /// Precision (number of decimals) of values.
        /// </summary>
        public int? Precision { get; set; }

        /// <summary>
        /// Radar chart only. Specifies if categories (axes' titles) should be displayed near axes)
        /// </summary>
        public bool? RadarCategoriesEnabled { get; set; }

        /// <summary>
        /// Specifies if graphs's values should be recalculated to percents.
        /// </summary>
        public bool? RecalculateToPercents { get; set; }

        /// <summary>
        /// Specifies if value axis should be reversed (smaller values on top).
        /// </summary>
        public bool? Reversed { get; set; }

        /// <summary>
        /// Stacking mode of the axis.
        /// Note, only graphs of one type will be stacked.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public StackType? StackType { get; set; }

        /// <summary>
        /// If you set minimum and maximum for your axis, chart adjusts them so that grid would start and end on the beginning and end of plot area and grid would be at equal intervals. 
        /// If you set strictMinMax to true, the chart will not adjust minimum and maximum of value axis.
        /// </summary>
        public bool? StrictMinMax { get; set; }

        /// <summary>
        /// In case you synchronize one value axis with another, you need to set the synchronization multiplier. Use synchronizeWithAxis method to set with which axis it should be synced.
        /// </summary>
        public double? SynchronizationMultiplier { get; set; }

        /// <summary>
        /// One value axis can be synchronized with another value axis. You can use both reference to your axis or id of the axis here.
        ///  You should set synchronizationMultiplyer in order for this to work.
        /// </summary>
        public ValueAxis SynchronizeWith { get; set; }

        /// <summary>
        /// If this value axis is stacked and has columns, setting valueAxis.totalText = "[[total]]" will make it to display total value above the most-top column.
        /// </summary>
        public string TotalText { get; set; }

        /// <summary>
        /// Color of total text.
        /// </summary>
        public string TotalTextColor { get; set; }

        /// <summary>
        /// Distance from data point to total text.
        /// </summary>
        public int? TotalTextOffset { get; set; }

        /// <summary>
        /// This allows you to have logarithmic value axis and have zero values in the data. You must set it to >0 value in order to work.
        /// </summary>
        public int? TreatZeroAs { get; set; }

        /// <summary>
        /// Type of value axis. If your values in data provider are dates and you want this axis to show dates instead of numbers, set it to "date".
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Unit which will be added to the value label.
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Position of the unit. Possible values are "left" and "right".
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public UnitPosition? UnitPosition { get; set; }

        /// <summary>
        /// If true, prefixes will be used for big and small numbers.
        /// You can set arrays of prefixes directly to the chart object via prefixesOfSmallNumbers and prefixesOfBigNumbers.
        /// </summary>
        public bool? UsePrefixes { get; set; }

        /// <summary>
        /// If true, values will always be formatted using scientific notation (5e+8, 5e-8...)
        /// Otherwise only values bigger then 1e+21 and smaller then 1e-7 will be displayed in scientific notation.
        /// </summary>
        public bool? UseScientificNotation { get; set; }

        /// <summary>
        /// Opacity of a zero grid line. By default it is equal to 2 x gridAlpha.
        /// </summary>
        public double? ZeroGridAlpha { get; set; }

    }
}