/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.HeatMapLib
{
    /// <summary>
    ///     Only relevant when the axis <c>type</c> is <c>date</c>. Sets the alignment
    ///     of data points on the x axis.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XPeriodAlignmentEnum
    {
        [EnumMember(Value=@"middle")]
        Middle = 0,
        [EnumMember(Value=@"start")]
        Start,
        [EnumMember(Value=@"end")]
        End
    }
}