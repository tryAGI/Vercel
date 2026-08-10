
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrCreateDriveRequest
    {
        /// <summary>
        /// The project ID or name to associate the drive with. Required unless using a Vercel OIDC token scoped to a project.<br/>
        /// Example: prj_abc123
        /// </summary>
        /// <example>prj_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Maximum drive size in bytes. Defaults to 100 GiB when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSizeBytes")]
        public int? MaxSizeBytes { get; set; }

        /// <summary>
        /// Region where the drive is stored. Defaults to iad1.<br/>
        /// Default Value: iad1<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrCreateDriveRequestRegionJsonConverter))]
        public global::Vercel.GetOrCreateDriveRequestRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateDriveRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The project ID or name to associate the drive with. Required unless using a Vercel OIDC token scoped to a project.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="maxSizeBytes">
        /// Maximum drive size in bytes. Defaults to 100 GiB when omitted.
        /// </param>
        /// <param name="region">
        /// Region where the drive is stored. Defaults to iad1.<br/>
        /// Default Value: iad1<br/>
        /// Example: iad1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrCreateDriveRequest(
            string? projectId,
            int? maxSizeBytes,
            global::Vercel.GetOrCreateDriveRequestRegion? region)
        {
            this.ProjectId = projectId;
            this.MaxSizeBytes = maxSizeBytes;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateDriveRequest" /> class.
        /// </summary>
        public GetOrCreateDriveRequest()
        {
        }

    }
}