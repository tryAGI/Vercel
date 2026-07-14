
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStorageStoresByIdResponseStore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectsMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItem> ProjectsMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectFilter")]
        public global::Vercel.GetStorageStoresByIdResponseStoreProjectFilter? ProjectFilter { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreStatusJsonConverter))]
        public global::Vercel.GetStorageStoresByIdResponseStoreStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageStoresByIdResponseStore" /> class.
        /// </summary>
        /// <param name="projectsMetadata"></param>
        /// <param name="usageQuotaExceeded"></param>
        /// <param name="projectFilter"></param>
        /// <param name="totalConnectedProjects"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStorageStoresByIdResponseStore(
            global::System.Collections.Generic.IList<global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItem> projectsMetadata,
            bool usageQuotaExceeded,
            global::Vercel.GetStorageStoresByIdResponseStoreProjectFilter? projectFilter,
            double? totalConnectedProjects,
            global::Vercel.GetStorageStoresByIdResponseStoreStatus? status)
        {
            this.ProjectsMetadata = projectsMetadata ?? throw new global::System.ArgumentNullException(nameof(projectsMetadata));
            this.ProjectFilter = projectFilter;
            this.TotalConnectedProjects = totalConnectedProjects;
            this.UsageQuotaExceeded = usageQuotaExceeded;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageStoresByIdResponseStore" /> class.
        /// </summary>
        public GetStorageStoresByIdResponseStore()
        {
        }

    }
}