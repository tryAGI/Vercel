
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeLinear
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        public string? AppName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookSecret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appScopes")]
        public global::System.Collections.Generic.IList<string>? AppScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userScopes")]
        public global::System.Collections.Generic.IList<string>? UserScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerOrganization")]
        public global::Vercel.CreateConnectorRequestDataTypeLinearOwnerOrganization? OwnerOrganization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application")]
        public global::Vercel.CreateConnectorRequestDataTypeLinearApplication? Application { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeLinear" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="appId"></param>
        /// <param name="appName"></param>
        /// <param name="webhookSecret"></param>
        /// <param name="appScopes"></param>
        /// <param name="userScopes"></param>
        /// <param name="ownerOrganization"></param>
        /// <param name="application"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeLinear(
            string clientId,
            string clientSecret,
            string? appId,
            string? appName,
            string? webhookSecret,
            global::System.Collections.Generic.IList<string>? appScopes,
            global::System.Collections.Generic.IList<string>? userScopes,
            global::Vercel.CreateConnectorRequestDataTypeLinearOwnerOrganization? ownerOrganization,
            global::Vercel.CreateConnectorRequestDataTypeLinearApplication? application,
            object? extras)
        {
            this.AppId = appId;
            this.AppName = appName;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.WebhookSecret = webhookSecret;
            this.AppScopes = appScopes;
            this.UserScopes = userScopes;
            this.OwnerOrganization = ownerOrganization;
            this.Application = application;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeLinear" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeLinear()
        {
        }

    }
}