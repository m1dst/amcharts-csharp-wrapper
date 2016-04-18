namespace AmChartsNet.Maps
{
    /// <summary>
    /// Small map displays a small map with rectangle indicating zoom level and position.
    /// </summary>
    public class SmallMap
    {

        /// <summary>
        /// Background opacity.
        /// </summary>
        public double? BackgroundAlpha { get; set; }

        /// <summary>
        /// Background color.
        /// </summary>
        public string BackgroundColor { get; set; }

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
        /// Distance from bottom of map container to the small map.You should set property "top" to NaN in order this property to work.
        /// </summary>
        public int? Bottom { get; set; }

        /// <summary>
        /// Specifies if SmallMap is enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Distance from left side of map container to the small map.You should set property "right" to NaN in order this property to work.
        /// </summary>
        public int? Left { get; set; }

        /// <summary>
        /// Color of a map of a small map control.
        /// </summary>
        public string MapColor { get; set; }

        /// <summary>
        /// Size of minimize button.You might need to change size of arrowUp.gif and arrowDown.gif if you change this property.
        /// </summary>
        public int? MinimizeButtonWidth { get; set; }

        /// <summary>
        /// Color of rectangle, which indicates zoom level and position.
        /// </summary>
        public string RectangleColor { get; set; }

        /// <summary>
        /// Distance from right side of map container to the small map.You should set property "left" to NaN in order this property to work.
        /// </summary>
        public int? Right { get; set; }

        /// <summary>
        /// Size of small map relative to map container size.
        /// </summary>
        public double? Size { get; set; }

        /// <summary>
        /// Distance from top of map container to the small map.You should set property "bottom" to NaN in order this property to work.
        /// </summary>
        public int? Top { get; set; }

    }
}