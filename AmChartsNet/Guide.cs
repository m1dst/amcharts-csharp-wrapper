using System;

namespace AmChartsNet
{
    /// <summary>
    /// Creates a horizontal/vertical guideline-/area for AmSerialChart, AmXYChart and AmRadarChart charts, automatically adapts it's settings from the axes if none has been specified.
    /// </summary>
    public class Guide
    {

        /// <summary>
        /// If you set it to true, the guide will be displayed above the graphs.
        /// </summary>
        public bool? Above { get; set; }

        /// <summary>
        /// Radar chart only. Specifies angle at which guide should start. Affects only fills, not lines.
        /// </summary>
        public int? Angle { get; set; }

        /// <summary>
        /// Balloon fill color.
        /// </summary>
        public string BalloonColor { get; set; }

        /// <summary>
        /// The text which will be displayed if the user rolls-over the guide.
        /// </summary>
        public string BalloonText { get; set; }

        /// <summary>
        /// Specifies if label should be bold or not.
        /// </summary>
        public bool? BoldLabel { get; set; }

        /// <summary>
        /// Category of the guide (in case the guide is for category axis).
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Color of a guide label.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Dash length.
        /// </summary>
        public int? DashLength { get; set; }

        /// <summary>
        /// Date of the guide (in case the guide is for category axis and parseDates is set to true).
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Works if a guide is added to CategoryAxis and this axis is non-date-based. 
        /// If you set it to true, the guide will start (or be placed, if it's not a fill) on the beginning of the category cell and will end at the end of toCategory cell.
        /// </summary>
        public bool? Expand { get; set; }

        /// <summary>
        /// Fill opacity. Value range is 0 - 1.
        /// </summary>
        public double? FillAlpha { get; set; }

        /// <summary>
        /// Fill color.
        /// </summary>
        public string FillColor { get; set; }

        /// <summary>
        /// Font size of guide label.
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        /// Unique id of a Guide. You don't need to set it, unless you want to.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Specifies whether label should be placed inside or outside plot area.
        /// </summary>
        public bool? Inside { get; set; }

        /// <summary>
        /// The label which will be displayed near the guide.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Rotation angle of a guide label.
        /// </summary>
        public int? LabelRotation { get; set; }

        /// <summary>
        /// Line opacity.
        /// </summary>
        public double? LineAlpha { get; set; }

        /// <summary>
        /// Line color.
        /// </summary>
        public string LineColor { get; set; }

        /// <summary>
        /// Line thickness.
        /// </summary>
        public int? LineThickness { get; set; }

        /// <summary>
        /// Position of guide label. Possible values are "left" or "right" for horizontal axis and "top" or "bottom" for vertical axis.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Tick length.
        /// </summary>
        public int? TickLength { get; set; }

        /// <summary>
        /// Radar chart only. Specifies angle at which guide should end. Affects only fills, not lines.
        /// </summary>
        public int? ToAngle { get; set; }

        /// <summary>
        /// "To" category of the guide (in case the guide is for category axis).
        /// </summary>
        public string ToCategory { get; set; }

        /// <summary>
        /// "To" date of the guide (in case the guide is for category axis and parseDates is set to true)
        /// If you have both date and toDate, the space between these two dates can be filled with color.
        /// </summary>
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// "To" value of the guide (in case the guide is for value axis).
        /// </summary>
        public double? ToValue { get; set; }

        /// <summary>
        /// Value of the guide (in case the guide is for value axis).
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Value axis of a guide. As you can add guides directly to the chart, you might need to specify which which value axis should be used.
        /// </summary>
        public ValueAxis ValueAxis { get; set; }

    }
}