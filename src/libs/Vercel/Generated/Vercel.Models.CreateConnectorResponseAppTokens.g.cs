
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorResponseAppTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossInstallation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CrossInstallation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsRefinement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsRefinement { get; set; }

        /// <summary>
        /// True when changing app token grants requires reinstalling the app, so tokens cannot be partitioned independently by requester environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiresReinstallation")]
        public bool? RequiresReinstallation { get; set; }

        /// <summary>
        /// Known allowed app-level scopes. For Slack this is the bot scope set configured on the app; for OAuth it is the connector's enabled `clientCredentials.scopes` configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedAuthorizationDetails")]
        public global::System.Collections.Generic.IList<string>? SupportedAuthorizationDetails { get; set; }

        /// <summary>
        /// Link to the page on the service where this client's app-level permissions are declared and granted, when the service has one and it differs from `clientUrl`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissionsUrl")]
        public string? PermissionsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseAppTokens" /> class.
        /// </summary>
        /// <param name="crossInstallation"></param>
        /// <param name="supportsRefinement"></param>
        /// <param name="requiresReinstallation">
        /// True when changing app token grants requires reinstalling the app, so tokens cannot be partitioned independently by requester environment.
        /// </param>
        /// <param name="scopes">
        /// Known allowed app-level scopes. For Slack this is the bot scope set configured on the app; for OAuth it is the connector's enabled `clientCredentials.scopes` configuration.
        /// </param>
        /// <param name="supportedAuthorizationDetails"></param>
        /// <param name="permissionsUrl">
        /// Link to the page on the service where this client's app-level permissions are declared and granted, when the service has one and it differs from `clientUrl`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseAppTokens(
            bool crossInstallation,
            bool supportsRefinement,
            bool? requiresReinstallation,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.IList<string>? supportedAuthorizationDetails,
            string? permissionsUrl)
        {
            this.CrossInstallation = crossInstallation;
            this.SupportsRefinement = supportsRefinement;
            this.RequiresReinstallation = requiresReinstallation;
            this.Scopes = scopes;
            this.SupportedAuthorizationDetails = supportedAuthorizationDetails;
            this.PermissionsUrl = permissionsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseAppTokens" /> class.
        /// </summary>
        public CreateConnectorResponseAppTokens()
        {
        }

    }
}