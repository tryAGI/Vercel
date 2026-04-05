
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentCheckRunResponseSourceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentCheckRunResponseSourceVariant1KindJsonConverter))]
        public global::Vercel.GetDeploymentCheckRunResponseSourceVariant1Kind Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalResourceId")]
        public string? ExternalResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentCheckRunResponseSourceVariant1" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="kind"></param>
        /// <param name="resourceId"></param>
        /// <param name="externalResourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentCheckRunResponseSourceVariant1(
            string integrationId,
            string integrationConfigurationId,
            global::Vercel.GetDeploymentCheckRunResponseSourceVariant1Kind kind,
            string? resourceId,
            string? externalResourceId)
        {
            this.Kind = kind;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.IntegrationConfigurationId = integrationConfigurationId ?? throw new global::System.ArgumentNullException(nameof(integrationConfigurationId));
            this.ResourceId = resourceId;
            this.ExternalResourceId = externalResourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentCheckRunResponseSourceVariant1" /> class.
        /// </summary>
        public GetDeploymentCheckRunResponseSourceVariant1()
        {
        }
    }
}