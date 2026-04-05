
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPromoteAliasesResponseVariant2Aliase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromoteAliasesResponseVariant2Aliase" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="alias"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPromoteAliasesResponseVariant2Aliase(
            string status,
            string alias,
            string id)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromoteAliasesResponseVariant2Aliase" /> class.
        /// </summary>
        public ListPromoteAliasesResponseVariant2Aliase()
        {
        }
    }
}