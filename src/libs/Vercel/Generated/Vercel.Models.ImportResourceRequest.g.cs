
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportResourceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ImportResourceRequestOwnershipJsonConverter))]
        public global::Vercel.ImportResourceRequestOwnership? Ownership { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ImportResourceRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ImportResourceRequestStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        public global::Vercel.ImportResourceRequestBillingPlan? BillingPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification")]
        public global::Vercel.ImportResourceRequestNotification? Notification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<global::Vercel.ImportResourceRequestSecret>? Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportResourceRequest" /> class.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="ownership"></param>
        /// <param name="metadata"></param>
        /// <param name="billingPlan"></param>
        /// <param name="notification"></param>
        /// <param name="extras"></param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportResourceRequest(
            string productId,
            string name,
            global::Vercel.ImportResourceRequestStatus status,
            global::Vercel.ImportResourceRequestOwnership? ownership,
            object? metadata,
            global::Vercel.ImportResourceRequestBillingPlan? billingPlan,
            global::Vercel.ImportResourceRequestNotification? notification,
            object? extras,
            global::System.Collections.Generic.IList<global::Vercel.ImportResourceRequestSecret>? secrets)
        {
            this.Ownership = ownership;
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Metadata = metadata;
            this.BillingPlan = billingPlan;
            this.Notification = notification;
            this.Extras = extras;
            this.Secrets = secrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportResourceRequest" /> class.
        /// </summary>
        public ImportResourceRequest()
        {
        }
    }
}