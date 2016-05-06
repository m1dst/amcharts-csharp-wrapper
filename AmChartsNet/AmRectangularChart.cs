using System.Collections.Generic;

namespace AmChartsNet
{
    /// <summary>
    /// Extension for AmCoordinateChart and base class of AmSerialChart and AmXYChart. It can not be instantiated explicitly.
    /// </summary>
    public class AmRectangularChart : AmCoordinateChart
    {

        public int? Angle { get; set; }
        public int? AutoMarginOffset { get; set; }
        public bool? AutoMargins { get; set; }
        public ChartCursor ChartCursor { get; set; }
        public ChartScrollbar ChartScrollbar { get; set; }
        public int? Depth3D { get; set; }
        public int? MarginBottom { get; set; }
        public int? MarginLeft { get; set; }
        public int? MarginRight { get; set; }
        public bool? MarginsUpdated { get; set; }
        public int? MarginTop { get; set; }
        public int? MaxZoomFactor { get; set; }
        public int? MinMarginBottom { get; set; }
        public int? MinMarginLeft { get; set; }
        public int? MinMarginRight { get; set; }
        public int? MinMarginTop { get; set; }
        public int? PlotAreaBorderAlpha { get; set; }
        public string PlotAreaBorderColor { get; set; }
        public double? PlotAreaFillAlphas { get; set; }
        public string PlotAreaFillColors { get; set; }
        public int? PlotAreaGradientAngle { get; set; }
        public List<TrendLine> TrendLines { get; set; }
        public double? ZoomOutButtonAlpha { get; set; }
        public string ZoomOutButtonColor { get; set; }
        public string ZoomOutButtonImage { get; set; }
        public int? ZoomOutButtonImageSize { get; set; }
        public int? ZoomOutButtonPadding { get; set; }
        public double? ZoomOutButtonRollOverAlpha { get; set; }
        public int? ZoomOutButtonTabIndex { get; set; }
        public string ZoomOutText { get; set; }
        public int? TabIndex { get; set; }
        public bool? ValueBalloonsEnabled { get; set; }
        public double? ValueLineAlpha { get; set; }
        public bool? ValueLineBalloonEnabled { get; set; }
        public bool? ValueLineEnabled { get; set; }
        public bool? ValueZoomable { get; set; }
        public bool? Zoomable { get; set; }
        public bool? Zooming { get; set; }


    }
}