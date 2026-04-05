
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetIntegrationResourceResponse
    {
        /// <summary>
        /// The ID provided by the 3rd party provider for the given resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID assigned by Vercel for the given resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InternalId { get; set; }

        /// <summary>
        /// The name of the resource as it is recorded in Vercel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The current status of the resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetIntegrationResourceResponseStatusJsonConverter))]
        public global::Vercel.GetIntegrationResourceResponseStatus? Status { get; set; }

        /// <summary>
        /// The ID of the product the resource is derived from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        /// Any settings provided for the resource to support its product's protocols
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolSettings")]
        public global::Vercel.GetIntegrationResourceResponseProtocolSettings? ProtocolSettings { get; set; }

        /// <summary>
        /// The notification, if set, displayed to the user when viewing the resource in Vercel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification")]
        public global::Vercel.GetIntegrationResourceResponseNotification? Notification { get; set; }

        /// <summary>
        /// The ID of the billing plan the resource is subscribed to, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanId")]
        public string? BillingPlanId { get; set; }

        /// <summary>
        /// The configured metadata for the resource as defined by its product's Metadata Schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID provided by the 3rd party provider for the given resource
        /// </param>
        /// <param name="internalId">
        /// The ID assigned by Vercel for the given resource
        /// </param>
        /// <param name="name">
        /// The name of the resource as it is recorded in Vercel
        /// </param>
        /// <param name="productId">
        /// The ID of the product the resource is derived from
        /// </param>
        /// <param name="status">
        /// The current status of the resource
        /// </param>
        /// <param name="protocolSettings">
        /// Any settings provided for the resource to support its product's protocols
        /// </param>
        /// <param name="notification">
        /// The notification, if set, displayed to the user when viewing the resource in Vercel
        /// </param>
        /// <param name="billingPlanId">
        /// The ID of the billing plan the resource is subscribed to, if applicable
        /// </param>
        /// <param name="metadata">
        /// The configured metadata for the resource as defined by its product's Metadata Schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourceResponse(
            string id,
            string internalId,
            string name,
            string productId,
            global::Vercel.GetIntegrationResourceResponseStatus? status,
            global::Vercel.GetIntegrationResourceResponseProtocolSettings? protocolSettings,
            global::Vercel.GetIntegrationResourceResponseNotification? notification,
            string? billingPlanId,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InternalId = internalId ?? throw new global::System.ArgumentNullException(nameof(internalId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.ProtocolSettings = protocolSettings;
            this.Notification = notification;
            this.BillingPlanId = billingPlanId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponse" /> class.
        /// </summary>
        public GetIntegrationResourceResponse()
        {
        }
    }
}