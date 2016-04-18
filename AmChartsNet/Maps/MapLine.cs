using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet.Maps
{
    public class MapLine : MapObject
    {

        /// <summary>
        /// Using this setting you can make lines to be curved, or actually to make them look like arcs. Note, there is one limitation - this works well with two-point lines only.
        /// </summary>
        public double? Arc { get; set; }

        /// <summary>
        /// Arrow position.Allowed values are: start, end, middle, both, none.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public ArrowPosition? Arrow { get; set; }

        /// <summary>
        /// Opacity of an arrow.
        /// </summary>
        public double? ArrowAlpha { get; set; }

        /// <summary>
        /// Color of an arrow.
        /// </summary>
        public string ArrowColor { get; set; }

        /// <summary>
        /// Size of an arrow.
        /// </summary>
        public int? ArrowSize { get; set; }

        /// <summary>
        /// Dash length.
        /// </summary>
        public int? DashLength { get; set; }

        /// <summary>
        /// Array of latitudes. If you set array of latitudes and longitudes, line move with the map.In case you want the line to be in a fixed position, set x and y arrays instead.
        /// </summary>
        public Tuple<double, double> Latitudes { get; set; }

        /// <summary>
        /// Array of longitudes. If you set array of latitudes and longitudes, line move with the map.In case you want the line to be in a fixed position, set x and y arrays instead.
        /// </summary>
        public Tuple<double, double> Longitudes { get; set; }

        /// <summary>
        /// Line thickness.
        /// </summary>
        public int? Thickness { get; set; }

    }
}