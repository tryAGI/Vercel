
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthTokenScopeVariant1Sudo
    {
        /// <summary>
        /// Possible step-up auth origins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthTokenScopeVariant1SudoOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AuthTokenScopeVariant1SudoOrigin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifiedAt")]
        public double? VerifiedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenScopeVariant1Sudo" /> class.
        /// </summary>
        /// <param name="origin">
        /// Possible step-up auth origins
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="verifiedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthTokenScopeVariant1Sudo(
            global::Vercel.AuthTokenScopeVariant1SudoOrigin origin,
            double expiresAt,
            double? verifiedAt)
        {
            this.Origin = origin;
            this.VerifiedAt = verifiedAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenScopeVariant1Sudo" /> class.
        /// </summary>
        public AuthTokenScopeVariant1Sudo()
        {
        }

    }
}