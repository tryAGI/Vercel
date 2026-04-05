
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEdgeConfigBackupResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetEdgeConfigBackupResponseVariant2User User { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetEdgeConfigBackupResponseVariant2Backup Backup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetEdgeConfigBackupResponseVariant2Metadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant2" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="id"></param>
        /// <param name="lastModified"></param>
        /// <param name="backup"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigBackupResponseVariant2(
            global::Vercel.GetEdgeConfigBackupResponseVariant2User user,
            string id,
            double lastModified,
            global::Vercel.GetEdgeConfigBackupResponseVariant2Backup backup,
            global::Vercel.GetEdgeConfigBackupResponseVariant2Metadata metadata)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastModified = lastModified;
            this.Backup = backup ?? throw new global::System.ArgumentNullException(nameof(backup));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant2" /> class.
        /// </summary>
        public GetEdgeConfigBackupResponseVariant2()
        {
        }
    }
}