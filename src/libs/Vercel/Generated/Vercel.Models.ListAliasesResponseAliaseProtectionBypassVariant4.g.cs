
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The protection bypass for the alias
    /// </summary>
    public sealed partial class ListAliasesResponseAliaseProtectionBypassVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastUpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListAliasesResponseAliaseProtectionBypassVariant4ScopeJsonConverter))]
        public global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant4Scope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseProtectionBypassVariant4" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="lastUpdatedBy"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAliasesResponseAliaseProtectionBypassVariant4(
            double createdAt,
            double lastUpdatedAt,
            string lastUpdatedBy,
            global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant4Scope scope)
        {
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy ?? throw new global::System.ArgumentNullException(nameof(lastUpdatedBy));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseProtectionBypassVariant4" /> class.
        /// </summary>
        public ListAliasesResponseAliaseProtectionBypassVariant4()
        {
        }
    }
}