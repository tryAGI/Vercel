
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant122NewOwnerBilling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant122NewOwnerBillingPlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant122NewOwnerBillingPlan Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant122NewOwnerBilling" /> class.
        /// </summary>
        /// <param name="plan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant122NewOwnerBilling(
            global::Vercel.UserEventPayloadVariant122NewOwnerBillingPlan plan)
        {
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant122NewOwnerBilling" /> class.
        /// </summary>
        public UserEventPayloadVariant122NewOwnerBilling()
        {
        }
    }
}