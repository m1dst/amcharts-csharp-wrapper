namespace AmChartsNet
{
    /// <summary>
    /// Creates a title on above the chart, multiple can be assigned.
    /// </summary>
    public class Title
    {

        /// <summary>
        /// Opacity of a title.
        /// </summary>
        public double? Alpha { get; set; }

        /// <summary>
        /// Specifies if title should be bold or not.
        /// </summary>
        public bool? Bold { get; set; }

        /// <summary>
        /// Text color of a title.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Unique id of a Title. You don't need to set it, unless you want to.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Text size of a title.
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Text of a title.
        /// </summary>
        public string Text { get; set; }

    }
}