
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectResponseService
    {
        /// <summary>
        /// Service name from the deployment (Service.name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceName { get; set; }

        /// <summary>
        /// Service kind (Service.type). Omitted for schemas that do not define one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseServiceServiceTypeJsonConverter))]
        public global::Vercel.GetProjectResponseServiceServiceType? ServiceType { get; set; }

        /// <summary>
        /// Framework slug, when the service has one (omitted otherwise).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseServiceFrameworkJsonConverter))]
        public global::Vercel.GetProjectResponseServiceFramework? Framework { get; set; }

        /// <summary>
        /// Generic runtime, e.g. 'node' | 'python' | 'go' | 'ruby' | 'rust' (Service.runtime). Omitted for static builds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseService" /> class.
        /// </summary>
        /// <param name="serviceName">
        /// Service name from the deployment (Service.name).
        /// </param>
        /// <param name="serviceType">
        /// Service kind (Service.type). Omitted for schemas that do not define one.
        /// </param>
        /// <param name="framework">
        /// Framework slug, when the service has one (omitted otherwise).
        /// </param>
        /// <param name="runtime">
        /// Generic runtime, e.g. 'node' | 'python' | 'go' | 'ruby' | 'rust' (Service.runtime). Omitted for static builds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseService(
            string serviceName,
            global::Vercel.GetProjectResponseServiceServiceType? serviceType,
            global::Vercel.GetProjectResponseServiceFramework? framework,
            string? runtime)
        {
            this.ServiceName = serviceName ?? throw new global::System.ArgumentNullException(nameof(serviceName));
            this.ServiceType = serviceType;
            this.Framework = framework;
            this.Runtime = runtime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseService" /> class.
        /// </summary>
        public GetProjectResponseService()
        {
        }

    }
}