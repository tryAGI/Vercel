
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitNotice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Remaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Reset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResetMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitNotice" /> class.
        /// </summary>
        /// <param name="remaining"></param>
        /// <param name="reset"></param>
        /// <param name="resetMs"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitNotice(
            int remaining,
            int reset,
            int resetMs,
            int total)
        {
            this.Remaining = remaining;
            this.Reset = reset;
            this.ResetMs = resetMs;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitNotice" /> class.
        /// </summary>
        public RateLimitNotice()
        {
        }
    }
}