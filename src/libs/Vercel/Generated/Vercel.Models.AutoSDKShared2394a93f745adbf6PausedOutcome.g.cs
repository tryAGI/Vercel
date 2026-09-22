
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared2394a93f745adbf6PausedOutcome
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2394a93f745adbf6PausedOutcomeTypeJsonConverter))]
        public global::Vercel.AutoSDKShared2394a93f745adbf6PausedOutcomeType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2394a93f745adbf6PausedOutcome" /> class.
        /// </summary>
        /// <param name="variantId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2394a93f745adbf6PausedOutcome(
            string variantId,
            global::Vercel.AutoSDKShared2394a93f745adbf6PausedOutcomeType type)
        {
            this.Type = type;
            this.VariantId = variantId ?? throw new global::System.ArgumentNullException(nameof(variantId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2394a93f745adbf6PausedOutcome" /> class.
        /// </summary>
        public AutoSDKShared2394a93f745adbf6PausedOutcome()
        {
        }

    }
}