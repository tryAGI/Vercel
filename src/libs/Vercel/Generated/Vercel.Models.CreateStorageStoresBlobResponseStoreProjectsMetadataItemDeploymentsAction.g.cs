
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction" /> class.
        /// </summary>
        /// <param name="environments"></param>
        /// <param name="slug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction(
            global::System.Collections.Generic.IList<string> environments,
            string slug)
        {
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction" /> class.
        /// </summary>
        public CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction()
        {
        }

    }
}