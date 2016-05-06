namespace AmChartsNet
{
    public enum ArrowPosition
    {
        Start,
        End,
        Middle,
        Both,
        None
    }

    public enum TextAlign
    {
        Left,
        Middle,
        Right
    }

    public enum ChartType
    {
        Funnel,
        Gauge,
        Map,
        Pie,
        Radar,
        Serial,
        Stock,
        XY
    }

    public enum CreditsPosition
    {
        [EnumMember(Value = "top-left")]
        TopLeft,

        [EnumMember(Value = "top-right")]
        TopRight,

        [EnumMember(Value = "bottom-left")]
        BottomLeft,

        [EnumMember(Value = "bottom-right")]
        BottomRight
    }

    public enum LegendSwitchType
    {
        X,
        Y
    }

    public enum LedgendPosition
    {
        Bottom,
        Top,
        Left,
        Right,
        Absolute
    }

    public enum AnimationEffect
    {
        EaseOutSine,
        EaseInSine,
        Elastic,
        Bounce
    }

    public enum AxisPosition
    {
        Top,
        Bottom,
        Left,
        Right
    }

    public enum GridType
    {
        Polygons,
        Circles
    }

    public enum GridPosition
    {
        Start,
        Middle
    }

    public enum TickPosition
    {
        Start,
        Middle
    }

    public enum StackType
    {
        None,
        Regular,

        [EnumMember(Value = "100%")]
        OneHundredPercent,

        [EnumMember(Value = "3d")]
        ThreeDimension
    }

    public enum UnitPosition
    {
        Left,
        Right
    }

    public enum ColumnType
    {
        Line,
        Column,
        Step,
        SmoothedLine,
        Candlestickm,
        Ohlc

    }

}