namespace AmChartsNet.Maps
{
    /// <summary>
    /// AreasSettings is a class which holds common settings of all MapArea objects.
    /// </summary>
    public class AreasSettings
    {

        /// <summary>
        /// Will add aria-label tag to images. It will be read by some of screen readers when user hovers them.
        /// </summary>
        public string AccessibleLabel { get; set; }

        /// <summary>
        /// By default the map will adjust area outlines when zooming in/out so that they will always stay of the same width.
        /// This however loads CPU quite a lot. If you set it to false, outlines will scale together with the areas.
        /// </summary>
        public bool? AdjustOutlineThickness { get; set; }

        /// <summary>
        /// Opacity of areas.
        /// </summary>
        public double? Alpha { get; set; }

        /// <summary>
        /// Specifies if the areas should be zoomed-in when user clicks on them, event if zoom properties are not set.
        /// </summary>
        public bool? AutoZoom { get; set; }

        /// <summary>
        /// Text which is displayed in a roll-over balloon. You can use the following tags: [[title]], [[description]], [[value]] and [[percent]]
        /// </summary>
        public string BalloonText { get; set; }

        /// <summary>
        /// Specifies if an area should change its z-index to the most top when user hovers it.
        /// </summary>
        public bool? BringForwardOnHover { get; set; }

        /// <summary>
        /// Color of the areas.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Color of area with highest value. Colors for areas with values less then highest will be colored with intermediate colors between color and colorSolid. Use colorSteps property of AmMap to change the number of intermediate colors.
        /// </summary>
        public string ColorSolid { get; set; }

        /// <summary>
        /// Distance from the bottom side of map container to the description window. In case it is not set (also if descriptionWindowTop is not set), window will be placed near the mouse pointer.
        /// </summary>
        public string DescriptionWindowBottom { get; set; }

        /// <summary>
        /// Height of a description window.
        /// </summary>
        public string DescriptionWindowHeight { get; set; }

        /// <summary>
        /// Distance from the left side of map container to the description window. In case it is not set (also if descriptionWindowRight is not set), window will be placed near the mouse pointer.
        /// </summary>
        public string DescriptionWindowLeft { get; set; }

        /// <summary>
        /// Distance from the right side of map container to the description window. In case it is not set (also if descriptionWindowLeft is not set), window will be placed near the mouse pointer.
        /// </summary>
        public string DescriptionWindowRight { get; set; }

        /// <summary>
        /// Distance from the top side of map container to the description window. In case it is not set (also if descriptionWindowBottom is not set), window will be placed near the mouse pointer.
        /// </summary>
        public string DescriptionWindowTop { get; set; }

        /// <summary>
        /// Width of a description window.
        /// </summary>
        public string DescriptionWindowWidth { get; set; }

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
        public double? OutlineThickness { get; set; }

        /// <summary>
        /// Color of area when user rolls-over it.
        /// </summary>
        public string RollOverColor { get; set; }

        /// <summary>
        /// Opacity of rolled-over area outline.
        /// </summary>
        public double? RollOverOutlineAlpha { get; set; }

        /// <summary>
        /// Color of area's outline when user rolls-over it.
        /// </summary>
        public string RollOverOutlineColor { get; set; }

        /// <summary>
        /// Thickness of rolled-over area outline.
        /// </summary>
        public int? RollOverOutlineThickness { get; set; }

        /// <summary>
        /// Specifies if areas are selectable, even no zoom/description/url is set.
        /// </summary>
        public bool Selectable { get; set; }

        /// <summary>
        /// Color of area which is currently selected.
        /// </summary>
        public string SelectedColor { get; set; }

        /// <summary>
        /// Color of selected area's outline.
        /// </summary>
        public string SelectedOutlineColor { get; set; }

        /// <summary>
        /// Thickness of selected area outline.
        /// </summary>
        public int? SelectedOutlineThickness { get; set; }

        /// <summary>
        /// Opacity of all areas which are in the map svg file, but not listed as areas in DataSet.
        /// </summary>
        public double? UnlistedAreasAlpha { get; set; }

        /// <summary>
        /// Color of all areas which are in the map svg file, but not listed as areas in DataSet.
        /// </summary>
        public string UnlistedAreasColor { get; set; }

        /// <summary>
        /// Opacity of all areas' outline which are in the map svg file, but not listed as areas in DataSet.
        /// </summary>
        public double? UnlistedAreasOutlineAlpha { get; set; }

        /// <summary>
        /// Color of all areas' outline which are in the map svg file, but not listed as areas in DataSet.
        /// </summary>
        public string UnlistedAreasOutlineColor { get; set; }

    }
}