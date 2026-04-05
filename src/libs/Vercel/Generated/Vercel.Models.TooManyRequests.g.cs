
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TooManyRequests
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TooManyRequestsCodeJsonConverter))]
        public global::Vercel.TooManyRequestsCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryAfter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TooManyRequestsRetryAfter RetryAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TooManyRequestsLimit Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequests" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="retryAfter"></param>
        /// <param name="limit"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TooManyRequests(
            double status,
            string message,
            global::Vercel.TooManyRequestsRetryAfter retryAfter,
            global::Vercel.TooManyRequestsLimit limit,
            global::Vercel.TooManyRequestsCode code)
        {
            this.Status = status;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RetryAfter = retryAfter ?? throw new global::System.ArgumentNullException(nameof(retryAfter));
            this.Limit = limit ?? throw new global::System.ArgumentNullException(nameof(limit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequests" /> class.
        /// </summary>
        public TooManyRequests()
        {
        }
    }
}