namespace AmChartsNet
{
    /// <summary>
    /// Base class of AmCharts. It can not be instantiated explicitly. Its makeChart method gives you the possibility to create charts easily with a single object.
    /// </summary>
    public class AmChart
    {

        /// <summary>
        /// When enabled, chart adds aria-label attributes to columns, bullets or map objects.
        /// You can control values of these labels using properties like accessibleLabel of AmGraph.
        /// Note, not all screen readers support these tags. We tested this mostly with NVDA Screen reader.
        /// WAI-ARIA is now official W3 standard, so in future more readers will handle this well.
        /// We will be improving accessibility on our charts, so we would be glad to hear your feedback.
        /// </summary>
        public bool? Accessible { get; set; }

        public bool HideCredits { get; set; } = true;

    }
}