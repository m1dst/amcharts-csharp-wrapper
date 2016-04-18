namespace AmChartsNet.Maps
{
    public class AmMap: AmChart
    {

        public string Type { get; private set; } = "map";

        /// <summary>
        /// Specifies if user can repeatedly click on already selected object.
        /// </summary>
        public bool? AllowClickOnSelectedObject { get; set; }

        /// <summary>
        /// Specifies if multiple description windows at a time are allowed. When set to false, previously opened window is closed when opening a new one.
        /// </summary>
        public bool? AllowMultipleDescriptionWindows { get; set; }

        /// <summary>
        /// You can create multiple AreasSettings objects and then set them using this property. For example,
        /// map.areasClasses["rivers"] = riversSettings; The class "rivers" should be set for your svg areas which should use the riversSettings object.
        /// </summary>
        public string AreasClasses { get; set; }

        /// <summary>
        /// Common settings of areas.
        /// </summary>
        public AreasSettings AreasSettings { get; set; }

        /// <summary>
        /// Specifies if the map should be centered.
        /// </summary>
        public bool? BackgroundZoomsToTop { get; set; }

        /// <summary>
        /// Method which will be called by the map when a balloon with some text is displayed. You can use it to change the default text of a balloon.
        /// When this function is called, mapObject and map references are passed to it:
        /// balloonLabelFunction(mapObject, ammap);
        /// You can extract any data from mapObject and return new balloon text.
        /// </summary>
        public string BalloonLabelFunction { get; set; }

        /// <summary>
        /// Specifies if the map should be centered.
        /// </summary>
        public bool? CenterMap { get; set; }

        /// <summary>
        /// If you set values for MapAreas, they are filled with colors between color and colorSolid (both set in AreasSettings).
        /// colorSteps property specifies how many different colors should be used. 
        /// Set this to some big number like 100 if you want each area to be filled with a different shade of color (according to it's value).
        /// </summary>
        public int? ColorSteps { get; set; }

        /// <summary>
        /// Data provider of the map.
        /// </summary>
        public MapData DataProvider { get; set; }

        /// <summary>
        /// When developer mode is set to true, you can click anywhere on the map while SHIFT key is pressed to trigger a writeDevInfo event.
        /// All the information about current map position/zoom will be transferred to the event handler.
        /// </summary>
        public bool? DeveloperMode { get; set; }

        /// <summary>
        /// Specifies if the map is draggable.
        /// </summary>
        public bool? DragMap { get; set; }

        /// <summary>
        /// Specifies if the map should be resized to fit to the stage.
        /// </summary>
        public bool? FitMapToContainer { get; set; }

        /// <summary>
        /// If you set it to true, the map will redraw all the areas, normalizing paths. This might be needed if you use SVG filters with areas.
        /// Might not work with maps containing complex paths (with arcs and similar).
        /// </summary>
        public bool? ForceNormalize { get; set; }

        /// <summary>
        /// Common settings of images.
        /// </summary>
        public ImagesSettings ImagesSettings { get; set; }

        /// <summary>
        /// You can specify whether lines should be above or below images.
        /// </summary>
        public bool LinesAboveImages { get; set; }

        /// <summary>
        /// Common settings of lines.
        /// </summary>
        public LinesSettings LinesSettings { get; set; }

        /// <summary>
        /// Use this property in case you set values for your areas and wish to set a different maxValue.
        /// These values are used when choosing a color for an area.
        /// </summary>
        public double? MaxValue { get; set; }

        /// <summary>
        /// Use this property in case you set values for your areas and wish to set a different minValue(it's 0 by default).
        /// These values are used when choosing a color for an area.
        /// </summary>
        public double? MinValue { get; set; }

        /// <summary>
        /// Specifies if zooming with mouse wheel is enabled.
        /// </summary>
        public bool? MouseWheelZoomEnabled { get; set; }

        /// <summary>
        /// Specifies absolute or relative path to amCharts files, i.e. "ammap/". (where all .js files are located)
        /// If relative URLs are used, they will be relative to the current web page, displaying the chart.
        /// You can also set path globally, using global JavaScript variable AmCharts_path.If this variable is set, and "path" is not set in map config,
        /// the mapwill assume the path from the global variable.This allows setting amCharts path globally. I.e.:
        /// var AmCharts_path = "/libs/ammap/";
        /// "path" parameter will be used by the maps to locate it's files, like images, plugins or patterns.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// If set to true, user won't be able to drag map out of the visible area.
        /// </summary>
        public bool? PreventDragOut { get; set; }

        /// <summary>
        /// Projection of the map. Projection can be also set in SVG map - all svg maps which are distributed with amMap have projection set in SVG.
        /// Available values are: "winkel3", "eckert3", "eckert5", "eckert6", "miller", "equirectangular" and "mercator" (default).
        /// </summary>
        public string Projection { get; set; }

        /// <summary>
        /// Specifies if MapAreas should be displayed in the ObjectList.
        /// </summary>
        public bool? ShowAreasInList { get; set; }

        /// <summary>
        /// Specifies if balloon should be displayed when hovering currently seleced object.
        /// </summary>
        public bool? ShowBalloonOnSelectedObject { get; set; }

        /// <summary>
        /// Specifies if description window should be shown when user hovers over the object.
        /// </summary>
        public bool? ShowDescriptionOnHover { get; set; }

        /// <summary>
        /// Specifies if MapImages should be displayed in the ObjectList.
        /// </summary>
        public bool? ShowImagesInList { get; set; }

        /// <summary>
        /// Specifies if MapLines should be displayed in the ObjectList.
        /// </summary>
        public bool? ShowLinesInList { get; set; }

        /// <summary>
        /// Specifies if child objects should be added to stage only after the map zoomed to the final position.
        /// </summary>
        public bool? ShowObjectsAfterZoom { get; set; }

        /// <summary>
        /// Small map displays a small map indicating zoom level and position.
        /// </summary>
        public SmallMap SmallMap { get; set; }

        /// <summary>
        /// Specifies if hand cursor should be displayed when mouse moves over a clickable object.
        /// </summary>
        public bool? UseHandCursorOnClickableOjects { get; set; }

        /// <summary>
        /// Specifies if balloon should use color of currenlty hovered object.
        /// </summary>
        public bool? UseObjectColorForBalloon { get; set; }

        /// <summary>
        /// Value legend displays a color range used by areas (in case you set values for your areas).
        /// </summary>
        public ValueLegend ValueLegend { get; set; }

        /// <summary>
        /// Zoom control of the map.
        /// </summary>
        public ZoomControl ZoomControl { get; set; }

        /// <summary>
        /// Duration of zoom animation, in seconds.
        /// </summary>
        public int? ZoomDuration { get; set; }

        /// <summary>
        /// Specifies if the map should be zoomed-in when user double clicks anywhere on the map (except objects which are clickable).
        /// </summary>
        public bool? ZoomOnDoubleClick { get; set; }

    }

}