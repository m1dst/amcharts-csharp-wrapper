using Newtonsoft.Json;

namespace AmChartsNet.Maps
{
    public class MapImage : MapObject
    {

        /// <summary>
        /// If you set it to true, and lineId of some line is set, the image will animate along the line.
        /// </summary>
        public bool? AnimateAlongLine { get; set; }

        /// <summary>
        /// Defines duration of animation (along line or when animateTo method is called), in seconds. Global animationDuration can also be set via ImagesSettings.
        /// </summary>
        public int? AnimationDuration { get; set; }

        /// <summary>
        /// Distance from bottom of a map container to the image. If centered property is false, then the distance is measured to the bottom of the image, otherwise - to the center.If you set this property, value of top property is ignored.This property can be set as a number (of pixels) or as a percent value, like: image.bottom = "10%";. The image will not be bounded to the map if this property is set.Use latitude and longitude properties if you want the image to move with the map.
        /// </summary>
        public int? Bottom { get; set; }

        /// <summary>
        /// Specifies if the image's center should be placed in the provided coordinates. If false, top-left corner will be at provided coordinates. This property doesn't work with images set as svgPath.
        /// </summary>
        public bool? Centered { get; set; }

        /// <summary>
        /// Function which defines how the image should animate.AmCharts.easeInOutQuad. You can use these methods: AmCharts.bounce, AmCharts.easeInSine, AmCharts.easeOutSine, AmCharts.easeOutElastic.Common for all easing function is set onImagesSettings.
        /// </summary>
        public string EasingFunction { get; set; }

        /// <summary>
        /// Specifies if animation along lines should be played in reverse direction when reached the end of a line.
        /// </summary>
        public bool? FlipDirection { get; set; }

        /// <summary>
        /// Height of an image. Works with predefined images (if type is set) and loaded images(imageURL is set). If svgPath is set, use scale property to change it's size.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Url of an image. Images can be svg, jpg, png or gif files. Note, you can't control color, outlineColor, outlineAlpha and outlineThickness of loaded images. Use svgPath property if you need to change these properties.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Text which will be shown next to the image.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Opacity of label background alpha.
        /// </summary>
        public double? LabelBackgroundAlpha { get; set; }

        /// <summary>
        /// Color of label background.
        /// </summary>
        public string LabelBackgroundColor { get; set; }

        /// <summary>
        /// Label color.
        /// </summary>
        public string LabelColor { get; set; }

        /// <summary>
        /// Font size of a label.
        /// </summary>
        public int? LabelFontSize { get; set; }

        /// <summary>
        /// Position of the label. Allowed values are: left, right, top, bottom and middle.
        /// </summary>
        public string LabelPosition { get; set; }

        /// <summary>
        /// Label roll-over color.
        /// </summary>
        public string LabelRollOverColor { get; set; }

        /// <summary>
        /// In some cases you might want to adjust label position a bit.Use this property to shift label horizontally.
        /// </summary>
        public int? LabelShiftX { get; set; }

        /// <summary>
        /// In some cases you might want to adjust label position a bit.Use this property to shift label vertically.
        /// </summary>
        public int? LabelShiftY { get; set; }

        /// <summary>
        /// Latitude of the image. Set this property if you want the image to be bounded to the map. Otherwise use left/right/top/bottom properties.
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Distance from left of a map container to the image.If centered property is false, then the distance is measured to the left of the image, otherwise - to the center.
        /// The image will not be bounded to the map if this property is set.Use latitude and longitude properties if you want the image to move with the map.
        /// This property can be set as a number (of pixels) or as a percent value, like: image.left = "10%";
        /// </summary>
        public string Left { get; set; }

        /// <summary>
        /// You should add id for the line and set this id for the image if you want to use create animation along line or position image at some relative position of a line.
        /// </summary>
        public string LineId { get; set; }

        /// <summary>
        /// Longitude of the image. Set this property if you want the image to be bounded to the map. Otherwise use left/right/top/bottom properties.
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Specifies if animation along lines should be looped.
        /// </summary>
        public bool? Loop { get; set; }

