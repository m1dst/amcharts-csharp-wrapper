using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet
{
    /// <summary>
    /// Creates the legend for the chart, automatically adapts the color settings of the graphs.
    /// </summary>
    public class AmLegend
    {

        /// <summary>
        /// Text which screen readers will read if user rolls-over the element or sets focus on it using tab key (this is possible only if tabIndex property of AmLegend is set to some number).
        /// Text is added as aria-label tag. Note - not all screen readers and browsers support this.
        /// </summary>
        public string AccessibleLabel { get; set; }

        /// <summary>
        /// Alignment of legend entries.
        /// </summary>
        [JsonConverter(typeof (StringEnumConverter), true)]
        public TextAlign? Align { get; set; }

        /// <summary>
        /// Used if chart is Serial or XY. In case true, margins of the legend are adjusted and made equal to chart's margins.
        /// </summary>
        public bool? AutoMargins { get; set; }

        /// <summary>
        /// Opacity of legend's background. Value range is 0 - 1
        /// </summary>
        public double? BackgroundAlpha { get; set; }

        /// <summary>
        /// Background color. You should set backgroundAlpha to >0 vallue in order background to be visible.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Opacity of chart's border. Value range is 0 - 1.
        /// </summary>    
        public double? BorderAlpha { get; set; }

        /// <summary>
        /// Color of legend's border. You should set borderAlpha >0 in order border to be visible.
        /// </summary>    
        public string BorderColor { get; set; }

        /// <summary>
        /// In case legend position is set to "absolute", you can set distance from bottom of the chart, in pixels.
        /// </summary>    
        public int? Bottom { get; set; }

        /// <summary>
        /// Text color.
        /// </summary>    
        public string Color { get; set; }

        /// <summary>
        /// You can pass array of objects with title, color, markerType values, for example: [{title: "One", color: "#3366CC"},{title: "Two", color: "#FFCC33"}]
        /// </summary>    
        public List<Object> Data { get; set; }

        /// <summary>
        /// You can set id of a div or a reference to div object in case you want the legend to be placed in a separate container.
        /// </summary>    
        public string DivId { get; set; }

        /// <summary>
        /// Specifies if legend is enabled or not.
        /// </summary>    
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies if each of legend entry should be equal to the most wide entry.Won't look good if legend has more than one line.
        /// </summary>    
        public bool? EqualWidths { get; set; }

        /// <summary>
        /// Font size.
        /// </summary>    
        public int? FontSize { get; set; }

        /// <summary>
        /// If you set this property to true, width of legend item labels won't be adjusted. Useful when you have more than one chart and want to align all the legends.
        /// </summary>    
        public bool? ForceWidth { get; set; }

        /// <summary>
        /// Can be used if legend uses custom data.Set it to 0, 90, 180 or 270.
        /// </summary>    
        public int? GradientRotation { get; set; }

        /// <summary>
        /// Horizontal space between legend item and left/right border.
        /// </summary>    
        public int? HorizontalGap { get; set; }

        /// <summary>
        /// The text which will be displayed in the legend.Tag [[title]] will be replaced with the title of the graph.
        /// </summary>    
        public string LabelText { get; set; }

        /// <summary>
        /// If width of the label is bigger than labelWidth, it will be wrapped.
        /// </summary>    
        public int? LabelWidth { get; set; }

        /// <summary>
        /// In case legend position is set to "absolute", you can set distance from left side of the chart, in pixels.
        /// </summary>    
        public int? Left { get; set; }

        /// <summary>
        /// You can add listeners of events using this property.Example: listeners = [{"event":"clickLabel", "method":handleEvent}];
        /// </summary>    
        public List<Object> Listeners { get; set; }

        /// <summary>
        /// Bottom margin.
        /// </summary>    
        public int? MarginBottom { get; set; }

        /// <summary>
        /// Left margin.This property will be ignored if chart is Serial or XY and autoMargins property of the legend is true (default).
        /// </summary>    
        public int? MarginLeft { get; set; }

        /// <summary>
        /// Right margin.This property will be ignored if chart is Serial or XY and autoMargins property of the legend is true (default).
        /// </summary>    
        public int? MarginRight { get; set; }

        /// <summary>
        /// Top margin.
        /// </summary>    
        public int? MarginTop { get; set; }

        /// <summary>
        /// Marker border opacity.
        /// </summary>    
        public double? MarkerBorderAlpha { get; set; }

        /// <summary>
        /// Marker border color.If not set, will use the same color as marker.
        /// </summary>    
        public string MarkerBorderColor { get; set; }

        /// <summary>
        /// Thickness of the legend border.The default value(0) means the line will be a "hairline" (1 px). In case marker type is line, this style will be used for line thickness.
        /// </summary>    
        public int? MarkerBorderThickness { get; set; }

        /// <summary>
        /// The color of the disabled marker(when the graph is hidden).
        /// </summary>    
        public string MarkerDisabledColor { get; set; }

        /// <summary>
        /// Space between legend marker and legend text, in pixels.
        /// </summary>    
        public int? MarkerLabelGap { get; set; }

        /// <summary>
        /// Size of the legend marker(key).
        /// </summary>    
        public int? MarkerSize { get; set; }

        /// <summary>
        /// Shape of the legend marker(key). Possible values are: square, circle, diamond, triangleUp, triangleDown, triangleLeft, triangleDown, bubble, line, none.
        /// </summary>    
        public string MarkerType { get; set; }

        /// <summary>
        /// Maximum number of columns in the legend.If Legend's position is set to "right" or "left", maxColumns is automatically set to 1.
        /// </summary>    
        public int? MaxColumns { get; set; }

        /// <summary>
        /// The text which will be displayed in the value portion of the legend when user is not hovering above any data point.The tags should be made out of two parts - the name of a field (value / open / close / high / low) and the value of the period you want to be show - open / close / high / low / sum / average / count.For example: [[value.sum]] means that sum of all data points of value field in the selected period will be displayed.
        /// </summary>    
        public string PeriodValueText { get; set; }

        /// <summary>
        /// Position of a legend. In case "absolute", you should set left and top properties too. (this setting is ignored in Stock charts). In case legend is used with AmMap, position is set to "absolute" automatically.
        /// </summary>    
        [JsonConverter(typeof(StringEnumConverter), true)]
        public LedgendPosition? Position { get; set; }

        /// <summary>
        /// Specifies whether legend entries should be placed in reversed order.
        /// </summary>    
        public bool? ReversedOrder { get; set; }

        /// <summary>
        /// In case legend position is set to "absolute", you can set distance from right side of the chart, in pixels.
        /// </summary>    
        public int? Right { get; set; }

        /// <summary>
        /// Legend item text color on roll-over.
        /// </summary>    
        public string RollOverColor { get; set; }

        /// <summary>
        /// When you roll-over the legend entry, all other graphs can reduce their opacity, so that the graph you rolled-over would be distinguished.This style specifies the opacity of the graphs.
        /// </summary>    
        public double? RollOverGraphAlpha { get; set; }

        /// <summary>
        /// You can use this property to turn all the legend entries off.
        /// </summary>    
        public bool? ShowEntries { get; set; }

        /// <summary>
        /// Horizontal space between legend items, in pixels.
        /// </summary>    
        public int? Spacing { get; set; }

        /// <summary>
        /// Whether showing/hiding of graphs by clicking on the legend marker is enabled or not.In case legend is used with AmMap, this is set to false automatically.
        /// </summary>    
        public bool? Switchable { get; set; }

        /// <summary>
        /// Legend switch color.
        /// </summary>    
        public string SwitchColor { get; set; }

        /// <summary>
        /// Legend switch type(in case the legend is switchable). Possible values are "x" and "v".
        /// </summary>    
        [JsonConverter(typeof(StringEnumConverter), true)]
        public LegendSwitchType? SwitchType { get; set; }

        /// <summary>
        /// In case you set it to some number, the chart will set focus on legend entry when user clicks tab key.When a focus is set, screen readers like NVDA Screen reader will read label which is set using accessibleLabel property of AmLegend.If legend has switchable set to true, pressing Enter(Return) key will show/hide the graph.Note, not all browsers and readers support this.
        /// </summary>    
        public int? TabIndex { get; set; }

        /// <summary>
        /// If true, clicking on the text will show/hide balloon of the graph.Otherwise it will show/hide graph/slice, if switchable is set to true.
        /// </summary>    
        public bool? TextClickEnabled { get; set; }

        /// <summary>
        /// In case legend position is set to "absolute", you can set distance from top of the chart, in pixels.
        /// </summary>    
        public int? Top { get; set; }

        /// <summary>
        /// Legend markers can mirror graph’s settings, displaying a line and a real bullet as in the graph itself.Set this property to true if you want to enable this feature.Note, if you set graph colors in dataProvider, they will not be reflected in the marker.
        /// </summary>    
        public bool? UseGraphSettings { get; set; }

        /// <summary>
        /// Labels will use marker color if you set this to true.
        /// </summary>    
        public bool? UseMarkerColorForLabels { get; set; }

        /// <summary>
        /// Specifies if legend values should be use same color as corresponding markers.
        /// </summary>    
        public bool? UseMarkerColorForValues { get; set; }

        /// <summary>
        /// Alignment of the value text.Possible values are "left" and "right".
        /// </summary>    
        public string ValueAlign { get; set; }

        /// <summary>
        /// You can use it to format value labels in any way you want.
        /// Legend will call this method and will passGraphDataItem and formatted text of currently hovered item (works only with ChartCursoradded to the chart). 
        /// This method should return string which will be displayed as value in the legend.
        /// </summary>
        public string ValueFunction { get; set; }

        /// <summary>
        /// The text which will be displayed in the value portion of the legend.You can use tags like [[value]], [[open]], [[high]], [[low]], [[close]], [[percents]], [[description]].
        /// </summary>    
        public string ValueText { get; set; }

        /// <summary>
        /// Width of the value text.
        /// </summary>    
        public int? ValueWidth { get; set; }

        /// <summary>
        /// Vertical space between legend items also between legend border and first and last legend row.
        /// </summary>    
        public int? VerticalGap { get; set; }

        /// <summary>
        /// Width of a legend, when position is set to absolute.
        /// </summary>    
        public int? Width { get; set; }

    }

}