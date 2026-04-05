
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VercelRateLimitErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public global::Vercel.RateLimitNotice? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VercelRateLimitErrorError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VercelRateLimitErrorError(
            string code,
            global::Vercel.RateLimitNotice? limit)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VercelRateLimitErrorError" /> class.
        /// </summary>
        public VercelRateLimitErrorError()
        {
        }
    }
}