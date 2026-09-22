
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
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectTraceResponseTraceSpanEvent> Events { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectTraceResponseTraceSpanLibrary Library { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentSpanId")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectTraceResponseTraceSpanStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceFlags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TraceFlags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceState")]
        public string? TraceState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTraceResponseTraceSpan" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="duration"></param>
        /// <param name="endTime"></param>
        /// <param name="events"></param>
        /// <param name="kind"></param>
        /// <param name="library"></param>
        /// <param name="links"></param>
        /// <param name="name"></param>
        /// <param name="resource"></param>
        /// <param name="spanId"></param>
        /// <param name="startTime"></param>
        /// <param name="status"></param>
        /// <param name="traceFlags"></param>
        /// <param name="parentSpanId"></param>
        /// <param name="traceState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectTraceResponseTraceSpan(
            object attributes,
            global::System.Collections.Generic.IList<double> duration,
            global::System.Collections.Generic.IList<double> endTime,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectTraceResponseTraceSpanEvent> events,
            double kind,
            global::Vercel.GetProjectTraceResponseTraceSpanLibrary library,
            global::System.Collections.Generic.IList<object> links,
            string name,
            string resource,
            string spanId,
            global::System.Collections.Generic.IList<double> startTime,
            global::Vercel.GetProjectTraceResponseTraceSpanStatus status,
            double traceFlags,
            string? parentSpanId,
            string? traceState)
        {
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Kind = kind;
            this.Library = library ?? throw new global::System.ArgumentNullException(nameof(library));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentSpanId = parentSpanId;
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TraceFlags = traceFlags;
            this.TraceState = traceState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTraceResponseTraceSpan" /> class.
        /// </summary>
        public GetProjectTraceResponseTraceSpan()
        {
        }

    }
}