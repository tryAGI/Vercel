
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorAuthorizationRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeApp, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUser, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeToken, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeOther>))]
        public global::Vercel.AnyOf<global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeApp, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUser, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeToken, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeOther>? Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        public string? InstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public global::System.Collections.Generic.IList<string>? Audience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<string>? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationDetails")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateConnectorAuthorizationRequestRequestAuthorizationDetail>? AuthorizationDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validityBufferMs")]
        public double? ValidityBufferMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceCode")]
        public bool? DeviceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresInMs")]
        public double? ExpiresInMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalParams")]
        public global::System.Collections.Generic.Dictionary<string, string>? AdditionalParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorAuthorizationRequestRequest" /> class.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="installationId"></param>
        /// <param name="audience"></param>
        /// <param name="scopes"></param>
        /// <param name="resources"></param>
        /// <param name="authorizationDetails"></param>
        /// <param name="validityBufferMs"></param>
        /// <param name="returnUrl"></param>
        /// <param name="webhook"></param>
        /// <param name="prompt"></param>
        /// <param name="deviceCode"></param>
        /// <param name="expiresInMs"></param>
        /// <param name="additionalParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorAuthorizationRequestRequest(
            global::Vercel.AnyOf<global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeApp, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUser, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeToken, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeOther>? subject,
            string? installationId,
            global::System.Collections.Generic.IList<string>? audience,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.IList<string>? resources,
            global::System.Collections.Generic.IList<global::Vercel.CreateConnectorAuthorizationRequestRequestAuthorizationDetail>? authorizationDetails,
            double? validityBufferMs,
            string? returnUrl,
            string? webhook,
            string? prompt,
            bool? deviceCode,
            double? expiresInMs,
            global::System.Collections.Generic.Dictionary<string, string>? additionalParams)
        {
            this.Subject = subject;
            this.InstallationId = installationId;
            this.Audience = audience;
            this.Scopes = scopes;
            this.Resources = resources;
            this.AuthorizationDetails = authorizationDetails;
            this.ValidityBufferMs = validityBufferMs;
            this.ReturnUrl = returnUrl;
            this.Webhook = webhook;
            this.Prompt = prompt;
            this.DeviceCode = deviceCode;
            this.ExpiresInMs = expiresInMs;
            this.AdditionalParams = additionalParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorAuthorizationRequestRequest" /> class.
        /// </summary>
        public CreateConnectorAuthorizationRequestRequest()
        {
        }

    }
}