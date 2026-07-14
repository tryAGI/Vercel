
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStorageStoresBlobResponseStore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectsMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItem> ProjectsMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectFilter")]
        public global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilter? ProjectFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalConnectedProjects")]
        public double? TotalConnectedProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageQuotaExceeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UsageQuotaExceeded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreStatusJsonConverter))]
        public global::Vercel.CreateStorageStoresBlobResponseStoreStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreAccessJsonConverter))]
        public global::Vercel.CreateStorageStoresBlobResponseStoreAccess? Access { get; set; }

        /// <summary>
        /// A project-default store is a private blob store that is lazily created per-project, uses OIDC auth instead of read-write tokens, and cannot be modified through standard store mutation APIs. Undefined for legacy stores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreKindJsonConverter))]
        public global::Vercel.CreateStorageStoresBlobResponseStoreKind? Kind { get; set; }

        /// <summary>
        /// The project this store is scoped to. Set for project-default stores and user-created stores with enforced project association.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateStorageStoresBlobResponseStoreRegion Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTokenExpired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTokenExpired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobResponseStore" /> class.
        /// </summary>
        /// <param name="projectsMetadata"></param>
        /// <param name="usageQuotaExceeded"></param>
        /// <param name="size"></param>
        /// <param name="count"></param>
        /// <param name="region"></param>
        /// <param name="isTokenExpired"></param>
        /// <param name="projectFilter"></param>
        /// <param name="totalConnectedProjects"></param>
        /// <param name="status"></param>
        /// <param name="access"></param>
        /// <param name="kind">
        /// A project-default store is a private blob store that is lazily created per-project, uses OIDC auth instead of read-write tokens, and cannot be modified through standard store mutation APIs. Undefined for legacy stores.
        /// </param>
        /// <param name="projectId">
        /// The project this store is scoped to. Set for project-default stores and user-created stores with enforced project association.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStorageStoresBlobResponseStore(
            global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItem> projectsMetadata,
            bool usageQuotaExceeded,
            double size,
            double count,
            global::Vercel.CreateStorageStoresBlobResponseStoreRegion region,
            bool isTokenExpired,
            global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilter? projectFilter,
            double? totalConnectedProjects,
            global::Vercel.CreateStorageStoresBlobResponseStoreStatus? status,
            global::Vercel.CreateStorageStoresBlobResponseStoreAccess? access,
            global::Vercel.CreateStorageStoresBlobResponseStoreKind? kind,
            string? projectId)
        {
            this.ProjectsMetadata = projectsMetadata ?? throw new global::System.ArgumentNullException(nameof(projectsMetadata));
            this.ProjectFilter = projectFilter;
            this.TotalConnectedProjects = totalConnectedProjects;
            this.UsageQuotaExceeded = usageQuotaExceeded;
            this.Status = status;
            this.Access = access;
            this.Kind = kind;
            this.ProjectId = projectId;
            this.Size = size;
            this.Count = count;
            this.Region = region;
            this.IsTokenExpired = isTokenExpired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobResponseStore" /> class.
        /// </summary>
        public CreateStorageStoresBlobResponseStore()
        {
        }

    }
}