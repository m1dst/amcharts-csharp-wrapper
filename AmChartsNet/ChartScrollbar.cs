namespace AmChartsNet
{
    /// <summary>
    /// Create a scrollbar for AmSerialChart and AmXYChart charts.
    /// </summary>
    public class ChartScrollbar
    {

        /// <summary>
        /// Text which screen readers will read if user rolls-over or sets focus using tab key (this is possible only if tabIndex property of AmGraph is set to some number) 
        /// on the grips or draggable part of a scrollbar. Text is added as aria-label tag. 
        /// Note - not all screen readers and browsers support this. Note, you should set tabIndex to some number in order it would be possible to zoom chart using cursor keys.
        /// 
        /// Will add aria-label tag to scrollbar grips and the scrollbar drag-area. It will be read by some of screen readers when user hovers or sets focus (in case tabIndex is set).
        /// </summary>
        public string AccessibleLabel { get; set; }

        /// <summary>
        /// Specifies whether number of gridCount is specified automatically, according to the axis size.
        /// </summary>
        public bool? AutoGridCount { get; set; }

        /// <summary>
        /// Background opacity.
        /// </summary>
        public double? BackgroundAlpha { get; set; }

        /// <summary>
        /// Background color of the scrollbar.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Color of axis labels.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Mouse cursor displayed when clicked on selected part of a scrollbar.
        /// </summary>
        public string DragCursorDown { get; set; }

        /// <summary>
        /// Mouse cursor displayed when hovering over selected part of a scrollbar.
        /// </summary>
        public string DragCursorHover { get; set; }

        /// <summary>
        /// File name of scrollbar drag (resize grip) icon. You can find a set of icons in amcharts/images folder - you can choose from these: 
        /// dragIconRectBig, dragIconRectBigBlack, dragIconRectSmall, dragIconRectSmallBlack, dragIconRoundBig, dragIconRoundBigBlack, dragIconRoundSmall, dragIconRoundSmallBlack. 
        /// You can also use your own custom icons. Don't forget to change dragIconWidth and dragIconHeight if you change icons.
        /// </summary>
        public string DragIcon { get; set; }

        /// <summary>
        /// Height of resize grip image. Note, you should also update the image in amcharts/images folder if you don't want it to be distorted because of resizing.
        /// </summary>
        public int? DragIconHeight { get; set; }

        /// <summary>
        /// Width of resize grip image. Note, you should also update the image in amcharts/images folder if you don't want it to be distorted because of resizing.
        /// </summary>
        public int? DragIconWidth { get; set; }

        /// <summary>
        /// Specifies if scrollbar is enabled. You can hide/show scrollbar using this property without actually removing it.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies which graph will be displayed in the scrollbar. Only Serial chart's category scrollbar can display a graph.
        /// </summary>
        public AmGraph Graph { get; set; }

        /// <summary>
        /// Graph fill opacity. Value range is 0 - 1.
        /// </summary>
        public double? GraphFillAlpha { get; set; }

        /// <summary>
        /// Graph fill color. 
        /// </summary>
        public string GraphFillColor { get; set; }

        /// <summary>
        /// Graph line opacity. Value range is 0 - 1.
        /// </summary>
        public double? GraphLineAlpha { get; set; }

        /// <summary>
        /// Graph line color.
        /// </summary>
        public string GraphLineColor { get; set; }

        /// <summary>
        /// By default the graph type is the same as the original graph's type, however in case of candlestick or ohlc you might want to show line graph in the scrollbar.
        /// Possible values are: line, column, step, smoothedLine, candlestick, ohlc
        /// </summary>
        public string GraphType { get; set; }

        /// <summary>
        /// Grid opacity. Value range is 0 - 1.
        /// </summary>
        public double? GridAlpha { get; set; }

        /// <summary>
        /// Grid color.
        /// </summary>
        public string GridColor { get; set; }

        /// <summary>
        /// The number of grid lines.
        /// </summary>
        public int? GridCount { get; set; }

        /// <summary>
        /// Specifies whether resize grips are hidden when mouse is away from the scrollbar.
        /// </summary>
        public bool? HideResizeGrips { get; set; }

        /// <summary>
        /// If you have column type graph in your scrollbar, and this graph has custom colors for one or more columns in data provider, 
        /// those columns will be colored with this custom color. However you might not want this in some cases. Set this property to true to use scrollbar's graph colors.
        /// </summary>
        public bool? IgnoreCustomColors { get; set; }

        /// <summary>
        /// Maximum value of ValueAxis of ChartScrollbar. Calculated automatically, if not set.
        /// </summary>
        public double? Maximum { get; set; }

        /// <summary>
        /// Minimum value of ValueAxis of ChartScrollbar. Calculated automatically, if not set.
        /// </summary>
        public double? Minimum { get; set; }

        /// <summary>
        /// Distance from plot area to scrollbar, in pixels.
        /// </summary>
        public double? Offset { get; set; }

        /// <summary>
        /// By default, scrollbar is in the opsite side of plot area from the axis. If you set this property to false, scrollbar will be placed next to category/value axis.
        /// However it won't adjust it's position regarding axis labels, so you might need to use offset property to move scrollbar away from labels.
        /// </summary>
        public bool? OppositeAxis { get; set; }

        /// <summary>
        /// Specifies whether scrollbar has a resize feature.
        /// </summary>
        public bool? ResizeEnabled { get; set; }

        /// <summary>
        /// Height (width, if chart is rotated) of a scrollbar.
        /// </summary>
        public int? ScrollbarHeight { get; set; }

        /// <summary>
        /// Duration of scrolling, when the user clicks on scrollbar's background, in seconds. Note, updateOnReleaseOnly should be set to false in order animation to happen.
        /// </summary>
        public int? ScrollDuration { get; set; }

        /// <summary>
        /// Selected backround opacity.
        /// </summary>
        public double? SelectedBackgroundAlpha { get; set; }

        /// <summary>
        /// Selected background color.
        /// </summary>
        public string SelectedBackgroundColor { get; set; }

        /// <summary>
        /// Selected background color.
        /// </summary>
        public double? SelectedGraphFillAlpha { get; set; }

        /// <summary>
        /// Selected graph's fill color.
        /// </summary>
        public string SelectedGraphFillColor { get; set; }

        /// <summary>
        /// Selected graph's line opacity. Value range is 0 - 1.
        /// </summary>
        public double? SelectedGraphLineAlpha { get; set; }

        /// <summary>
        /// Selected graph's line color.
        /// </summary>
        public string SelectedGraphLineColor { get; set; }

        /// <summary>
        /// In case you set it to some number, the chart will set focus on grips and draggable area of the scrollbar when user clicks tab key.
        /// When a focus is set, screen readers like NVDA Screen reader will read label which is set using accessibleLabel property of ChartScrollbar.
        /// When a focus is set user can zoom-in, zoom-out or pan the scrollbar using cursor keys. Note, not all browsers and readers support this.
        /// </summary>
        public int? TabIndex { get; set; }

        /// <summary>
        /// Specifies if the chart should be updated while dragging/resizing the scrollbar or only at the moment when user releases mouse button.
        /// </summary>
        public bool? UpdateOnReleaseOnly { get; set; }


    }
}