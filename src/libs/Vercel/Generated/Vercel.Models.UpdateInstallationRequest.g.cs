
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateInstallationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateInstallationRequestStatusJsonConverter))]
        public global::Vercel.UpdateInstallationRequestStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        public global::Vercel.UpdateInstallationRequestBillingPlan? BillingPlan { get; set; }

        /// <summary>
        /// A notification to display to your customer. Send `null` to clear the current notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateInstallationRequestNotification, string>))]
        public global::Vercel.OneOf<global::Vercel.UpdateInstallationRequestNotification, string>? Notification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInstallationRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="externalId"></param>
        /// <param name="billingPlan"></param>
        /// <param name="notification">
        /// A notification to display to your customer. Send `null` to clear the current notification.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInstallationRequest(
            global::Vercel.UpdateInstallationRequestStatus? status,
            string? externalId,
            global::Vercel.UpdateInstallationRequestBillingPlan? billingPlan,
            global::Vercel.OneOf<global::Vercel.UpdateInstallationRequestNotification, string>? notification)
        {
            this.Status = status;
            this.ExternalId = externalId;
            this.BillingPlan = billingPlan;
            this.Notification = notification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInstallationRequest" /> class.
        /// </summary>
        public UpdateInstallationRequest()
        {
        }
    }
}