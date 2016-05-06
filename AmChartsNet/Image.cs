namespace AmChartsNet
{
    public class Image
    {

        /// <summary>
        /// Roll-over balloon color.
        /// </summary>
        public string BalloonColor { get; set; }

        /// <summary>
        /// Roll-over text.
        /// </summary>
        public string BalloonText { get; set; }

        /// <summary>
        /// Color of an image. Works only if an image is generated using SVG path (using svgPath property on an Image)
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Height of an image.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Horizontal offset.
        /// </summary>
        public int? OffsetX { get; set; }

        /// <summary>
        /// Vertical offset.
        /// </summary>
        public int? OffsetY { get; set; }

        /// <summary>
        /// Color of image outline. Works only if an image is generated using SVG path (using svgPath property on an Image)
        /// </summary>
        public string OutlineColor { get; set; }

        /// <summary>
        /// Rotation of an image.
        /// </summary>
        public int? Rotation { get; set; }

        /// <summary>
        /// Svg path of an image. Will not work with IE8.
        /// </summary>
        public string SvgPath { get; set; }

        /// <summary>
        /// Url of an image.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Width on an image.
        /// </summary>
        public int? Width { get; set; }

    }
}