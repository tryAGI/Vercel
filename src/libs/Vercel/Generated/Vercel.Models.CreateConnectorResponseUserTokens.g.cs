
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorResponseUserTokens
    {
        /// <summary>
        /// Whether one user token can be used across installations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossInstallation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CrossInstallation { get; set; }

        /// <summary>
        /// Whether callers can narrow user-token grants per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsRefinement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsRefinement { get; set; }

        /// <summary>
        /// Known allowed user-level scopes. For Slack this is the user scope set configured on the app; for OAuth it is the connector's enabled `userAuthorization.scopes` configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Supported OAuth authorization-detail type names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedAuthorizationDetails")]
        public global::System.Collections.Generic.IList<string>? SupportedAuthorizationDetails { get; set; }

        /// <summary>
        /// User authorization is completed by the Connect consent screen submitting a credential instead of an OAuth redirect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualCredentialInput")]
        public bool? ManualCredentialInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseUserTokens" /> class.
        /// </summary>
        /// <param name="crossInstallation">
        /// Whether one user token can be used across installations.
        /// </param>
        /// <param name="supportsRefinement">
        /// Whether callers can narrow user-token grants per request.
        /// </param>
        /// <param name="scopes">
        /// Known allowed user-level scopes. For Slack this is the user scope set configured on the app; for OAuth it is the connector's enabled `userAuthorization.scopes` configuration.
        /// </param>
        /// <param name="supportedAuthorizationDetails">
        /// Supported OAuth authorization-detail type names.
        /// </param>
        /// <param name="manualCredentialInput">
        /// User authorization is completed by the Connect consent screen submitting a credential instead of an OAuth redirect.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseUserTokens(
            bool crossInstallation,
            bool supportsRefinement,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.IList<string>? supportedAuthorizationDetails,
            bool? manualCredentialInput)
        {
            this.CrossInstallation = crossInstallation;
            this.SupportsRefinement = supportsRefinement;
            this.Scopes = scopes;
            this.SupportedAuthorizationDetails = supportedAuthorizationDetails;
            this.ManualCredentialInput = manualCredentialInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseUserTokens" /> class.
        /// </summary>
        public CreateConnectorResponseUserTokens()
        {
        }

    }
}