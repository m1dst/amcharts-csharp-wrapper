namespace AmChartsNet.Maps
{
    /// <summary>
    /// ImagesSettings is a class which holds common settings of all MapImage objects.
    /// </summary>
    public class ImagesSettings
    {

        /// <summary>
        /// Will add aria-label tag to images. It will be read by some of screen readers when user hovers them.
        /// </summary>
        public string AccessibleLabel { get; set; }

        /// <summary>
        /// If you set it to true, images along the lines will adjust the speed of animation corresponding the distance between lines.
        /// </summary>
        public bool? AdjustAnimationSpeed { get; set; }

        /// <summary>
        /// Opacity of the image.
        /// </summary>
        public double? Alpha { get; set; }

        /// <summary>
        /// Defines duration of animation, in seconds. Custom animationDuration can also be set directly on MapImage.
        /// </summary>
        public int? AnimationDuration { get; set; }

        /// <summary>
        /// Using this setting you can make lines to be curved, or actually to make them look like arcs. Note, there is one limitation - this works well with two-point lines only. You can also set arc for MapLine individually.
        /// </summary>
        public double? Arc { get; set; }

        /// <summary>
        /// Text which is displayed in a roll-over balloon. You can use the following tags: [[title]], [[description]], [[value]] and [[percent]].
        /// </summary>
        public string BalloonText { get; set; }

        /// <summary>
        /// If adjustAnimationSpeed is set to true, the the image will move at a speed which would allow to move by 500 pixels during animationDuration.
        /// If the distance between start/end points of animation is less than baseAnimationDistance, the image will move faster, otherwise – slower.
        /// </summary>
        public int? BaseAnimationDistance { get; set; }

        /// <summary>
        /// Specifies if image should change it's z-index to the most top when user hovers it.
        /// </summary>
        public bool? BringForwardOnHover { get; set; }

        /// <summary>
        /// Specifies if the image's center should be placed in the provided coordinates. If false, top-left corner will be at provided coordinates.
        /// </summary>
        public bool? Centered { get; set; }

        /// <summary>
        /// Color of image. This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Distance from the bottom side of map container to the description window. In case it is not set (also if descriptionWindowTop is not set), window will be placed near the mouse pointer.
        /// </summary>
        public int? DescriptionWindowBottom { get; set; }

        /// <summary>
        /// Height of a description window.
        /// </summary>
        public int? DescriptionWindowHeight { get; set; }

        /// <summary>
        /// Distance from the left side of map container to the description window. In case it is not set (also if descriptionWindowRight is not set), window will be placed near the mouse pointer.
        /// </summary>
        public int? DescriptionWindowLeft { get; set; }

        /// <summary>
        /// Distance from the right side of map container to the description window. In case it is not set (also if descriptionWindowLeft is not set), window will be placed near the mouse pointer.
        /// </summary>
        public int? DescriptionWindowRight { get; set; }

        /// <summary>
        /// Distance from the top side of map container to the description window. In case it is not set (also if descriptionWindowBottom is not set), window will be placed near the mouse pointer.
        /// </summary>
        public int? DescriptionWindowTop { get; set; }

        /// <summary>
        /// Width of a description window.
        /// </summary>
        public int? DescriptionWindowWidth { get; set; }

        /// <summary>
        /// Label color.
        /// </summary>
        public string LabelColor { get; set; }

        /// <summary>
        /// Font size of a label.
        /// </summary>
        public int? LabelFontSize { get; set; }

        /// <summary>
        /// Position of the label.Allowed values are: left, right, top, bottom and middle.
        /// </summary>
        public string LabelPosition { get; set; }

        /// <summary>
        /// Label roll-over color.
        /// </summary>
        public string LabelRollOverColor { get; set; }

        /// <summary>
        /// Opacity of image outline.This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public double? OutlineAlpha { get; set; }

        /// <summary>
        /// Color of image outline.This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public string OutlineColor { get; set; }

        /// <summary>
        /// Thickness of image outline.This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public int? OutlineThickness { get; set; }

        /// <summary>
        /// Defines pause between animations (if a line has more than one segment or animation is looped or flipped).
        /// </summary>
        public int? PauseDuration { get; set; }

        /// <summary>
        /// Color of image when hovered.This will affect only predefined images (with "type" property set) and images with svgPath set. This property won't affect bitmap images and loaded SVG images.
        /// </summary>
        public string RollOverColor { get; set; }

        /// <summary>
        /// Thickness of rolled-over image outline.
        /// </summary>
        public int? RollOverOutlineThickness { get; set; }

        /// <summary>
        /// Scale of the image when hovered. Use value like 1.5 - 2 to enlarge image when user rolls-over it.
        /// </summary>
        public double? RollOverScale { get; set; }

        /// <summary>
        /// Specifies if all images on the map can be selected. You can also override this setting for each individual image individually.
        /// </summary>
        public bool? Selectable { get; set; }

        /// <summary>
        /// Color of selected image.
        /// </summary>
        public string SelectedColor { get; set; }

        /// <summary>
        /// Label color in case the image is selected.
        /// </summary>
        public string SelectedLabelColor { get; set; }

        /// <summary>
        /// Color of selected image outline.
        /// </summary>
        public string SelectedOutlineColor { get; set; }

        /// <summary>
        /// Outline thickness of selected image.
        /// </summary>
        public int? SelectedOutlineThickness { get; set; }

        /// <summary>
        /// Scale of the image if it is selected. Use value like 1.5 - 2 to enlarge selected image.
        /// </summary>
        public double? SelectedScale { get; set; }

    }
}