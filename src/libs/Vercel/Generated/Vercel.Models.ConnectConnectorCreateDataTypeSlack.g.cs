
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeSlack
    {
        /// <summary>
        /// Slack app ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppId { get; set; }

        /// <summary>
        /// Slack app display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// OAuth client ID assigned by Slack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Slack app OAuth client secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Slack workspace metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slackTeam")]
        public global::Vercel.ConnectConnectorCreateDataTypeSlackSlackTeam? SlackTeam { get; set; }

        /// <summary>
        /// Slack request signing secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingSecret")]
        public string? SigningSecret { get; set; }

        /// <summary>
        /// Legacy Slack webhook verification token.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verificationToken")]
        public string? VerificationToken { get; set; }

        /// <summary>
        /// OAuth scopes requested for Slack bot tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botScopes")]
        public global::System.Collections.Generic.IList<string>? BotScopes { get; set; }

        /// <summary>
        /// OAuth scopes requested for Slack user tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userScopes")]
        public global::System.Collections.Generic.IList<string>? UserScopes { get; set; }

        /// <summary>
        /// Additional provider metadata stored with the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSlack" /> class.
        /// </summary>
        /// <param name="appId">
        /// Slack app ID.
        /// </param>
        /// <param name="appName">
        /// Slack app display name.
        /// </param>
        /// <param name="clientId">
        /// OAuth client ID assigned by Slack.
        /// </param>
        /// <param name="clientSecret">
        /// Slack app OAuth client secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="slackTeam">
        /// Slack workspace metadata.
        /// </param>
        /// <param name="signingSecret">
        /// Slack request signing secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="verificationToken">
        /// Legacy Slack webhook verification token.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="botScopes">
        /// OAuth scopes requested for Slack bot tokens.
        /// </param>
        /// <param name="userScopes">
        /// OAuth scopes requested for Slack user tokens.
        /// </param>
        /// <param name="extras">
        /// Additional provider metadata stored with the connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeSlack(
            string appId,
            string appName,
            string clientId,
            string? clientSecret,
            global::Vercel.ConnectConnectorCreateDataTypeSlackSlackTeam? slackTeam,
            string? signingSecret,
            string? verificationToken,
            global::System.Collections.Generic.IList<string>? botScopes,
            global::System.Collections.Generic.IList<string>? userScopes,
            object? extras)
        {
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.SlackTeam = slackTeam;
            this.SigningSecret = signingSecret;
            this.VerificationToken = verificationToken;
            this.BotScopes = botScopes;
            this.UserScopes = userScopes;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSlack" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeSlack()
        {
        }

    }
}