
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEdgeConfigBackupResponseVariant2Backup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.GetEdgeConfigBackupResponseVariant2BackupItems2> Items { get; set; }

        /// <summary>
        /// Name for the Edge Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant2Backup" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="slug">
        /// Name for the Edge Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="digest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigBackupResponseVariant2Backup(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetEdgeConfigBackupResponseVariant2BackupItems2> items,
            string slug,
            double updatedAt,
            string digest)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.UpdatedAt = updatedAt;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant2Backup" /> class.
        /// </summary>
        public GetEdgeConfigBackupResponseVariant2Backup()
        {
        }
    }
}