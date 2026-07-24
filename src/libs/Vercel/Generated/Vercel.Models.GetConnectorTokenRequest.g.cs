
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectorTokenRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetConnectorTokenRequestSubjectTypeApp, global::Vercel.GetConnectorTokenRequestSubjectTypeUser, global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearer, global::Vercel.GetConnectorTokenRequestSubjectTypeToken, global::Vercel.GetConnectorTokenRequestSubjectTypeOther>))]
        public global::Vercel.AnyOf<global::Vercel.GetConnectorTokenRequestSubjectTypeApp, global::Vercel.GetConnectorTokenRequestSubjectTypeUser, global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearer, global::Vercel.GetConnectorTokenRequestSubjectTypeToken, global::Vercel.GetConnectorTokenRequestSubjectTypeOther>? Subject { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.GetConnectorTokenRequestAuthorizationDetail>? AuthorizationDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validityBufferMs")]
        public double? ValidityBufferMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorTokenRequest" /> class.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="installationId"></param>
        /// <param name="audience"></param>
        /// <param name="scopes"></param>
        /// <param name="resources"></param>
        /// <param name="authorizationDetails"></param>
        /// <param name="validityBufferMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectorTokenRequest(
            global::Vercel.AnyOf<global::Vercel.GetConnectorTokenRequestSubjectTypeApp, global::Vercel.GetConnectorTokenRequestSubjectTypeUser, global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearer, global::Vercel.GetConnectorTokenRequestSubjectTypeToken, global::Vercel.GetConnectorTokenRequestSubjectTypeOther>? subject,
            string? installationId,
            global::System.Collections.Generic.IList<string>? audience,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.IList<string>? resources,
            global::System.Collections.Generic.IList<global::Vercel.GetConnectorTokenRequestAuthorizationDetail>? authorizationDetails,
            double? validityBufferMs)
        {
            this.Subject = subject;
            this.InstallationId = installationId;
            this.Audience = audience;
            this.Scopes = scopes;
            this.Resources = resources;
            this.AuthorizationDetails = authorizationDetails;
            this.ValidityBufferMs = validityBufferMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorTokenRequest" /> class.
        /// </summary>
        public GetConnectorTokenRequest()
        {
        }

    }
}