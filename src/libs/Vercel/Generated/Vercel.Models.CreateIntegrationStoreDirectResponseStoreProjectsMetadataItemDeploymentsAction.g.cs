
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment> Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsAction" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsAction(
            string slug,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment> environments)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsAction" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsAction()
        {
        }
    }
}