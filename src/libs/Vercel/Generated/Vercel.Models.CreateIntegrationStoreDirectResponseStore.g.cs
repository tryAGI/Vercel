
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStore
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectFilter")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilter? ProjectFilter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectsMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItem> ProjectsMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreStatusJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalConnectedProjects")]
        public double? TotalConnectedProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageQuotaExceeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UsageQuotaExceeded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlan? BillingPlan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreCapabilities? Capabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directPartnerConsoleUrl")]
        public string? DirectPartnerConsoleUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalResourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalResourceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalResourceStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreExternalResourceStatusJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreExternalResourceStatus? ExternalResourceStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreNotification? Notification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreOwnershipJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreOwnership? Ownership { get; set; }

        /// <summary>
        /// The ID of the parent resource. Used to establish a parent-child relationship between resources, such as sandbox resources linking to their owner account resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateIntegrationStoreDirectResponseStoreProduct Product { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolSettings")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettings? ProtocolSettings { get; set; }

        /// <summary>
        /// The timestamp when secret rotation was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotationCompletedAt")]
        public double? SecretRotationCompletedAt { get; set; }

        /// <summary>
        /// The timestamp when secret rotation was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotationRequestedAt")]
        public double? SecretRotationRequestedAt { get; set; }

        /// <summary>
        /// The ID of the user/team who requested the secret rotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotationRequestedBy")]
        public string? SecretRotationRequestedBy { get; set; }

        /// <summary>
        /// The reason for the secret rotation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotationRequestedReason")]
        public string? SecretRotationRequestedReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreSecret> Secrets { get; set; }

        /// <summary>
        /// The deployment targets that this resource is available for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreTarget>? Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStore" /> class.
        /// </summary>
        /// <param name="projectsMetadata"></param>
        /// <param name="usageQuotaExceeded"></param>
        /// <param name="externalResourceId"></param>
        /// <param name="product"></param>
        /// <param name="secrets"></param>
        /// <param name="projectFilter"></param>
        /// <param name="status"></param>
        /// <param name="totalConnectedProjects"></param>
        /// <param name="billingPlan"></param>
        /// <param name="capabilities"></param>
        /// <param name="directPartnerConsoleUrl"></param>
        /// <param name="externalResourceStatus"></param>
        /// <param name="metadata"></param>
        /// <param name="notification"></param>
        /// <param name="ownership"></param>
        /// <param name="parentId">
        /// The ID of the parent resource. Used to establish a parent-child relationship between resources, such as sandbox resources linking to their owner account resource.
        /// </param>
        /// <param name="protocolSettings"></param>
        /// <param name="secretRotationCompletedAt">
        /// The timestamp when secret rotation was completed.
        /// </param>
        /// <param name="secretRotationRequestedAt">
        /// The timestamp when secret rotation was requested.
        /// </param>
        /// <param name="secretRotationRequestedBy">
        /// The ID of the user/team who requested the secret rotation.
        /// </param>
        /// <param name="secretRotationRequestedReason">
        /// The reason for the secret rotation request.
        /// </param>
        /// <param name="targets">
        /// The deployment targets that this resource is available for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStore(
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItem> projectsMetadata,
            bool usageQuotaExceeded,
            string externalResourceId,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProduct product,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreSecret> secrets,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilter? projectFilter,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreStatus? status,
            double? totalConnectedProjects,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlan? billingPlan,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreCapabilities? capabilities,
            string? directPartnerConsoleUrl,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreExternalResourceStatus? externalResourceStatus,
            object? metadata,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreNotification? notification,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreOwnership? ownership,
            string? parentId,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettings? protocolSettings,
            double? secretRotationCompletedAt,
            double? secretRotationRequestedAt,
            string? secretRotationRequestedBy,
            string? secretRotationRequestedReason,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreTarget>? targets)
        {
            this.ProjectFilter = projectFilter;
            this.ProjectsMetadata = projectsMetadata ?? throw new global::System.ArgumentNullException(nameof(projectsMetadata));
            this.Status = status;
            this.TotalConnectedProjects = totalConnectedProjects;
            this.UsageQuotaExceeded = usageQuotaExceeded;
            this.BillingPlan = billingPlan;
            this.Capabilities = capabilities;
            this.DirectPartnerConsoleUrl = directPartnerConsoleUrl;
            this.ExternalResourceId = externalResourceId ?? throw new global::System.ArgumentNullException(nameof(externalResourceId));
            this.ExternalResourceStatus = externalResourceStatus;
            this.Metadata = metadata;
            this.Notification = notification;
            this.Ownership = ownership;
            this.ParentId = parentId;
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.ProtocolSettings = protocolSettings;
            this.SecretRotationCompletedAt = secretRotationCompletedAt;
            this.SecretRotationRequestedAt = secretRotationRequestedAt;
            this.SecretRotationRequestedBy = secretRotationRequestedBy;
            this.SecretRotationRequestedReason = secretRotationRequestedReason;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Targets = targets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStore" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStore()
        {
        }

    }
}