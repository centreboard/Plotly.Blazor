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

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The Ohlc class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Ohlc : ITrace, IEquatable<Ohlc>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Ohlc;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.OhlcLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set;} 

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public IList<object> Ids { get; set;} 

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, <c>scatter</c> traces also appends
        ///     customdata items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object Meta { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        [Array]
        public IList<object> MetaArray { get; set;} 

        /// <summary>
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the <c>unselected</c> are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the <c>selected</c>
        ///     and <c>unselected</c> styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object SelectedPoints { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.OhlcLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        [Array]
        public IList<Plotly.Blazor.Traces.OhlcLib.HoverInfoFlag?> HoverInfoArray { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.OhlcLib.Stream Stream { get; set;} 

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        public IList<ITransform> Transforms { get; set;} 

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: <c>constraintrange</c>
        ///     in <c>parcoords</c> traces, as well as some &#39;editable: true&#39; modifications
        ///     such as <c>name</c> and <c>colorbar.title</c>. Defaults to <c>layout.uirevision</c>.
        ///     Note that other user-driven trace attribute changes are controlled by <c>layout</c>
        ///     attributes: <c>trace.visible</c> is controlled by <c>layout.legend.uirevision</c>,
        ///     <c>selectedpoints</c> is controlled by <c>layout.selectionrevision</c>,
        ///     and <c>colorbar.(x|y)</c> (accessible with &#39;config: {editable: true}&#39;)
        ///     is controlled by <c>layout.editrevision</c>. Trace changes are tracked by
        ///     <c>uid</c>, which only falls back on trace index if no <c>uid</c> is provided.
        ///     So if your app can add/remove traces before the end of the <c>data</c> array,
        ///     such that the same trace has a different index, you can still preserve user-driven
        ///     changes if you give each trace a <c>uid</c> that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Only relevant when the axis <c>type</c> is <c>date</c>. Sets the period
        ///     positioning in milliseconds or <c>M&lt;n&gt;</c> on the x axis. Special
        ///     values in the form of <c>M&lt;n&gt;</c> could be used to declare the number
        ///     of months. In this case <c>n</c> must be a positive integer.
        /// </summary>
        [JsonPropertyName(@"xperiod")]
        public object XPeriod { get; set;} 

        /// <summary>
        ///     Only relevant when the axis <c>type</c> is <c>date</c>. Sets the base for
        ///     period positioning in milliseconds or date string on the x0 axis. When <c>x0period</c>
        ///     is round number of weeks, the <c>x0period0</c> by default would be on a
        ///     Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
        /// </summary>
        [JsonPropertyName(@"xperiod0")]
        public object XPeriod0 { get; set;} 

        /// <summary>
        ///     Only relevant when the axis <c>type</c> is <c>date</c>. Sets the alignment
        ///     of data points on the x axis.
        /// </summary>
        [JsonPropertyName(@"xperiodalignment")]
        public Plotly.Blazor.Traces.OhlcLib.XPeriodAlignmentEnum? XPeriodAlignment { get; set;} 

        /// <summary>
        ///     Sets the x coordinates. If absent, linear coordinate will be generated.
        /// </summary>
        [JsonPropertyName(@"x")]
        public IList<object> X { get; set;} 

        /// <summary>
        ///     Sets the open values.
        /// </summary>
        [JsonPropertyName(@"open")]
        public IList<object> Open { get; set;} 

        /// <summary>
        ///     Sets the high values.
        /// </summary>
        [JsonPropertyName(@"high")]
        public IList<object> High { get; set;} 

        /// <summary>
        ///     Sets the low values.
        /// </summary>
        [JsonPropertyName(@"low")]
        public IList<object> Low { get; set;} 

        /// <summary>
        ///     Sets the close values.
        /// </summary>
        [JsonPropertyName(@"close")]
        public IList<object> Close { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.OhlcLib.Line Line { get; set;} 

        /// <summary>
        ///     Gets or sets the Increasing.
        /// </summary>
        [JsonPropertyName(@"increasing")]
        public Plotly.Blazor.Traces.OhlcLib.Increasing Increasing { get; set;} 

        /// <summary>
        ///     Gets or sets the Decreasing.
        /// </summary>
        [JsonPropertyName(@"decreasing")]
        public Plotly.Blazor.Traces.OhlcLib.Decreasing Decreasing { get; set;} 

        /// <summary>
        ///     Sets hover text elements associated with each sample point. If a single
        ///     string, the same string appears over all the data points. If an array of
        ///     string, the items are mapped in order to this trace&#39;s sample points.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets hover text elements associated with each sample point. If a single
        ///     string, the same string appears over all the data points. If an array of
        ///     string, the items are mapped in order to this trace&#39;s sample points.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public IList<string> TextArray { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public IList<string> HoverTextArray { get; set;} 

        /// <summary>
        ///     Sets the width of the open/close tick marks relative to the <c>x</c> minimal
        ///     interval.
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public decimal? TickWidth { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.OhlcLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use with <c>x</c> date data.
        /// </summary>
        [JsonPropertyName(@"xcalendar")]
        public Plotly.Blazor.Traces.OhlcLib.XCalendarEnum? XCalendar { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s x coordinates and a 2D cartesian
        ///     x axis. If <c>x</c> (the default value), the x coordinates refer to <c>layout.xaxis</c>.
        ///     If <c>x2</c>, the x coordinates refer to <c>layout.xaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string XAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s y coordinates and a 2D cartesian
        ///     y axis. If <c>y</c> (the default value), the y coordinates refer to <c>layout.yaxis</c>.
        ///     If <c>y2</c>, the y coordinates refer to <c>layout.yaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string YAxis { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ids .
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  open .
        /// </summary>
        [JsonPropertyName(@"opensrc")]
        public string OpenSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  high .
        /// </summary>
        [JsonPropertyName(@"highsrc")]
        public string HighSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  low .
        /// </summary>
        [JsonPropertyName(@"lowsrc")]
        public string LowSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  close .
        /// </summary>
        [JsonPropertyName(@"closesrc")]
        public string CloseSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Ohlc other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Ohlc other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Visible == other.Visible ||
                    Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    ShowLegend == other.ShowLegend ||
                    ShowLegend != null &&
                    ShowLegend.Equals(other.ShowLegend)
                ) && 
                (
                    LegendGroup == other.LegendGroup ||
                    LegendGroup != null &&
                    LegendGroup.Equals(other.LegendGroup)
                ) && 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    UId == other.UId ||
                    UId != null &&
                    UId.Equals(other.UId)
                ) && 
                (
                    Equals(Ids, other.Ids) ||
                    Ids != null && other.Ids != null &&
                    Ids.SequenceEqual(other.Ids)
                ) &&
                (
                    Equals(CustomData, other.CustomData) ||
                    CustomData != null && other.CustomData != null &&
                    CustomData.SequenceEqual(other.CustomData)
                ) &&
                (
                    Meta == other.Meta ||
                    Meta != null &&
                    Meta.Equals(other.Meta)
                ) && 
                (
                    Equals(MetaArray, other.MetaArray) ||
                    MetaArray != null && other.MetaArray != null &&
                    MetaArray.SequenceEqual(other.MetaArray)
                ) &&
                (
                    SelectedPoints == other.SelectedPoints ||
                    SelectedPoints != null &&
                    SelectedPoints.Equals(other.SelectedPoints)
                ) && 
                (
                    HoverInfo == other.HoverInfo ||
                    HoverInfo != null &&
                    HoverInfo.Equals(other.HoverInfo)
                ) && 
                (
                    Equals(HoverInfoArray, other.HoverInfoArray) ||
                    HoverInfoArray != null && other.HoverInfoArray != null &&
                    HoverInfoArray.SequenceEqual(other.HoverInfoArray)
                ) &&
                (
                    Stream == other.Stream ||
                    Stream != null &&
                    Stream.Equals(other.Stream)
                ) && 
                (
                    Equals(Transforms, other.Transforms) ||
                    Transforms != null && other.Transforms != null &&
                    Transforms.SequenceEqual(other.Transforms)
                ) &&
                (
                    UiRevision == other.UiRevision ||
                    UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    XPeriod == other.XPeriod ||
                    XPeriod != null &&
                    XPeriod.Equals(other.XPeriod)
                ) && 
                (
                    XPeriod0 == other.XPeriod0 ||
                    XPeriod0 != null &&
                    XPeriod0.Equals(other.XPeriod0)
                ) && 
                (
                    XPeriodAlignment == other.XPeriodAlignment ||
                    XPeriodAlignment != null &&
                    XPeriodAlignment.Equals(other.XPeriodAlignment)
                ) && 
                (
                    Equals(X, other.X) ||
                    X != null && other.X != null &&
                    X.SequenceEqual(other.X)
                ) &&
                (
                    Equals(Open, other.Open) ||
                    Open != null && other.Open != null &&
                    Open.SequenceEqual(other.Open)
                ) &&
                (
                    Equals(High, other.High) ||
                    High != null && other.High != null &&
                    High.SequenceEqual(other.High)
                ) &&
                (
                    Equals(Low, other.Low) ||
                    Low != null && other.Low != null &&
                    Low.SequenceEqual(other.Low)
                ) &&
                (
                    Equals(Close, other.Close) ||
                    Close != null && other.Close != null &&
                    Close.SequenceEqual(other.Close)
                ) &&
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Increasing == other.Increasing ||
                    Increasing != null &&
                    Increasing.Equals(other.Increasing)
                ) && 
                (
                    Decreasing == other.Decreasing ||
                    Decreasing != null &&
                    Decreasing.Equals(other.Decreasing)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Equals(TextArray, other.TextArray) ||
                    TextArray != null && other.TextArray != null &&
                    TextArray.SequenceEqual(other.TextArray)
                ) &&
                (
                    HoverText == other.HoverText ||
                    HoverText != null &&
                    HoverText.Equals(other.HoverText)
                ) && 
                (
                    Equals(HoverTextArray, other.HoverTextArray) ||
                    HoverTextArray != null && other.HoverTextArray != null &&
                    HoverTextArray.SequenceEqual(other.HoverTextArray)
                ) &&
                (
                    TickWidth == other.TickWidth ||
                    TickWidth != null &&
                    TickWidth.Equals(other.TickWidth)
                ) && 
                (
                    HoverLabel == other.HoverLabel ||
                    HoverLabel != null &&
                    HoverLabel.Equals(other.HoverLabel)
                ) && 
                (
                    XCalendar == other.XCalendar ||
                    XCalendar != null &&
                    XCalendar.Equals(other.XCalendar)
                ) && 
                (
                    XAxis == other.XAxis ||
                    XAxis != null &&
                    XAxis.Equals(other.XAxis)
                ) && 
                (
                    YAxis == other.YAxis ||
                    YAxis != null &&
                    YAxis.Equals(other.YAxis)
                ) && 
                (
                    IdsSrc == other.IdsSrc ||
                    IdsSrc != null &&
                    IdsSrc.Equals(other.IdsSrc)
                ) && 
                (
                    CustomDataSrc == other.CustomDataSrc ||
                    CustomDataSrc != null &&
                    CustomDataSrc.Equals(other.CustomDataSrc)
                ) && 
                (
                    MetaSrc == other.MetaSrc ||
                    MetaSrc != null &&
                    MetaSrc.Equals(other.MetaSrc)
                ) && 
                (
                    HoverInfoSrc == other.HoverInfoSrc ||
                    HoverInfoSrc != null &&
                    HoverInfoSrc.Equals(other.HoverInfoSrc)
                ) && 
                (
                    XSrc == other.XSrc ||
                    XSrc != null &&
                    XSrc.Equals(other.XSrc)
                ) && 
                (
                    OpenSrc == other.OpenSrc ||
                    OpenSrc != null &&
                    OpenSrc.Equals(other.OpenSrc)
                ) && 
                (
                    HighSrc == other.HighSrc ||
                    HighSrc != null &&
                    HighSrc.Equals(other.HighSrc)
                ) && 
                (
                    LowSrc == other.LowSrc ||
                    LowSrc != null &&
                    LowSrc.Equals(other.LowSrc)
                ) && 
                (
                    CloseSrc == other.CloseSrc ||
                    CloseSrc != null &&
                    CloseSrc.Equals(other.CloseSrc)
                ) && 
                (
                    TextSrc == other.TextSrc ||
                    TextSrc != null &&
                    TextSrc.Equals(other.TextSrc)
                ) && 
                (
                    HoverTextSrc == other.HoverTextSrc ||
                    HoverTextSrc != null &&
                    HoverTextSrc.Equals(other.HoverTextSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (ShowLegend != null) hashCode = hashCode * 59 + ShowLegend.GetHashCode();
                if (LegendGroup != null) hashCode = hashCode * 59 + LegendGroup.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (UId != null) hashCode = hashCode * 59 + UId.GetHashCode();
                if (Ids != null) hashCode = hashCode * 59 + Ids.GetHashCode();
                if (CustomData != null) hashCode = hashCode * 59 + CustomData.GetHashCode();
                if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
                if (MetaArray != null) hashCode = hashCode * 59 + MetaArray.GetHashCode();
                if (SelectedPoints != null) hashCode = hashCode * 59 + SelectedPoints.GetHashCode();
                if (HoverInfo != null) hashCode = hashCode * 59 + HoverInfo.GetHashCode();
                if (HoverInfoArray != null) hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (Transforms != null) hashCode = hashCode * 59 + Transforms.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (XPeriod != null) hashCode = hashCode * 59 + XPeriod.GetHashCode();
                if (XPeriod0 != null) hashCode = hashCode * 59 + XPeriod0.GetHashCode();
                if (XPeriodAlignment != null) hashCode = hashCode * 59 + XPeriodAlignment.GetHashCode();
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (Open != null) hashCode = hashCode * 59 + Open.GetHashCode();
                if (High != null) hashCode = hashCode * 59 + High.GetHashCode();
                if (Low != null) hashCode = hashCode * 59 + Low.GetHashCode();
                if (Close != null) hashCode = hashCode * 59 + Close.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Increasing != null) hashCode = hashCode * 59 + Increasing.GetHashCode();
                if (Decreasing != null) hashCode = hashCode * 59 + Decreasing.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (TextArray != null) hashCode = hashCode * 59 + TextArray.GetHashCode();
                if (HoverText != null) hashCode = hashCode * 59 + HoverText.GetHashCode();
                if (HoverTextArray != null) hashCode = hashCode * 59 + HoverTextArray.GetHashCode();
                if (TickWidth != null) hashCode = hashCode * 59 + TickWidth.GetHashCode();
                if (HoverLabel != null) hashCode = hashCode * 59 + HoverLabel.GetHashCode();
                if (XCalendar != null) hashCode = hashCode * 59 + XCalendar.GetHashCode();
                if (XAxis != null) hashCode = hashCode * 59 + XAxis.GetHashCode();
                if (YAxis != null) hashCode = hashCode * 59 + YAxis.GetHashCode();
                if (IdsSrc != null) hashCode = hashCode * 59 + IdsSrc.GetHashCode();
                if (CustomDataSrc != null) hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                if (HoverInfoSrc != null) hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();
                if (XSrc != null) hashCode = hashCode * 59 + XSrc.GetHashCode();
                if (OpenSrc != null) hashCode = hashCode * 59 + OpenSrc.GetHashCode();
                if (HighSrc != null) hashCode = hashCode * 59 + HighSrc.GetHashCode();
                if (LowSrc != null) hashCode = hashCode * 59 + LowSrc.GetHashCode();
                if (CloseSrc != null) hashCode = hashCode * 59 + CloseSrc.GetHashCode();
                if (TextSrc != null) hashCode = hashCode * 59 + TextSrc.GetHashCode();
                if (HoverTextSrc != null) hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Ohlc and the right Ohlc.
        /// </summary>
        /// <param name="left">Left Ohlc.</param>
        /// <param name="right">Right Ohlc.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Ohlc left, Ohlc right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Ohlc and the right Ohlc.
        /// </summary>
        /// <param name="left">Left Ohlc.</param>
        /// <param name="right">Right Ohlc.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Ohlc left, Ohlc right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Ohlc</returns>
        public Ohlc DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Ohlc) formatter.Deserialize(ms);
        }
    }
}