
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagRequestEnvironmentsFallthroughVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagRequestEnvironmentsFallthroughVariant2Base Base { get; set; }

        /// <summary>
        /// The distribution for each variant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Weights { get; set; }

        /// <summary>
        /// This variant will be used when the base attribute does not exist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultVariantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsFallthroughVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="base"></param>
        /// <param name="weights">
        /// The distribution for each variant
        /// </param>
        /// <param name="defaultVariantId">
        /// This variant will be used when the base attribute does not exist
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagRequestEnvironmentsFallthroughVariant2(
            object type,
            global::Vercel.UpdateFlagRequestEnvironmentsFallthroughVariant2Base @base,
            global::System.Collections.Generic.Dictionary<string, double> weights,
            string defaultVariantId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Weights = weights ?? throw new global::System.ArgumentNullException(nameof(weights));
            this.DefaultVariantId = defaultVariantId ?? throw new global::System.ArgumentNullException(nameof(defaultVariantId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsFallthroughVariant2" /> class.
        /// </summary>
        public UpdateFlagRequestEnvironmentsFallthroughVariant2()
        {
        }
    }
}