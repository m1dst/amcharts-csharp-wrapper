using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet
{
    /// <summary>
    /// Creates the visualization of the data in following types: line, column, step line, smoothed line, olhc and candlestick.
    /// </summary>
    public class AmGraph
    {

        public string AccessibleLabel { get; set; }
        public string AlphaField { get; set; }
        public bool? AnimationPlayed { get; set; }
        public AmBalloon Balloon { get; set; }
        public string BalloonColor { get; set; }
        public string BalloonFunction { get; set; }
        public string BalloonText { get; set; }
        public bool? BehindColumns { get; set; }
        public string Bullet { get; set; }
        public int? BulletAlpha { get; set; }
        public ValueAxis BulletAxis { get; set; }
        public int? BulletBorderAlpha { get; set; }
        public string BulletBorderColor { get; set; }
        public int? BulletBorderThickness { get; set; }
        public string BulletColor { get; set; }
        public string BulletField { get; set; }
        public int? BulletHitAreaSize { get; set; }
        public int? BulletOffset { get; set; }
        public int? BulletSize { get; set; }
        public string BulletSizeField { get; set; }
        public string ClassNameField { get; set; }
        public string CloseField { get; set; }
        public bool? Clustered { get; set; }
        public string Color { get; set; }
        public string ColorField { get; set; }
        public int? ColumnWidth { get; set; }
        public bool? Connect { get; set; }
        public int? CornerRadiusTop { get; set; }
        public double? CursorBulletAlpha { get; set; }
        public string CustomBullet { get; set; }
        public string CustomBulletField { get; set; }
        public string CustomMarker { get; set; }
        public int? DashLength { get; set; }
        public string DashLengthField { get; set; }
        public string DateFormat { get; set; }
        public string DescriptionField { get; set; }
        public string ErrorField { get; set; }
        public double? FillAlphas { get; set; }
        public string FillColors { get; set; }
        public string FillColorsField { get; set; }
        public ValueAxis FillToAxis { get; set; }
        public AmGraph FillToGraph { get; set; }
        public int? FixedColumnWidth { get; set; }
        public int? FontSize { get; set; }
        public string GapField { get; set; }
        public int? GapPeriod { get; set; }
        public string GradientOrientation { get; set; }
        public bool? Hidden { get; set; }
        public int? HideBulletsCount { get; set; }
        public string HighField { get; set; }
        public string Id { get; set; }
        public bool? IncludeInMinMax { get; set; }
        public string LabelAnchor { get; set; }
        public string LabelColorField { get; set; }
        public string LabelFunction { get; set; }
        public int? LabelOffset { get; set; }
        public string LabelPosition { get; set; }
        public int? LabelRotation { get; set; }
        public string LabelText { get; set; }
        public double? LegendAlpha { get; set; }
        public string LegendColor { get; set; }
        public string LegendPeriodValueText { get; set; }
        public string LegendValueText { get; set; }
        public double? LineAlpha { get; set; }
        public string LineColor { get; set; }
        public string LineColorField { get; set; }
        public int? LineThickness { get; set; }
        public string LowField { get; set; }
        public string MarkerType { get; set; }
        public int? MaxBulletSize { get; set; }
        public int? MinBulletSize { get; set; }
        public int? MinDistance { get; set; }
        public int? NegativeBase { get; set; }
        public double? NegativeFillAlphas { get; set; }
        public string NegativeFillColors { get; set; }
        public double? NegativeLineAlpha { get; set; }
        public string NegativeLineColor { get; set; }
        public bool? NewStack { get; set; }
        public bool? NoStepRisers { get; set; }
        public string OpenField { get; set; }
        public Object Pattern { get; set; }
        public string PatternField { get; set; }
        public int? PeriodSpan { get; set; }
        public string PointPosition { get; set; }
        public int? Precision { get; set; }
        public bool? ProCandlesticks { get; set; }
        public Object SegmentData { get; set; }
        public bool? ShowAllValueLabels { get; set; }
        public bool? ShowBalloon { get; set; }
        public string ShowBalloonAt { get; set; }
        public string ShowBulletsAt { get; set; }
        public bool? ShowHandOnHover { get; set; }
        public bool? ShowOnAxis { get; set; }
        public bool? Stackable { get; set; }
        public string StepDirection { get; set; }
        public bool? Switchable { get; set; }
        public int? TabIndex { get; set; }
        public string Title { get; set; }
        public int? TopRadius { get; set; }

        [JsonConverter(typeof(StringEnumConverter), true)]
        public ColumnType Type { get; set; }

        public string UrlField { get; set; }
        public string UrlTarget { get; set; }
        public bool? UseLineColorForBulletBorder { get; set; }
        public bool? UseNegativeColorIfDown { get; set; }
        public ValueAxis ValueAxis { get; set; }
        public string ValueField { get; set; }
        public bool? VisibleInLegend { get; set; }
        public ValueAxis XAxis { get; set; }
        public string XField { get; set; }
        public ValueAxis YAxis { get; set; }
        public string YField { get; set; }


    }
}