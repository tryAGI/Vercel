
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The protection bypass for the alias
    /// </summary>
    public sealed partial class ListAliasesResponseAliaseProtectionBypassVariant3
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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListAliasesResponseAliaseProtectionBypassVariant3ScopeJsonConverter))]
        public global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant3Scope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseProtectionBypassVariant3" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAliasesResponseAliaseProtectionBypassVariant3(
            double createdAt,
            string createdBy,
            global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant3Scope scope)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseProtectionBypassVariant3" /> class.
        /// </summary>
        public ListAliasesResponseAliaseProtectionBypassVariant3()
        {
        }
    }
}