/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ScatterPolarGlLib
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Sets the line color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the style of the lines.
        /// </summary>
        [JsonPropertyName(@"dash")]
        public Plotly.Blazor.Traces.ScatterPolarGlLib.LineLib.DashEnum? Dash { get; set;} 

        /// <summary>
        ///     Determines the line shape. The values correspond to step-wise line shapes.
        /// </summary>
        [JsonPropertyName(@"shape")]
        public Plotly.Blazor.Traces.ScatterPolarGlLib.LineLib.ShapeEnum? Shape { get; set;} 

        /// <summary>
        ///     Sets the line width (in px).
        /// </summary>
        [JsonPropertyName(@"width")]
        public decimal? Width { get; set;} 

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
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Dash == other.Dash ||
                    Dash != null &&
                    Dash.Equals(other.Dash)
                ) && 
                (
                    Shape == other.Shape ||
                    Shape != null &&
                    Shape.Equals(other.Shape)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Dash != null) hashCode = hashCode * 59 + Dash.GetHashCode();
                if (Shape != null) hashCode = hashCode * 59 + Shape.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
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