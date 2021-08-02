/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.GeoLib
{
    /// <summary>
    ///     Set the scope of the map.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ScopeEnum
    {
        [EnumMember(Value=@"world")]
        World = 0,
        [EnumMember(Value=@"africa")]
        Africa,
        [EnumMember(Value=@"asia")]
        Asia,
        [EnumMember(Value=@"europe")]
        Europe,
        [EnumMember(Value=@"north america")]
        NorthAmerica,
        [EnumMember(Value=@"south america")]
        SouthAmerica,
        [EnumMember(Value=@"usa")]
        USA
    }
}