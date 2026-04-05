
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagRequestEnvironmentsPausedOutcome
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
        [global::System.Text.Json.Serialization.JsonPropertyName("variantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironmentsPausedOutcome" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="variantId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagRequestEnvironmentsPausedOutcome(
            object type,
            string variantId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.VariantId = variantId ?? throw new global::System.ArgumentNullException(nameof(variantId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironmentsPausedOutcome" /> class.
        /// </summary>
        public CreateFlagRequestEnvironmentsPausedOutcome()
        {
        }
    }
}