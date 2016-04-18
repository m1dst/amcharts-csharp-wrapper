namespace AmChartsNet.Maps
{
    /// <summary>
    /// This class displays a color range used by areas (in case you set values for your areas).
    /// </summary>
    public class ValueLegend
    {

        /// <summary>
        /// Border opacity.
        /// </summary>
        public double? BorderAlpha { get; set; }

        /// <summary>
        /// Border color.
        /// </summary>
        public string BorderColor { get; set; } 

        /// <summary>
        /// Border thickness.
        /// </summary>
        public int? BorderThickness { get; set; }

        /// <summary>
        /// Distance from bottom of the map container to the value legend.
        /// </summary>
        public int? Bottom { get; set; }

        /// <summary>
        /// Text color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Specifies if value legend is enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Font size.
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        /// Height of value legend.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Distance from left of the map container to the value legend.
        /// </summary>
        public int? Left { get; set; }

        /// <summary>
        /// Value, which will be displayed on the right of the legend (will display max value in case not set any).
        /// </summary>
        public string MaxValue { get; set; }

        /// <summary>
        /// Value which will be displayed on the left of a legend.
        /// </summary>
        public string MinValue { get; set; }

        /// <summary>
        /// Distance from right of the map container to the value legend.
        /// </summary>
        public int? Right { get; set; }

        /// <summary>
        /// Specifies if color range should be displayed as a gradient or as a set of rectangles, each with different color.
        /// </summary>
        public bool? ShowAsGradient { get; set; }

        /// <summary>
        /// Distance from top of the map container to the value legend.
        /// </summary>
        public int? Top { get; set; }

        /// <summary>
        /// Width of value legend.
        /// </summary>
        public int? Width { get; set; }

    }
}