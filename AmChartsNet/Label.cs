namespace AmChartsNet
{
    /// <summary>
    /// Creates a label on the chart which can be placed anywhere, multiple can be assigned.
    /// </summary>
    public class Label
    {

        /// <summary>
        /// Alignment of the label.
        /// </summary>
        public string Align { get; set; }

        /// <summary>
        /// Opacity of the label.
        /// </summary>
        public double? Alpha { get; set; }

        /// <summary>
        /// Specifies if label should be bold or not.
        /// </summary>
        public bool? Bold { get; set; }

        /// <summary>
        /// Text color of a label.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Unique id of a label. You don't need to set it, unless you want to.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Rotation angle.
        /// </summary>
        public double? Rotation { get; set; }

        /// <summary>
        /// Text size of a label.
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Text of a label.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// URL which will be accessed if user clicks on a label.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// X position of a label.
        /// </summary>
        public string X { get; set; }

        /// <summary>
        /// Y position of a label.
        /// </summary>
        public string Y { get; set; }

    }
}