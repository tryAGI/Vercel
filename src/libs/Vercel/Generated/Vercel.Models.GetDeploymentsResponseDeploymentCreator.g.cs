
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata information of the user who created the deployment.
    /// </summary>
    public sealed partial class GetDeploymentsResponseDeploymentCreator
    {
        /// <summary>
        /// The unique identifier of the user.<br/>
        /// Example: eLrCnEgbKhsHyfbiNR7E8496
        /// </summary>
        /// <example>eLrCnEgbKhsHyfbiNR7E8496</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The email address of the user.<br/>
        /// Example: example@example.com
        /// </summary>
        /// <example>example@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The username of the user.<br/>
        /// Example: johndoe
        /// </summary>
        /// <example>johndoe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The GitHub login of the user.<br/>
        /// Example: johndoe
        /// </summary>
        /// <example>johndoe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubLogin")]
        public string? GithubLogin { get; set; }

        /// <summary>
        /// The GitLab login of the user.<br/>
        /// Example: johndoe
        /// </summary>
        /// <example>johndoe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlabLogin")]
        public string? GitlabLogin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentCreator" /> class.
        /// </summary>
        /// <param name="uid">
        /// The unique identifier of the user.<br/>
        /// Example: eLrCnEgbKhsHyfbiNR7E8496
        /// </param>
        /// <param name="email">
        /// The email address of the user.<br/>
        /// Example: example@example.com
        /// </param>
        /// <param name="username">
        /// The username of the user.<br/>
        /// Example: johndoe
        /// </param>
        /// <param name="githubLogin">
        /// The GitHub login of the user.<br/>
        /// Example: johndoe
        /// </param>
        /// <param name="gitlabLogin">
        /// The GitLab login of the user.<br/>
        /// Example: johndoe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentsResponseDeploymentCreator(
            string uid,
            string? email,
            string? username,
            string? githubLogin,
            string? gitlabLogin)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Email = email;
            this.Username = username;
            this.GithubLogin = githubLogin;
            this.GitlabLogin = gitlabLogin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentCreator" /> class.
        /// </summary>
        public GetDeploymentsResponseDeploymentCreator()
        {
        }
    }
}