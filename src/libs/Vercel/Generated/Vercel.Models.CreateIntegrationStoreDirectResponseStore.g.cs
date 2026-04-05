
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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectsMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItem> ProjectsMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectFilter")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilter? ProjectFilter { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreStatusJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreOwnershipJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreOwnership? Ownership { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreCapabilities? Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("directPartnerConsoleUrl")]
        public string? DirectPartnerConsoleUrl { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreNotification? Notification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreSecret> Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlan? BillingPlan { get; set; }

        /// <summary>
        /// The timestamp when secret rotation was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotationRequestedAt")]
        public double? SecretRotationRequestedAt { get; set; }

        /// <summary>
        /// The reason for the secret rotation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotationRequestedReason")]
        public string? SecretRotationRequestedReason { get; set; }

        /// <summary>
        /// The ID of the user/team who requested the secret rotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotationRequestedBy")]
        public string? SecretRotationRequestedBy { get; set; }

        /// <summary>
        /// The timestamp when secret rotation was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotationCompletedAt")]
        public double? SecretRotationCompletedAt { get; set; }

        /// <summary>
        /// The ID of the parent resource. Used to establish a parent-child relationship between resources, such as sandbox resources linking to their owner account resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

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
        /// <param name="totalConnectedProjects"></param>
        /// <param name="status"></param>
        /// <param name="ownership"></param>
        /// <param name="capabilities"></param>
        /// <param name="metadata"></param>
        /// <param name="externalResourceStatus"></param>
        /// <param name="directPartnerConsoleUrl"></param>
        /// <param name="protocolSettings"></param>
        /// <param name="notification"></param>
        /// <param name="billingPlan"></param>
        /// <param name="secretRotationRequestedAt">
        /// The timestamp when secret rotation was requested.
        /// </param>
        /// <param name="secretRotationRequestedReason">
        /// The reason for the secret rotation request.
        /// </param>
        /// <param name="secretRotationRequestedBy">
        /// The ID of the user/team who requested the secret rotation.
        /// </param>
        /// <param name="secretRotationCompletedAt">
        /// The timestamp when secret rotation was completed.
        /// </param>
        /// <param name="parentId">
        /// The ID of the parent resource. Used to establish a parent-child relationship between resources, such as sandbox resources linking to their owner account resource.
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
            double? totalConnectedProjects,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreStatus? status,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreOwnership? ownership,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreCapabilities? capabilities,
            object? metadata,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreExternalResourceStatus? externalResourceStatus,
            string? directPartnerConsoleUrl,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettings? protocolSettings,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreNotification? notification,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlan? billingPlan,
            double? secretRotationRequestedAt,
            string? secretRotationRequestedReason,
            string? secretRotationRequestedBy,
            double? secretRotationCompletedAt,
            string? parentId,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreTarget>? targets)
        {
            this.ProjectsMetadata = projectsMetadata ?? throw new global::System.ArgumentNullException(nameof(projectsMetadata));
            this.ProjectFilter = projectFilter;
            this.TotalConnectedProjects = totalConnectedProjects;
            this.UsageQuotaExceeded = usageQuotaExceeded;
            this.Status = status;
            this.Ownership = ownership;
            this.Capabilities = capabilities;
            this.Metadata = metadata;
            this.ExternalResourceId = externalResourceId ?? throw new global::System.ArgumentNullException(nameof(externalResourceId));
            this.ExternalResourceStatus = externalResourceStatus;
            this.DirectPartnerConsoleUrl = directPartnerConsoleUrl;
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.ProtocolSettings = protocolSettings;
            this.Notification = notification;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.BillingPlan = billingPlan;
            this.SecretRotationRequestedAt = secretRotationRequestedAt;
            this.SecretRotationRequestedReason = secretRotationRequestedReason;
            this.SecretRotationRequestedBy = secretRotationRequestedBy;
            this.SecretRotationCompletedAt = secretRotationCompletedAt;
            this.ParentId = parentId;
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