        /// <summary>
        /// Opacity of image outline. This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public double? OutlineAlpha { get; set; }

        /// <summary>
        /// Color of image outline. This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public string OutlineColor { get; set; }

        /// <summary>
        /// Thickness of image outline. This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public int? OutlineThickness { get; set; }

        /// <summary>
        /// Height of an image, in percents of map container. Works with predefined images (if type is set) and loaded images(imageURL is set). If svgPath is set, use scale property to change it's size.
        /// </summary>
        public int? PercentHeight { get; set; }

        /// <summary>
        /// Width of an image, in percents of map container. Works with predefined images (if type is set) and loaded images(imageURL is set). If svgPath is set, use scale property to change it's size.
        /// </summary>
        public int? PercentWidth { get; set; }

        /// <summary>
        /// If you set lineId of some line and then set positionOnLine to 0.5, the image will be placed in the middle of the line. Allowed values are from 0 to 1.
        /// </summary>
        public double? PositionOnLine { get; set; }

        /// <summary>
        /// If you set it to 2, the image will scale 2x in the middle of the animation.
        /// </summary>
        public double? PositionScale { get; set; }

        /// <summary>
        /// Distance from right of a map container to the image. If centered property is false, then the distance is measured to the right of the image, otherwise - to the center.
        /// If you set this property, value of left property is ignored. The image will not be bounded to the map if this property is set.
        /// This property can be set as a number (of pixels) or as a percent value, like: image.right= "10%"; Use latitude and longitude properties if you want the image to move with the map.
        /// </summary>
        public string Right { get; set; }

        /// <summary>
        /// Scale of the image when hovered. Use value like 1.5 - 2 to enlarge image when user rolls-over it.
        /// </summary>
        public double? RollOverScale { get; set; }

        /// <summary>
        /// Scale of the image. Works only with images created using svgPath. Use width/height properties for all other images.
        /// </summary>
        public double? Scale { get; set; }

        /// <summary>
        /// Color of a label when image is selected.
        /// </summary>
        public string SelectedLabelColor { get; set; }

        /// <summary>
        /// Scale of the image if it is selected. Use value like 1.5 - 2 to enlarge selected image.
        /// </summary>
        public double? SelectedScale { get; set; }

        /// <summary>
        /// SVG path, for example: 
        /// M9,0C4.029,0,0,4.029,0,9s4.029,9,9,9s9-4.029,9-9S13.971,0,9,0z M9,15.93 c-3.83,0-6.93-3.1-6.93-6.93S5.17,2.07,9,2.07s6.93,3.1,6.93,6.93S12.83,15.93,9,15.93 M12.5,9c0,1.933-1.567,3.5-3.5,3.5S5.5,10.933,5.5,9S7.067,5.5,9,5.5 S12.5,7.067,12.5,9z
        /// The line above will create a target icon.For more icons we recommend visiting this page: http://raphaeljs.com/icons/
        /// Simply click on an icon you like and you will get SVG path in the bottom. This is the recommended way to create icons/images in AmMap.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string SvgPath { get; set; }

        /// <summary>
        /// Distance from top of a map container to the image.If centered property is false, then the distance is measured to the top bound of the image, 
        /// otherwise - to the center.The image will not be bounded to the map if this property is set.This property can be set as a number (of pixels) or 
        /// as a percent value, like: image.top = "10%"; Use latitude and longitude properties if you want the image to move with the map.
        /// </summary>
        public string Top { get; set; }

        /// <summary>
        /// Type of a predefined image. Allowed values are: circle, rectangle, bubble and hexagon.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Width of an image. Works with predefined images (if type is set) and loaded images(imageURL is set). If svgPath is set, use scale property to change it's size.
        /// </summary>
        public int? Width { get; set; }


        /// <summary>
        /// You can set miles or kilometers as a unit of width/height of an image. This works only with predefined images (type is set).
        /// </summary>
        public string WidthAndHeightUnits { get; set; }
        
    }
}