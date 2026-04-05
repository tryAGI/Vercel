
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResourceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateResourceRequestOwnershipJsonConverter))]
        public global::Vercel.UpdateResourceRequestOwnership? Ownership { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateResourceRequestStatusJsonConverter))]
        public global::Vercel.UpdateResourceRequestStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        public global::Vercel.UpdateResourceRequestBillingPlan? BillingPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateResourceRequestNotification, string>))]
        public global::Vercel.OneOf<global::Vercel.UpdateResourceRequestNotification, string>? Notification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>? Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequest" /> class.
        /// </summary>
        /// <param name="ownership"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="billingPlan"></param>
        /// <param name="notification"></param>
        /// <param name="extras"></param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResourceRequest(
            global::Vercel.UpdateResourceRequestOwnership? ownership,
            string? name,
            global::Vercel.UpdateResourceRequestStatus? status,
            object? metadata,
            global::Vercel.UpdateResourceRequestBillingPlan? billingPlan,
            global::Vercel.OneOf<global::Vercel.UpdateResourceRequestNotification, string>? notification,
            object? extras,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>? secrets)
        {
            this.Ownership = ownership;
            this.Name = name;
            this.Status = status;
            this.Metadata = metadata;
            this.BillingPlan = billingPlan;
            this.Notification = notification;
            this.Extras = extras;
            this.Secrets = secrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequest" /> class.
        /// </summary>
        public UpdateResourceRequest()
        {
        }
    }
}