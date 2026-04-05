
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TooManyRequestsLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Remaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Reset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequestsLimit" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="remaining"></param>
        /// <param name="reset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TooManyRequestsLimit(
            double total,
            double remaining,
            double reset)
        {
            this.Total = total;
            this.Remaining = remaining;
            this.Reset = reset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequestsLimit" /> class.
        /// </summary>
        public TooManyRequestsLimit()
        {
        }
    }
}