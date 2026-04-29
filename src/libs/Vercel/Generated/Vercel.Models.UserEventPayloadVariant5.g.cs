
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant5
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
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeAccount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripeAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeOrganisation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripeOrganisation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountRequestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountRequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant5" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="stripeAccount"></param>
        /// <param name="stripeOrganisation"></param>
        /// <param name="accountRequestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant5(
            string teamId,
            string stripeAccount,
            string stripeOrganisation,
            string accountRequestId)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.StripeAccount = stripeAccount ?? throw new global::System.ArgumentNullException(nameof(stripeAccount));
            this.StripeOrganisation = stripeOrganisation ?? throw new global::System.ArgumentNullException(nameof(stripeOrganisation));
            this.AccountRequestId = accountRequestId ?? throw new global::System.ArgumentNullException(nameof(accountRequestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant5" /> class.
        /// </summary>
        public UserEventPayloadVariant5()
        {
        }
    }
}