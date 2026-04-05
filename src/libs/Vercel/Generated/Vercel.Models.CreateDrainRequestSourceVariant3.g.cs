
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainRequestSourceVariant3
    {
        /// <summary>
        /// Default Value: integration
        /// </summary>
        /// <default>"integration"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; } = "integration";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestSourceVariant3" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: integration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainRequestSourceVariant3(
            string kind)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestSourceVariant3" /> class.
        /// </summary>
        public CreateDrainRequestSourceVariant3()
        {
        }
    }
}