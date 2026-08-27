
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectCreatorVariant2App
    {
        /// <summary>
        /// The internal ID of the Vercel App backing this principal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The protocol-facing OAuth client ID. This may differ from {@link id} when Client ID Metadata Documents (CIMD) are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectCreatorVariant2App" /> class.
        /// </summary>
        /// <param name="id">
        /// The internal ID of the Vercel App backing this principal.
        /// </param>
        /// <param name="clientId">
        /// The protocol-facing OAuth client ID. This may differ from {@link id} when Client ID Metadata Documents (CIMD) are used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectCreatorVariant2App(
            string id,
            string? clientId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ClientId = clientId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectCreatorVariant2App" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectCreatorVariant2App()
        {
        }

    }
}