
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagRequestEnvironmentsRuleOutcomeVariant3Slot
    {
        /// <summary>
        /// Promille of traffic for rollToVariant (0-100_000, where 1_000 = 1%)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promille")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Promille { get; set; }

        /// <summary>
        /// How long this promille is served in ms before moving to the next slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsRuleOutcomeVariant3Slot" /> class.
        /// </summary>
        /// <param name="promille">
        /// Promille of traffic for rollToVariant (0-100_000, where 1_000 = 1%)
        /// </param>
        /// <param name="durationMs">
        /// How long this promille is served in ms before moving to the next slot.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagRequestEnvironmentsRuleOutcomeVariant3Slot(
            double promille,
            double durationMs)
        {
            this.Promille = promille;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsRuleOutcomeVariant3Slot" /> class.
        /// </summary>
        public UpdateFlagRequestEnvironmentsRuleOutcomeVariant3Slot()
        {
        }
    }
}