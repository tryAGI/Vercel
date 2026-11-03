
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
        /// Custom claims embedded in the resource tokens Vercel mints for this resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customClaims")]
        public global::Vercel.UpdateResourceRequestCustomClaims? CustomClaims { get; set; }

        /// <summary>
        /// The credential types the resource accepts: `static` for long-lived secrets, `oidc` for Vercel resource OIDC tokens. Can be set freely while the resource has none. After that, only to confirm a change Vercel requested with a secrets rotation, once it is complete. Without `static`, all long-lived secrets must be expired and removed, and no new ones minted or injected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialTypes")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestCredentialType>? CredentialTypes { get; set; }

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
        /// <param name="customClaims">
        /// Custom claims embedded in the resource tokens Vercel mints for this resource.
        /// </param>
        /// <param name="credentialTypes">
        /// The credential types the resource accepts: `static` for long-lived secrets, `oidc` for Vercel resource OIDC tokens. Can be set freely while the resource has none. After that, only to confirm a change Vercel requested with a secrets rotation, once it is complete. Without `static`, all long-lived secrets must be expired and removed, and no new ones minted or injected.
        /// </param>
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
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>? secrets,
            global::Vercel.UpdateResourceRequestCustomClaims? customClaims,
            global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestCredentialType>? credentialTypes)
        {
            this.Ownership = ownership;
            this.Name = name;
            this.Status = status;
            this.Metadata = metadata;
            this.BillingPlan = billingPlan;
            this.Notification = notification;
            this.Extras = extras;
            this.Secrets = secrets;
            this.CustomClaims = customClaims;
            this.CredentialTypes = credentialTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequest" /> class.
        /// </summary>
        public UpdateResourceRequest()
        {
        }

    }
}