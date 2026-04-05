
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant36
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant36" /> class.
        /// </summary>
        /// <param name="planSlug"></param>
        /// <param name="subscriptionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant36(
            string planSlug,
            string? subscriptionId)
        {
            this.SubscriptionId = subscriptionId;
            this.PlanSlug = planSlug ?? throw new global::System.ArgumentNullException(nameof(planSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant36" /> class.
        /// </summary>
        public UserEventPayloadVariant36()
        {
        }
    }
}