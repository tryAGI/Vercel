
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The access scopes granted to the token.
    /// </summary>
    public sealed partial class AuthTokenScopeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthTokenScopeVariant1TypeJsonConverter))]
        public global::Vercel.AuthTokenScopeVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sudo")]
        public global::Vercel.AuthTokenScopeVariant1Sudo? Sudo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthTokenScopeVariant1OriginJsonConverter))]
        public global::Vercel.AuthTokenScopeVariant1Origin? Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenScopeVariant1" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="type"></param>
        /// <param name="sudo"></param>
        /// <param name="origin"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthTokenScopeVariant1(
            double createdAt,
            global::Vercel.AuthTokenScopeVariant1Type type,
            global::Vercel.AuthTokenScopeVariant1Sudo? sudo,
            global::Vercel.AuthTokenScopeVariant1Origin? origin,
            double? expiresAt)
        {
            this.Type = type;
            this.Sudo = sudo;
            this.Origin = origin;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenScopeVariant1" /> class.
        /// </summary>
        public AuthTokenScopeVariant1()
        {
        }
    }
}