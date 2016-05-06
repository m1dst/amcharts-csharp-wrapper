using System;

namespace AmChartsNet
{
    /// <summary>
    /// Creates a trendline for AmSerialChart and AmXYChart charts which indicates the trend of your data or covers some different purposes. 
    /// Multiple can be assigned.
    /// </summary>
    public class TrendLine
    {

        public string BalloonText { get; set; }
        public int? DashLength { get; set; }
        public string FinalCategory { get; set; }
        public DateTime? FinalDate { get; set; }
        public Image FinalImage { get; set; }
        public int? FinalValue { get; set; }
        public int? FinalXValue { get; set; }
        public string Id { get; set; }
        public string InitialCategory { get; set; }
        public DateTime? InitialDate { get; set; }
        public Image InitialImage { get; set; }
        public int? InitialValue { get; set; }
        public int? InitialXValue { get; set; }
        public bool? IsProtected { get; set; }
        public double? LineAlpha { get; set; }
        public string LineColor { get; set; }
        public int? LineThickness { get; set; }
        public ValueAxis ValueAxis { get; set; }
        public ValueAxis ValueAxisX { get; set; }


    }
}