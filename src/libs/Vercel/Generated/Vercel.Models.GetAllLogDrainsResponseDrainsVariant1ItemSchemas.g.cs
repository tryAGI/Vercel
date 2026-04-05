
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponseDrainsVariant1ItemSchemas
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        public object? Log { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public object? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analytics")]
        public object? Analytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_insights")]
        public object? SpeedInsights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_gateway")]
        public object? AiGateway { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant1ItemSchemas" /> class.
        /// </summary>
        /// <param name="log"></param>
        /// <param name="trace"></param>
        /// <param name="analytics"></param>
        /// <param name="speedInsights"></param>
        /// <param name="aiGateway"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponseDrainsVariant1ItemSchemas(
            object? log,
            object? trace,
            object? analytics,
            object? speedInsights,
            object? aiGateway)
        {
            this.Log = log;
            this.Trace = trace;
            this.Analytics = analytics;
            this.SpeedInsights = speedInsights;
            this.AiGateway = aiGateway;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant1ItemSchemas" /> class.
        /// </summary>
        public GetAllLogDrainsResponseDrainsVariant1ItemSchemas()
        {
        }
    }
}