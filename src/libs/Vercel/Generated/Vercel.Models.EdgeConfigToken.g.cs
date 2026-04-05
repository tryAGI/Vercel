
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The EdgeConfig.
    /// </summary>
    public sealed partial class EdgeConfigToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// This is not the token itself, but rather an id to identify the token by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeConfigId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeConfigToken" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="label"></param>
        /// <param name="id">
        /// This is not the token itself, but rather an id to identify the token by
        /// </param>
        /// <param name="edgeConfigId"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EdgeConfigToken(
            string token,
            string label,
            string id,
            string edgeConfigId,
            double createdAt)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EdgeConfigId = edgeConfigId ?? throw new global::System.ArgumentNullException(nameof(edgeConfigId));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeConfigToken" /> class.
        /// </summary>
        public EdgeConfigToken()
        {
        }
    }
}