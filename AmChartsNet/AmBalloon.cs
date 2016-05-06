using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet
{
    /// <summary>
    /// Creates the balloons ( tooltips ) of the chart, It follows the mouse cursor when you roll-over the data items.
    /// The framework generates the instances automatically you only need to adjust the appearance to your needs.
    /// </summary>
    public class AmBalloon
    {

        /// <summary>
        /// If this is set to true, border color instead of background color will be changed when user rolls-over the slice, graph, etc.
        /// </summary>
        public bool? AdjustBorderColor { get; set; }

        /// <summary>
        /// Duration of balloon movement from previous point to current point, in seconds.
        /// </summary>
        public double? AnimationDuration { get; set; }

        /// <summary>
        /// Balloon border opacity. Value range is 0 - 1.
        /// </summary>
        public double? BorderAlpha { get; set; }

        /// <summary>
        /// Balloon border color. Will only be used of adjustBorderColor is false.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Balloon border thickness.
        /// </summary>
        public int? BorderThickness { get; set; }

        /// <summary>
        /// Color of text in the balloon.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Balloon corner radius.
        /// </summary>
        public int? CornerRadius { get; set; }

        /// <summary>
        /// In case your balloon has links, you have to set this to true in order links to work.
        /// </summary>
        public bool? DisableMouseEvents { get; set; }

        /// <summary>
        /// Allows having drop-shaped balloons.Note, these balloons will not check for overlapping with other balloons, or if they go outside plot area.
        /// It also does not change pointer orientation automatically based on its vertical position like regular balloons do. 
        /// You can use pointerOrientation property if you want it to point to different direction. Not supported by IE8.
        /// </summary>
        public bool? Drop { get; set; }

        /// <summary>
        /// Use this property to disable balloons for certain value axes.
        /// </summary>
        /// <example>
        /// "valueAxes": [{
        ///   // ...
        ///   // value balloons are shown
        /// }, {
        ///   // ...
        ///   "balloon": {
        ///   "enabled": false
        ///   }
        ///   // value balloons are not shown
        /// }]
        /// </example>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Duration of a fade out animation, in seconds.
        /// </summary>
        public double? FadeOutDuration { get; set; }

        /// <summary>
        /// Balloon background opacity.
        /// </summary>
        public double? FillAlpha { get; set; }

        /// <summary>
        /// Balloon background color.Usually balloon background color is set by the chart.
        /// Only if "adjustBorderColor" is "true" this color will be used.
        /// </summary>
        public string FillColor { get; set; }

        /// <summary>
        /// Specifies if balloon should follow mouse when hovering the slice/column/bullet or stay in fixed position (this does not affect balloon behavior if ChartCursor is used).
        /// </summary>
        public bool? FixedPosition { get; set; }

        /// <summary>
        /// Size of text in the balloon.Chart's fontSize is used by default.
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        /// Horizontal padding of the balloon.
        /// </summary>
        public int? HorizontalPadding { get; set; }

        /// <summary>
        /// Maximum width of a balloon.
        /// </summary>
        public int? MaxWidth { get; set; }

        /// <summary>
        /// Defines horizontal distance from mouse pointer to balloon pointer. If you set it to a small value, the balloon might flicker, as mouse might lose focus on hovered object.
        /// NOTE: this setting is ignored unless fixedPosition is set to false.
        /// </summary>
        public int? OffsetX { get; set; }

        /// <summary>
        /// Defines vertical distance from mouse pointer to balloon pointer. If you set it to a small value, the balloon might flicker, as mouse might lose focus on hovered object.
        /// NOTE: this setting is ignored unless fixedPosition is set to false.
        /// </summary>
        public int? OffsetY { get; set; }

        /// <summary>
        /// Works only if balloon.drop set to true, specifies direction of a pointer.
        /// </summary>
        public string PointerOrientation { get; set; }

        /// <summary>
        /// The width of the pointer(arrow) "root". Only used if cornerRadius is 0.
        /// </summary>
        public int? PointerWidth { get; set; }

        /// <summary>
        /// Opacity of a shadow.
        /// </summary>
        public double? ShadowAlpha { get; set; }

        /// <summary>
        /// Color of a shadow.
        /// </summary>
        public string ShadowColor { get; set; }

        /// <summary>
        /// If cornerRadius of a balloon is >0, showBullet is set to true for value balloons when ChartCursor is used.
        /// If you don't want the bullet near the balloon, set it to false: chart.balloon.showBullet = false
        /// </summary>
        public bool? ShowBullet { get; set; }

        /// <summary>
        /// Text alignment
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public TextAlign? TextAlign { get; set; }

        /// <summary>
        /// Vertical padding of the balloon.
        /// </summary>
        public int? VerticalPadding { get; set; }

    }
}