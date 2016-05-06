using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet
{
    /// <summary>
    /// Base class of AmCharts. It can not be instantiated explicitly. Its makeChart method gives you the possibility to create charts easily with a single object.
    /// </summary>
    public class AmChart
    {

        [JsonConverter(typeof(StringEnumConverter), true)]
        public ChartType Type { get; set; }

        /// <summary>
        /// When enabled, chart adds aria-label attributes to columns, bullets or map objects.
        /// You can control values of these labels using properties like accessibleLabel of AmGraph.
        /// Note, not all screen readers support these tags. We tested this mostly with NVDA Screen reader.
        /// WAI-ARIA is now official W3 standard, so in future more readers will handle this well.
        /// We will be improving accessibility on our charts, so we would be glad to hear your feedback.
        /// </summary>
        public bool? Accessible { get; set; }

        /// <summary>
        /// <title> element will be added to <svg> node if you set any.It is read by most of the screen readers.
        /// </summary>
        public string AccessibleTitle { get; set; }

        /// <summary>
        /// Specifies, if class names should be added to chart elements.
        /// </summary>
        public bool? AddClassNames { get; set; }

        /// <summary>
        /// Array of Labels. Example of label object, with all possible properties:
        /// {"x": 20, "y": 20, "text": "this is label", "align": "left", "size": 12, "color": "#CC0000", "alpha": 1, "rotation": 0, "bold": true, "url": "http://www.amcharts.com"}
        /// </summary>
        public List<Label> AllLabels { get; set; }

        /// <summary>
        /// If you set it to true the chart will automatically monitor changes of display style of chart’s container (or any of it’s parents) and 
        /// will render chart correctly if it is changed from none to block. We recommend setting it to true if you change this style at a run time, 
        /// as it affects performance a bit.
        /// </summary>
        public bool? AutoDisplay { get; set; }

        /// <summary>
        /// Set this to false if you don't want chart to resize itself whenever its parent container size changes.
        /// </summary>
        public bool? AutoResize { get; set; }

        /// <summary>
        /// If you set it to true and your chart div (or any of the parent div) has css scale applied, 
        /// the chart will position mouse at a correct position. Default value is false because this 
        /// operation consumes some CPU and quite a few people are using css transfroms.
        /// </summary>
        public bool? AutoTransform { get; set; }

        /// <summary>
        /// Opacity of background. Set it to >0 value if you want backgroundColor to work. 
        /// However we recommend changing div's background-color style for changing background color.
        /// </summary>
        public double? BackgroundAlpha { get; set; }

        /// <summary>
        /// Background color. You should set backgroundAlpha to >0 value in order background to be visible. 
        /// We recommend setting background color directly on a chart's DIV instead of using this property.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// The chart creates AmBalloon class itself. If you want to customize balloon, get balloon instance using this property, and then change balloon's properties.
        /// </summary>
        public AmBalloon Balloon { get; set; }

        /// <summary>
        /// Opacity of chart's border. Value range is 0 - 1.
        /// </summary>
        public double? BorderAlpha { get; set; }

        /// <summary>
        /// Color of chart's border. You should set borderAlpha >0 in order border to be visible.
        /// We recommend setting border color directly on a chart's DIV instead of using this property.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// This prefix is added to all class names which are added to all visual elements of a chart in case addClassNames is set to true.
        /// </summary>
        public string ClassNamePrefix { get; set; }

        /// <summary>
        /// Text color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Non-commercial version only.
        /// Specifies position of link to amCharts site. Allowed values are: top-left, top-right, bottom-left and bottom-right.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter), true)]
        public CreditsPosition? CreditsPosition { get; set; }

        /// <summary>
        /// A config object for Data Loader plugin. Please refer to the following page for more information.
        /// </summary>
        public Object DataLoader { get; set; }

        /// <summary>
        /// Array of data objects, for example: [{country:"US", value:524},{country:"UK", value:624},{country:"Lithuania", value:824}]. 
        /// You can have any number of fields and use any field names. In case of AmMap, data provider should be MapData object.
        /// The data set data.
        /// Important: if you are using date/time-based category axis, the data points needs to come pre-ordered in ascending order.
        /// Data with incorrect order might result in visual and functional glitches on the chart.
        /// </summary>
        public List<object> DataProvider { get; set; }

        /// <summary>
        /// Decimal separator.
        /// </summary>
        public string DecimalSeparator { get; set; }

        /// <summary>
        /// Using this property you can add any additional information to SVG, like SVG filters or clip paths. 
        /// The structure of this object should be identical to XML structure of a object you are adding, only in JSON format.
        /// </summary>
        public Object Defs { get; set; }

        /// <summary>
        /// Export config. Specifies how export to image/data export/print/annotate menu will look and behave. 
        /// You can find a lot of examples in amcharts/plugins/export folder.
        /// </summary>
        public Export Export { get; set; }

        /// <summary>
        /// Font family.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Font size.
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        /// If you set this to true, the lines of the chart will be distorted and will produce hand-drawn effect. 
        /// Try to adjust chart.handDrawScatter and chart.handDrawThickness properties for a more scattered result.
        /// </summary>
        public bool? HandDrawn { get; set; }

        /// <summary>
        /// Defines by how many pixels hand-drawn line (when handDrawn is set to true) will fluctuate.
        /// </summary>
        public int? HandDrawScatter { get; set; }

        /// <summary>
        /// Defines by how many pixels line thickness will fluctuate (when handDrawn is set to true).
        /// </summary>
        public int? HandDrawThickness { get; set; }

        /// <summary>
        /// Time, in milliseconds after which balloon is hidden if the user rolls-out of the object. 
        /// Might be useful for AmMap to avoid balloon flickering while moving mouse over the areas.
        ///  Note, this is not duration of fade-out. Duration of fade-out is set in AmBalloon class.
        /// </summary>
        public int? HideBalloonTime { get; set; }

        /// <summary>
        /// Decides if the credits should be shown or not.
        /// </summary>
        public bool HideCredits { get; set; } = true;

        /// <summary>
        /// Allows changing language easily. 
        /// Note, you should include language js file from amcharts/lang or ammap/lang folder and then use variable name used in this file, like chart.
        /// language = "de"; Note, for maps this works differently - you use language only for country names, as there are no other strings in the maps application.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Allows changing language easily. 
        /// Note, you should include language js file from amcharts/lang or ammap/lang folder and then use variable name used in this file, like chart.
        /// language = "de"; Note, for maps this works differently - you use language only for country names, as there are no other strings in the maps application.
        /// </summary>
        public AmLegend Legend { get; set; }

        /// <summary>
        /// You can add listeners of events using this property.
        /// </summary>
        /// <example>listeners = [{"event":"dataUpdated", "method":handleEvent}];</example>
        public List<Object> Listeners { get; set; }

        /// <summary>
        /// This setting affects touch-screen devices only.
        /// If a chart is on a page, and panEventsEnabled are set to true, the page won't move if the user touches the chart first. 
        /// If a chart is big enough and occupies all the screen of your touch device, the user won’t be able to move the page at all.
        /// If you think that selecting/panning the chart or moving/pinching the map is a primary purpose of your users, you should set panEventsEnabled to true, otherwise - false.
        /// </summary>
        public bool? PanEventsEnabled { get; set; }

        /// <summary>
        /// Specifies absolute or relative path to amCharts files, i.e. "amcharts/". (where all .js files are located)
        /// If relative URLs are used, they will be relative to the current web page, displaying the chart.
        /// You can also set path globally, using global JavaScript variable AmCharts_path.
        /// If this variable is set, and "path" is not set in chart config, the chart will assume the path from the global variable. This allows setting amCharts path globally. I.e.:
        /// var AmCharts_path = "/libs/amcharts/";
        /// "path" parameter will be used by the charts to locate it's files, like images, plugins or patterns.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Precision of percent values. -1 means percent values won't be rounded at all and show as they are.
        /// </summary>
        public int? PercentPrecision { get; set; }

        /// <summary>
        /// Prefixes which are used to make big numbers shorter: 2M instead of 2000000, etc. 
        /// Prefixes are used on value axes and in the legend. To enable prefixes, set usePrefixes property to true.
        /// </summary>
        public List<PrefixOfNumber> PrefixesOfBigNumbers { get; set; }

        /// <summary>
        /// Prefixes which are used to make big numbers shorter: 2M instead of 2000000, etc. 
        /// Prefixes are used on value axes and in the legend. To enable prefixes, set usePrefixes property to true.
        /// </summary>
        public List<PrefixOfNumber> PrefixesOfSmallNumbers { get; set; }

        /// <summary>
        /// If processTimeout is > 0, 1000 data items will be parsed at a time, then the chart will make pause and continue parsing data until it finishes.
        /// </summary>
        public int? ProcessCount { get; set; }

        /// <summary>
        /// If you set it to 1 millisecond or some bigger value, chart will be built in chunks instead of all at once.
        /// This is useful if you work with a lot of data and the initial build of the chart takes a lot of time, 
        /// which freezes the whole web application by not allowing other processes to do their job while the chart is busy.
        /// </summary>
        public int? ProcessTimeout { get; set; }

        /// <summary>
        /// A config object for Responsive plugin.
        /// </summary>
        public object Responsive { get; set; }

        /// <summary>
        /// Charts will use SVG icons (some are loaded from images folder and some are drawn inline) if browser supports SVG.
        /// This makes icons look good on retina displays on all resolutions.
        /// </summary>
        public bool? SvgIcons { get; set; }

        /// <summary>
        /// Charts which require gestures like swipe (charts with scrollbar/cursor) or pinch (maps) used to prevent regular page scrolling 
        /// and could result page to stick to the same spot if the chart occupied whole screen. 
        /// Now, in order these gestures to start working user has to touch the chart/maps once. 
        /// Regular touch events like touching on the bar/slice/map area do not require the first tap and will show balloons and perform other tasks as usual.
        ///  If you have a map or chart which occupies full screen and your page does not require scrolling, set tapToActivate to false – this will bring old behavior back.
        /// </summary>
        public bool? TapToActivate { get; set; }

        /// <summary>
        /// Theme of a chart. Config files of themes can be found in amcharts/themes/ folder.
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// Thousands separator.
        /// </summary>
        public string ThousandsSeparator { get; set; }

        /// <summary>
        /// Collection of Titles
        /// </summary>
        public List<Title> Titles { get; set; }

        /// <summary>
        /// If you set it to 200 (milliseconds) or so, the chart will fire clickGraphItem or clickSlice (AmSlicedChart) or clickMapObjet only if user holds his finger for 0.2 seconds (200 ms) on the colum/bullet/slice/map object.
        /// </summary>
        public int? TouchClickDuration { get; set; }


        /// <summary>
        /// If true, prefixes will be used for big and small numbers. You can set arrays of prefixes via prefixesOfSmallNumbers and prefixesOfBigNumbers properties.
        /// </summary>
        public bool? UsePrefixes { get; set; }



        public class PrefixOfNumber
        {
            public string Number { get; set; }
            public string Prefix { get; set; }
        }

    }
}