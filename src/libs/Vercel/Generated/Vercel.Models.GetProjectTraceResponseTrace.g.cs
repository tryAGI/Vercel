
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectTraceResponseTrace
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectTraceResponseTraceResource>? Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectTraceResponseTraceSpan> Spans { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootSpanId")]
        public string? RootSpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTraceResponseTrace" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="spans"></param>
        /// <param name="resources"></param>
        /// <param name="rootSpanId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectTraceResponseTrace(
            string traceId,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectTraceResponseTraceSpan> spans,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectTraceResponseTraceResource>? resources,
            string? rootSpanId)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.Resources = resources;
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
            this.RootSpanId = rootSpanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTraceResponseTrace" /> class.
        /// </summary>
        public GetProjectTraceResponseTrace()
        {
        }

    }
}