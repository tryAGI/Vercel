
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A version of routing rules stored in S3.
    /// </summary>
    public sealed partial class DeleteRoutesResponseVersion
    {
        /// <summary>
        /// The staging alias for previewing this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// The user who created this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// Unique identifier for the version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether this version is currently live in production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isLive")]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Whether this version is staged and not yet promoted to production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isStaging")]
        public bool? IsStaging { get; set; }

        /// <summary>
        /// Timestamp of when this version was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastModified { get; set; }

        /// <summary>
        /// The number of routing rules in this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleCount")]
        public double? RuleCount { get; set; }

        /// <summary>
        /// The S3 key where the routing rules are stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3Key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRoutesResponseVersion" /> class.
        /// </summary>
        /// <param name="createdBy">
        /// The user who created this version.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the version.
        /// </param>
        /// <param name="lastModified">
        /// Timestamp of when this version was last modified.
        /// </param>
        /// <param name="s3Key">
        /// The S3 key where the routing rules are stored.
        /// </param>
        /// <param name="alias">
        /// The staging alias for previewing this version.
        /// </param>
        /// <param name="isLive">
        /// Whether this version is currently live in production.
        /// </param>
        /// <param name="isStaging">
        /// Whether this version is staged and not yet promoted to production.
        /// </param>
        /// <param name="ruleCount">
        /// The number of routing rules in this version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteRoutesResponseVersion(
            string createdBy,
            string id,
            double lastModified,
            string s3Key,
            string? alias,
            bool? isLive,
            bool? isStaging,
            double? ruleCount)
        {
            this.Alias = alias;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsLive = isLive;
            this.IsStaging = isStaging;
            this.LastModified = lastModified;
            this.RuleCount = ruleCount;
            this.S3Key = s3Key ?? throw new global::System.ArgumentNullException(nameof(s3Key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRoutesResponseVersion" /> class.
        /// </summary>
        public DeleteRoutesResponseVersion()
        {
        }

    }
}