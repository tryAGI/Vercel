
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectUsageStatus
    {
        /// <summary>
        /// Billing mode. Always 'flat' for flat-rate projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectUsageStatusKindJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectUsageStatusKind Kind { get; set; }

        /// <summary>
        /// Timestamp until which the project has exceeded its CDN allowance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exceededAllowanceUntil")]
        public double? ExceededAllowanceUntil { get; set; }

        /// <summary>
        /// Timestamp until which throttling is bypassed (project pays list rates for overage).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypassThrottleUntil")]
        public double? BypassThrottleUntil { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectUsageStatus" /> class.
        /// </summary>
        /// <param name="kind">
        /// Billing mode. Always 'flat' for flat-rate projects.
        /// </param>
        /// <param name="exceededAllowanceUntil">
        /// Timestamp until which the project has exceeded its CDN allowance.
        /// </param>
        /// <param name="bypassThrottleUntil">
        /// Timestamp until which throttling is bypassed (project pays list rates for overage).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectUsageStatus(
            global::Vercel.GetProjectsResponseVariant3ProjectUsageStatusKind kind,
            double? exceededAllowanceUntil,
            double? bypassThrottleUntil)
        {
            this.Kind = kind;
            this.ExceededAllowanceUntil = exceededAllowanceUntil;
            this.BypassThrottleUntil = bypassThrottleUntil;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectUsageStatus" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectUsageStatus()
        {
        }
    }
}