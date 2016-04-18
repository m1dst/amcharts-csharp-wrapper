using System;

namespace AmChartsNet.Maps
{
    public class MapArea : MapObject
    {

        /// <summary>
        /// Specifies if the area should be zoomed-in when user clicks on it, even if zoom properties are not set.
        /// </summary>
        public bool? AutoZoom { get; set; }

        /// <summary>
        /// Opacity of area's outline.
        /// </summary>
        public double? OutlineAlpha { get; set; }

        /// <summary>
        /// Color of area's outline.
        /// </summary>
        public string OutlineColor { get; set; }

        /// <summary>
        /// Thickness of area's outline.
        /// </summary>
        public int? OutlineThickness { get; set; }

        /// <summary>
        /// Value of pattern should be object with url, width, height of an image, optionally it might have x, y, randomX and randomY values. 
        /// For example: {"url":"../amcharts/patterns/black/pattern1.png", "width":4, "height":4}. 
        /// Check ammap/patterns folder for some patterns. You can create your own patterns and use them.
        /// </summary>
        public Object Pattern { get; set; }

        /// <summary>
        /// Color of area's outline when user rolls-over it.
        /// </summary>
        public string RollOverOutlineColor { get; set; }

        /// <summary>
        /// Value of the area. Areas will be filled with color range from AreasSettings.color to AreasSettings.colorSolid, depending on the value.
        /// </summary>
        public double? Value { get; set; }

    }
}