
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd9e46425f35715a0OutcomeVariant3Slot
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promille")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Promille { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0OutcomeVariant3Slot" /> class.
        /// </summary>
        /// <param name="durationMs"></param>
        /// <param name="promille"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd9e46425f35715a0OutcomeVariant3Slot(
            double durationMs,
            double promille)
        {
            this.DurationMs = durationMs;
            this.Promille = promille;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0OutcomeVariant3Slot" /> class.
        /// </summary>
        public AutoSDKSharedd9e46425f35715a0OutcomeVariant3Slot()
        {
        }

    }
}