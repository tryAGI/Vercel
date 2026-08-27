
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateStorageStoresBlobRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateStorageStoresBlobRequestRegionJsonConverter))]
        public global::Vercel.CreateStorageStoresBlobRequestRegion? Region { get; set; }

        /// <summary>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateStorageStoresBlobRequestAccessJsonConverter))]
        public global::Vercel.CreateStorageStoresBlobRequestAccess? Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <param name="access">
        /// Default Value: public
        /// </param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStorageStoresBlobRequest(
            string name,
            global::Vercel.CreateStorageStoresBlobRequestRegion? region,
            global::Vercel.CreateStorageStoresBlobRequestAccess? access,
            string? projectId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Region = region;
            this.Access = access;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobRequest" /> class.
        /// </summary>
        public CreateStorageStoresBlobRequest()
        {
        }

    }
}