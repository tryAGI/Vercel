
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant60
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketLogin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BitbucketLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketAccountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BitbucketAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant60" /> class.
        /// </summary>
        /// <param name="bitbucketLogin"></param>
        /// <param name="bitbucketAccountId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant60(
            string bitbucketLogin,
            string bitbucketAccountId)
        {
            this.BitbucketLogin = bitbucketLogin ?? throw new global::System.ArgumentNullException(nameof(bitbucketLogin));
            this.BitbucketAccountId = bitbucketAccountId ?? throw new global::System.ArgumentNullException(nameof(bitbucketAccountId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant60" /> class.
        /// </summary>
        public UserEventPayloadVariant60()
        {
        }
    }
}