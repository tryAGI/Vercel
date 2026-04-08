
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Git provider user associated with the commit author email (only set if resolved)
    /// </summary>
    public sealed partial class GetDeploymentsResponseDeploymentAttributionGitUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, double?> Id { get; set; }

        /// <summary>
        /// Git provider username/login
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// User type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The git provider (github, gitlab, bitbucket)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentAttributionGitUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="login">
        /// Git provider username/login
        /// </param>
        /// <param name="type">
        /// User type
        /// </param>
        /// <param name="provider">
        /// The git provider (github, gitlab, bitbucket)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentsResponseDeploymentAttributionGitUser(
            global::Vercel.OneOf<string, double?> id,
            string login,
            string? type,
            string? provider)
        {
            this.Id = id;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Type = type;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentAttributionGitUser" /> class.
        /// </summary>
        public GetDeploymentsResponseDeploymentAttributionGitUser()
        {
        }
    }
}