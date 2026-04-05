
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum" /> class.
        /// </summary>
        /// <param name="expr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum(
            string expr)
        {
            this.Expr = expr ?? throw new global::System.ArgumentNullException(nameof(expr));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant8UiOptionVariant3DisabledEnum()
        {
        }
    }
}