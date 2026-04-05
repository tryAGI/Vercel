
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The protection bypass for the alias
    /// </summary>
    public sealed partial class GetAliasResponseProtectionBypassVariant2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAliasResponseProtectionBypassVariant2AccessJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetAliasResponseProtectionBypassVariant2Access Access { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAliasResponseProtectionBypassVariant2ScopeJsonConverter))]
        public global::Vercel.GetAliasResponseProtectionBypassVariant2Scope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponseProtectionBypassVariant2" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="lastUpdatedBy"></param>
        /// <param name="access"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAliasResponseProtectionBypassVariant2(
            double createdAt,
            double lastUpdatedAt,
            string lastUpdatedBy,
            global::Vercel.GetAliasResponseProtectionBypassVariant2Access access,
            global::Vercel.GetAliasResponseProtectionBypassVariant2Scope scope)
        {
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy ?? throw new global::System.ArgumentNullException(nameof(lastUpdatedBy));
            this.Access = access;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponseProtectionBypassVariant2" /> class.
        /// </summary>
        public GetAliasResponseProtectionBypassVariant2()
        {
        }
    }
}