
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant59
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketEmail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BitbucketEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketLogin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BitbucketLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketName")]
        public string? BitbucketName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant59" /> class.
        /// </summary>
        /// <param name="bitbucketEmail"></param>
        /// <param name="bitbucketLogin"></param>
        /// <param name="bitbucketName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant59(
            string bitbucketEmail,
            string bitbucketLogin,
            string? bitbucketName)
        {
            this.BitbucketEmail = bitbucketEmail ?? throw new global::System.ArgumentNullException(nameof(bitbucketEmail));
            this.BitbucketLogin = bitbucketLogin ?? throw new global::System.ArgumentNullException(nameof(bitbucketLogin));
            this.BitbucketName = bitbucketName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant59" /> class.
        /// </summary>
        public UserEventPayloadVariant59()
        {
        }
    }
}