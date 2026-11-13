
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListPromoteAliasesResponseVariant2Aliase
    {
        /// <summary>
        /// The alias hostname.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// The alias ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the alias has been mapped to the deployment targeted by the last request. `pending` is also returned when the project has no request of the requested type, so it does not by itself indicate a running job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListPromoteAliasesResponseVariant2AliaseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListPromoteAliasesResponseVariant2AliaseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromoteAliasesResponseVariant2Aliase" /> class.
        /// </summary>
        /// <param name="alias">
        /// The alias hostname.
        /// </param>
        /// <param name="id">
        /// The alias ID.
        /// </param>
        /// <param name="status">
        /// Whether the alias has been mapped to the deployment targeted by the last request. `pending` is also returned when the project has no request of the requested type, so it does not by itself indicate a running job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPromoteAliasesResponseVariant2Aliase(
            string alias,
            string id,
            global::Vercel.ListPromoteAliasesResponseVariant2AliaseStatus status)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromoteAliasesResponseVariant2Aliase" /> class.
        /// </summary>
        public ListPromoteAliasesResponseVariant2Aliase()
        {
        }

    }
}