
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRuntimeLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRuntimeLogsResponseLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRuntimeLogsResponseLevel Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRuntimeLogsResponseSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRuntimeLogsResponseSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampInMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimestampInMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageTruncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MessageTruncated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestMethod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseStatusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRuntimeLogsResponse" /> class.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="rowId"></param>
        /// <param name="source"></param>
        /// <param name="timestampInMs"></param>
        /// <param name="domain"></param>
        /// <param name="messageTruncated"></param>
        /// <param name="requestMethod"></param>
        /// <param name="requestPath"></param>
        /// <param name="responseStatusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRuntimeLogsResponse(
            global::Vercel.GetRuntimeLogsResponseLevel level,
            string message,
            string rowId,
            global::Vercel.GetRuntimeLogsResponseSource source,
            double timestampInMs,
            string domain,
            bool messageTruncated,
            string requestMethod,
            string requestPath,
            double responseStatusCode)
        {
            this.Level = level;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RowId = rowId ?? throw new global::System.ArgumentNullException(nameof(rowId));
            this.Source = source;
            this.TimestampInMs = timestampInMs;
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.MessageTruncated = messageTruncated;
            this.RequestMethod = requestMethod ?? throw new global::System.ArgumentNullException(nameof(requestMethod));
            this.RequestPath = requestPath ?? throw new global::System.ArgumentNullException(nameof(requestPath));
            this.ResponseStatusCode = responseStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRuntimeLogsResponse" /> class.
        /// </summary>
        public GetRuntimeLogsResponse()
        {
        }
    }
}