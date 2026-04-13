
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant228
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
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlabLogin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitlabLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlabEmail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitlabEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlabName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitlabName { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant228" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="gitlabLogin"></param>
        /// <param name="gitlabEmail"></param>
        /// <param name="gitlabName"></param>
        /// <param name="zeitAccount"></param>
        /// <param name="zeitAccountType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant228(
            string email,
            string gitlabLogin,
            string gitlabEmail,
            string gitlabName,
            string zeitAccount,
            string zeitAccountType)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.GitlabLogin = gitlabLogin ?? throw new global::System.ArgumentNullException(nameof(gitlabLogin));
            this.GitlabEmail = gitlabEmail ?? throw new global::System.ArgumentNullException(nameof(gitlabEmail));
            this.GitlabName = gitlabName ?? throw new global::System.ArgumentNullException(nameof(gitlabName));
            this.ZeitAccount = zeitAccount ?? throw new global::System.ArgumentNullException(nameof(zeitAccount));
            this.ZeitAccountType = zeitAccountType ?? throw new global::System.ArgumentNullException(nameof(zeitAccountType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant228" /> class.
        /// </summary>
        public UserEventPayloadVariant228()
        {
        }
    }
}