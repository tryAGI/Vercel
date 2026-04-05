
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitNamespacesResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, double?> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAccessRestricted")]
        public bool? IsAccessRestricted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        public double? InstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireReauth")]
        public bool? RequireReauth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitNamespacesResponseItem" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="slug"></param>
        /// <param name="id"></param>
        /// <param name="ownerType"></param>
        /// <param name="name"></param>
        /// <param name="isAccessRestricted"></param>
        /// <param name="installationId"></param>
        /// <param name="requireReauth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitNamespacesResponseItem(
            string provider,
            string slug,
            global::Vercel.OneOf<string, double?> id,
            string ownerType,
            string? name,
            bool? isAccessRestricted,
            double? installationId,
            bool? requireReauth)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Id = id;
            this.OwnerType = ownerType ?? throw new global::System.ArgumentNullException(nameof(ownerType));
            this.Name = name;
            this.IsAccessRestricted = isAccessRestricted;
            this.InstallationId = installationId;
            this.RequireReauth = requireReauth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitNamespacesResponseItem" /> class.
        /// </summary>
        public GitNamespacesResponseItem()
        {
        }
    }
}