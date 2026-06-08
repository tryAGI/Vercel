
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeSlack
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slackTeam")]
        public global::Vercel.CreateConnectorRequestDataTypeSlackSlackTeam? SlackTeam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingSecret")]
        public string? SigningSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verificationToken")]
        public string? VerificationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botScopes")]
        public global::System.Collections.Generic.IList<string>? BotScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userScopes")]
        public global::System.Collections.Generic.IList<string>? UserScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSlack" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appName"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="slackTeam"></param>
        /// <param name="signingSecret"></param>
        /// <param name="verificationToken"></param>
        /// <param name="botScopes"></param>
        /// <param name="userScopes"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeSlack(
            string appId,
            string appName,
            string clientId,
            string clientSecret,
            global::Vercel.CreateConnectorRequestDataTypeSlackSlackTeam? slackTeam,
            string? signingSecret,
            string? verificationToken,
            global::System.Collections.Generic.IList<string>? botScopes,
            global::System.Collections.Generic.IList<string>? userScopes,
            object? extras)
        {
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.SlackTeam = slackTeam;
            this.SigningSecret = signingSecret;
            this.VerificationToken = verificationToken;
            this.BotScopes = botScopes;
            this.UserScopes = userScopes;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSlack" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeSlack()
        {
        }

    }
}