
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared2394a93f745adbf6FallthroughVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant2Base Base { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2394a93f745adbf6FallthroughVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant2Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared2394a93f745adbf6FallthroughVariant2" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="defaultVariantId"></param>
        /// <param name="weights"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2394a93f745adbf6FallthroughVariant2(
            global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant2Base @base,
            string defaultVariantId,
            global::System.Collections.Generic.Dictionary<string, double> weights,
            global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant2Type type)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.DefaultVariantId = defaultVariantId ?? throw new global::System.ArgumentNullException(nameof(defaultVariantId));
            this.Type = type;
            this.Weights = weights ?? throw new global::System.ArgumentNullException(nameof(weights));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2394a93f745adbf6FallthroughVariant2" /> class.
        /// </summary>
        public AutoSDKShared2394a93f745adbf6FallthroughVariant2()
        {
        }

    }
}