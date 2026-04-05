
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The object the API responds with when requesting an Edge Config backup
    /// </summary>
    public sealed partial class GetEdgeConfigBackupResponseVariant1
    {
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
        public required global::Vercel.GetEdgeConfigBackupResponseVariant1Backup Backup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetEdgeConfigBackupResponseVariant1Metadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Vercel.GetEdgeConfigBackupResponseVariant1User? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastModified"></param>
        /// <param name="backup"></param>
        /// <param name="metadata"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigBackupResponseVariant1(
            string id,
            double lastModified,
            global::Vercel.GetEdgeConfigBackupResponseVariant1Backup backup,
            global::Vercel.GetEdgeConfigBackupResponseVariant1Metadata metadata,
            global::Vercel.GetEdgeConfigBackupResponseVariant1User? user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastModified = lastModified;
            this.Backup = backup ?? throw new global::System.ArgumentNullException(nameof(backup));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant1" /> class.
        /// </summary>
        public GetEdgeConfigBackupResponseVariant1()
        {
        }
    }
}