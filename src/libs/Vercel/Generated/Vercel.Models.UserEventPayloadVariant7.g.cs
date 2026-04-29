
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeAccount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripeAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant7" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="teamSlug"></param>
        /// <param name="stripeAccount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant7(
            string teamId,
            string teamSlug,
            string stripeAccount)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamSlug = teamSlug ?? throw new global::System.ArgumentNullException(nameof(teamSlug));
            this.StripeAccount = stripeAccount ?? throw new global::System.ArgumentNullException(nameof(stripeAccount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant7" /> class.
        /// </summary>
        public UserEventPayloadVariant7()
        {
        }
    }
}