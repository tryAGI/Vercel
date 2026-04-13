
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant143PrevProjectAnalytics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public double? CanceledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DisabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EnabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paidAt")]
        public double? PaidAt { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant143PrevProjectAnalytics" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="disabledAt"></param>
        /// <param name="enabledAt"></param>
        /// <param name="canceledAt"></param>
        /// <param name="paidAt"></param>
        /// <param name="sampleRatePercent"></param>
        /// <param name="spendLimitInDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant143PrevProjectAnalytics(
            string id,
            double disabledAt,
            double enabledAt,
            double? canceledAt,
            double? paidAt,
            double? sampleRatePercent,
            double? spendLimitInDollars)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CanceledAt = canceledAt;
            this.DisabledAt = disabledAt;
            this.EnabledAt = enabledAt;
            this.PaidAt = paidAt;
            this.SampleRatePercent = sampleRatePercent;
            this.SpendLimitInDollars = spendLimitInDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant143PrevProjectAnalytics" /> class.
        /// </summary>
        public UserEventPayloadVariant143PrevProjectAnalytics()
        {
        }
    }
}