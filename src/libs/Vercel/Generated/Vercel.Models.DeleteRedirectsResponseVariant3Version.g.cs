
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteRedirectsResponseVariant3Version
    {
        /// <summary>
        /// The staging link for previewing redirects in this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// The unique identifier for the version.
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
        /// Whether this version has not been promoted to production yet and is not serving end users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isStaging")]
        public bool? IsStaging { get; set; }

        /// <summary>
        /// The key of the version. The key may be duplicated across versions if the contents are the same as a different version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastModified { get; set; }

        /// <summary>
        /// Optional name for the version. If not provided, defaults to an ISO timestamp string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The number of redirects in this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectCount")]
        public double? RedirectCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRedirectsResponseVariant3Version" /> class.
        /// </summary>
        /// <param name="createdBy"></param>
        /// <param name="id">
        /// The unique identifier for the version.
        /// </param>
        /// <param name="key">
        /// The key of the version. The key may be duplicated across versions if the contents are the same as a different version.
        /// </param>
        /// <param name="lastModified"></param>
        /// <param name="alias">
        /// The staging link for previewing redirects in this version.
        /// </param>
        /// <param name="isLive">
        /// Whether this version is currently live in production.
        /// </param>
        /// <param name="isStaging">
        /// Whether this version has not been promoted to production yet and is not serving end users.
        /// </param>
        /// <param name="name">
        /// Optional name for the version. If not provided, defaults to an ISO timestamp string.
        /// </param>
        /// <param name="redirectCount">
        /// The number of redirects in this version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteRedirectsResponseVariant3Version(
            string createdBy,
            string id,
            string key,
            double lastModified,
            string? alias,
            bool? isLive,
            bool? isStaging,
            string? name,
            double? redirectCount)
        {
            this.Alias = alias;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsLive = isLive;
            this.IsStaging = isStaging;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.LastModified = lastModified;
            this.Name = name;
            this.RedirectCount = redirectCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRedirectsResponseVariant3Version" /> class.
        /// </summary>
        public DeleteRedirectsResponseVariant3Version()
        {
        }

    }
}