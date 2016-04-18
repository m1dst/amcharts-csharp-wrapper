namespace AmChartsNet.Maps
{
    /// <summary>
    /// Zoom control displays zoom and pan controls on the map.
    /// </summary>
    public class ZoomControl
    {

        /// <summary>
        /// Distance from left side of map container to the zoom control.
        /// </summary>
        public int? Bottom { get; set; }

        /// <summary>
        /// Button border opacity.
        /// </summary>
        public double? ButtonBorderAlpha { get; set; }

        /// <summary>
        /// Color of button borders.
        /// </summary>
        public string ButtonColorColor { get; set; }

        /// <summary>
        /// Button border thickness.
        /// </summary>
        public int? ButtonBorderThickness { get; set; }

        /// <summary>
        /// Button roll-over color.
        /// </summary>
        public string ButtonColorHover { get; set; }

        /// <summary>
        /// Button corner radius.
        /// </summary>
        public int? ButtonCornerRadius { get; set; }

        /// <summary>
        /// Button fill opacity.
        /// </summary>
        public double? ButtonFillAlpha { get; set; }

        /// <summary>
        /// Button fill color.
        /// </summary>
        public string ButtonFillColor { get; set; }

        /// <summary>
        /// Opacity of button icons.
        /// </summary>
        public double? ButtonIconAlpha { get; set; }

        /// <summary>
        /// Button icon color.
        /// </summary>
        public string ButtonIconColor { get; set; }

        /// <summary>
        /// Button roll-over color.
        /// </summary>
        public string ButtonRollOverColor { get; set; }

        /// <summary>
        /// Size of buttons.
        /// </summary>
        public int? ButtonSize { get; set; }

        /// <summary>
        /// Opacity of a dragger.
        /// </summary>
        public double? DraggerAlpha { get; set; }

        /// <summary>
        /// Opacity of zoom-grid.
        /// </summary>
        public double? GridAlpha { get; set; }

        /// <summary>
        /// Opacity of background under zoom-grid.
        /// </summary>
        public double? GridBackgroundAlpha { get; set; }

        /// <summary>
        /// Color of background under zoom-grid.
        /// </summary>
        public string GridBackgroundColor { get; set; }

        /// <summary>
        /// Grid color.
        /// </summary>
        public string GridColor { get; set; }

        /// <summary>
        /// Zoom grid height in pixels.
        /// </summary>
        public int? GridHeight { get; set; }

        /// <summary>
        /// Specifies if home button is visible or not.
        /// </summary>
        public bool? HomeButtonEnabled { get; set; }

        /// <summary>
        /// Home icon color.
        /// </summary>
        public string HomeIconColor { get; set; }

        /// <summary>
        /// File name of home icon. You can also find homeIconWhite.gif in the images folder, or you can create your own image.
        /// </summary>
        public string HomeIconFile { get; set; }

        /// <summary>
        /// Size of icons.You might need to change size of icon gif files if you change this property.
        /// </summary>
        public int? IconSize { get; set; }

        /// <summary>
        /// Distance from left side of map container to the small map.
        /// </summary>
        public int? Left { get; set; }

        /// <summary>
        /// Max zoom level.
        /// </summary>
        public int? MaxZoomLevel { get; set; }

        /// <summary>
        /// Min zoom level.
        /// </summary>
        public int? MinZoomLevel { get; set; }

        /// <summary>
        /// Specifies if pan control is enabled.
        /// </summary>
        public bool? PanControlEnabled { get; set; }

        /// <summary>
        /// Specifies by what part of a map container width/height the map will be moved when user clicks on pan arrows.
        /// </summary>
        public double? PanStepSize { get; set; }

        /// <summary>
        /// Distance from top of map container to the small map.
        /// </summary>
        public int? Right { get; set; }

        /// <summary>
        /// Specifies if buttons should be round or not (rectangular).
        /// </summary>
        public bool? RoundButtons { get; set; }

        /// <summary>
        /// Distance from top of map container to the small map.
        /// </summary>
        public int? Top { get; set; }

        /// <summary>
        /// Specifies if zoom control is enabled.
        /// </summary>
        public bool? ZoomControlEnabled { get; set; }

        /// <summary>
        /// ZoomFactor is a number by which current scale will be multiplied when user clicks on zoom in button or divided when user clicks on zoom-out button.
        /// </summary>
        public double? ZoomFactor { get; set; }

    }
}