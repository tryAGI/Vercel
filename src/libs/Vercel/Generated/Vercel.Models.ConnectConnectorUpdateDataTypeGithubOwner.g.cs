
#nullable enable

namespace Vercel
{
    /// <summary>
    /// GitHub App owner.
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeGithubOwner
    {
        /// <summary>
        /// GitHub App owner type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorUpdateDataTypeGithubOwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectConnectorUpdateDataTypeGithubOwnerType Type { get; set; }

        /// <summary>
        /// GitHub App owner numeric ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// GitHub App owner login.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// GitHub App owner display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeGithubOwner" /> class.
        /// </summary>
        /// <param name="type">
        /// GitHub App owner type.
        /// </param>
        /// <param name="id">
        /// GitHub App owner numeric ID.
        /// </param>
        /// <param name="slug">
        /// GitHub App owner login.
        /// </param>
        /// <param name="name">
        /// GitHub App owner display name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeGithubOwner(
            global::Vercel.ConnectConnectorUpdateDataTypeGithubOwnerType type,
            int id,
            string slug,
            string? name)
        {
            this.Type = type;
            this.Id = id;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeGithubOwner" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeGithubOwner()
        {
        }

    }
}