
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant58
    {
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
        public string? GitlabName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeitAccount")]
        public string? ZeitAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeitAccountType")]
        public string? ZeitAccountType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant58" /> class.
        /// </summary>
        /// <param name="gitlabLogin"></param>
        /// <param name="gitlabEmail"></param>
        /// <param name="gitlabName"></param>
        /// <param name="zeitAccount"></param>
        /// <param name="zeitAccountType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant58(
            string gitlabLogin,
            string gitlabEmail,
            string? gitlabName,
            string? zeitAccount,
            string? zeitAccountType)
        {
            this.GitlabLogin = gitlabLogin ?? throw new global::System.ArgumentNullException(nameof(gitlabLogin));
            this.GitlabEmail = gitlabEmail ?? throw new global::System.ArgumentNullException(nameof(gitlabEmail));
            this.GitlabName = gitlabName;
            this.ZeitAccount = zeitAccount;
            this.ZeitAccountType = zeitAccountType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant58" /> class.
        /// </summary>
        public UserEventPayloadVariant58()
        {
        }
    }
}