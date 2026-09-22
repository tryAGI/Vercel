
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd9e46425f35715a0OutcomeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant2Base Base { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultVariantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd9e46425f35715a0OutcomeVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Weights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0OutcomeVariant2" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="defaultVariantId"></param>
        /// <param name="weights"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd9e46425f35715a0OutcomeVariant2(
            global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant2Base @base,
            string defaultVariantId,
            global::System.Collections.Generic.Dictionary<string, double> weights,
            global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant2Type type)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.DefaultVariantId = defaultVariantId ?? throw new global::System.ArgumentNullException(nameof(defaultVariantId));
            this.Type = type;
            this.Weights = weights ?? throw new global::System.ArgumentNullException(nameof(weights));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0OutcomeVariant2" /> class.
        /// </summary>
        public AutoSDKSharedd9e46425f35715a0OutcomeVariant2()
        {
        }

    }
}