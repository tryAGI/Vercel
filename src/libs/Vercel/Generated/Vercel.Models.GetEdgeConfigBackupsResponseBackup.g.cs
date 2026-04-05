
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEdgeConfigBackupsResponseBackup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vercel.GetEdgeConfigBackupsResponseBackupMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastModified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupsResponseBackup" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastModified"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigBackupsResponseBackup(
            string id,
            double lastModified,
            global::Vercel.GetEdgeConfigBackupsResponseBackupMetadata? metadata)
        {
            this.Metadata = metadata;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupsResponseBackup" /> class.
        /// </summary>
        public GetEdgeConfigBackupsResponseBackup()
        {
        }
    }
}