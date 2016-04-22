using System.Collections.Generic;
using Newtonsoft.Json;

namespace AmChartsNet.Maps
{
    /// <summary>
    /// Baseclass for MapArea, MapLine and MapImage, it overwrites the default settings from AreasSettings, LinesSettings and ImagesSettings.
    /// </summary>
    public class MapObject
    {

        public MapObject()
        {
            Lines = new List<MapLine>();
            Images = new List<MapImage>();
        }

        /// <summary>
        /// Will add aria-label tag to images. It will be read by some of screen readers when user hovers them.
        /// </summary>
        public string AccessibleLabel { get; set; }

        /// <summary>
        /// Opacity of the image.
        /// </summary>
        public double? Alpha { get; set; }

        /// <summary>
        /// Text which is displayed in a roll-over balloon. You can use the following tags: [[title]], [[description]], [[value]] and [[percent]].
        /// </summary>
        public string BalloonText { get; set; }

        /// <summary>
        /// Specifies if the object should change it's z-index to the top-most when user hovers it.
        /// </summary>
        public bool? BringForwardOnHover { get; set; }

        /// <summary>
        /// Color of image. This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Description of MapObject. Description is displayed in DescriptionWindow (when user clicks on an object). It can also be displayed in a roll-over balloon. DescriptionWindow can display HTML formatted code.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Distance from the bottom side of map container to the description window. In case it is not set (also if descriptionWindowTop is not set), window will be placed near the mouse pointer.
        /// </summary>
        public string DescriptionWindowBottom { get; set; }

        /// <summary>
        /// Height of a description window.
        /// </summary>
        public string DescriptionWindowHeight { get; set; }

        /// <summary>
        /// Distance from the left side of map container to the description window. In case it is not set (also if descriptionWindowRight is not set), window will be placed near the mouse pointer.
        /// </summary>
        public string DescriptionWindowLeft { get; set; }

        /// <summary>
        /// Distance from the right side of map container to the description window. In case it is not set (also if descriptionWindowLeft is not set), window will be placed near the mouse pointer.
        /// </summary>
        public string DescriptionWindowRight { get; set; }

        /// <summary>
        /// Distance from the top side of map container to the description window. In case it is not set (also if descriptionWindowBottom is not set), window will be placed near the mouse pointer.
        /// </summary>
        public string DescriptionWindowTop { get; set; }

        /// <summary>
        /// Width of a description window.
        /// </summary>
        public string DescriptionWindowWidth { get; set; }

        /// <summary>
        /// Specifies if the object should change the size together with the map or keep fixed size. This applies for objects with lat and long properties set, as they move together with the map.
        /// </summary>
        public bool? FixedSize { get; set; }

        /// <summary>
        /// Id of a group. You can group MapObjects to groups. Grouped objects will change color together with this object when you roll-over it or click it. 
        /// You can show/hide them using showGroup(groupId) and hideGroup(groupId) methods of AmMap class. 
        /// You can also use map.zoomToGroup(groupId) methot to zoom-in the map so that all grouped objects are visible.
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Unique id of the object. In case it's area, id should match svg path id from SVG file.
        /// Id can be used with linkToObject property of MapObject - you can link one object to another using it.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Collection of MapImage objects.
        /// </summary>
        public List<MapImage> Images { get; set; }

        /// <summary>
        /// Collection of MapLine objects.
        /// </summary>
        public List<MapLine> Lines { get; set; }

        /// <summary>
        /// LinkToObject can be a reference or id of some other MapObject - MapArea, MapImage or MapLine. It can also be a reference to another DataSet (but not an id). 
        /// Then user clicks on this object the application would zoom-in to this objects' zoom position (if it is set) and then act as if the linkToObject was clicked. 
        /// This can also be used for selecting the object you want to be selected right after the map is initialized, as DataSet extends MapObject class, 
        /// you can specify linkToObject for your DataSet. When you link to another DataSet, you can build drill-down maps.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string LinkToObject { get; set; }

        /// <summary>
        /// Set this to false to make the object be irresponsive to any interactions like hover or click events.
        /// </summary>
        public bool? MouseEnabled { get; set; }

        /// <summary>
        /// Specifies if current zoom values should be passed to target MapObject. Useful when building drill down maps.
        /// </summary>
        public bool? PassZoomValuesToTarget { get; set; }

        /// <summary>
        /// Specifies if the MapObject and other objects of the same level should remain visible if it was clicked and it has children MapObjects.
        /// </summary>
        public bool? RemainVisible { get; set; }

        /// <summary>
        /// Color of image when hovered.This will affect only predefined images (with "type" property set) and images with svgPath set.
        /// This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public string RollOverColor { get; set; }

        /// <summary>
        /// Specifies if the object can be selected even if it is not clickable. Map object is clickable if zoom properties are set or it has description or has children objects. 
        /// Sometimes even non of the listed conditions is met you might need it to be clickable. You should set this property to true in this case.
        /// </summary>
        public bool? Selectable { get; set; }

        /// <summary>
        /// Color of an object when it is selected (somebody clicked on it).
        /// </summary>
        public string SelectedColor { get; set; }

        /// <summary>
        /// Specifies if selectedColor should be applied to the object. AmMap can have only one selected item at a time, 
        /// however there might be situations when multiple objects (areas, images, lines) have to look like they are selected. 
        /// By setting this property to true, you will be able to produce this result.
        /// </summary>
        public bool? ShowAsSelected { get; set; }

        /// <summary>
        /// Specifies if this object must be displayed in ObjectsList Title should be defined in order the object to appear there.
        /// </summary>
        public bool? ShowInList { get; set; }

        /// <summary>
        /// Title of a MapObject. It can be displayed in the roll-over balloon and in the header of description window. 
        /// All areas in SVG maps distributed with amMap has country names (titles) hard coded in the SVG file.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Url of an object. The application will go to this url when you click on the object.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Target of an URL, if URL is a string, for example: "_blank", "_top".
        /// </summary>
        public string UrlTarget { get; set; }

        /// <summary>
        /// Specifies if MapObject's, specified in the url zoom values should be used. Useful when building drill down maps.
        /// </summary>
        public bool? UseTargetsZoomValues { get; set; }

        /// <summary>
        /// Specifies latitude to which map should be moved when this object is clicked
        /// </summary>
        public double? ZoomLatitude { get; set; }

        /// <summary>
        /// Specifies map scale to which map should be rescaled when this object is clicked.
        /// </summary>
        public double? ZoomLevel { get; set; }

        /// <summary>
        /// Specifies longitude to which map should be moved when this object is clicked.
        /// </summary>
        public double? ZoomLongitude { get; set; }

        /// <summary>
        /// Specifies x position (in percents of stage width) to which map should be moved when this object is clicked.
        /// You can also use zoomLat and zoomLong instead of zoomY and zoomY.
        /// </summary>
        public double? ZoomX { get; set; }

        /// <summary>
        /// Specifies y position (in percents of stage height) to which map should be moved when this object is clicked.
        /// You can also use zoomLat and zoomLong instead of zoomY and zoomY.
        /// </summary>
        public double? ZoomY { get; set; }

    }
}