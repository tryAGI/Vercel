
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Allow-list of extra claims to propagate, keyed by source (idToken). Only claims named here and present in that source are exposed.
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeOauthForwardedClaims
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idToken")]
        public global::System.Collections.Generic.IList<string>? IdToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthForwardedClaims" /> class.
        /// </summary>
        /// <param name="idToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeOauthForwardedClaims(
            global::System.Collections.Generic.IList<string>? idToken)
        {
            this.IdToken = idToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthForwardedClaims" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeOauthForwardedClaims()
        {
        }

    }
}