
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRollingReleaseBillingStatusResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableSlots")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsJsonConverter))]
        public global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots AvailableSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2ReasonJsonConverter))]
        public global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRollingReleaseBillingStatusResponseVariant2" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="availableSlots"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRollingReleaseBillingStatusResponseVariant2(
            string message,
            global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots availableSlots,
            global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason reason)
        {
            this.AvailableSlots = availableSlots;
            this.Reason = reason;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRollingReleaseBillingStatusResponseVariant2" /> class.
        /// </summary>
        public GetRollingReleaseBillingStatusResponseVariant2()
        {
        }
    }
}