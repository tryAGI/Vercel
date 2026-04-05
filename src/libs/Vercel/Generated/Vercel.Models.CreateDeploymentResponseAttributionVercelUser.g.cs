
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Vercel user linked to the git provider account (only set if resolved)
    /// </summary>
    public sealed partial class CreateDeploymentResponseAttributionVercelUser
    {
        /// <summary>
        /// Vercel user ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Vercel username
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Team roles at time of deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<string>? TeamRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseAttributionVercelUser" /> class.
        /// </summary>
        /// <param name="id">
        /// Vercel user ID
        /// </param>
        /// <param name="username">
        /// Vercel username
        /// </param>
        /// <param name="teamRoles">
        /// Team roles at time of deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseAttributionVercelUser(
            string id,
            string username,
            global::System.Collections.Generic.IList<string>? teamRoles)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.TeamRoles = teamRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseAttributionVercelUser" /> class.
        /// </summary>
        public CreateDeploymentResponseAttributionVercelUser()
        {
        }
    }
}