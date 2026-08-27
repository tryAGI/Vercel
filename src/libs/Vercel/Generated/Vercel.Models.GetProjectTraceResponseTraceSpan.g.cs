
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectTraceResponseTraceSpan
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectTraceResponseTraceSpanLibrary Library { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentSpanId")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectTraceResponseTraceSpanStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceState")]
        public string? TraceState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceFlags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TraceFlags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectTraceResponseTraceSpanEvent> Events { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTraceResponseTraceSpan" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="resource"></param>
        /// <param name="library"></param>
        /// <param name="spanId"></param>
        /// <param name="status"></param>
        /// <param name="traceFlags"></param>
        /// <param name="attributes"></param>
        /// <param name="links"></param>
        /// <param name="events"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="duration"></param>
        /// <param name="parentSpanId"></param>
        /// <param name="traceState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectTraceResponseTraceSpan(
            string name,
            double kind,
            string resource,
            global::Vercel.GetProjectTraceResponseTraceSpanLibrary library,
            string spanId,
            global::Vercel.GetProjectTraceResponseTraceSpanStatus status,
            double traceFlags,
            object attributes,
            global::System.Collections.Generic.IList<object> links,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectTraceResponseTraceSpanEvent> events,
            global::System.Collections.Generic.IList<double> startTime,
            global::System.Collections.Generic.IList<double> endTime,
            global::System.Collections.Generic.IList<double> duration,
            string? parentSpanId,
            string? traceState)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.Library = library ?? throw new global::System.ArgumentNullException(nameof(library));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.ParentSpanId = parentSpanId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TraceState = traceState;
            this.TraceFlags = traceFlags;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTraceResponseTraceSpan" /> class.
        /// </summary>
        public GetProjectTraceResponseTraceSpan()
        {
        }

    }
}