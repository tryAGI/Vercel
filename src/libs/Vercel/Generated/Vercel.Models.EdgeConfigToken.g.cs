
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The EdgeConfig.
    /// </summary>
    public sealed partial class EdgeConfigToken
    {
        /// <summary>
        /// A partially-masked representation of the token, safe to display in UIs. The format is the first 4 characters of the token followed by a fixed 8-character `*` mask (e.g. `550e8400-e29b-41d4-a716-446655440000` → `550e********`). The mask length is intentionally fixed (not proportional to the original token length) to avoid leaking the token length. Prefer this field for display/reference in UIs and logs. The full, plaintext token is only disclosed once at creation time via `POST /v1/edge-config/:edgeConfigId/token`; use `id` to reference a token in subsequent calls (e.g. when deleting).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partialToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialToken { get; set; }

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
        /// Deprecated: the full, plaintext token. - Returned once by `POST /v1/edge-config/:edgeConfigId/token` (create). - Still returned by `GET /v1/edge-config/:edgeConfigId/token/:token` (detail) for backwards compatibility, but scheduled for removal. - **Not** returned by `GET /v1/edge-config/:edgeConfigId/tokens` (list); use `partialToken` for display and `id` to reference tokens. Do not rely on this field being present on read operations. Prefer `partialToken` for display and `id` for references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeConfigToken" /> class.
        /// </summary>
        /// <param name="partialToken">
        /// A partially-masked representation of the token, safe to display in UIs. The format is the first 4 characters of the token followed by a fixed 8-character `*` mask (e.g. `550e8400-e29b-41d4-a716-446655440000` → `550e********`). The mask length is intentionally fixed (not proportional to the original token length) to avoid leaking the token length. Prefer this field for display/reference in UIs and logs. The full, plaintext token is only disclosed once at creation time via `POST /v1/edge-config/:edgeConfigId/token`; use `id` to reference a token in subsequent calls (e.g. when deleting).
        /// </param>
        /// <param name="label"></param>
        /// <param name="id">
        /// This is not the token itself, but rather an id to identify the token by
        /// </param>
        /// <param name="edgeConfigId"></param>
        /// <param name="createdAt"></param>
        /// <param name="token">
        /// Deprecated: the full, plaintext token. - Returned once by `POST /v1/edge-config/:edgeConfigId/token` (create). - Still returned by `GET /v1/edge-config/:edgeConfigId/token/:token` (detail) for backwards compatibility, but scheduled for removal. - **Not** returned by `GET /v1/edge-config/:edgeConfigId/tokens` (list); use `partialToken` for display and `id` to reference tokens. Do not rely on this field being present on read operations. Prefer `partialToken` for display and `id` for references.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EdgeConfigToken(
            string partialToken,
            string label,
            string id,
            string edgeConfigId,
            double createdAt,
            string? token)
        {
            this.PartialToken = partialToken ?? throw new global::System.ArgumentNullException(nameof(partialToken));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EdgeConfigId = edgeConfigId ?? throw new global::System.ArgumentNullException(nameof(edgeConfigId));
            this.CreatedAt = createdAt;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeConfigToken" /> class.
        /// </summary>
        public EdgeConfigToken()
        {
        }
    }
}