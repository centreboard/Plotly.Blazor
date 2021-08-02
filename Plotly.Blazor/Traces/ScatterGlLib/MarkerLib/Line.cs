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

namespace Plotly.Blazor.Traces.ScatterGlLib.MarkerLib
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>marker.line.colorscale</c>. Has
        ///     an effect only if in <c>marker.line.color</c>is set to a numerical array.
        ///     In case <c>colorscale</c> is unspecified or <c>autocolorscale</c> is true,
        ///     the default  palette will be chosen according to whether numbers in the
        ///     <c>color</c> array are all positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>marker.line.color</c>) or the bounds set in <c>marker.line.cmin</c>
        ///     and <c>marker.line.cmax</c>  Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. Defaults to <c>false</c> when <c>marker.line.cmin</c>
        ///     and <c>marker.line.cmax</c> are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.line.color</c>
        ///     and if set, <c>marker.line.cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public decimal? CMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>marker.line.cmin</c>
        ///     and/or <c>marker.line.cmax</c> to be equidistant to this point. Has an effect
        ///     only if in <c>marker.line.color</c>is set to a numerical array. Value should
        ///     have the same units as in <c>marker.line.color</c>. Has no effect when <c>marker.line.cauto</c>
        ///     is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public decimal? CMid { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.line.color</c>
        ///     and if set, <c>marker.line.cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public decimal? CMin { get; set;} 

        /// <summary>
        ///     Sets themarker.linecolor. It accepts either a specific color or an array
        ///     of numbers that are mapped to the colorscale relative to the max and min
        ///     values of the array or relative to <c>marker.line.cmin</c> and <c>marker.line.cmax</c>
        ///     if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets themarker.linecolor. It accepts either a specific color or an array
        ///     of numbers that are mapped to the colorscale relative to the max and min
        ///     values of the array or relative to <c>marker.line.cmin</c> and <c>marker.line.cmax</c>
        ///     if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public IList<object> ColorArray { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Sets the colorscale. Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. The colorscale must be an array containing arrays
        ///     mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color
        ///     string. At minimum, a mapping for the lowest (0) and highest (1) values
        ///     are required. For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>marker.line.cmin</c>
        ///     and <c>marker.line.cmax</c>. Alternatively, <c>colorscale</c> may be a palette
        ///     name string of the following list: Blackbody,Bluered,Blues,Cividis,Earth,Electric,Greens,Greys,Hot,Jet,Picnic,Portland,Rainbow,RdBu,Reds,Viridis,YlGnBu,YlOrRd.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. Has an effect only if in <c>marker.line.color</c>is
        ///     set to a numerical array. If true, <c>marker.line.cmin</c> will correspond
        ///     to the last color in the array and <c>marker.line.cmax</c> will correspond
        ///     to the first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the lines bounding the marker points.
        /// </summary>
        [JsonPropertyName(@"width")]
        public decimal? Width { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the lines bounding the marker points.
        /// </summary>
        [JsonPropertyName(@"width")]
        [Array]
        public IList<decimal?> WidthArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  width .
        /// </summary>
        [JsonPropertyName(@"widthsrc")]
        public string WidthSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Line other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Line other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AutoColorScale == other.AutoColorScale ||
                    AutoColorScale != null &&
                    AutoColorScale.Equals(other.AutoColorScale)
                ) && 
                (
                    CAuto == other.CAuto ||
                    CAuto != null &&
                    CAuto.Equals(other.CAuto)
                ) && 
                (
                    CMax == other.CMax ||
                    CMax != null &&
                    CMax.Equals(other.CMax)
                ) && 
                (
                    CMid == other.CMid ||
                    CMid != null &&
                    CMid.Equals(other.CMid)
                ) && 
                (
                    CMin == other.CMin ||
                    CMin != null &&
                    CMin.Equals(other.CMin)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Equals(ColorArray, other.ColorArray) ||
                    ColorArray != null && other.ColorArray != null &&
                    ColorArray.SequenceEqual(other.ColorArray)
                ) &&
                (
                    ColorAxis == other.ColorAxis ||
                    ColorAxis != null &&
                    ColorAxis.Equals(other.ColorAxis)
                ) && 
                (
                    ColorScale == other.ColorScale ||
                    ColorScale != null &&
                    ColorScale.Equals(other.ColorScale)
                ) && 
                (
                    ColorSrc == other.ColorSrc ||
                    ColorSrc != null &&
                    ColorSrc.Equals(other.ColorSrc)
                ) && 
                (
                    ReverseScale == other.ReverseScale ||
                    ReverseScale != null &&
                    ReverseScale.Equals(other.ReverseScale)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
                ) && 
                (
                    Equals(WidthArray, other.WidthArray) ||
                    WidthArray != null && other.WidthArray != null &&
                    WidthArray.SequenceEqual(other.WidthArray)
                ) &&
                (
                    WidthSrc == other.WidthSrc ||
                    WidthSrc != null &&
                    WidthSrc.Equals(other.WidthSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (AutoColorScale != null) hashCode = hashCode * 59 + AutoColorScale.GetHashCode();
                if (CAuto != null) hashCode = hashCode * 59 + CAuto.GetHashCode();
                if (CMax != null) hashCode = hashCode * 59 + CMax.GetHashCode();
                if (CMid != null) hashCode = hashCode * 59 + CMid.GetHashCode();
                if (CMin != null) hashCode = hashCode * 59 + CMin.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (ColorArray != null) hashCode = hashCode * 59 + ColorArray.GetHashCode();
                if (ColorAxis != null) hashCode = hashCode * 59 + ColorAxis.GetHashCode();
                if (ColorScale != null) hashCode = hashCode * 59 + ColorScale.GetHashCode();
                if (ColorSrc != null) hashCode = hashCode * 59 + ColorSrc.GetHashCode();
                if (ReverseScale != null) hashCode = hashCode * 59 + ReverseScale.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                if (WidthArray != null) hashCode = hashCode * 59 + WidthArray.GetHashCode();
                if (WidthSrc != null) hashCode = hashCode * 59 + WidthSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Line left, Line right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Line left, Line right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Line</returns>
        public Line DeepClone()
        {
            return this.Copy();
        }
    }
}