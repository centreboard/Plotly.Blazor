/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ContourCarpetLib.ColorBarLib
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Title : IEquatable<Title>
    {
        /// <summary>
        ///     Sets this color bar&#39;s title font. Note that the title&#39;s font used
        ///     to be set by the now deprecated <c>titlefont</c> attribute.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.Traces.ContourCarpetLib.ColorBarLib.TitleLib.Font Font { get; set;} 

        /// <summary>
        ///     Determines the location of color bar&#39;s title with respect to the color
        ///     bar. Note that the title&#39;s location used to be set by the now deprecated
        ///     <c>titleside</c> attribute.
        /// </summary>
        [JsonPropertyName(@"side")]
        public Plotly.Blazor.Traces.ContourCarpetLib.ColorBarLib.TitleLib.SideEnum? Side { get; set;} 

        /// <summary>
        ///     Sets the title of the color bar. Note that before the existence of <c>title.text</c>,
        ///     the title&#39;s contents used to be defined as the <c>title</c> attribute
        ///     itself. This behavior has been deprecated.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Title other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Title other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    Side == other.Side ||
                    Side != null &&
                    Side.Equals(other.Side)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (Side != null) hashCode = hashCode * 59 + Side.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Title and the right Title.
        /// </summary>
        /// <param name="left">Left Title.</param>
        /// <param name="right">Right Title.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Title left, Title right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Title and the right Title.
        /// </summary>
        /// <param name="left">Left Title.</param>
        /// <param name="right">Right Title.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Title left, Title right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Title</returns>
        public Title DeepClone()
        {
            return this.Copy();
        }
    }
}