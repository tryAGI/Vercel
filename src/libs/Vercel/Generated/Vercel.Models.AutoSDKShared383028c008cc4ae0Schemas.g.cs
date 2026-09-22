
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared383028c008cc4ae0Schemas
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_gateway")]
        public object? AiGateway { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analytics")]
        public object? Analytics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audit_log")]
        public object? AuditLog { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connect")]
        public object? Connect { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        public object? Log { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_insights")]
        public object? SpeedInsights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public object? Trace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared383028c008cc4ae0Schemas" /> class.
        /// </summary>
        /// <param name="aiGateway"></param>
        /// <param name="analytics"></param>
        /// <param name="auditLog"></param>
        /// <param name="connect"></param>
        /// <param name="log"></param>
        /// <param name="speedInsights"></param>
        /// <param name="trace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared383028c008cc4ae0Schemas(
            object? aiGateway,
            object? analytics,
            object? auditLog,
            object? connect,
            object? log,
            object? speedInsights,
            object? trace)
        {
            this.AiGateway = aiGateway;
            this.Analytics = analytics;
            this.AuditLog = auditLog;
            this.Connect = connect;
            this.Log = log;
            this.SpeedInsights = speedInsights;
            this.Trace = trace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared383028c008cc4ae0Schemas" /> class.
        /// </summary>
        public AutoSDKShared383028c008cc4ae0Schemas()
        {
        }

    }
}