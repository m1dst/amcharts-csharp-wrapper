using System.Collections.Generic;
using Newtonsoft.Json;

namespace AmChartsNet.Maps
{
    public class MapData : MapObject
    {

        /// <summary>
        /// Collection of MapArea objects.
        /// </summary>
        public List<MapArea> Areas { get; set; }

        /// <summary>
        /// Latitude of bottom-most point of a map. All maps in amMap package have this information hardcoded in SVG file.
        /// </summary>
        public double? BottomLatitude { get; set; }

        /// <summary>
        /// If you set this to true, all areas available in SVG map will be created automatically.
        /// </summary>
        public bool? GetAreasFromMap { get; set; }

        /// <summary>
        /// Longitude of left-most point of a map. All maps in amMap package have this information hardcoded in SVG file.
        /// </summary>
        public double? LeftLongitude { get; set; }

        /// <summary>
        /// linkToObject can be a reference or id of some other MapObject - MapArea, MapImage or MapLine. 
        /// It can also be a reference to another DataSet (but not an id). 
        /// Then user clicks on this object the application would zoom-in to this objects' zoom position (if it is set) and then act as if the linkToObject was clicked. 
        /// This can also be used for selecting the object you want to be selected right after the map is initialized, as DataSet extends MapObject class, you can specify linkToObject for your DataSet. 
        /// When you link to another DataSet, you can build drill-down maps.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string LinkToObject { get; set; }

        /// <summary>
        /// Name of a map. Instead of using mapURL or mapVar you can use name of the map, usualy the same as file name of the map, for example: map = "worldLow".
        /// </summary>
        public string Map { get; set; }

        /// <summary>
        /// Path to map SVG file. Use it if you don't include map as .js file.
        /// Loading SVG is a bit risky, as some browsers might not do this correctly - it depends on server configuration.
        /// We recommend to include maps as .js files. Application won't load svg files from hard drive, so you can test this only on web server.
        /// </summary>
        public string MapUrl { get; set; }

        /// <summary>
        /// In case you included map as js file, you should specify variable name of a map.
        /// Open your map.js file and copy variable name, for example: AmCharts.maps.worldLow
        /// </summary>
        public string MapVar { get; set; }

        /// <summary>
        /// Longitude of right-most point of a map. All maps in amMap package have this information hardcoded in SVG file.
        /// </summary>
        public double? RightLongitude { get; set; }

        /// <summary>
        /// Latitude of top-most point of a map. All maps in amMap package have this information hardcoded in SVG file.
        /// </summary>
        public double? TopLatitude { get; set; }

    }
}