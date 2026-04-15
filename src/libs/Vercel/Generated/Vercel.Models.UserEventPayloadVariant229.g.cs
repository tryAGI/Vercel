
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant229
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubLogin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GithubLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeitAccount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ZeitAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeitAccountType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ZeitAccountType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant229" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="githubLogin"></param>
        /// <param name="zeitAccount"></param>
        /// <param name="zeitAccountType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant229(
            string email,
            string githubLogin,
            string zeitAccount,
            string zeitAccountType)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.GithubLogin = githubLogin ?? throw new global::System.ArgumentNullException(nameof(githubLogin));
            this.ZeitAccount = zeitAccount ?? throw new global::System.ArgumentNullException(nameof(zeitAccount));
            this.ZeitAccountType = zeitAccountType ?? throw new global::System.ArgumentNullException(nameof(zeitAccountType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant229" /> class.
        /// </summary>
        public UserEventPayloadVariant229()
        {
        }
    }
}