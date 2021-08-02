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

namespace Plotly.Blazor.Traces.IcicleLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>marker.colorscale</c>. Has an
        ///     effect only if colorsis set to a numerical array. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default  palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here colors) or the bounds set in <c>marker.cmin</c> and <c>marker.cmax</c>
        ///      Has an effect only if colorsis set to a numerical array. Defaults to <c>false</c>
        ///     when <c>marker.cmin</c> and <c>marker.cmax</c> are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Has an effect only if colorsis
        ///     set to a numerical array. Value should have the same units as colors and
        ///     if set, <c>marker.cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public decimal? CMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>marker.cmin</c> and/or
        ///     <c>marker.cmax</c> to be equidistant to this point. Has an effect only if
        ///     colorsis set to a numerical array. Value should have the same units as colors.
        ///     Has no effect when <c>marker.cauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public decimal? CMid { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Has an effect only if colorsis
        ///     set to a numerical array. Value should have the same units as colors and
        ///     if set, <c>marker.cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public decimal? CMin { get; set;} 

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
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.IcicleLib.MarkerLib.ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets the color of each sector of this trace. If not specified, the default
        ///     trace color set is used to pick the sector colors.
        /// </summary>
        [JsonPropertyName(@"colors")]
        public IList<object> Colors { get; set;} 

        /// <summary>
        ///     Sets the colorscale. Has an effect only if colorsis set to a numerical array.
        ///     The colorscale must be an array containing arrays mapping a normalized value
        ///     to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping
        ///     for the lowest (0) and highest (1) values are required. For example, &#39;[[0,
        ///     <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;. To control the bounds
        ///     of the colorscale in color space, use<c>marker.cmin</c> and <c>marker.cmax</c>.
        ///     Alternatively, <c>colorscale</c> may be a palette name string of the following
        ///     list: Blackbody,Bluered,Blues,Cividis,Earth,Electric,Greens,Greys,Hot,Jet,Picnic,Portland,Rainbow,RdBu,Reds,Viridis,YlGnBu,YlOrRd.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  colors .
        /// </summary>
        [JsonPropertyName(@"colorssrc")]
        public string ColorsSrc { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.IcicleLib.MarkerLib.Line Line { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. Has an effect only if colorsis set to
        ///     a numerical array. If true, <c>marker.cmin</c> will correspond to the last
        ///     color in the array and <c>marker.cmax</c> will correspond to the first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace. Has an
        ///     effect only if colorsis set to a numerical array.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Marker other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Marker other)
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
                    ColorAxis == other.ColorAxis ||
                    ColorAxis != null &&
                    ColorAxis.Equals(other.ColorAxis)
                ) && 
                (
                    ColorBar == other.ColorBar ||
                    ColorBar != null &&
                    ColorBar.Equals(other.ColorBar)
                ) && 
                (
                    Equals(Colors, other.Colors) ||
                    Colors != null && other.Colors != null &&
                    Colors.SequenceEqual(other.Colors)
                ) &&
                (
                    ColorScale == other.ColorScale ||
                    ColorScale != null &&
                    ColorScale.Equals(other.ColorScale)
                ) && 
                (
                    ColorsSrc == other.ColorsSrc ||
                    ColorsSrc != null &&
                    ColorsSrc.Equals(other.ColorsSrc)
                ) && 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    ReverseScale == other.ReverseScale ||
                    ReverseScale != null &&
                    ReverseScale.Equals(other.ReverseScale)
                ) && 
                (
                    ShowScale == other.ShowScale ||
                    ShowScale != null &&
                    ShowScale.Equals(other.ShowScale)
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
                if (ColorAxis != null) hashCode = hashCode * 59 + ColorAxis.GetHashCode();
                if (ColorBar != null) hashCode = hashCode * 59 + ColorBar.GetHashCode();
                if (Colors != null) hashCode = hashCode * 59 + Colors.GetHashCode();
                if (ColorScale != null) hashCode = hashCode * 59 + ColorScale.GetHashCode();
                if (ColorsSrc != null) hashCode = hashCode * 59 + ColorsSrc.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (ReverseScale != null) hashCode = hashCode * 59 + ReverseScale.GetHashCode();
                if (ShowScale != null) hashCode = hashCode * 59 + ShowScale.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Marker left, Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Marker left, Marker right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Marker</returns>
        public Marker DeepClone()
        {
            return this.Copy();
        }
    }
}