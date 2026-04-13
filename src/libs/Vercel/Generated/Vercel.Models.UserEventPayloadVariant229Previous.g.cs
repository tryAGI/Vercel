
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant229Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRatePercent")]
        public double? SampleRatePercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spendLimitInDollars")]
        public double? SpendLimitInDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant229Previous" /> class.
        /// </summary>
        /// <param name="sampleRatePercent"></param>
        /// <param name="spendLimitInDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant229Previous(
            double? sampleRatePercent,
            double? spendLimitInDollars)
        {
            this.SampleRatePercent = sampleRatePercent;
            this.SpendLimitInDollars = spendLimitInDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant229Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant229Previous()
        {
        }
    }
}