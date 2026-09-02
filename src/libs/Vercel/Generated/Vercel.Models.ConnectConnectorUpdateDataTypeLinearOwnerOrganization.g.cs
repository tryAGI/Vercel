
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Linear organization that owns the OAuth application.
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeLinearOwnerOrganization
    {
        /// <summary>
        /// Linear organization ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Linear organization slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Linear organization name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Linear organization logo URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logoUrl")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeLinearOwnerOrganization" /> class.
        /// </summary>
        /// <param name="id">
        /// Linear organization ID.
        /// </param>
        /// <param name="slug">
        /// Linear organization slug.
        /// </param>
        /// <param name="name">
        /// Linear organization name.
        /// </param>
        /// <param name="logoUrl">
        /// Linear organization logo URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeLinearOwnerOrganization(
            string id,
            string slug,
            string name,
            string? logoUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LogoUrl = logoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeLinearOwnerOrganization" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeLinearOwnerOrganization()
        {
        }

    }
}