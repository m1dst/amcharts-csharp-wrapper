using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet
{
    /// <summary>
    /// Base class of AmRectangularChart and AmRadarChart. It can not be instantiated explicitly.
    /// </summary>
    public class AmCoordinateChart : AmChart
    {
        /// <summary>
        /// Specifies the colors of the graphs if the lineColor of a graph is not set. If there are more graphs then colors in this array, the chart picks a random color.
        /// </summary>
        public List<string> Colors { get; set; }

        /// <summary>
        /// The array of graphs belonging to this chart.
        /// </summary>
        public List<AmGraph> Graphs { get; set; }

        /// <summary>
        /// Specifies if grid should be drawn above the graphs or below. Will not work properly with 3D charts.
        /// </summary>
        public bool? GridAboveGraphs { get; set; }

        /// <summary>
        /// Instead of adding guides to the axes, you can push all of them to this array. 
        /// In case guide has category or date defined, it will automatically will be assigned to the category axis.
        ///  Otherwise to first value axis, unless you specify a different valueAxis for the guide.
        /// </summary>
        public List<Guide> Guides { get; set; }

        /// <summary>
        /// Specifies whether the animation should be sequenced or all objects should appear at once.
        /// </summary>
        public bool? SequencedAnimation { get; set; }

        /// <summary>
        /// The initial opacity of the column/line. If you set startDuration to a value higher than 0, the columns/lines will fade in from startAlpha. Value range is 0 - 1.
        /// </summary>
        public double? StartAlpha { get; set; }

        /// <summary>
        /// Duration of the animation, in seconds.
        /// </summary>
        public int? StartDuration { get; set; }

        /// <summary>
        /// Animation effect.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public AnimationEffect? StartEffect { get; set; }

        /// <summary>
        /// Target of url.
        /// </summary>
        public string UrlTarget { get; set; }

        /// <summary>
        /// The array of value axes. Chart creates one value axis automatically, so if you need only one value axis, you don't need to create it.
        /// </summary>
        public List<ValueAxis> ValueAxes { get; set; }

    }
}