
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventRequestEventVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateEventRequestEventVariant1TypeJsonConverter))]
        public global::Vercel.CreateEventRequestEventVariant1Type Type { get; set; }

        /// <summary>
        /// The installation-level billing plan ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanId")]
        public string? BillingPlanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequestEventVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="billingPlanId">
        /// The installation-level billing plan ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEventRequestEventVariant1(
            global::Vercel.CreateEventRequestEventVariant1Type type,
            string? billingPlanId)
        {
            this.Type = type;
            this.BillingPlanId = billingPlanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequestEventVariant1" /> class.
        /// </summary>
        public CreateEventRequestEventVariant1()
        {
        }
    }
}