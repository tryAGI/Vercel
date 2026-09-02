
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeSlack
    {
        /// <summary>
        /// Slack app ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        /// Slack app display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        public string? AppName { get; set; }

        /// <summary>
        /// Slack app OAuth client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

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
        public global::Vercel.ConnectConnectorUpdateDataTypeSlackSlackTeam? SlackTeam { get; set; }

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
        /// Slash commands configured for the managed Slack app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slashCommands")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeSlackSlashCommand>? SlashCommands { get; set; }

        /// <summary>
        /// Global and message shortcuts configured for the Slack app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortcuts")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcut>? Shortcuts { get; set; }

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
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSlack" /> class.
        /// </summary>
        /// <param name="appId">
        /// Slack app ID.
        /// </param>
        /// <param name="appName">
        /// Slack app display name.
        /// </param>
        /// <param name="clientId">
        /// Slack app OAuth client ID.
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
        /// <param name="slashCommands">
        /// Slash commands configured for the managed Slack app.
        /// </param>
        /// <param name="shortcuts">
        /// Global and message shortcuts configured for the Slack app.
        /// </param>
        /// <param name="extras">
        /// Additional provider metadata stored with the connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeSlack(
            string? appId,
            string? appName,
            string? clientId,
            string? clientSecret,
            global::Vercel.ConnectConnectorUpdateDataTypeSlackSlackTeam? slackTeam,
            string? signingSecret,
            string? verificationToken,
            global::System.Collections.Generic.IList<string>? botScopes,
            global::System.Collections.Generic.IList<string>? userScopes,
            global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeSlackSlashCommand>? slashCommands,
            global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcut>? shortcuts,
            object? extras)
        {
            this.AppId = appId;
            this.AppName = appName;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.SlackTeam = slackTeam;
            this.SigningSecret = signingSecret;
            this.VerificationToken = verificationToken;
            this.BotScopes = botScopes;
            this.UserScopes = userScopes;
            this.SlashCommands = slashCommands;
            this.Shortcuts = shortcuts;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSlack" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeSlack()
        {
        }

    }
}