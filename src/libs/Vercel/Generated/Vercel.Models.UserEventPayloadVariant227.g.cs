
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant227
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
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketLogin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BitbucketLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketEmail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BitbucketEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BitbucketName { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant227" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="bitbucketLogin"></param>
        /// <param name="bitbucketEmail"></param>
        /// <param name="bitbucketName"></param>
        /// <param name="zeitAccount"></param>
        /// <param name="zeitAccountType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant227(
            string email,
            string bitbucketLogin,
            string bitbucketEmail,
            string bitbucketName,
            string zeitAccount,
            string zeitAccountType)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.BitbucketLogin = bitbucketLogin ?? throw new global::System.ArgumentNullException(nameof(bitbucketLogin));
            this.BitbucketEmail = bitbucketEmail ?? throw new global::System.ArgumentNullException(nameof(bitbucketEmail));
            this.BitbucketName = bitbucketName ?? throw new global::System.ArgumentNullException(nameof(bitbucketName));
            this.ZeitAccount = zeitAccount ?? throw new global::System.ArgumentNullException(nameof(zeitAccount));
            this.ZeitAccountType = zeitAccountType ?? throw new global::System.ArgumentNullException(nameof(zeitAccountType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant227" /> class.
        /// </summary>
        public UserEventPayloadVariant227()
        {
        }
    }
}