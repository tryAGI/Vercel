
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeployments
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeployments" /> class.
        /// </summary>
        /// <param name="required"></param>
        /// <param name="actions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeployments(
            bool required,
            global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction> actions)
        {
            this.Required = required;
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeployments" /> class.
        /// </summary>
        public CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeployments()
        {
        }

    }
}