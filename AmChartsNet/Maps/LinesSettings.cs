using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet.Maps
{
    /// <summary>
    /// LinesSettings is a class which holds common settings of all MapLine Objects.
    /// </summary>
    public class LinesSettings
    {

        /// <summary>
        /// Will add aria-label tag to lines. It will be read by some of screen readers when user hovers them.
        /// </summary>
        public string AccessibleLabel { get; set; }

        /// <summary>
        /// Using this setting you can make lines to be curved, or actually to make them look like arcs. Note, there is one limitation - this works well with two-point lines only.
        /// </summary>
        public double? Arc { get; set; }

        /// <summary>
        /// Opacity of the image.
        /// </summary>
        public double? Alpha { get; set; }

        /// <summary>
        /// Position of the arrows.Possible values are "start", "end", "middle", "both" and "none".
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public ArrowPosition? Arrow { get; set; }

        /// <summary>
        /// Opacity of the arrows.
        /// </summary>
        public double? ArrowAlpha { get; set; }

        /// <summary>
        /// Arrow color. Will use line color if not set.
        /// </summary>
        public string ArrowColor { get; set; }

        /// <summary>
        /// Size of the arrows.
        /// </summary>
        public int? ArrowSize { get; set; }

        /// <summary>
        /// Text which is displayed in a roll-over balloon. You can use the following tags: [[title]], [[description]], [[value]] and [[percent]]
        /// </summary>
        public string BalloonText { get; set; }

        /// <summary>
        /// Specifies if line should change it's z-index to the most top when user hovers it.
        /// </summary>
        public bool? BringForwardOnHover { get; set; }

        /// <summary>
        /// Line color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Length of a dash. 0 means line is not dashed.
        /// </summary>
        public int? DashLength { get; set; }

        /// <summary>
        /// Distance from the bottom side of map container to the description window. In case it is not set (also if descriptionWindowTop is not set), window will be placed near the mouse pointer.
        /// </summary>
        public int? DescriptionWindowBottom { get; set; }

        /// <summary>
        /// Height of a description window.
        /// </summary>
        public int? DescriptionWindowHeight { get; set; }

        /// <summary>
        /// Distance from the left side of map container to the description window. In case it is not set (also if descriptionWindowRight is not set), window will be placed near the mouse pointer.
        /// </summary>
        public int? DescriptionWindowLeft { get; set; }

        /// <summary>
        /// Distance from the right side of map container to the description window. In case it is not set (also if descriptionWindowLeft is not set), window will be placed near the mouse pointer.
        /// </summary>
        public int? DescriptionWindowRight { get; set; }

        /// <summary>
        /// Distance from the top side of map container to the description window. In case it is not set (also if descriptionWindowBottom is not set), window will be placed near the mouse pointer.
        /// </summary>
        public int? DescriptionWindowTop { get; set; }

        /// <summary>
        /// Width of a description window.
        /// </summary>
        public int? DescriptionWindowWidth { get; set; }

        /// <summary>
        /// Line thickness.
        /// </summary>
        public int? Thickness { get; set; }

    }
}