/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The ModeBar class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class ModeBar : IEquatable<ModeBar>
    {
        /// <summary>
        ///     Sets the orientation of the modebar.
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public Plotly.Blazor.LayoutLib.ModeBarLib.OrientationEnum? Orientation { get; set;} 

        /// <summary>
        ///     Sets the background color of the modebar.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the color of the icons in the modebar.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the color of the active or hovered on icons in the modebar.
        /// </summary>
        [JsonPropertyName(@"activecolor")]
        public object ActiveColor { get; set;} 

        /// <summary>
        ///     Controls persistence of user-driven changes related to the modebar, including
        ///     <c>hovermode</c>, <c>dragmode</c>, and <c>showspikes</c> at both the root
        ///     level and inside subplots. Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Determines which predefined modebar buttons to add. Please note that these
        ///     buttons will only be shown if they are compatible with all trace types used
        ///     in a graph. Similar to <c>config.modeBarButtonsToAdd</c> option. This may
        ///     include <c>v1hovermode</c>, <c>hoverclosest</c>, <c>hovercompare</c>, <c>togglehover</c>,
        ///     <c>togglespikelines</c>, <c>drawline</c>, <c>drawopenpath</c>, <c>drawclosedpath</c>,
        ///     <c>drawcircle</c>, <c>drawrect</c>, <c>eraseshape</c>.
        /// </summary>
        [JsonPropertyName(@"add")]
        public string Add { get; set;} 

        /// <summary>
        ///     Determines which predefined modebar buttons to add. Please note that these
        ///     buttons will only be shown if they are compatible with all trace types used
        ///     in a graph. Similar to <c>config.modeBarButtonsToAdd</c> option. This may
        ///     include <c>v1hovermode</c>, <c>hoverclosest</c>, <c>hovercompare</c>, <c>togglehover</c>,
        ///     <c>togglespikelines</c>, <c>drawline</c>, <c>drawopenpath</c>, <c>drawclosedpath</c>,
        ///     <c>drawcircle</c>, <c>drawrect</c>, <c>eraseshape</c>.
        /// </summary>
        [JsonPropertyName(@"add")]
        [Array]
        public IList<string> AddArray { get; set;} 

        /// <summary>
        ///     Determines which predefined modebar buttons to remove. Similar to <c>config.modeBarButtonsToRemove</c>
        ///     option. This may include <c>autoScale2d</c>, <c>autoscale</c>, <c>editInChartStudio</c>,
        ///     <c>editinchartstudio</c>, <c>hoverCompareCartesian</c>, <c>hovercompare</c>,
        ///     <c>lasso</c>, <c>lasso2d</c>, <c>orbitRotation</c>, <c>orbitrotation</c>,
        ///     <c>pan</c>, <c>pan2d</c>, <c>pan3d</c>, <c>reset</c>, <c>resetCameraDefault3d</c>,
        ///     <c>resetCameraLastSave3d</c>, <c>resetGeo</c>, <c>resetSankeyGroup</c>,
        ///     <c>resetScale2d</c>, <c>resetViewMapbox</c>, <c>resetViews</c>, <c>resetcameradefault</c>,
        ///     <c>resetcameralastsave</c>, <c>resetsankeygroup</c>, <c>resetscale</c>,
        ///     <c>resetview</c>, <c>resetviews</c>, <c>select</c>, <c>select2d</c>, <c>sendDataToCloud</c>,
        ///     <c>senddatatocloud</c>, <c>tableRotation</c>, <c>tablerotation</c>, <c>toImage</c>,
        ///     <c>toggleHover</c>, <c>toggleSpikelines</c>, <c>togglehover</c>, <c>togglespikelines</c>,
        ///     <c>toimage</c>, <c>zoom</c>, <c>zoom2d</c>, <c>zoom3d</c>, <c>zoomIn2d</c>,
        ///     <c>zoomInGeo</c>, <c>zoomInMapbox</c>, <c>zoomOut2d</c>, <c>zoomOutGeo</c>,
        ///     <c>zoomOutMapbox</c>, <c>zoomin</c>, <c>zoomout</c>.
        /// </summary>
        [JsonPropertyName(@"remove")]
        public string Remove { get; set;} 

        /// <summary>
        ///     Determines which predefined modebar buttons to remove. Similar to <c>config.modeBarButtonsToRemove</c>
        ///     option. This may include <c>autoScale2d</c>, <c>autoscale</c>, <c>editInChartStudio</c>,
        ///     <c>editinchartstudio</c>, <c>hoverCompareCartesian</c>, <c>hovercompare</c>,
        ///     <c>lasso</c>, <c>lasso2d</c>, <c>orbitRotation</c>, <c>orbitrotation</c>,
        ///     <c>pan</c>, <c>pan2d</c>, <c>pan3d</c>, <c>reset</c>, <c>resetCameraDefault3d</c>,
        ///     <c>resetCameraLastSave3d</c>, <c>resetGeo</c>, <c>resetSankeyGroup</c>,
        ///     <c>resetScale2d</c>, <c>resetViewMapbox</c>, <c>resetViews</c>, <c>resetcameradefault</c>,
        ///     <c>resetcameralastsave</c>, <c>resetsankeygroup</c>, <c>resetscale</c>,
        ///     <c>resetview</c>, <c>resetviews</c>, <c>select</c>, <c>select2d</c>, <c>sendDataToCloud</c>,
        ///     <c>senddatatocloud</c>, <c>tableRotation</c>, <c>tablerotation</c>, <c>toImage</c>,
        ///     <c>toggleHover</c>, <c>toggleSpikelines</c>, <c>togglehover</c>, <c>togglespikelines</c>,
        ///     <c>toimage</c>, <c>zoom</c>, <c>zoom2d</c>, <c>zoom3d</c>, <c>zoomIn2d</c>,
        ///     <c>zoomInGeo</c>, <c>zoomInMapbox</c>, <c>zoomOut2d</c>, <c>zoomOutGeo</c>,
        ///     <c>zoomOutMapbox</c>, <c>zoomin</c>, <c>zoomout</c>.
        /// </summary>
        [JsonPropertyName(@"remove")]
        [Array]
        public IList<string> RemoveArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  add .
        /// </summary>
        [JsonPropertyName(@"addsrc")]
        public string AddSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  remove .
        /// </summary>
        [JsonPropertyName(@"removesrc")]
        public string RemoveSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is ModeBar other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] ModeBar other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Orientation == other.Orientation ||
                    Orientation != null &&
                    Orientation.Equals(other.Orientation)
                ) && 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    ActiveColor == other.ActiveColor ||
                    ActiveColor != null &&
                    ActiveColor.Equals(other.ActiveColor)
                ) && 
                (
                    UiRevision == other.UiRevision ||
                    UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    Add == other.Add ||
                    Add != null &&
                    Add.Equals(other.Add)
                ) && 
                (
                    Equals(AddArray, other.AddArray) ||
                    AddArray != null && other.AddArray != null &&
                    AddArray.SequenceEqual(other.AddArray)
                ) &&
                (
                    Remove == other.Remove ||
                    Remove != null &&
                    Remove.Equals(other.Remove)
                ) && 
                (
                    Equals(RemoveArray, other.RemoveArray) ||
                    RemoveArray != null && other.RemoveArray != null &&
                    RemoveArray.SequenceEqual(other.RemoveArray)
                ) &&
                (
                    AddSrc == other.AddSrc ||
                    AddSrc != null &&
                    AddSrc.Equals(other.AddSrc)
                ) && 
                (
                    RemoveSrc == other.RemoveSrc ||
                    RemoveSrc != null &&
                    RemoveSrc.Equals(other.RemoveSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Orientation != null) hashCode = hashCode * 59 + Orientation.GetHashCode();
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (ActiveColor != null) hashCode = hashCode * 59 + ActiveColor.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Add != null) hashCode = hashCode * 59 + Add.GetHashCode();
                if (AddArray != null) hashCode = hashCode * 59 + AddArray.GetHashCode();
                if (Remove != null) hashCode = hashCode * 59 + Remove.GetHashCode();
                if (RemoveArray != null) hashCode = hashCode * 59 + RemoveArray.GetHashCode();
                if (AddSrc != null) hashCode = hashCode * 59 + AddSrc.GetHashCode();
                if (RemoveSrc != null) hashCode = hashCode * 59 + RemoveSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ModeBar and the right ModeBar.
        /// </summary>
        /// <param name="left">Left ModeBar.</param>
        /// <param name="right">Right ModeBar.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (ModeBar left, ModeBar right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ModeBar and the right ModeBar.
        /// </summary>
        /// <param name="left">Left ModeBar.</param>
        /// <param name="right">Right ModeBar.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (ModeBar left, ModeBar right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ModeBar</returns>
        public ModeBar DeepClone()
        {
            return this.Copy();
        }
    }
}